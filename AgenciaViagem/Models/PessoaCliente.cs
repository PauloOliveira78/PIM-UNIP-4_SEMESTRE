using static AgenciaViagem.Models.Enum;

namespace AgenciaViagem.Models
{
    /// <summary>
    /// Representa informações de um cliente.
    /// </summary>
    public class PessoaCliente
    {
        /// <summary>
        /// Obtém ou define o CPF do cliente.
        /// </summary>
        public int CPF { get; set; }

        /// <summary>
        /// Obtém ou define o nome do cliente.
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Obtém ou define a idade do cliente.
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Obtém ou define o gênero do cliente.
        /// </summary>
        public string? Genero { get; set; }

        /// <summary>
        /// Obtém ou define o telefone do cliente.
        /// </summary>
        public string? Telefone { get; set; }

        /// <summary>
        /// Obtém ou define o endereço do cliente.
        /// </summary>
        public string? Endereco { get; set; }

        /// <summary>
        /// Obtém ou define a cidade do cliente.
        /// </summary>
        public string? Cidade { get; set; }

        /// <summary>
        /// Obtém ou define o país do cliente.
        /// </summary>
        public string? Pais { get; set; }

        /// <summary>
        /// Obtém ou define o e-mail do cliente.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Obtém ou define o login do cliente.
        /// </summary>
        public string? Login { get; set; }

        /// <summary>
        /// Obtém ou define a senha do cliente.
        /// </summary>
        public int Senha { get; set; }

        /// <summary>
        /// Obtém ou define o perfil do cliente.
        /// </summary>
        public PessoaClientePerfil Perfil { get; set; }
    }
}
