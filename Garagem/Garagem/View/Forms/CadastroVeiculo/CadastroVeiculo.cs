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

namespace Garagem.View.Forms.NovaPasta1
{
    public partial class CadastroVeiculo : Form
    {
        private VeiculoService _veiculoService;
        private MarcaService _marcaService;
        private ModeloService _modeloService;
        public CadastroVeiculo(IVeiculoRepository veiculoRepository, IMarcaRepository marcaRepository, IModeloRepository modeloRepository)
        {
            InitializeComponent();
            _veiculoService = new VeiculoService(veiculoRepository);
            _marcaService = new MarcaService(marcaRepository);
            _modeloService = new ModeloService(modeloRepository);
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
                foreach (var marca in marcas)
                {
                    comboBoxMarca.Items.Add(marca);
                    comboBoxMarca.ValueMember = "codigo";
                    comboBoxMarca.DisplayMember = "nome";
                }
            }
        }

        private async void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModelo.Items.Clear();
            string idMarcaSelecionada = (string)comboBoxMarca.SelectedValue;

            if (idMarcaSelecionada != null)
            {
                var modelosTask = _modeloService.ListarModelosByIdMarcaAsync(idMarcaSelecionada);

                if (modelosTask != null)
                {
                    List<ModeloDto>? modelos = await modelosTask;
                    comboBoxModelo.ValueMember = "codigo";
                    comboBoxModelo.DisplayMember = "nome";

                    foreach (var modelo in modelos)
                    {
                        comboBoxModelo.Items.Add(modelo);
                    }
                }
            }
        }
    }
}
