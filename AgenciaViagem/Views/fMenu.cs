using AgenciaViagem.Models;
using static AgenciaViagem.Models.Enum;

namespace AgenciaViagem.Views
{
    /// <summary>
    /// Classe parcial responsável por gerenciar o formulário de menu da aplicação.
    /// </summary>
    public partial class fMenu : Form
    {

        private PessoaCliente _clienteLogado;

        /// <summary>
        /// Construtor da classe fMenu.
        /// Inicializa os componentes da interface e configura a visibilidade de botões de acordo com o perfil do cliente.
        /// </summary>
        public fMenu()
        {
            InitializeComponent();
            _clienteLogado = Storage.ObterClienteLogado();
            btnConfiguracao.Visible = _clienteLogado.Perfil == PessoaClientePerfil.Admin;
            ajustarPosicaoBtn();
        }

        /// <summary>
        /// Ajusta a posição dos botões na interface, dependendo do perfil do cliente.
        /// </summary>
        private void ajustarPosicaoBtn()
        {
            if (_clienteLogado.Perfil != PessoaClientePerfil.Admin)
            {
                Conta.Location = new Point(Conta.Location.X, btnConfiguracao.Location.Y);
                panel4.Visible = false;
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de configuração.
        /// Abre o formulário de configuração se o perfil for de administrador.
        /// </summary>
        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            fConfiguração fConfiguração = new fConfiguração();
            fConfiguração.ShowDialog();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Encerrar".
        /// Encerra a aplicação.
        /// </summary>
        private void btnEncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Maximizar".
        /// Define o estado da janela como maximizado e altera a visibilidade dos botões de maximizar e restaurar.
        /// </summary>
        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Restaurar".
        /// Define o estado da janela como normal e altera a visibilidade dos botões de restaurar e maximizar.
        /// </summary>
        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Minimizar".
        /// Define o estado da janela como minimizado.
        /// </summary>
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Abre um formulário dentro de um painel específico na interface.
        /// </summary>
        /// <param name="formhija">Formulário a ser aberto no painel.</param>
        private void AbrirFormEmPanel(object formhija)
        {
            if (this.panelCenter.Controls.Count > 0)
                this.panelCenter.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(fh);
            this.panelCenter.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Questionário".
        /// Abre o formulário do questionário dentro do painel central.
        /// </summary>
        private void btnQuestionario_Click_1(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new fQuestionario());
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Destino".
        /// Abre o formulário de sugestão de destino dentro do painel central.
        /// </summary>
        private void btnDestino_Click(object sender, EventArgs e)
        {

            AbrirFormEmPanel(new fSugestChatgpt());
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Conta".
        /// Abre o formulário para consultar dados do cliente dentro do painel central.
        /// </summary>
        private void Conta_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new fConsultarCliente());
        }
    }
}
