using Garagem.Infra.Repositories;
using Garagem.Models;
using Garagem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Garagem.View
{
    public partial class MenuRestrito : Form
    {
        private GaragemService _garagemService;
        public MenuRestrito(IGaragemRepository garagemRepository)
        {
            InitializeComponent();
            _garagemService= new GaragemService(garagemRepository);
            InitializeDataGridView();

        }

        private void MenuRestrito_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void groupGrid_Enter(object sender, EventArgs e)
        {

        }
        private async void LoadData()
        {
            // Supondo que você tenha uma lista de carros
            var veiculoTask = _garagemService.ListarVeiculosCadastrados();
            if (veiculoTask != null)
            {
                IEnumerable<VeiculoDto> veiculos = await veiculoTask;
                foreach (var veiculo in veiculos)
                {
                    gridVeiculos.Rows.Add(veiculo.NomeMarca, veiculo.NomeModelo, veiculo.AnoModelo);
                }
            }
        }
        private void InitializeDataGridView()
        {
            gridVeiculos.Dock = DockStyle.Fill;
            gridVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridVeiculos.ReadOnly = true;
            gridVeiculos.ColumnCount = 3; // Por exemplo, Marca, Modelo, e Ações
            gridVeiculos.Columns[0].Name = "Marca";
            gridVeiculos.Columns[1].Name = "Modelo";
            gridVeiculos.Columns[2].Name = "Ano";



            // Adicionar botões
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Ações";
            btn.Text = "Ver Detalhes";
            btn.Name = "btnDetalhes";
            btn.UseColumnTextForButtonValue = true;
            gridVeiculos.Columns.Add(btn);
            LoadData();
        }
        private void gridVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridVeiculos.Columns["btnDetalhes"].Index)
            {
                var marca = gridVeiculos.Rows[e.RowIndex].Cells[0].Value.ToString();
                var modelo = gridVeiculos.Rows[e.RowIndex].Cells[1].Value.ToString();

                // Abrir diálogo com detalhes
                MessageBox.Show($"Marca: {marca}\nModelo: {modelo}", "Detalhes do Carro");
            }

        }
    }
}
