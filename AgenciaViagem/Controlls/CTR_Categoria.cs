using AgenciaViagem.Dal;
using AgenciaViagem.Models;

namespace AgenciaViagem.Controllers
{
    /// <summary>
    /// Controlador para interação com a entidade Categoria.
    /// </summary>
    internal class CTR_Categoria
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor padrão que inicializa a conexão com o banco de dados para a entidade Categoria.
        /// </summary>
        public CTR_Categoria()
        {
            conexao = new DAOConexaoSqlServer();
        }

        /// <summary>
        /// Adiciona uma nova categoria.
        /// </summary>
        /// <param name="categoria">Categoria a ser adicionada.</param>
        public void AdicionarCategoria(Categoria categoria)
        {
            DAOCategoria dalcategoria = new DAOCategoria(conexao);
            dalcategoria.create(categoria);
        }

        /// <summary>
        /// Obtém todas as categorias existentes.
        /// </summary>
        /// <returns>Lista de todas as categorias.</returns>
        public List<Categoria> ObterTodasCategorias()
        {
            DAOCategoria daoCategoria = new DAOCategoria(conexao);
            return daoCategoria.Read();
        }

        /// <summary>
        /// Obtém uma categoria pelo seu ID.
        /// </summary>
        /// <param name="categoria">Categoria com o ID a ser obtido.</param>
        /// <returns>Categoria correspondente ao ID fornecido.</returns>
        public Categoria ObterCategoriaPorID(Categoria categoria)
        {
            DAOCategoria daoCategoria = new DAOCategoria(new DAOConexaoSqlServer());
            return daoCategoria.ObterPorID(categoria);
        }

        /// <summary>
        /// Atualiza uma categoria existente.
        /// </summary>
        /// <param name="categoria">Categoria a ser atualizada.</param>
        public void AtualizarCategoria(Categoria categoria)
        {
            DAOCategoria dalcategoria = new DAOCategoria(conexao);
            dalcategoria.update(categoria);
        }

        /// <summary>
        /// Deleta uma categoria existente.
        /// </summary>
        /// <param name="categoria">Categoria a ser deletada.</param>
        public void DeletarCategoria(Categoria categoria)
        {
            DAOCategoria dalcategoria = new DAOCategoria(conexao);
            dalcategoria.delete(categoria);
        }
    }
}
