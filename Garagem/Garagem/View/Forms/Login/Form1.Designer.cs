namespace Garagem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnEntrar = new Button();
            label_login = new Label();
            Login = new GroupBox();
            btnCancelar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            labelUsuario = new Label();
            labelSenha = new Label();
            Login.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonHighlight;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.Location = new Point(312, 169);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(110, 37);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Location = new Point(159, 29);
            label_login.Name = "label_login";
            label_login.Size = new Size(0, 15);
            label_login.TabIndex = 1;
            label_login.Click += label1_Click;
            // 
            // Login
            // 
            Login.Controls.Add(btnCancelar);
            Login.Controls.Add(txtSenha);
            Login.Controls.Add(txtUsuario);
            Login.Controls.Add(labelUsuario);
            Login.Controls.Add(labelSenha);
            Login.Controls.Add(label_login);
            Login.Controls.Add(btnEntrar);
            Login.Location = new Point(12, 26);
            Login.Name = "Login";
            Login.Size = new Size(433, 222);
            Login.TabIndex = 2;
            Login.TabStop = false;
            Login.Text = "Login";
            Login.Enter += Login_Enter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(207, 169);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 37);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(12, 123);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(410, 29);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(12, 51);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "DIgite seu usuário";
            txtUsuario.Size = new Size(410, 29);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 12F);
            labelUsuario.Location = new Point(12, 27);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(67, 21);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Segoe UI", 12F);
            labelSenha.Location = new Point(12, 99);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(56, 21);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha:";
            labelSenha.Click += label1_Click_1;
            // 
            // Form1
            // 
            AccessibleName = "GV - Garagem virtual";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 268);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GV - Garagem virtual";
            Load += Form1_Load;
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrar;
        private Label label_login;
        private GroupBox Login;
        private Label labelSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label labelUsuario;
        private Button btnCancelar;
    }
}
