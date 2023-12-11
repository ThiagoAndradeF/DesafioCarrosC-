using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garagem.Infra.Repositories;
using Garagem.Models;
using Garagem.Services;
using Microsoft.Extensions.DependencyInjection;
using static System.Resources.ResXFileRef;

namespace Garagem.View.Forms.NovaPasta1
{
    public partial class CadastroVeiculo : Form
    {
        private VeiculoService _veiculoService;
        private MarcaService _marcaService;
        private ModeloService _modeloService;
        private List<MarcaWithIndexListDto> _listaMarcaIndexada;
        private List<ModeloWithIndexListDto> _listaModeloIndexada;
        private MarcaDto? _marcaSelecionada;
        private ModeloDto? _modeloSelecionado;
        private IServiceProvider _serviceProvider;
        public CadastroVeiculo(IVeiculoRepository veiculoRepository, IMarcaRepository marcaRepository, IModeloRepository modeloRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _veiculoService = new VeiculoService(veiculoRepository);
            _marcaService = new MarcaService(marcaRepository);
            _modeloService = new ModeloService(modeloRepository);
            _listaMarcaIndexada = [];
            _listaModeloIndexada = [];
            _marcaSelecionada = new MarcaDto();
            _modeloSelecionado = new ModeloDto();
            _serviceProvider = serviceProvider;
            LoadDataComboBoxMarca();
            ConfigurarMascarasEValidacoes();
        }


        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {

        }
        private async void LoadDataComboBoxMarca()
        {
            var marcasTask = _marcaService.ListarMarcasAsync();
            if (marcasTask != null)
            {
                IEnumerable<MarcaDto> marcas = await marcasTask;

                int index = 0;
                comboBoxMarca.ValueMember = "codigo";

                foreach (var marca in marcas)
                {
                    var marcaIndexada = new MarcaWithIndexListDto();
                    marcaIndexada.marca.nome = marca.nome;
                    marcaIndexada.marca.codigo = marca.codigo;
                    marcaIndexada.id = index;

                    comboBoxMarca.Items.Add(marca.nome);
                    _listaMarcaIndexada.Add(marcaIndexada);
                    index++;
                }
            }
        }
        public static object ConvertValue(string value, Type targetType)
        {
            try
            {
                return Convert.ChangeType(value, targetType);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível converter o campo '{value}' para o tipo '{targetType.Name}'", "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new InvalidOperationException($"Não foi possível converter o campo '{value}' para o tipo '{targetType.Name}'", ex);
            }
        }


        private VeiculoCreateDto atribuirValores()
        {
            VeiculoCreateDto veiculoCreate = new VeiculoCreateDto();
            veiculoCreate.Marca = _marcaSelecionada;
            veiculoCreate.Modelo = _modeloSelecionado;
            veiculoCreate.Observacoes = txtObs.Text;
            veiculoCreate.ValorVenda = (decimal)ConvertValue(textoVenda.Text, typeof(decimal));
            veiculoCreate.ValorFIPE = (decimal)ConvertValue(textoFipe.Text, typeof(decimal));
            veiculoCreate.Chassi = chassiTxt.Text;
            veiculoCreate.AnoFabricacao = (int)ConvertValue(txtAnoFabricacao.Text, typeof(int));
            veiculoCreate.AnoModelo = (int)ConvertValue(txtAnoModelo.Text, typeof(int));
            veiculoCreate.Placa = txtPlaca.Text;

            return veiculoCreate;
        }
        private async void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.Items.Clear();
            comboBoxModelo.ValueMember = "";
            int indexMarcaSelecionada = comboBoxMarca.SelectedIndex;
            if (indexMarcaSelecionada >= 0)
            {
                MarcaDto MarcaSelecionada = _marcaService.EncontrarMarcaPorIndex(_listaMarcaIndexada, indexMarcaSelecionada);
                _marcaSelecionada = MarcaSelecionada;
                var modelosTask = _modeloService.ListarModelosByIdMarcaAsync(MarcaSelecionada.codigo);
                if (modelosTask != null)
                {
                    List<ModeloDto>? modelos = await modelosTask;
                    int index = 0;
                    foreach (var modelo in modelos)
                    {
                        var modeloIndexado = new ModeloWithIndexListDto();
                        modeloIndexado.modelo.nome = modelo.nome;
                        modeloIndexado.modelo.codigo = modelo.codigo;
                        modeloIndexado.id = index;
                        _listaModeloIndexada.Add(modeloIndexado);
                        comboBoxModelo.Items.Add(modelo.nome);
                        index++;
                    }
                }

            }

        }
        private void comboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexModeloSelecionado = comboBoxMarca.SelectedIndex;
            if (indexModeloSelecionado >= 0)
            {
                _modeloSelecionado = _modeloService.EncontrarModeloPorIndex(_listaModeloIndexada, indexModeloSelecionado);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            VeiculoCreateDto novoVeiculo = atribuirValores();
            _veiculoService.CriarVeiculoAsync(novoVeiculo);
            MessageBox.Show("Você conseguiu adicionar um novo veículo", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var cadastro = _serviceProvider.GetRequiredService<MenuRestrito>();
            cadastro.Show();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var cadastro = _serviceProvider.GetRequiredService<MenuRestrito>();
            cadastro.Show();
            this.Close();
        }
        private void ConfigurarMascarasEValidacoes()
        {

            txtPlaca.Mask = @"AAA-0000";
            txtPlaca.PromptChar = '_';
            txtAnoFabricacao.Mask = "0000";
            txtAnoModelo.Mask = "0000";
            chassiTxt.Mask = "AAAAAAAAAAAAAAAAA";
            txtPlaca.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtPlaca.Culture = System.Globalization.CultureInfo.InvariantCulture;
            txtPlaca.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBox_Validating);

            txtAnoFabricacao.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtAnoFabricacao.Culture = System.Globalization.CultureInfo.InvariantCulture;
            txtAnoFabricacao.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBox_Validating);

