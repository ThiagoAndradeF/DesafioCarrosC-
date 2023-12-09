using Garagem.Infra.Repositories;
using Garagem.Services;
using System.Linq.Expressions;

namespace Garagem
{
    public partial class Form1 : Form
    {
        public AuthenticationService _authService; 
        public Form1(IAuthenticationRepository authRepository)
        {
            InitializeComponent();
            _authService = new AuthenticationService(authRepository);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Length > 0 && txtSenha.Text.Length>0)
            {
                string? usuario = txtUsuario.Text.ToString();
                string? senha = txtSenha.Text.ToString();
                try
                {
                    bool login =await _authService.ExecuteLoginAsync(usuario, senha);
                    if (login == true) {
                        //MessageBox.Show("Login bem sucedido.", "Login bem sucedido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                        txtSenha.Text = "";
                    }
                }
                catch {
                    MessageBox.Show("Desculpe, Erro no processo de login.", "Erro no processo de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Desculpe.", "Usuário ou senha nulos");
            }
            
        }
    }
}
