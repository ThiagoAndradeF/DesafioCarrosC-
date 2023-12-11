using Garagem.Infra.Repositories;
using Garagem.Models;
using Garagem.Services;
using Garagem.View.Forms.NovaPasta1;
using Microsoft.Extensions.DependencyInjection;
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
        private IServiceProvider _serviceProvider;

        public MenuRestrito(IGaragemRepository garagemRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _garagemService = new GaragemService(garagemRepository);
            _serviceProvider = serviceProvider;
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
            var veiculoTask = _garagemService.ListarVeiculosCadastrados();
            if (veiculoTask != null)
            {
                 IEnumerable<VeiculoDto> veiculos = await veiculoTask;
                foreach (var veiculo in veiculos)
                {
                    int rowIndex = gridVeiculos.Rows.Add(veiculo.NomeMarca, veiculo.NomeModelo, veiculo.AnoModelo, veiculo.Id);

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
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.HeaderText = "Id";
            idColumn.Visible = false; // Oculta a coluna
            gridVeiculos.Columns.Add(idColumn);

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
                var idVeiculo = Convert.ToInt32(gridVeiculos.Rows[e.RowIndex].Cells["Id"].Value);
                //var menu = _serviceProvider.GetRequiredService<DetalhesVeiculo>();
                //menu.IdVeiculoSelecionado = idVeiculo;
                //menu.Show();
            }
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            var menu = _serviceProvider.GetRequiredService<CadastroVeiculo>();
            menu.Show();
            this.Close();
        }
    }
}
