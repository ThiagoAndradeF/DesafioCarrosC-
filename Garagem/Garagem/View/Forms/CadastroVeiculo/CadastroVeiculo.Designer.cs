﻿namespace Garagem.View.Forms.NovaPasta1
{
    partial class CadastroVeiculo
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
            txtObs = new TextBox();
            txtVenda = new TextBox();
            txtFipe = new TextBox();
            txtChassi = new TextBox();
            txtAnoFabricacao = new TextBox();
            txtAnoModelo = new TextBox();
            txtPlaca = new TextBox();
            lblChassi = new Label();
            lblFipe = new Label();
            lblModelo = new Label();
            lblAnoFabricacao = new Label();
            lblValorVenda = new Label();
            label4 = new Label();
            lblPlaca = new Label();
            lblAnoModelo = new Label();
            btnSave = new Button();
            label2 = new Label();
            lblMarca = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            comboBoxMarca = new ComboBox();
            comboBoxModelo = new ComboBox();
            SuspendLayout();
            // 
            // txtObs
            // 
            txtObs.Location = new Point(18, 316);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.ShortcutsEnabled = false;
            txtObs.Size = new Size(765, 100);
            txtObs.TabIndex = 38;
            // 
            // txtVenda
            // 
            txtVenda.Font = new Font("Segoe UI", 12F);
            txtVenda.Location = new Point(18, 203);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(164, 29);
            txtVenda.TabIndex = 37;
            // 
            // txtFipe
            // 
            txtFipe.Font = new Font("Segoe UI", 12F);
            txtFipe.Location = new Point(202, 203);
            txtFipe.Name = "txtFipe";
            txtFipe.Size = new Size(176, 29);
            txtFipe.TabIndex = 36;
            // 
            // txtChassi
            // 
            txtChassi.Font = new Font("Segoe UI", 12F);
            txtChassi.Location = new Point(400, 120);
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(154, 29);
            txtChassi.TabIndex = 35;
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Font = new Font("Segoe UI", 12F);
            txtAnoFabricacao.Location = new Point(202, 120);
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(176, 29);
            txtAnoFabricacao.TabIndex = 34;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.Font = new Font("Segoe UI", 12F);
            txtAnoModelo.Location = new Point(400, 44);
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(154, 29);
            txtAnoModelo.TabIndex = 33;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Segoe UI", 12F);
            txtPlaca.Location = new Point(18, 120);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(164, 29);
            txtPlaca.TabIndex = 30;
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(400, 102);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(41, 15);
            lblChassi.TabIndex = 29;
            lblChassi.Text = "Chassi";
            // 
            // lblFipe
            // 
            lblFipe.AutoSize = true;
            lblFipe.Location = new Point(202, 185);
            lblFipe.Name = "lblFipe";
            lblFipe.Size = new Size(29, 15);
            lblFipe.TabIndex = 28;
            lblFipe.Text = "FIPE";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(202, 26);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 27;
            lblModelo.Text = "Modelo";
            // 
            // lblAnoFabricacao
            // 
            lblAnoFabricacao.AutoSize = true;
            lblAnoFabricacao.Location = new Point(202, 102);
            lblAnoFabricacao.Name = "lblAnoFabricacao";
            lblAnoFabricacao.Size = new Size(89, 15);
            lblAnoFabricacao.TabIndex = 26;
            lblAnoFabricacao.Text = "Ano Fabricação";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Location = new Point(18, 185);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new Size(68, 15);
            lblValorVenda.TabIndex = 25;
            lblValorVenda.Text = "Valor Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 283);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 24;
            label4.Text = "Observações";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(18, 102);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 23;
            lblPlaca.Text = "Placa";
            // 
            // lblAnoModelo
            // 
            lblAnoModelo.AutoSize = true;
            lblAnoModelo.Location = new Point(400, 26);
            lblAnoModelo.Name = "lblAnoModelo";
            lblAnoModelo.Size = new Size(73, 15);
            lblAnoModelo.TabIndex = 22;
            lblAnoModelo.Text = "Ano Modelo";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.ForeColor = Color.DarkBlue;
            btnSave.Location = new Point(641, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 98);
            btnSave.TabIndex = 20;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 26);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 40;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(18, 26);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 41;
            lblMarca.Text = "Marca";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.Font = new Font("Segoe UI", 12F);
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(18, 44);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(164, 29);
            comboBoxMarca.TabIndex = 42;
            comboBoxMarca.SelectedIndexChanged += comboBoxMarca_SelectedIndexChanged;
            // 
            // comboBoxModelo
            // 
            comboBoxModelo.Font = new Font("Segoe UI", 12F);
            comboBoxModelo.FormattingEnabled = true;
            comboBoxModelo.Location = new Point(202, 44);
            comboBoxModelo.Name = "comboBoxModelo";
            comboBoxModelo.Size = new Size(164, 29);
            comboBoxModelo.TabIndex = 43;
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxModelo);
            Controls.Add(comboBoxMarca);
            Controls.Add(lblMarca);
            Controls.Add(label2);
            Controls.Add(txtObs);
            Controls.Add(txtVenda);
            Controls.Add(txtFipe);
            Controls.Add(txtChassi);
            Controls.Add(txtAnoFabricacao);
            Controls.Add(txtAnoModelo);
            Controls.Add(txtPlaca);
            Controls.Add(lblChassi);
            Controls.Add(lblFipe);
            Controls.Add(lblModelo);
            Controls.Add(lblAnoFabricacao);
            Controls.Add(lblValorVenda);
            Controls.Add(label4);
            Controls.Add(lblPlaca);
            Controls.Add(lblAnoModelo);
            Controls.Add(btnSave);
            Name = "CadastroVeiculo";
            Text = "CadastroVeiculo";
            Load += CadastroVeiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObs;
        private TextBox txtVenda;
        private TextBox txtFipe;
        private TextBox txtChassi;
        private TextBox txtAnoFabricacao;
        private TextBox txtAnoModelo;
        private TextBox txtPlaca;
        private Label lblChassi;
        private Label lblFipe;
        private Label lblModelo;
        private Label lblAnoFabricacao;
        private Label lblValorVenda;
        private Label label4;
        private Label lblPlaca;
        private Label lblAnoModelo;
        private Button btnSave;
        private Label label2;
        private Label lblMarca;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ComboBox comboBoxMarca;
        private ComboBox comboBoxModelo;
    }
}