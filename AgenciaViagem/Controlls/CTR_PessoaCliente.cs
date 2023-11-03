using AgenciaViagem.Controlls;
using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgenciaViagem.Controlls
{
    internal class CTR_PessoaCliente
    {
        private PessoaCliente cliente;
        private DAOConexaoSqlServer conexao;
        public CTR_PessoaCliente()
        {
            cliente = new PessoaCliente();
            conexao = new DAOConexaoSqlServer();
        }
        public void CriarCliente(PessoaCliente cliente)
        {
            try
            {
                conexao.AbrirConexao();

             
                string verificaClienteQuery = "SELECT COUNT(*) FROM CLIENTE WHERE LO = @LO";

                using (SqlCommand verificaClienteCommand = new SqlCommand(verificaClienteQuery, conexao.GetConnection()))
                {
                    verificaClienteCommand.Parameters.AddWithValue("@LO", cliente.Login);
                    int count = (int)verificaClienteCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Esse Usuario já existe.");
                        return;
                    }
                }
                string sqlQuery = "INSERT INTO CLIENTE (NO, NU, GE, CP, TF, ED, CD, PS, EM, LO, SN) VALUES (@NO, @NU, @GE, @CP, @TF, @ED, @CD, @PS, @EM, @LO, @SN)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@NO", cliente.Nome);
                    command.Parameters.AddWithValue("@NU", cliente.Idade);
                    command.Parameters.AddWithValue("@GE", cliente.Genero);
                    command.Parameters.AddWithValue("@CP", cliente.CPF);
                    command.Parameters.AddWithValue("@TF", cliente.Telefone);
                    command.Parameters.AddWithValue("@ED", cliente.Endereco);
                    command.Parameters.AddWithValue("@CD", cliente.Cidade);
                    command.Parameters.AddWithValue("@PS", cliente.Pais);
                    command.Parameters.AddWithValue("@EM", cliente.Email);
                    command.Parameters.AddWithValue("@LO", cliente.Login);
                    command.Parameters.AddWithValue("@SN", cliente.Senha);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar cliente: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    

            
        
        public PessoaCliente LerCliente(PessoaCliente PessoaCliente)
        {
          
            return PessoaCliente;
        }
        public void AtualizarCliente(PessoaCliente cliente)
        {
            // Lógica para atualizar um cliente
        }

        public void DeletarCliente(PessoaCliente cliente)
        {
            // Lógica para deletar um cliente pelo ID
        }
        
    }
}
