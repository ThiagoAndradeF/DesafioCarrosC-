using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Garagem.Infra.Repositories;
using Garagem.Models;
using Garagem.Services;
using static System.Resources.ResXFileRef;

namespace Garagem.View.Forms.NovaPasta1
{
    public partial class CadastroVeiculo : Form
    {
        private VeiculoService _veiculoService;
        private MarcaService _marcaService;
        private ModeloService _modeloService;
        private List<MarcaWithIndexListDto> _listaMarcaIndexada;
        public CadastroVeiculo(IVeiculoRepository veiculoRepository, IMarcaRepository marcaRepository, IModeloRepository modeloRepository)
        {
            InitializeComponent();
            _veiculoService = new VeiculoService(veiculoRepository);
            _marcaService = new MarcaService(marcaRepository);
            _modeloService = new ModeloService(modeloRepository);
            _listaMarcaIndexada = [];
            LoadDataComboBoxMarca();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
                throw new InvalidOperationException($"Não foi possível converter o campo '{value}' para o tipo '{targetType.Name}'", ex);
            }
        }
        private VeiculoCreateDto atribuirValores()
        {
            VeiculoCreateDto veiculoCreate = new VeiculoCreateDto();
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

                var modelosTask = _modeloService.ListarModelosByIdMarcaAsync(MarcaSelecionada.codigo);
                if (modelosTask != null)
                {
                    List<ModeloDto>? modelos = await modelosTask;
                    comboBoxModelo.ValueMember = "codigo";
                    comboBoxModelo.DisplayMember = "nome";
                    foreach (var modelo in modelos)
                    {
                        comboBoxModelo.Items.Add(modelo.nome);
                    }
                }

            }

        }



        private void comboBoxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAnoModelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
