using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System.Data.SqlClient;

namespace AgenciaViagem.Dao
{
    /// <summary>
    /// Classe responsável por realizar operações CRUD relacionadas à entidade ObjetivoOpcao no banco de dados.
    /// </summary>
    internal class DAOObjetivoOpcao
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor da classe que recebe a conexão com o banco de dados.
        /// </summary>
        /// <param name="conexao">Instância da classe DAOConexaoSqlServer para conexão com o banco de dados.</param>
        public DAOObjetivoOpcao(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        /// <summary>
        /// Insere uma nova opção de objetivo no banco de dados.
        /// </summary>
        /// <param name="objetivoopcao">Objeto do tipo ObjetivoOpcao a ser inserido.</param>
        /// <param name="objetivo">Objeto do tipo Objetivo associado à opção de objetivo.</param>
        public void create(ObjetivoOpcao objetivoopcao)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "INSERT INTO OBJETIVO_OPCAO (opcao_resposta, id_objetivo) VALUES (@opcao_resposta, @id_objetivo)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@opcao_resposta", objetivoopcao.objetivoopcao);
                    command.Parameters.AddWithValue("@id_objetivo", objetivoopcao.objetivo.idObjetivo);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar Objetivo Opção: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Obtém todas as opções de objetivos do banco de dados, juntamente com os objetivos associados a elas.
        /// </summary>
        /// <returns>Lista de objetos do tipo ObjetivoOpcao, incluindo informações dos objetivos relacionados.</returns>
        public List<ObjetivoOpcao> Read(Objetivo objetivo)
        {
            try
            {
                List<ObjetivoOpcao> objetivoOpcoes = new List<ObjetivoOpcao>();

                conexao.AbrirConexao();

                string sqlQuery = "SELECT OBJETIVO_OPCAO.opcao_resposta AS OPDS FROM OBJETIVO_OPCAO WHERE id_objetivo = @id_objetivo";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_objetivo", objetivo.idObjetivo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ObjetivoOpcao objetivoopcao = new ObjetivoOpcao();
                            objetivoopcao.objetivoopcao = reader["OPDS"].ToString();

                            objetivoOpcoes.Add(objetivoopcao);
                        }
                    }
                }

                return objetivoOpcoes;
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
        /// Obtém uma opção de objetivo por seu ID.
        /// </summary>
        /// <param name="objetivo">Objeto do tipo ObjetivoOpcao com a descrição da opção de objetivo a ser buscada.</param>
        /// <returns>Objeto do tipo ObjetivoOpcao com o ID correspondente à descrição informada.</returns>
        public ObjetivoOpcao ObterPorID(ObjetivoOpcao objetivo)
        {

            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT id_objetivo_opcao FROM OBJETIVO_OPCAO WHERE opcao_resposta = @OBJETIVO";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@OBJETIVO", objetivo.objetivoopcao);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            objetivo.idObjetivoOpcao = Convert.ToInt32(reader["id_objetivo_opcao"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter objetivo por descrição: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }

            return objetivo;
        }
    }
}

