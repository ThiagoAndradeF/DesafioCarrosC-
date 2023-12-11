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
            editButton = new Button();
            deleteButton = new Button();
            backButton = new Button();
            lblMarca = new Label();
            label2 = new Label();
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
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // editButton
            // 
            editButton.AccessibleName = "editButton";
            editButton.Cursor = Cursors.Hand;
            editButton.ForeColor = Color.Gold;
            editButton.Location = new Point(658, 111);
            editButton.Name = "editButton";
            editButton.Size = new Size(106, 45);
            editButton.TabIndex = 0;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += btnEdit_Click;
            // 
            // deleteButton
            // 
            deleteButton.AccessibleName = "deleteButton";
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.ForeColor = Color.Crimson;
            deleteButton.Location = new Point(658, 39);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(106, 50);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Excluir";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += btnDelete_Click;
            // 
            // backButton
            // 
            backButton.AccessibleDescription = "";
            backButton.AccessibleName = "backButton";
            backButton.Cursor = Cursors.Hand;
            backButton.Location = new Point(658, 180);
            backButton.Name = "backButton";
            backButton.Size = new Size(106, 47);
            backButton.TabIndex = 66;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(30, 25);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 62;
            lblMarca.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 25);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 61;
            // 
            // txtObs
            // 
            txtObs.Location = new Point(30, 320);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.ShortcutsEnabled = false;
            txtObs.Size = new Size(734, 100);
            txtObs.TabIndex = 60;
            // 
            // txtVenda
            // 
            txtVenda.Font = new Font("Segoe UI", 12F);
            txtVenda.Location = new Point(30, 198);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(164, 29);
            txtVenda.TabIndex = 59;
            // 
            // txtFipe
            // 
            txtFipe.Font = new Font("Segoe UI", 12F);
            txtFipe.Location = new Point(214, 198);
            txtFipe.Name = "txtFipe";
            txtFipe.Size = new Size(176, 29);
            txtFipe.TabIndex = 58;
            txtFipe.TextChanged += txtFipe_TextChanged;
            // 
            // txtChassi
            // 
            txtChassi.Font = new Font("Segoe UI", 12F);
            txtChassi.Location = new Point(412, 119);
            txtChassi.Name = "txtChassi";
            txtChassi.Size = new Size(154, 29);
            txtChassi.TabIndex = 57;
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Font = new Font("Segoe UI", 12F);
            txtAnoFabricacao.Location = new Point(214, 119);
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(176, 29);
            txtAnoFabricacao.TabIndex = 56;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.Font = new Font("Segoe UI", 12F);
            txtAnoModelo.Location = new Point(412, 43);
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(154, 29);
            txtAnoModelo.TabIndex = 55;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Segoe UI", 12F);
            txtPlaca.Location = new Point(30, 119);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(164, 29);
            txtPlaca.TabIndex = 54;
            // 
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(412, 101);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(41, 15);
            lblChassi.TabIndex = 53;
            lblChassi.Text = "Chassi";
            // 
            // lblFipe
            // 
            lblFipe.AutoSize = true;
            lblFipe.Location = new Point(214, 180);
            lblFipe.Name = "lblFipe";
            lblFipe.Size = new Size(29, 15);
            lblFipe.TabIndex = 52;
            lblFipe.Text = "FIPE";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(214, 25);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 51;
            lblModelo.Text = "Modelo";
            // 
            // lblAnoFabricacao
            // 
            lblAnoFabricacao.AutoSize = true;
            lblAnoFabricacao.Location = new Point(214, 101);
            lblAnoFabricacao.Name = "lblAnoFabricacao";
            lblAnoFabricacao.Size = new Size(89, 15);
            lblAnoFabricacao.TabIndex = 50;
            lblAnoFabricacao.Text = "Ano Fabricação";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Location = new Point(30, 180);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new Size(68, 15);
            lblValorVenda.TabIndex = 49;
            lblValorVenda.Text = "Valor Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 287);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 48;
            label4.Text = "Observações";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(30, 101);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 47;
            lblPlaca.Text = "Placa";
            // 
            // lblAnoModelo
            // 
            lblAnoModelo.AutoSize = true;
            lblAnoModelo.Location = new Point(412, 25);
            lblAnoModelo.Name = "lblAnoModelo";
            lblAnoModelo.Size = new Size(73, 15);
            lblAnoModelo.TabIndex = 46;
            lblAnoModelo.Text = "Ano Modelo";
            // 
            // txtModelo
            // 
            txtModelo.AccessibleName = "txtModelo";
            txtModelo.Font = new Font("Segoe UI", 12F);
            txtModelo.Location = new Point(214, 43);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(176, 29);
            txtModelo.TabIndex = 67;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtMarca
            // 
            txtMarca.AccessibleName = "txtMarca";
            txtMarca.Font = new Font("Segoe UI", 12F);
            txtMarca.Location = new Point(30, 43);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(154, 29);
            txtMarca.TabIndex = 68;
            // 
            // saveButton
            // 
            saveButton.AccessibleName = "saveButton";
            saveButton.BackColor = Color.Transparent;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Font = new Font("Segoe UI", 12F);
            saveButton.ForeColor = Color.Lime;
            saveButton.Location = new Point(610, 252);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(154, 50);
            saveButton.TabIndex = 69;
            saveButton.Text = "Salvar";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AccessibleName = "cancelButton";
            cancelButton.BackColor = Color.Transparent;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Font = new Font("Segoe UI", 12F);
            cancelButton.ForeColor = Color.Red;
            cancelButton.Location = new Point(412, 252);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(154, 50);
            cancelButton.TabIndex = 70;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // DetalhesVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(backButton);
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
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Name = "DetalhesVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalhesVeiculo";
            TopMost = true;
            Load += DetalhesVeiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editButton;
        private Button deleteButton;
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
        private TextBox txtAnoModelo;
        private TextBox txtAnoFabricacao;
        private TextBox txtChassi;
        private TextBox txtFipe;
        private TextBox txtVenda;
        private TextBox txtObs;
        private Button backButton;
        private Label label2;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Button saveButton;
        private Button cancelButton;
    }
}