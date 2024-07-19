using AgenciaViagem.Models;
using System.Data.SqlClient;

namespace AgenciaViagem.Dal
{
    /// <summary>
    /// Classe responsável por realizar operações CRUD relacionadas à entidade Categoria no banco de dados.
    /// </summary>
    internal class DAOCategoria
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor que inicializa a conexão para acesso ao banco de dados.
        /// </summary>
        /// <param name="conexao">Objeto de conexão com o banco de dados.</param>
        public DAOCategoria(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        /// <summary>
        /// Cria uma nova categoria no banco de dados.
        /// </summary>
        /// <param name="categoria">Objeto Categoria a ser criado.</param>
        public void create(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();

                string verificaCategoriaQuery = "SELECT COUNT(*) FROM CATEGORIA WHERE descricao = @descricao";

                using (SqlCommand verificaCategoriaCommand = new SqlCommand(verificaCategoriaQuery, conexao.GetConnection()))
                {
                    verificaCategoriaCommand.Parameters.AddWithValue("@descricao", categoria.categoria);
                    int count = (int)verificaCategoriaCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        throw new Exception("Categoria já existe.");
                    }
                }

                string sqlQuery = "INSERT INTO CATEGORIA (descricao) VALUES (@descricao)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@descricao", categoria.categoria);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar categoria: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Retorna todas as categorias existentes no banco de dados.
        /// </summary>
        /// <returns>Lista de objetos Categoria.</returns>
        public List<Categoria> Read()
        {
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT id_categoria, descricao FROM CATEGORIA";
                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = new Categoria();
                            categoria.idCategoria = Convert.ToInt32(reader["id_categoria"]);
                            categoria.categoria = reader["descricao"].ToString();
                            categorias.Add(categoria);
                        }
                    }
                }

                return categorias;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter categoria do banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Obtém uma categoria do banco de dados por meio do seu ID.
        /// </summary>
        /// <param name="categoria">Objeto Categoria contendo o ID a ser obtido.</param>
        /// <returns>Objeto Categoria com os dados encontrados no banco de dados.</returns>
        public Categoria ObterPorID(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT id_categoria, descricao FROM CATEGORIA WHERE id_categoria = @id_categoria";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_categoria", categoria.idCategoria);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoria.idCategoria = Convert.ToInt32(reader["id_categoria"]);
                            categoria.categoria = reader["descricao"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter categoria por ID: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }

            return categoria;
        }

        /// <summary>
        /// Atualiza uma categoria existente no banco de dados.
        /// </summary>
        /// <param name="categoria">Objeto Categoria com os dados atualizados.</param>
        public void update(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQueryUpdate = "UPDATE CATEGORIA SET descricao = @descricao WHERE id_categoria = @id_categoria";

                using (SqlCommand command = new SqlCommand(sqlQueryUpdate, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@descricao", categoria.categoria);
                    command.Parameters.AddWithValue("@id_categoria", categoria.idCategoria);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar categoria: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Deleta uma categoria do banco de dados por meio do seu ID.
        /// </summary>
        /// <param name="categoria">Objeto Categoria a ser deletado.</param>
        public void delete(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();
                string sqlQueryDelete = "DELETE FROM CATEGORIA WHERE id_categoria = @id_categoria";

                using (SqlCommand deleteCommand = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    deleteCommand.Parameters.AddWithValue("@id_categoria", categoria.idCategoria);
                    deleteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar categoria: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}