namespace Garagem.View
{
    partial class MenuRestrito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuContainer = new TabControl();
            optionListar = new TabPage();
            optionCadastrar = new TabPage();
            gridVeiculos = new DataGridView();
            groupGrid = new GroupBox();
            atualizarButton = new Button();
            btnAddVeiculo = new Button();
            menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVeiculos).BeginInit();
            groupGrid.SuspendLayout();
            SuspendLayout();
            // 
            // menuContainer
            // 
            menuContainer.AccessibleName = "menuContainer";
            menuContainer.Controls.Add(optionListar);
            menuContainer.Controls.Add(optionCadastrar);
            menuContainer.Location = new Point(2, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.SelectedIndex = 0;
            menuContainer.Size = new Size(796, 23);
            menuContainer.TabIndex = 0;
            // 
            // optionListar
            // 
            optionListar.Location = new Point(4, 24);
            optionListar.Name = "optionListar";
            optionListar.Padding = new Padding(3);
            optionListar.Size = new Size(788, 0);
            optionListar.TabIndex = 0;
            optionListar.Text = "Listar ";
            optionListar.UseVisualStyleBackColor = true;
            // 
            // optionCadastrar
            // 
            optionCadastrar.Location = new Point(4, 24);
            optionCadastrar.Name = "optionCadastrar";
            optionCadastrar.Padding = new Padding(3);
            optionCadastrar.Size = new Size(788, 0);
            optionCadastrar.TabIndex = 1;
            optionCadastrar.Text = "Cadastrar Carro";
            optionCadastrar.UseVisualStyleBackColor = true;
            // 
            // gridVeiculos
            // 
            gridVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVeiculos.Location = new Point(23, 22);
            gridVeiculos.Name = "gridVeiculos";
            gridVeiculos.Size = new Size(688, 333);
            gridVeiculos.TabIndex = 1;
            gridVeiculos.CellContentClick += gridVeiculos_CellContentClick;
            // 
            // groupGrid
            // 
            groupGrid.Controls.Add(atualizarButton);
            groupGrid.Controls.Add(gridVeiculos);
            groupGrid.Location = new Point(35, 50);
            groupGrid.Name = "groupGrid";
            groupGrid.Size = new Size(736, 372);
            groupGrid.TabIndex = 2;
            groupGrid.TabStop = false;
            groupGrid.Text = "Veículos Cadastrados";
            groupGrid.Enter += groupGrid_Enter;
            // 
            // atualizarButton
            // 
            atualizarButton.AccessibleName = "atualizarButton";
            atualizarButton.Cursor = Cursors.Hand;
            atualizarButton.Location = new Point(666, 22);
            atualizarButton.Name = "atualizarButton";
            atualizarButton.Size = new Size(45, 45);
            atualizarButton.TabIndex = 4;
            atualizarButton.Text = "Atualizar";
            atualizarButton.UseVisualStyleBackColor = true;
            atualizarButton.Click += atualizarButton_Click;
            // 
            // btnAddVeiculo
            // 
            btnAddVeiculo.Location = new Point(589, 30);
            btnAddVeiculo.Name = "btnAddVeiculo";
            btnAddVeiculo.Size = new Size(157, 36);
            btnAddVeiculo.TabIndex = 3;
            btnAddVeiculo.Text = "Adicionar";
            btnAddVeiculo.UseVisualStyleBackColor = true;
            btnAddVeiculo.Click += btnAddVeiculo_Click;
            // 
            // MenuRestrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddVeiculo);
            Controls.Add(groupGrid);
            Controls.Add(menuContainer);
            Name = "MenuRestrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuRestrito";
            Load += MenuRestrito_Load;
            menuContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridVeiculos).EndInit();
            groupGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl menuContainer;
        private TabPage optionListar;
        private TabPage optionCadastrar;
        private DataGridView gridVeiculos;
        private GroupBox groupGrid;
        private Button btnAddVeiculo;
        private Button atualizarButton;
    }
}