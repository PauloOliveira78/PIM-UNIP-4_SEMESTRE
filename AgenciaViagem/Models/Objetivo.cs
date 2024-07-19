namespace AgenciaViagem.Models
{
    /// <summary>
    /// Representa um objetivo associado a uma atividade.
    /// </summary>
    public class Objetivo
    {
        /// <summary>
        /// Obtém ou define o ID do objetivo.
        /// </summary>
        public int idObjetivo { get; set; }

        /// <summary>
        /// Obtém ou define o texto descritivo do objetivo.
        /// </summary>
        public string? objetivo { get; set; }
    }

}
