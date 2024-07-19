using AgenciaViagem.Controlls;
using AgenciaViagem.Models;
using System.Globalization;
using static AgenciaViagem.Models.Enum;

namespace AgenciaViagem.Views
{
    public partial class fCadastrarCliente : Form
    {
        private CTR_PessoaCliente CTR_PessoaCliente;

        /// <summary>
        /// Construtor da classe fCadastrarCliente, inicializa o formulário e a instância do controlador CTR_PessoaCliente.
        /// </summary>
        public fCadastrarCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de clique do botão "Cadastrar", cria um novo cliente com base nos dados fornecidos e o cadastra utilizando o controlador.
        /// </summary>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtIdade.Text) || string.IsNullOrWhiteSpace(cboGenero.SelectedItem.ToString()) || string.IsNullOrWhiteSpace(txtTelefone.Text) || string.IsNullOrWhiteSpace(txtEndereco.Text) || string.IsNullOrWhiteSpace(txtCidade.Text) || string.IsNullOrWhiteSpace(comboboxperfil.SelectedItem.ToString()) || string.IsNullOrWhiteSpace(txtPais.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PessoaClientePerfil perfilSelecionado = (PessoaClientePerfil)System.Enum.Parse(typeof(PessoaClientePerfil), comboboxperfil.SelectedItem.ToString());
            DateTime dataNascimento = DateTime.ParseExact(txtIdade.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            PessoaCliente cliente = new PessoaCliente();

            cliente.Nome = txtNome.Text;
            cliente.DataNascimento = dataNascimento;
            cliente.Genero = cboGenero.SelectedItem.ToString();
            cliente.CPF = (int)Convert.ToInt64(txtCPF.Text);
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Perfil = (PessoaClientePerfil)(int)perfilSelecionado;
            cliente.Pais = txtPais.Text;
            cliente.Email = txtEmail.Text;
            cliente.Login = txtLogin.Text;
            cliente.Senha = Convert.ToInt32(txtSenha.Text);

            CTR_PessoaCliente = new CTR_PessoaCliente();
            CTR_PessoaCliente.CriarCliente(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        /// <summary>
        /// Evento de clique do botão "Login", exibe o formulário de login e oculta o formulário atual.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = new fLogin();
            login.Show();
            this.Visible = false;
        }
    }
}
