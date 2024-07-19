using AgenciaViagem.Dal;
using AgenciaViagem.Dao;
using AgenciaViagem.Models;

namespace AgenciaViagem.Controlls
{
    /// <summary>
    /// Controlador para interação com a entidade Pergunta.
    /// </summary>
    internal class CTR_Pergunta
    {
        Pergunta Pergunta;
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor padrão que inicializa a conexão com o banco de dados para a entidade Pergunta.
        /// </summary>
        public CTR_Pergunta()
        {
            conexao = new DAOConexaoSqlServer();
        }

        /// <summary>
        /// Adiciona uma nova pergunta associada a uma categoria específica.
        /// </summary>
        /// <param name="pergunta">Pergunta a ser adicionada.</param>
        /// <param name="categoria">Categoria associada à pergunta.</param>
        public void AdicionarPergunta(Pergunta pergunta)
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            dalpergunta.create(pergunta);
        }

        /// <summary>
        /// Obtém todas as perguntas armazenadas no banco de dados.
        /// </summary>
        /// <returns>Lista de todas as perguntas.</returns>
        public List<Pergunta> ObterPerguntasDoBanco()
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            return dalpergunta.ObterPerguntasDoBanco();
        }

        /// <summary>
        /// Obtém todas as perguntas para exibir em um grid.
        /// </summary>
        /// <returns>Lista de perguntas para exibição no grid.</returns>
        public List<Pergunta> ObterTodasPerguntasGrid()
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            return dalpergunta.Read();
        }

        /// <summary>
        /// Obtém uma pergunta específica pelo seu identificador.
        /// </summary>
        /// <param name="pergunta">Pergunta a ser buscada.</param>
        /// <returns>Pergunta encontrada.</returns>
        public Pergunta ObterPergunta(Pergunta pergunta)
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            return dalpergunta.ObterPorID(pergunta);
        }

        /// <summary>
        /// Atualiza uma pergunta existente no banco de dados.
        /// </summary>
        /// <param name="pergunta">Pergunta a ser atualizada.</param>
        public void AtualizarPergunta(Pergunta pergunta)
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            dalpergunta.update(pergunta);
        }

        /// <summary>
        /// Deleta uma pergunta do banco de dados.
        /// </summary>
        /// <param name="pergunta">Pergunta a ser removida.</param>
        public void DeletarPergunta(Pergunta pergunta)
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            dalpergunta.delete(pergunta);
        }
    }
}
