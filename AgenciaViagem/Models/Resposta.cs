namespace AgenciaViagem.Models
{
    /// <summary>
    /// Representa uma resposta associada a uma pergunta.
    /// Herda propriedades da classe 'Pergunta'.
    /// </summary>
    public class Resposta
    {
        /// <summary>
        /// Obtém ou define o ID da resposta.
        /// </summary>
        public int idResposta { get; set; }

        /// <summary>
        /// Obtém ou define o texto da resposta.
        /// </summary>
        public string resposta { get; set; }

        /// <summary>
        /// Obtém ou define a pergunta relacionada a esta resposta.
        /// </summary>
        public Pergunta pergunta { get; set; }

        /// <summary>
        /// Obtém ou define o cliente associado a esta resposta.
        /// </summary>
        public PessoaCliente cliente { get; set; }

        /// <summary>
        /// Obtém ou define a opção de objetivo associada a esta resposta.
        /// </summary>
        public ObjetivoOpcao objetivoopcao { get; set; }

        public Resposta()
        {
            pergunta = new Pergunta();
            cliente = new PessoaCliente();
            objetivoopcao = new ObjetivoOpcao();
        }
    }
}
