using Garagem.Infra.Repositories;
using Garagem.Models;
using Garagem.Services;
using Microsoft.Extensions.DependencyInjection;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagem.View
{
    public partial class DetalhesVeiculo : Form
    {
        VeiculoService _veiculoService;
        private int _idVeiculoSelecionado;
        private IServiceProvider _serviceProvider;
        public int idVeiculoSelecionado;
        public DetalhesVeiculo(int idVeiculo, IVeiculoRepository veiculoRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _veiculoService = new VeiculoService(veiculoRepository);
            _serviceProvider = serviceProvider;
            _idVeiculoSelecionado = idVeiculo;
            LoadData();
        }
        private void SetTextBoxesReadOnly(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txtBox)
                {
                    txtBox.ReadOnly = true;
                }
                else if (c.HasChildren)
                {
                    SetTextBoxesReadOnly(c); // Chama recursivamente para controles filhos
                }
            }
        }
        private void PopularTextBoxesComValor(Control parent, string valor)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txtBox)
                {
                    txtBox.Text = valor;
                }
                else if (c.HasChildren)
                {
                    PopularTextBoxesComValor(c, valor); // Chama recursivamente para controles filhos
                }
            }
        }
        private async void LoadData()
        {
            var veiculoTask = _veiculoService.DetalhesVeiculoAsync(_idVeiculoSelecionado);
            if (veiculoTask != null)
            {
                VeiculoDto veiculoSelecionado = await veiculoTask;
                txtMarca.Text = veiculoSelecionado.NomeMarca;
                txtAnoFabricacao.Text = veiculoSelecionado?.AnoFabricacao.ToString();
                txtAnoModelo.Text = veiculoSelecionado?.AnoModelo.ToString();
                txtChassi.Text = veiculoSelecionado?.Chassi;
                txtFipe.Text = veiculoSelecionado?.ValorFIPE.ToString();
                txtModelo.Text = veiculoSelecionado?.NomeModelo.ToString();
                txtObs.Text = veiculoSelecionado?.Observacoes.ToString();
                txtPlaca.Text = veiculoSelecionado?.Placa.ToString();
                txtVenda.Text = veiculoSelecionado?.ValorVenda.ToString();

            }
            SetTextBoxesReadOnly(this);
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetalhesVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var menuRestrito = _serviceProvider.GetRequiredService<MenuRestrito>();
            menuRestrito.Show();
            this.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            
            await _veiculoService.ExcluirVeiculoAsync(_idVeiculoSelecionado);
        }
    }
} 
