namespace AgenciaViagem.Models
{
    /// <summary>
    /// Classe responsável por armazenar informações temporárias do sistema.
    /// </summary>
    public static class Storage
    {
        /// <summary>
        /// Lista de respostas armazenadas temporariamente.
        /// </summary>
        private static List<Resposta> _respostas = new List<Resposta>();

        /// <summary>
        /// Informações do cliente armazenadas temporariamente.
        /// </summary>
        private static PessoaCliente _cliente;

        /// <summary>
        /// Lista de opções de objetivos armazenadas temporariamente.
        /// </summary>
        private static List<ObjetivoOpcao> _objetivos = new List<ObjetivoOpcao>();

        /// <summary>
        /// Adiciona um objetivo à lista de objetivos.
        /// </summary>
        /// <param name="objetivo">Objetivo a ser adicionado.</param>
        public static void AdicionarObjetivo(ObjetivoOpcao objetivo)
        {
            _objetivos.Add(objetivo);
        }

        /// <summary>
        /// Retorna a lista de objetivos armazenados.
        /// </summary>
        /// <returns>Lista de ObjetivoOpcao.</returns>
        public static List<ObjetivoOpcao> ObterObjetivos()
        {
            return _objetivos;
        }

        /// <summary>
        /// Adiciona uma resposta relacionada a uma pergunta.
        /// </summary>
        /// <param name="pergunta">Pergunta relacionada à resposta.</param>
        /// <param name="resposta">Resposta a ser adicionada.</param>
        public static void AdicionarResposta(Pergunta pergunta, Resposta resposta)
        {
            Resposta novaresposta = new Resposta();

            novaresposta.pergunta.pergunta = pergunta.pergunta;
            novaresposta.resposta = resposta.resposta;
           

            _respostas.Add(novaresposta);
        }

        /// <summary>
        /// Retorna a lista de respostas armazenadas.
        /// </summary>
        /// <returns>Lista de Resposta.</returns>
        public static List<Resposta> ObterRespostas()
        {
            return _respostas;
        }

        /// <summary>
        /// Armazena as informações do cliente logado.
        /// </summary>
        /// <param name="cliente">Cliente logado.</param>
        public static void AdicionarClienteLogado(PessoaCliente cliente)
        {
            _cliente = cliente;
        }

        /// <summary>
        /// Retorna as informações do cliente logado.
        /// </summary>
        /// <returns>Cliente logado.</returns>
        public static PessoaCliente ObterClienteLogado()
        {
            return _cliente;
        }
    }
}
