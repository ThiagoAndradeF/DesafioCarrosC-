namespace Garagem.View.Forms.NovaPasta1
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
            lblChassi = new Label();
            lblFipe = new Label();
            lblModelo = new Label();
            lblAnoFabricacao = new Label();
            lblValorVenda = new Label();
            label4 = new Label();
            lblPlaca = new Label();
            lblAnoModelo = new Label();
            label2 = new Label();
            lblMarca = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            comboBoxMarca = new ComboBox();
            comboBoxModelo = new ComboBox();
            SaveButton = new Button();
            backButton = new Button();
            txtAnoModelo = new MaskedTextBox();
            txtPlaca = new MaskedTextBox();
            txtAnoFabricacao = new MaskedTextBox();
            chassiTxt = new MaskedTextBox();
            txtVenda = new TextBox();
            textoVenda = new TextBox();
            textoFipe = new TextBox();
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
            // lblChassi
            // 
            lblChassi.AutoSize = true;
            lblChassi.Location = new Point(400, 97);
            lblChassi.Name = "lblChassi";
            lblChassi.Size = new Size(41, 15);
            lblChassi.TabIndex = 29;
            lblChassi.Text = "Chassi";
            // 
            // lblFipe
            // 
            lblFipe.AutoSize = true;
            lblFipe.Location = new Point(202, 176);
            lblFipe.Name = "lblFipe";
            lblFipe.Size = new Size(50, 15);
            lblFipe.TabIndex = 28;
            lblFipe.Text = "FIPE(R$)";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(202, 21);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 27;
            lblModelo.Text = "Modelo";
            // 
            // lblAnoFabricacao
            // 
            lblAnoFabricacao.AutoSize = true;
            lblAnoFabricacao.Location = new Point(202, 97);
            lblAnoFabricacao.Name = "lblAnoFabricacao";
            lblAnoFabricacao.Size = new Size(89, 15);
            lblAnoFabricacao.TabIndex = 26;
            lblAnoFabricacao.Text = "Ano Fabricação";
            // 
            // lblValorVenda
            // 
            lblValorVenda.AutoSize = true;
            lblValorVenda.Location = new Point(18, 176);
            lblValorVenda.Name = "lblValorVenda";
            lblValorVenda.Size = new Size(89, 15);
            lblValorVenda.TabIndex = 25;
            lblValorVenda.Text = "Valor Venda(R$)";
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
            lblPlaca.Location = new Point(18, 97);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(35, 15);
            lblPlaca.TabIndex = 23;
            lblPlaca.Text = "Placa";
            // 
            // lblAnoModelo
            // 
            lblAnoModelo.AutoSize = true;
            lblAnoModelo.Location = new Point(400, 21);
            lblAnoModelo.Name = "lblAnoModelo";
            lblAnoModelo.Size = new Size(73, 15);
            lblAnoModelo.TabIndex = 22;
            lblAnoModelo.Text = "Ano Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 40;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(18, 21);
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
            comboBoxMarca.Location = new Point(18, 39);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(164, 29);
            comboBoxMarca.TabIndex = 42;
            comboBoxMarca.SelectedIndexChanged += comboBoxMarca_SelectedIndexChanged;
            // 
            // comboBoxModelo
            // 
            comboBoxModelo.Font = new Font("Segoe UI", 12F);
            comboBoxModelo.FormattingEnabled = true;
            comboBoxModelo.Location = new Point(202, 39);
            comboBoxModelo.Name = "comboBoxModelo";
            comboBoxModelo.Size = new Size(164, 29);
            comboBoxModelo.TabIndex = 43;
            comboBoxModelo.SelectedIndexChanged += comboBoxModelo_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.AccessibleName = "saveButton";
            SaveButton.Location = new Point(624, 129);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(143, 62);
            SaveButton.TabIndex = 44;
            SaveButton.Text = "Salvar";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // backButton
            // 
            backButton.AccessibleDescription = "";
            backButton.AccessibleName = "backButton";
            backButton.Location = new Point(624, 21);
            backButton.Name = "backButton";
            backButton.Size = new Size(143, 61);
            backButton.TabIndex = 45;
            backButton.Text = "Voltar";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.AccessibleName = "txtAnoModelo";
            txtAnoModelo.Font = new Font("Segoe UI", 12F);
            txtAnoModelo.Location = new Point(400, 39);
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(154, 29);
            txtAnoModelo.TabIndex = 46;
            // 
            // txtPlaca
            // 
            txtPlaca.AccessibleName = "txtPlaca";
            txtPlaca.Font = new Font("Segoe UI", 12F);
            txtPlaca.Location = new Point(18, 115);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(154, 29);
            txtPlaca.TabIndex = 48;
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.AccessibleName = "txtAnoFabricacao";
            txtAnoFabricacao.Font = new Font("Segoe UI", 12F);
            txtAnoFabricacao.Location = new Point(202, 115);
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(154, 29);
            txtAnoFabricacao.TabIndex = 49;
            // 
            // chassiTxt
            // 
            chassiTxt.AccessibleDescription = "chassiTxt";
            chassiTxt.Font = new Font("Segoe UI", 12F);
            chassiTxt.Location = new Point(400, 115);
            chassiTxt.Name = "chassiTxt";
            chassiTxt.Size = new Size(148, 29);
            chassiTxt.TabIndex = 51;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(0, 0);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(100, 23);
            txtVenda.TabIndex = 0;
            // 
            // textoVenda
            // 
            textoVenda.AccessibleDescription = "textoVenda";
            textoVenda.Font = new Font("Segoe UI", 12F);
            textoVenda.Location = new Point(18, 198);
            textoVenda.Name = "textoVenda";
            textoVenda.Size = new Size(154, 29);
            textoVenda.TabIndex = 52;
            // 
            // textoFipe
            // 
            textoFipe.AccessibleDescription = "textoFipe";
            textoFipe.Font = new Font("Segoe UI", 12F);
            textoFipe.Location = new Point(202, 198);
            textoFipe.Name = "textoFipe";
            textoFipe.Size = new Size(154, 29);
            textoFipe.TabIndex = 53;
            textoFipe.TextChanged += textoVendo_TextChanged;
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textoFipe);
            Controls.Add(textoVenda);
            Controls.Add(chassiTxt);
            Controls.Add(txtAnoFabricacao);
            Controls.Add(txtPlaca);
            Controls.Add(txtAnoModelo);
            Controls.Add(backButton);
            Controls.Add(SaveButton);
            Controls.Add(comboBoxModelo);
            Controls.Add(comboBoxMarca);
            Controls.Add(lblMarca);
            Controls.Add(label2);
            Controls.Add(txtObs);
            Controls.Add(lblChassi);
            Controls.Add(lblFipe);
            Controls.Add(lblModelo);
            Controls.Add(lblAnoFabricacao);
            Controls.Add(lblValorVenda);
            Controls.Add(label4);
            Controls.Add(lblPlaca);
            Controls.Add(lblAnoModelo);
            Name = "CadastroVeiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroVeiculo";
            Load += CadastroVeiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObs;
        private Label lblChassi;
        private Label lblFipe;
        private Label lblModelo;
        private Label lblAnoFabricacao;
        private Label lblValorVenda;
        private Label label4;
        private Label lblPlaca;
        private Label lblAnoModelo;
        private Label label2;
        private Label lblMarca;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ComboBox comboBoxMarca;
        private ComboBox comboBoxModelo;
        private Button SaveButton;
        private Button backButton;
        private MaskedTextBox txtAnoModelo;
        private MaskedTextBox txtPlaca;
        private MaskedTextBox txtAnoFabricacao;
        private MaskedTextBox txtChassi;
        private MaskedTextBox vendaTxt;
        private MaskedTextBox chassiTxt;
        private TextBox textBox1;
        //private TextBox vendaTxt;
        private TextBox txtVenda;
        private TextBox txtFipe;
        private TextBox textoVenda;
        private TextBox textoFipe;
    }
}