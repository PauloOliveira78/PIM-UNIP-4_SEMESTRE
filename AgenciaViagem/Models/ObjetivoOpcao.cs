namespace AgenciaViagem.Models
{
    /// <summary>
    /// Representa uma opção associada a um objetivo.
    /// </summary>
    public class ObjetivoOpcao
    {
        /// <summary>
        /// Obtém ou define o ID da opção do objetivo.
        /// </summary>
        public int idObjetivoOpcao { get; set; }

        /// <summary>
        /// Obtém ou define o texto descritivo da opção do objetivo.
        /// </summary>
        public string? objetivoopcao { get; set; }

        /// <summary>
        /// Obtém ou define o objetivo ao qual esta opção está associada.
        /// </summary>
        public Objetivo objetivo { get; set; }

        public ObjetivoOpcao()
        {
            objetivo = new Objetivo();
        }
    }
}
