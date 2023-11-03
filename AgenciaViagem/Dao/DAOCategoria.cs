using AgenciaViagem.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagem.Dal
{
    internal class DAOCategoria
    {
        private DAOConexaoSqlServer conexao;
        public DAOCategoria(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        public void create(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();

                string verificaCategoriaQuery = "SELECT COUNT(*) FROM CATEGORIA WHERE DS = @DS";

               using (SqlCommand verificaCategoriaCommand = new SqlCommand(verificaCategoriaQuery, conexao.GetConnection()))
               {
                   verificaCategoriaCommand.Parameters.AddWithValue("@DS", categoria.categoria);
                   int count = (int)verificaCategoriaCommand.ExecuteScalar();
               
                   if (count > 0)
                   {
                       throw new Exception("Categoria já existe.");
                   }
               }

                string sqlQuery = "INSERT INTO CATEGORIA (DS) VALUES (@DS)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@DS", categoria.categoria);
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
        public DataTable Read()
        {
            DataTable dataTable = new DataTable();

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT ID, DS FROM CATEGORIA ORDER BY ID";

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
                throw new Exception("Erro ao ler categorias: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }

            return dataTable;
        }
        public Categoria ObterPorID(Categoria categoria)
        {
           
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT ID, DS FROM CATEGORIA WHERE ID = @CategoriaID";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@CategoriaID", categoria.idCategoria);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoria.idCategoria = Convert.ToInt32(reader["ID"]);
                            categoria.categoria = reader["DS"].ToString();
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
        public void update(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQueryUpdate = "UPDATE CATEGORIA SET DS = @DS WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(sqlQueryUpdate, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@DS", categoria.categoria);
                    command.Parameters.AddWithValue("@ID", categoria.idCategoria);
                    command.ExecuteNonQuery();
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
        public void delete(Categoria categoria)
        {
            try
            {
                conexao.AbrirConexao();
                        string sqlQueryDelete = "DELETE CATEGORIA WHERE ID = @ID";

                        using (SqlCommand deleteCommand = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                        {
                            deleteCommand.Parameters.AddWithValue("@ID", categoria.idCategoria);
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

