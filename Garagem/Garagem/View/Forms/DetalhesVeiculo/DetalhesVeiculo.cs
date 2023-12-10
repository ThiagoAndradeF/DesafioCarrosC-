using Garagem.Infra.Repositories;
using Garagem.Models;
using Garagem.Services;
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
        public int  IdVeiculoSelecionado;
        public DetalhesVeiculo(int idVeiculo, IVeiculoRepository veiculoRepository)
        {
            InitializeComponent();
            _veiculoService = new VeiculoService(veiculoRepository);
            SetTextBoxesReadOnly(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Código para editar o veículo
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Código para excluir o veículo
        }
        private void DetalhesVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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


    }
}
