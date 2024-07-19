using AgenciaViagem.Dal;
using AgenciaViagem.Dao;
using AgenciaViagem.Models;

namespace AgenciaViagem.Controlls
{
    /// <summary>
    /// Controlador para manipulação de operações relacionadas a clientes.
    /// </summary>
    internal class CTR_PessoaCliente
    {
        private PessoaCliente cliente;
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor padrão que inicializa as propriedades da classe.
        /// </summary>
        public CTR_PessoaCliente()
        {
            cliente = new PessoaCliente();
            conexao = new DAOConexaoSqlServer();
        }

        /// <summary>
        /// Cria um novo cliente.
        /// </summary>
        /// <param name="cliente">Cliente a ser criado.</param>
        public void CriarCliente(PessoaCliente cliente)
        {
            DAOPessoaCliente daocliente = new DAOPessoaCliente(conexao);
            daocliente.create(cliente);
        }

        /// <summary>
        /// Autentica um cliente para login.
        /// </summary>
        /// <param name="pessoaCliente">Cliente a ser autenticado.</param>
        /// <returns>Objeto de sessão com informações de autenticação.</returns>
        public Sessao autenticador(PessoaCliente pessoaCliente)
        {
            DAOPessoaCliente daocliente = new DAOPessoaCliente(conexao);
            Sessao sessao = daocliente.ValidarLogin(pessoaCliente);
            Sessao resultado = new Sessao();
            resultado.ValidarUsuario = sessao.ValidarUsuario;
            return resultado;
        }

        /// <summary>
        /// Obtém informações de um cliente.
        /// </summary>
        /// <param name="PessoaCliente">Cliente a ser obtido.</param>
        /// <returns>Informações do cliente.</returns>
        public PessoaCliente LerCliente(PessoaCliente PessoaCliente)
        {
            return PessoaCliente;
        }

        /// <summary>
        /// Atualiza informações de um cliente existente.
        /// </summary>
        /// <param name="cliente">Cliente a ser atualizado.</param>
        public void AtualizarCliente(PessoaCliente cliente)
        {
            DAOPessoaCliente daocliente = new DAOPessoaCliente(conexao);
            daocliente.update(cliente);
        }

        /// <summary>
        /// Deleta um cliente pelo ID.
        /// </summary>
        /// <param name="cliente">Cliente a ser removido.</param>
        public void DeletarCliente(PessoaCliente cliente)
        {
            // Lógica para deletar um cliente pelo ID
        }
    }
}
