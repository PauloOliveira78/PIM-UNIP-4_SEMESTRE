


using System.Data.SqlClient;

namespace AgenciaViagem.Dal
{
    public class DAOConexaoSqlServer
    {
        private string connectionString = @"Data Source=SARAH;Initial Catalog=PIM;User Id=sa;Password=080202;";
        private SqlConnection connection;

        public DAOConexaoSqlServer()
        {
            connection = new SqlConnection(connectionString);
        }

        public void AbrirConexao()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void FecharConexao()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
