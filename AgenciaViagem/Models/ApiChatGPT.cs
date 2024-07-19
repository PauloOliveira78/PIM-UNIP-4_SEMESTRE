namespace AgenciaViagem.Models
{
    /// <summary>
    /// Classe responsável por interagir com a API do ChatGPT.
    /// </summary>
    internal class ApiChatGPT
    {
        /// <summary>
        /// Chave de API para autenticação.
        /// </summary>
        public readonly string apiKey;

        /// <summary>
        /// Texto a ser enviado para o modelo GPT.
        /// </summary>
        public string Prompt { get; set; }

        /// <summary>
        /// Construtor da classe que recebe a chave de API como parâmetro.
        /// </summary>
        /// <param name="apiKey">Chave de API para autenticação.</param>
        public ApiChatGPT(string apiKey)
        {
            this.apiKey = apiKey;
        }
    }
}
