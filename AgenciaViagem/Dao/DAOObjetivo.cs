using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System.Data.SqlClient;

namespace AgenciaViagem.Dao
{
    /// <summary>
    /// Classe responsável por realizar operações CRUD relacionadas à entidade Objetivo no banco de dados.
    /// </summary>
    internal class DAOObjetivo
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor da classe que recebe a conexão com o banco de dados.
        /// </summary>
        /// <param name="conexao">Instância da classe DAOConexaoSqlServer para conexão com o banco de dados.</param>
        public DAOObjetivo(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        /// <summary>
        /// Insere um novo objetivo no banco de dados.
        /// </summary>
        /// <param name="objetivo">Objeto do tipo Objetivo a ser inserido.</param>
        public void create(Objetivo objetivo)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "INSERT INTO OBJETIVO_PERGUNTA (descricao) VALUES (@descricao)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@descricao", objetivo.objetivo);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar objetivo: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Obtém todos os objetivos do banco de dados.
        /// </summary>
        /// <returns>Lista de objetos do tipo Objetivo.</returns>
        public List<Objetivo> Read()
        {
            List<Objetivo> objetivos = new List<Objetivo>();

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT id_objetivo AS OID, descricao AS ODS FROM OBJETIVO_PERGUNTA";
                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Objetivo objetivo = new Objetivo();
                            objetivo.idObjetivo = Convert.ToInt32(reader["OID"]);
                            objetivo.objetivo = reader["ODS"].ToString();
                            objetivos.Add(objetivo);
                        }
                    }
                }

                return objetivos;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter objetivo do banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        /// <summary>
        /// Deleta uma objetivo do banco de dados por meio do seu ID.
        /// </summary>
        /// <param name="objetivo">Objeto Objetivo a ser deletado.</param>
        public void delete(Objetivo objetivo)
        {
            try
            {
                conexao.AbrirConexao();
                string sqlQueryDelete = "DELETE FROM OBJETIVO_PERGUNTA WHERE id_objetivo = @id_objetivo";

                using (SqlCommand deleteCommand = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    deleteCommand.Parameters.AddWithValue("@id_objetivo", objetivo.idObjetivo);
                    deleteCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar objetivo: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}

