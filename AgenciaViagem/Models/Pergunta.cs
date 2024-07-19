namespace AgenciaViagem.Models
{
    /// <summary>
    /// Representa uma pergunta relacionada a uma categoria.
    /// </summary>
    public class Pergunta
    {
        /// <summary>
        /// Identificador único da pergunta.
        /// </summary>
        public int idPergunta { get; set; }

        /// <summary>
        /// Texto da pergunta.
        /// </summary>
        public string? pergunta { get; set; }

        /// <summary>
        /// Obtém ou define a categoria à qual esta pergunta está associada.
        /// </summary>
        public Categoria categoria { get; set; } 
        public Pergunta()
        {
            categoria = new Categoria();
        }

    }


}

