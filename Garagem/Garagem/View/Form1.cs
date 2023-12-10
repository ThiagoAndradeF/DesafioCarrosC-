using Garagem.Infra.Repositories;
using Garagem.Services;
using Garagem.View;
using System.Linq.Expressions;

namespace Garagem
{
    public partial class Form1 : Form
    {
        private IGaragemRepository _garagemRepository;
        private AuthenticationService _authService;
        public Form1(IAuthenticationRepository authRepository, IGaragemRepository garagemRepository)
        {
            InitializeComponent();
            _authService = new AuthenticationService(authRepository);
            _garagemRepository = garagemRepository;
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
            if (txtUsuario.Text.Length > 0 && txtSenha.Text.Length > 0)
            {
                string? usuario = txtUsuario.Text.ToString();
                string? senha = txtSenha.Text.ToString();
                try
                {
                    bool login = await _authService.ExecuteLoginAsync(usuario, senha);
                    if (login == true)
                    {
                        var menu = new MenuRestrito(_garagemRepository);
                        menu.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                        txtSenha.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Desculpe, Erro no processo de login.", "Erro no processo de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Desculpe.", "Usu�rio ou senha nulos");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
