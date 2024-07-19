using AgenciaViagem.Controlls;
using AgenciaViagem.Models;

namespace AgenciaViagem.Views
{
    /// <summary>
    /// Classe parcial responsável pela interface do questionário.
    /// </summary>
    public partial class fQuestionario : Form
    {
        private List<Pergunta> perguntas;
        private int indicePerguntaAtual;
        public ObjetivoOpcao objetivoopcao;

        public fQuestionario()
        {
            InitializeComponent();
            CTR_Pergunta ctrPergunta = new CTR_Pergunta();
            objetivoopcao = new ObjetivoOpcao();
            CTR_ObjetivoOpcao ctr_objetivoopcao = new CTR_ObjetivoOpcao();
            perguntas = ctrPergunta.ObterPerguntasDoBanco();
            indicePerguntaAtual = 0;
            AjustarVisibilidadeSalvar();
            ExibirPergunta();
            ExibirInformacoes();
        }

        /// <summary>
        /// Exibe a pergunta atual na interface.
        /// </summary>
        private void ExibirPergunta()
        {
            if (indicePerguntaAtual < perguntas.Count)
            {
                labelPergunta.Text = perguntas[indicePerguntaAtual].pergunta;
            }
            else
            {
                MessageBox.Show("Não há mais perguntas.");
            }
        }

        /// <summary>
        /// Exibe informações na interface com base nos objetivos e opções disponíveis.
        /// </summary>
        private void ExibirInformacoes()
        {
            Objetivo objetivo = new Objetivo();
            CTR_Objetivo ctr_objetivo = new CTR_Objetivo();
            CTR_ObjetivoOpcao ctr_objetivoopcao = new CTR_ObjetivoOpcao();

            List<Objetivo> objetivos = ctr_objetivo.ObterTodosObjetivos();

            if (objetivos != null && objetivos.Count > 0)
            {
                comboboxpergunta.DataSource = objetivos;
                comboboxpergunta.DisplayMember = "objetivo";
                comboboxpergunta.ValueMember = "idObjetivo";
            }
            else
            {
                MessageBox.Show("Não há perguntas para exibir.");
                return;
            }

            comboboxpergunta.SelectedIndexChanged += (sender, args) =>
            {
                if (comboboxpergunta.SelectedItem != null)
                {
                    string idPerguntaString = comboboxpergunta.SelectedValue.ToString();
                    int.TryParse(idPerguntaString, out int idObjetivo);

                    objetivo.idObjetivo = idObjetivo;
                    List<ObjetivoOpcao> opcoes = ctr_objetivoopcao.ObterObjetivoOpcao(objetivo);

                    if (opcoes != null && opcoes.Count > 0)
                    {
                        comboboxopcao.DataSource = opcoes;
                        comboboxopcao.DisplayMember = "objetivoopcao";
                        comboboxopcao.ValueMember = "idObjetivoOpcao";
                    }
                    else
                    {
                        MessageBox.Show("Não há respostas para exibir para esta pergunta.");
                    }
                }
            };
        }
        /// <summary>
        /// Método acionado ao clicar no botão 'Anterior'.
        /// Navega para a pergunta anterior no questionário.
        /// </summary>
        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (indicePerguntaAtual > 0)
            {
                indicePerguntaAtual--;
                ExibirPergunta();
            }
            else
            {
                MessageBox.Show("Esta é a primeira pergunta.");
            }
        }

        /// <summary>
        /// Método acionado ao clicar no botão 'Próximo'.
        /// Verifica o valor do controle trackBar e realiza ações com base nesse valor.
        /// Salva informações relacionadas à resposta da pergunta atual e avança para a próxima pergunta.
        /// </summary>
        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            string respostatrackbar;
            int valorTrackBar = trackBar.Value;

            switch (valorTrackBar)
            {
                case 1:
                    respostatrackbar = "Muito Ruim";
                    break;
                case 2:
                    respostatrackbar = "Ruim";
                    break;
                case 3:
                    respostatrackbar = "Gosto";
                    break;
                case 4:
                    respostatrackbar = "Gosto Muito";
                    break;
                default:
                    respostatrackbar = "Opção Inválida";
                    break;
            }

            ObjetivoOpcao objetivoOpcao = new ObjetivoOpcao();
            objetivoOpcao.objetivoopcao = comboboxopcao.Text;

            CTR_ObjetivoOpcao ctr_objetivoopcao = new CTR_ObjetivoOpcao();
            objetivoOpcao = ctr_objetivoopcao.ObterObjetivoId(objetivoOpcao);

            PessoaCliente usuario = new PessoaCliente();
            usuario = Storage.ObterClienteLogado();

            Resposta resposta = new Resposta();
            resposta.resposta = respostatrackbar;



            Pergunta pergunta = perguntas[indicePerguntaAtual];

            Storage.AdicionarResposta(pergunta, resposta);

            CTR_Resposta ctr_resposta = new CTR_Resposta();
            ctr_resposta.SalvarRespostaNoBanco(objetivoOpcao, usuario, pergunta, resposta);

            indicePerguntaAtual++;
            ExibirPergunta();
        }

        /// <summary>
        /// Método acionado ao clicar no botão 'Salvar'. Salva o objetivo que será enviado para a Storage
        /// </summary>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string objetivo = comboboxpergunta.Text;
                string resposta = comboboxopcao.Text;

                ObjetivoOpcao objetivoOpcao = new ObjetivoOpcao();
                objetivoOpcao.objetivo.objetivo = objetivo;
                objetivoOpcao.objetivoopcao = resposta;

                Storage.AdicionarObjetivo(objetivoOpcao);

                MessageBox.Show("Objetivo Salvo!");
            }
            catch
            {
                MessageBox.Show("Não foi possivel adicionar o objetivo");
            }
            AjustarVisibilidadeQuestionario();
        }

        /// <summary>
        /// Ajusta a visibilidade dos elementos na interface ao iniciar. Esse metodo oculta o questionario, fazendo
        /// com que o usuario responda primeiro objetivo.
        /// </summary>
        private void AjustarVisibilidadeSalvar()
        {
            btnProximo.Visible = false;
            trackBar.Visible = false;
            labelPergunta.Visible = false;
            btnAnterior.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }
        /// <summary>
        /// Ajusta a visibilidade dos elementos na interface. Libera o questionario e deixa apenas visivel os campos de Objetivo.
        /// </summary>
        private void AjustarVisibilidadeQuestionario()
        {
            btnProximo.Visible = true;
            trackBar.Visible = true;
            labelPergunta.Visible = true;
            btnAnterior.Visible = true;
            btnSalvar.Enabled = false;
            comboboxopcao.Enabled = false;
            comboboxpergunta.Enabled = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

    }
}