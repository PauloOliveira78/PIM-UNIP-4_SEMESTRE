using AgenciaViagem.Controlls;
using AgenciaViagem.Models;
using System.Text;

namespace AgenciaViagem.Views
{
    /// <summary>
    /// Classe parcial responsável pela interface de sugestões em um chat.
    /// </summary>
    public partial class fSugestChatgpt : Form
    {
        private CTR_ApiChatGPT ctr_api;

        public fSugestChatgpt()
        {
            InitializeComponent();
            ctr_api = new CTR_ApiChatGPT();
        }
        /// <summary>
        /// Método acionado ao clicar no botão de sugestão.
        /// Obtém respostas e objetivos, cria um prompt e solicita uma sugestão de destino de viagem com base nas informações fornecidas.
        /// Exibe a sugestão na interface gráfica.
        /// </summary>
        private async void btnSugerir_Click(object sender, EventArgs e)
        {
            var respostas = Storage.ObterRespostas();
            var listaDeObjetivos = Storage.ObterObjetivos();

            var prompt = new StringBuilder();

            prompt.AppendLine("De acordo com as perguntas e respostas, respondidas por essa pessoa, defina um destino para essa pessoa viajar. Peço que só de o nome do destino. Tambem pesso que considere na hora de dar a sugestao o  objetivo da pessoa.");

            foreach (Resposta resposta in respostas)
            {
                prompt.AppendLine("Pergunta:" + resposta.pergunta.pergunta + " Resposta:" + resposta.resposta + ",");
            }

            foreach (ObjetivoOpcao objetivoopcao in listaDeObjetivos)
            {
                prompt.AppendLine("Objetivo:" + objetivoopcao.objetivo.objetivo + " Resposta:" + objetivoopcao.objetivoopcao + ",");
            }

            var proptText = prompt.ToString();

            MessageBox.Show(proptText);
            ctr_api.SetPrompt(proptText);
            string sugestao = await ctr_api.GetChatSuggestion();
            label1.Text = sugestao;
        }
    }
}
