using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagem.Dao
{
    internal class DAOPergunta
    {

        private DAOConexaoSqlServer conexao;
        public DAOPergunta(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        public void create(Pergunta pergunta, Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "INSERT INTO PERGUNTA (DS, ID_CATEGORIA) VALUES (@DS, @ID_CATEGORIA)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@DS", pergunta.pergunta);
                    command.Parameters.AddWithValue("@ID_CATEGORIA", categoria.idCategoria);

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
        public DataTable Read()
        {
            DataTable dataTable = new DataTable();

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT C.DS AS DSC, P.DS AS DSP, P.ID AS PID FROM PERGUNTA P INNER JOIN CATEGORIA C ON P.ID_CATEGORIA = C.ID ";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
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

            return dataTable;
        }
        public Pergunta ObterPorID(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT P.DS AS DSP, P.ID AS PID, P.ID_CATEGORIA FROM PERGUNTA P  WHERE P.ID = @PerguntaID";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@PerguntaID", pergunta.idPergunta);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pergunta.idPergunta = Convert.ToInt32(reader["PID"]); 
                            pergunta.pergunta = reader["DSP"].ToString();
                            pergunta.idCategoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
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
        public void update(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQueryDelete = "UPDATE PERGUNTA SET DS = @DS, ID_Categoria = @ID_Categoria WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@DS", pergunta.pergunta);
                    command.Parameters.AddWithValue("@ID", pergunta.idPergunta);
                    command.Parameters.AddWithValue("@ID_Categoria", pergunta.idCategoria);


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
        public void delete(Pergunta pergunta)
        {
            try
            {
                conexao.AbrirConexao();


                string sqlQueryDelete = "DELETE PERGUNTA WHERE ID = @PID";

                using (SqlCommand command = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@PID", pergunta.idPergunta);
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
    }

}
