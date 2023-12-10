namespace Garagem.View
{
    partial class DetalhesVeiculo
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
            btnEdit = new Button();
            btnDelete = new Button();
            lblPlaca = new Label();
            lblAnoModelo = new Label();
            lblMarca = new Label();
            label4 = new Label();
            lblValorVenda = new Label();
            lblAnoFabricacao = new Label();
            lblModelo = new Label();
            lblFipe = new Label();
            lblChassi = new Label();
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtAnoModelo = new TextBox();
            txtAnoFabricacao = new TextBox();
            txtChassi = new TextBox();
            txtFipe = new TextBox();
            txtVenda = new TextBox();
            txtObs = new TextBox();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.System;
            btnEdit.ForeColor = Color.DarkBlue;
            btnEdit.Location = new Point(658, 111);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 45);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Crimson;
            btnDelete.Location = new Point(658, 39);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Excluir";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(12, 25);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 2;
            lblPlaca.Text = "Placa";
            lblPlaca.Click += label1_Click;
            // 
            // lblAnoModelo
            // 
            lblAnoModelo.AutoSize = true;
            lblAnoModelo.Location = new Point(12, 97);
            lblAnoModelo.Name = "lblAnoModelo";
            lblAnoModelo.Size = new Size(73, 15);
            lblAnoModelo.TabIndex = 3;
            lblAnoModelo.Text = "Ano Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(196, 25);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 297);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Observações";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Location = new Point(12, 180);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new Size(68, 15);
            lblValorVenda.TabIndex = 6;
            lblValorVenda.Text = "Valor Venda";
            // 
            // lblAnoFabricacao
            // 
            lblAnoFabricacao.AutoSize = true;
            lblAnoFabricacao.Location = new Point(196, 97);
            lblAnoFabricacao.Name = "lblAnoFabricacao";
            lblAnoFabricacao.Size = new Size(89, 15);
            lblAnoFabricacao.TabIndex = 7;
            lblAnoFabricacao.Text = "Ano Fabricação";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(394, 25);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 8;
            lblModelo.Text = "Modelo";
            // 
            // lblFipe
            // 
            lblFipe.AutoSize = true;
            lblFipe.Location = new Point(196, 180);
            lblFipe.Name = "lblFipe";
            lblFipe.Size = new Size(29, 15);
            lblFipe.TabIndex = 9;
            lblFipe.Text = "FIPE";
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(394, 97);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(41, 15);
            lblChassi.TabIndex = 10;
            lblChassi.Text = "Chassi";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 43);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(134, 23);
            txtPlaca.TabIndex = 11;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(196, 43);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(134, 23);
            txtMarca.TabIndex = 12;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(394, 43);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(134, 23);
            txtModelo.TabIndex = 13;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.Location = new Point(12, 115);
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(134, 23);
            txtAnoModelo.TabIndex = 14;
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Location = new Point(196, 115);
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(134, 23);
            txtAnoFabricacao.TabIndex = 15;
            // 
            // txtChassi
            // 
            txtChassi.Location = new Point(394, 115);
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(134, 23);
            txtChassi.TabIndex = 16;
            // 
            // txtFipe
            // 
            txtFipe.Location = new Point(196, 198);
            txtFipe.Name = "txtFipe";
            txtFipe.Size = new Size(134, 23);
            txtFipe.TabIndex = 17;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(12, 198);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(134, 23);
            txtVenda.TabIndex = 18;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(12, 327);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.ShortcutsEnabled = false;
            txtObs.Size = new Size(765, 88);
            txtObs.TabIndex = 19;
            // 
            // DetalhesVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtObs);
            Controls.Add(txtVenda);
            Controls.Add(txtFipe);
            Controls.Add(txtChassi);
            Controls.Add(txtAnoFabricacao);
            Controls.Add(txtAnoModelo);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtPlaca);
            Controls.Add(lblChassi);
            Controls.Add(lblFipe);
            Controls.Add(lblModelo);
            Controls.Add(lblAnoFabricacao);
            Controls.Add(lblValorVenda);
            Controls.Add(label4);
            Controls.Add(lblMarca);
            Controls.Add(lblAnoModelo);
            Controls.Add(lblPlaca);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Name = "DetalhesVeiculo";
            Text = "DetalhesVeiculo";
            TopMost = true;
            Load += DetalhesVeiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnDelete;
        private Label lblPlaca;
        private Label lblAnoModelo;
        private Label lblMarca;
        private Label label4;
        private Label lblValorVenda;
        private Label lblAnoFabricacao;
        private Label lblModelo;
        private Label lblFipe;
        private Label lblChassi;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtAnoModelo;
        private TextBox txtAnoFabricacao;
        private TextBox txtChassi;
        private TextBox txtFipe;
        private TextBox txtVenda;
        private TextBox txtObs;
    }
}