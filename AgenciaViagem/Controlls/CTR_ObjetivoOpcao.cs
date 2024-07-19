using AgenciaViagem.Dal;
using AgenciaViagem.Dao;
using AgenciaViagem.Models;

namespace AgenciaViagem.Controlls
{
    /// <summary>
    /// Controlador para interação com a entidade ObjetivoOpcao.
    /// </summary>
    internal class CTR_ObjetivoOpcao
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor padrão que inicializa a conexão com o banco de dados para a entidade ObjetivoOpcao.
        /// </summary>
        public CTR_ObjetivoOpcao()
        {
            conexao = new DAOConexaoSqlServer();
        }

        /// <summary>
        /// Adiciona uma nova opção de objetivo relacionada a um objetivo específico.
        /// </summary>
        /// <param name="objetivoopcao">Opção de objetivo a ser adicionada.</param>
        /// <param name="objetivo">Objetivo relacionado à opção.</param>
        public void AdicionarObjetivoOpcao(ObjetivoOpcao objetivoopcao)
        {
            DAOObjetivoOpcao daoobjetivoopcao = new DAOObjetivoOpcao(conexao);
            daoobjetivoopcao.create(objetivoopcao);
        }

        /// <summary>
        /// Obtém todas as opções de objetivo existentes.
        /// </summary>
        /// <returns>Lista de todas as opções de objetivo.</returns>
        public List<ObjetivoOpcao> ObterObjetivoOpcao(Objetivo objetivo)
        {
            DAOObjetivoOpcao daoobjetivoopcao = new DAOObjetivoOpcao(conexao);
            return daoobjetivoopcao.Read(objetivo);
        }

        /// <summary>
        /// Obtém uma opção de objetivo pelo seu identificador.
        /// </summary>
        /// <param name="objetivo">Objetivo a ser buscado.</param>
        /// <returns>Opção de objetivo encontrada.</returns>
        public ObjetivoOpcao ObterObjetivoId(ObjetivoOpcao objetivo)
        {
            DAOObjetivoOpcao daoobjetivoopcao = new DAOObjetivoOpcao(conexao);
            daoobjetivoopcao.ObterPorID(objetivo);
            return objetivo;
        }
    }
}
