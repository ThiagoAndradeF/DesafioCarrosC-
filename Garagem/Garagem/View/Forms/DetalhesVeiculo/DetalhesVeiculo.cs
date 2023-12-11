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
        private VeiculoDto? _veiculoBackup;
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
                    SetTextBoxesReadOnly(c); 
                }
            }
        }
        private void SetTextBoxesEditable(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox txtBox)
                {
                    txtBox.ReadOnly = false;
                }
                else if (c.HasChildren)
                {
                    SetTextBoxesEditable(c); // Chamada recursiva para controles filhos
                }
            }
        }
        private async void LoadData(VeiculoDto? veiculoBackup = null)
        {
            VeiculoDto veiculoSelecionado;
            var veiculoTask = _veiculoService.DetalhesVeiculoAsync(_idVeiculoSelecionado);
            if (veiculoTask != null)
            {
                if(veiculoBackup == null){
                    veiculoSelecionado = await veiculoTask;
                }
                else veiculoSelecionado = veiculoBackup;
                txtMarca.Text = veiculoSelecionado.NomeMarca;
                txtAnoFabricacao.Text = veiculoSelecionado?.AnoFabricacao.ToString();
                txtAnoModelo.Text = veiculoSelecionado?.AnoModelo.ToString();
                txtChassi.Text = veiculoSelecionado?.Chassi;
                txtFipe.Text = veiculoSelecionado?.ValorFIPE.ToString();
                txtModelo.Text = veiculoSelecionado?.NomeModelo.ToString();
                txtObs.Text = veiculoSelecionado?.Observacoes.ToString();
                txtPlaca.Text = veiculoSelecionado?.Placa.ToString();
                txtVenda.Text = veiculoSelecionado?.ValorVenda.ToString();
                _veiculoBackup = veiculoSelecionado;
            }

            estadoFormularioDefault();
        }
        

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetalhesVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void voltarParaMenuRestrito()
        {
            var menuRestrito = _serviceProvider.GetRequiredService<MenuRestrito>();
            menuRestrito.Show();
            this.Close();

        }
        private void backButton_Click(object sender, EventArgs e)
        {
            voltarParaMenuRestrito();

        }
        private void estadoFormularioDefault()
        {
            deleteButton.Visible = true;
            editButton.Visible = true;
            backButton.Visible = true;
            saveButton.Visible = false;
            cancelButton.Visible = false;
            SetTextBoxesReadOnly(this);
        }
        private void estadoFormularioEdit()
        {
            deleteButton.Visible = false;
            editButton.Visible = false;
            backButton.Visible = false;
            saveButton.Visible = true;
            cancelButton.Visible = true;
            SetTextBoxesEditable(this);
            txtMarca.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtAnoModelo.ReadOnly = true;
            txtAnoFabricacao.ReadOnly = true;
            txtPlaca.ReadOnly = true;
            txtChassi.ReadOnly = true;
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            estadoFormularioEdit();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            await _veiculoService.ExcluirVeiculoAsync(_idVeiculoSelecionado);
            voltarParaMenuRestrito();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            VeiculoUpdateDto valoresVeiculoAtualizados = new VeiculoUpdateDto();
            valoresVeiculoAtualizados.ValorVenda = Convert.ToDecimal(txtVenda.Text);
            valoresVeiculoAtualizados.ValorFIPE = Convert.ToDecimal(txtFipe.Text);
            valoresVeiculoAtualizados.Observacoes = txtObs.Text;
            _veiculoService.EditarVeiculoAsync(_idVeiculoSelecionado,valoresVeiculoAtualizados);
            estadoFormularioDefault();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            estadoFormularioDefault();
            LoadData(_veiculoBackup);
        }
    }
} 
