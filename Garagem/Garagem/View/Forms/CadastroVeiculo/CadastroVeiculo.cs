using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                // Converte o valor para o tipo especificado
                return Convert.ChangeType(value, targetType);
            }
            catch (Exception ex)
            {
                // Lança uma nova exceção se a conversão falhar
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
            veiculoCreate.ValorVenda = (decimal)ConvertValue(txtVenda.Text, typeof(decimal));
            veiculoCreate.ValorFIPE = (decimal)ConvertValue(txtFipe.Text, typeof(decimal));
            veiculoCreate.Chassi = txtChassi.Text;
            veiculoCreate.AnoFabricacao = (int)ConvertValue(txtAnoFabricacao.Text, typeof(int));
            veiculoCreate.AnoModelo = (int)ConvertValue(txtAnoFabricacao.Text, typeof(int));
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

        private void txtAnoModelo_TextChanged(object sender, EventArgs e)
        {

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
    }
}
