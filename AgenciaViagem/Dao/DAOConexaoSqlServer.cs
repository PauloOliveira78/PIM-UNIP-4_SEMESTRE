using System.Data.SqlClient;

namespace AgenciaViagem.Dal
{
    /// <summary>
    /// Classe responsável por gerenciar a conexão com o banco de dados SQL Server.
    /// </summary>
    public class DAOConexaoSqlServer
    {
        private string connectionString = (@"Data Source=SARAH;User Id=sa;Password=080202;Initial Catalog=DB_PIM;");
        private SqlConnection connection;

        /// <summary>
        /// Construtor da classe que inicializa a conexão com a string de conexão informada.
        /// </summary>
        public DAOConexaoSqlServer()
        {
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Abre a conexão com o banco de dados se estiver fechada.
        /// </summary>
        public void AbrirConexao()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Retorna a instância da conexão.
        /// </summary>
        /// <returns>Objeto SqlConnection representando a conexão com o banco de dados.</returns>
        public SqlConnection GetConnection()
        {
            return connection;
        }

        /// <summary>
        /// Fecha a conexão com o banco de dados se estiver aberta.
        /// </summary>
        public void FecharConexao()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
