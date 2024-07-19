using AgenciaViagem.Dal;
using AgenciaViagem.Dao;
using AgenciaViagem.Models;

namespace AgenciaViagem.Controlls
{
    /// <summary>
    /// Controlador para interação com a entidade Objetivo.
    /// </summary>
    internal class CTR_Objetivo
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor padrão que inicializa a conexão com o banco de dados para a entidade Objetivo.
        /// </summary>
        public CTR_Objetivo()
        {
            conexao = new DAOConexaoSqlServer();
        }

        /// <summary>
        /// Adiciona um novo objetivo.
        /// </summary>
        /// <param name="objetivo">Objetivo a ser adicionado.</param>
        public void AdicionarObjetivo(Objetivo objetivo)
        {
            DAOObjetivo daoobjetivo = new DAOObjetivo(conexao);
            daoobjetivo.create(objetivo);
        }

        /// <summary>
        /// Obtém todos os objetivos existentes.
        /// </summary>
        /// <returns>Lista de todos os objetivos.</returns>
        public List<Objetivo> ObterTodosObjetivos()
        {
            DAOObjetivo daoobjetivo = new DAOObjetivo(conexao);
            return daoobjetivo.Read();
        }

        /// <summary>
        /// Deleta uma objetivo existente.
        /// </summary>
        /// <param name="objetivo">Objetivo a ser deletado.</param>
        public void DeletarObjetivo(Objetivo objetivo)
        {
            DAOObjetivo dalobjetivo = new DAOObjetivo(conexao);
            dalobjetivo.delete(objetivo);
        }
    }
}
