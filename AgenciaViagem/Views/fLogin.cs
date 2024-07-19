using AgenciaViagem.Controlls;
using AgenciaViagem.Models;

namespace AgenciaViagem.Views
{

    public partial class fLogin : Form
    {
        /// <summary>
        /// Classe parcial responsável pelo formulário de login da aplicação.
        /// </summary>
        private CTR_PessoaCliente CTR_PessoaCliente;

        public fLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento acionado ao clicar no link para cadastro.
        /// Abre o formulário de cadastro de cliente.
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cadastrar = new fCadastrarCliente();
            cadastrar.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Entrar".
        /// Realiza a autenticação do usuário com base no login e senha inseridos.
        /// </summary>
        private void Entrar_Click_1(object sender, EventArgs e)
        {
            CTR_PessoaCliente ctr_pessoacliente = new CTR_PessoaCliente();
            PessoaCliente pessoaCliente = new PessoaCliente();
            pessoaCliente.Login = txtCliente.Text;

            if (int.TryParse(txtSenha.Text, out int senha))
            {
                pessoaCliente.Senha = senha;

                Sessao sessao = ctr_pessoacliente.autenticador(pessoaCliente);

                if (sessao.ValidarUsuario)
                {
                    MessageBox.Show("Login bem-sucedido!");

                    fMenu fMenu = new fMenu();
                    fMenu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            else
            {
                MessageBox.Show("Formato inválido para senha. Insira um número válido.");
            }
        }
    }
}

