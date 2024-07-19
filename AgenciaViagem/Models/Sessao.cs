namespace AgenciaViagem.Models
{
    /// <summary>
    /// Representa uma sessão de usuário após autenticação.
    /// </summary>
    internal class Sessao
    {
        /// <summary>
        /// Obtém ou define um valor booleano indicando se o usuário foi validado.
        /// </summary>
        public bool ValidarUsuario { get; set; }

        /// <summary>
        /// Obtém ou define informações do cliente associado à sessão.
        /// </summary>
        public PessoaCliente Cliente { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe Sessao.
        /// </summary>
        public Sessao()
        {
            Cliente = new PessoaCliente();            
        }
    }
}