            txtAnoModelo.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtAnoModelo.Culture = System.Globalization.CultureInfo.InvariantCulture;
            txtAnoModelo.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBox_Validating);

            chassiTxt.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            chassiTxt.Culture = System.Globalization.CultureInfo.InvariantCulture;
            chassiTxt.Validating += new System.ComponentModel.CancelEventHandler(this.MaskedTextBox_Validating);


        }
        
        private void DecimalMaskedTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove o prompt e espaços em branco da string para validação
            string text = maskedTextBox.Text.Replace(maskedTextBox.PromptChar, ' ').Trim();

            // Verifica se o texto não está vazio e se tem o formato correto
            if (string.IsNullOrWhiteSpace(text) || text == ",")
            {
                maskedTextBox.BackColor = Color.LightCoral; // Muda a cor de fundo para vermelho claro
                MessageBox.Show("O campo é obrigatório e deve ser preenchido corretamente.");
                e.Cancel = true;
            }
            else
            {
                // Converte a string para decimal, usando a cultura correta
                if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal value))
                {
                    // Verifica se o valor está dentro do intervalo permitido
                    if (value < 1000m || value > 10000000m)
                    {
                        maskedTextBox.BackColor = Color.LightCoral; // Muda a cor de fundo para vermelho claro
                        MessageBox.Show("O valor deve estar entre 1.000 e 10.000.000.");
                        e.Cancel = true;
                    }
                    else
                    {
                        // Verifica se há apenas uma vírgula ou ponto
                        int separatorCount = text.Count(c => c == ',' || c == '.');
                        if (separatorCount > 1)
                        {
                            maskedTextBox.BackColor = Color.LightCoral; // Muda a cor de fundo para vermelho claro
                            MessageBox.Show("Insira apenas um separador decimal.");
                            e.Cancel = true;
                        }
                        else
                        {
                            // Restaura a cor de fundo original
                            maskedTextBox.BackColor = Color.White;
                        }
                    }
                }
                else
                {
                    maskedTextBox.BackColor = Color.LightCoral; // Muda a cor de fundo para vermelho claro
                    MessageBox.Show("Por favor, insira um valor numérico válido.");
                    e.Cancel = true;
                }
            }
        }

        private void MaskedTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            if (maskedTextBox != null)
            {
                if (!maskedTextBox.MaskCompleted || string.IsNullOrWhiteSpace(maskedTextBox.Text.Replace(maskedTextBox.PromptChar, ' ')))
                {
                    maskedTextBox.BackColor = Color.LightCoral;
                    e.Cancel = true;
                }
                else
                {
                    maskedTextBox.BackColor = Color.White;
                }
            }
        }


        private void MaskedTextBox_Validated(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            if (maskedTextBox != null && maskedTextBox.MaskCompleted)
            {
                maskedTextBox.BackColor = Color.White;
            }
        }

        private void textoVendo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
