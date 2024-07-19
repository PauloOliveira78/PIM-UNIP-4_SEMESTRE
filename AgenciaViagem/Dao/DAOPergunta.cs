using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System.Data.SqlClient;

namespace AgenciaViagem.Dao
{
    /// <summary>
    /// Classe responsável por realizar operações CRUD relacionadas à entidade Pergunta no banco de dados.
    /// </summary>
    internal class DAOPergunta
    {

        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor da classe que recebe a conexão com o banco de dados.
        /// </summary>
        /// <param name="conexao">Instância da classe DAOConexaoSqlServer para conexão com o banco de dados.</param>
        public DAOPergunta(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        /// <summary>
        /// Cria uma nova pergunta associada a uma categoria no banco de dados.
        /// </summary>
        /// <param name="pergunta">Objeto do tipo Pergunta a ser inserido.</param>
        /// <param name="categoria">Objeto do tipo Categoria associado à pergunta.</param>
        public void create(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "INSERT INTO PERGUNTA (descricao, id_categoria) VALUES (@descricao, @id_categoria)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@descricao", pergunta.pergunta);
                    command.Parameters.AddWithValue("@id_categoria", pergunta.categoria.idCategoria);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar perguntas: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Obtém todas as perguntas do banco de dados juntamente com as categorias associadas a elas.
        /// </summary>
        /// <returns>Lista de objetos do tipo Pergunta, incluindo informações das categorias relacionadas.</returns>
        public List<Pergunta> Read()
        {
            List<Pergunta> perguntas = new List<Pergunta>();

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT C.descricao AS DSC, P.descricao AS DSP, P.id_pergunta AS PID FROM PERGUNTA P INNER JOIN CATEGORIA C ON P.id_categoria = C.id_categoria ";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pergunta Pergunta = new Pergunta();

                            Pergunta.categoria.categoria = reader["DSC"].ToString();
                            Pergunta.pergunta = reader["DSP"].ToString();
                            Pergunta.idPergunta = Convert.ToInt32(reader["PID"]);
                            
                            perguntas.Add(Pergunta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler perguntas: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }

            return perguntas;
        }

        /// <summary>
        /// Obtém uma pergunta específica do banco de dados com base no seu ID.
        /// </summary>
        /// <param name="pergunta">Objeto do tipo Pergunta contendo o ID da pergunta a ser obtida.</param>
        /// <returns>Objeto do tipo Pergunta encontrado no banco de dados.</returns>
        public Pergunta ObterPorID(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT P.descricao AS DSP, P.id_pergunta AS PID, P.id_categoria FROM PERGUNTA P  WHERE P.id_pergunta = @id_pergunta";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_pergunta", pergunta.idPergunta);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pergunta.idPergunta = Convert.ToInt32(reader["PID"]);
                            pergunta.pergunta = reader["DSP"].ToString();
                            pergunta.categoria.idCategoria = Convert.ToInt32(reader["id_categoria"]);
                            return pergunta;
                        }
                    }
                }

                return null;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter pergunta por ID: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Atualiza os dados de uma pergunta no banco de dados.
        /// </summary>
        /// <param name="pergunta

        public void update(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQueryDelete = "UPDATE PERGUNTA SET descricao = @descricao, id_categoria = @id_categoria WHERE id_pergunta = @id_pergunta";

                using (SqlCommand command = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@descricao", pergunta.pergunta);
                    command.Parameters.AddWithValue("@id_pergunta", pergunta.idPergunta);
                    command.Parameters.AddWithValue("@id_categoria", pergunta.categoria.idCategoria);


                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar pergunta: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        /// <summary>
        /// Deleta uma pergunta do banco de dados com base no ID da pergunta.
        /// </summary>
        /// <param name="pergunta">Objeto do tipo Pergunta contendo o ID da pergunta a ser deletada.</param>
        public void delete(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQueryDelete = "DELETE PERGUNTA WHERE id_pergunta = @id_pergunta";

                using (SqlCommand command = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_pergunta", pergunta.idPergunta);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar pergunta: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Obtém todas as perguntas armazenadas no banco de dados.
        /// </summary>
        /// <returns>Lista de objetos do tipo Pergunta presentes no banco de dados.</returns>
        public List<Pergunta> ObterPerguntasDoBanco()
        {
            List<Pergunta> perguntas = new List<Pergunta>();

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT id_pergunta, descricao FROM PERGUNTA";
                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pergunta pergunta = new Pergunta();
                            pergunta.idPergunta = Convert.ToInt32(reader["id_pergunta"]);
                            pergunta.pergunta = reader["descricao"].ToString();
                            perguntas.Add(pergunta);
                        }
                    }
                }

                return perguntas;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter perguntas do banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

    }
}