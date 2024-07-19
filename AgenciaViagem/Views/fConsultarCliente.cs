using AgenciaViagem.Controlls;
using AgenciaViagem.Models;
using static AgenciaViagem.Models.Enum;

namespace AgenciaViagem.Views
{
    /// <summary>
    /// Classe parcial responsável pela interface do ConsultarCliente.
    /// </summary>
    public partial class fConsultarCliente : Form
    {
        private CTR_PessoaCliente pessoaCliente;
        public fConsultarCliente()
        {
            InitializeComponent();
            pessoaCliente = new CTR_PessoaCliente();
            DesabilitarEdicaoCampos();
        }

        /// <summary>
        /// Método chamado ao carregar a tela de consulta do cliente. Carrega os dados do cliente logado.
        /// </summary>
        private void fConsultarCliente_Load(object sender, EventArgs e)
        {
            PessoaCliente clienteLogado = Storage.ObterClienteLogado();

            PessoaClientePerfil perfilSelecionado = clienteLogado.Perfil;
            string perfilTexto = perfilSelecionado.ToString();
            comboboxperfil.SelectedItem = perfilTexto;
            txtLogin.Text = clienteLogado.Login;
            txtSenha.Text = Convert.ToString(clienteLogado.Senha);
            txtNome.Text = clienteLogado.Nome;
            txtIdade.Text = Convert.ToString(clienteLogado.DataNascimento);
            txtCPF.Text = Convert.ToString(clienteLogado.CPF);
            txtPais.Text = clienteLogado.Pais;
            txtEndereco.Text = clienteLogado.Endereco;
            txtCidade.Text = clienteLogado.Cidade;
            txtEmail.Text = clienteLogado.Email;
            txtTelefone.Text = clienteLogado.Telefone;
            cboGenero.SelectedItem = clienteLogado.Genero;
        }

        /// <summary>
        /// Desabilita a edição dos campos na tela.
        /// </summary>
        private void DesabilitarEdicaoCampos()
        {
            comboboxperfil.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            txtEndereco.Enabled = false;
            txtPais.Enabled = false;
            txtCPF.Enabled = false;
            txtIdade.Enabled = false;
            txtNome.Enabled = false;
            cboGenero.Enabled = false;
            Salvar.Enabled = false;
            btnAlterar.Enabled = true;
        }

        /// <summary>
        /// Habilita a edição dos campos na tela.
        /// </summary>
        private void HabilitarEdicaoCampos()
        {
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtCidade.Enabled = true;
            txtEndereco.Enabled = true;
            txtPais.Enabled = true;
            Salvar.Enabled = true;
        }

        /// <summary>
        /// Evento de clique no botão de alteração para habilitar a edição dos campos.
        /// </summary>
        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            HabilitarEdicaoCampos();
        }

        /// <summary>
        /// Evento de clique no botão de salvar para atualizar as informações do cliente.
        /// </summary>
        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                CTR_PessoaCliente ctr_pessoacliente = new CTR_PessoaCliente();
                PessoaCliente pessoa = new PessoaCliente();

                pessoa = Storage.ObterClienteLogado();

                pessoa.Login = txtLogin.Text;
                pessoa.Senha = Convert.ToInt32(txtSenha.Text);
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Pais = txtPais.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.Telefone = txtTelefone.Text;
                _ = pessoa.CPF;
                ctr_pessoacliente.AtualizarCliente(pessoa);
                DesabilitarEdicaoCampos();
                MessageBox.Show("Usuario alterado com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro ao alterar o Usuario");
            }
        }

    }
}
