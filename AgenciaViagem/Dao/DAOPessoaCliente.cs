using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System.Data.SqlClient;
using static AgenciaViagem.Models.Enum;

namespace AgenciaViagem.Dao
{
    /// <summary>
    /// Classe responsável por realizar operações CRUD relacionadas à entidade PessoaCliente no banco de dados.
    /// </summary>
    internal class DAOPessoaCliente
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor que inicializa a conexão para acesso ao banco de dados.
        /// </summary>
        /// <param name="conexao">Objeto de conexão com o banco de dados.</param>
        public DAOPessoaCliente(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        /// <summary>
        /// Valida o login de um cliente no sistema.
        /// </summary>
        /// <param name="pessoaCliente">Objeto do tipo PessoaCliente contendo as credenciais de login (Login e Senha).</param>
        /// <returns>Objeto Sessao indicando se o login foi validado com sucesso e os dados do cliente logado.</returns>
        public Sessao ValidarLogin(PessoaCliente pessoaCliente)
        {
            try
            {
                conexao.AbrirConexao();
                string comandosql = "SELECT COUNT(*) as ValidarUsuario, perfil,nome, data_nascimento, genero,  CPF_CNPJ, telefone, endereco, cidade, pais, email  FROM PESSOA_CLIENTE WHERE login = @login AND senha = @senha GROUP BY perfil,nome, data_nascimento, genero, CPF_CNPJ, telefone, endereco, cidade, pais, email ";

                using (SqlCommand command = new SqlCommand(comandosql, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@login", pessoaCliente.Login);
                    command.Parameters.AddWithValue("@senha", pessoaCliente.Senha);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Sessao sessao = new Sessao();

                        if (reader.Read())
                        {
                            sessao.ValidarUsuario = Convert.ToBoolean(reader["ValidarUsuario"]);

                            if (sessao.ValidarUsuario)
                            {
                                PessoaClientePerfil perfil = (PessoaClientePerfil)System.Enum.Parse(typeof(PessoaClientePerfil), reader["perfil"].ToString());
                                string nome = reader["nome"].ToString();
                                DateTime idade = Convert.ToDateTime(reader["data_nascimento"].ToString());
                                string genero = reader["genero"].ToString();
                                int cpf = Convert.ToInt32(reader["CPF_CNPJ"]);
                                string telefone = reader["telefone"].ToString();
                                string endereco = reader["endereco"].ToString();
                                string cidade = reader["cidade"].ToString();
                                string pais = reader["pais"].ToString();
                                string email = reader["email"].ToString();

                                pessoaCliente.Perfil = perfil;
                                pessoaCliente.Nome = nome;
                                pessoaCliente.DataNascimento = idade;
                                pessoaCliente.Genero = genero;
                                pessoaCliente.CPF = cpf;
                                pessoaCliente.Telefone = telefone;
                                pessoaCliente.Endereco = endereco;
                                pessoaCliente.Cidade = cidade;
                                pessoaCliente.Pais = pais;
                                pessoaCliente.Email = email;

                                Storage.AdicionarClienteLogado(pessoaCliente);
                            }
                        }

                        return sessao;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar o login: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        /// <summary>
        /// Adiciona um novo cliente ao banco de dados.
        /// </summary>
        /// <param name="cliente">Objeto do tipo PessoaCliente a ser adicionado.</param>
        public void create(PessoaCliente cliente)

        {
            try
            {
                conexao.AbrirConexao();


                string verificaClienteQuery = "SELECT COUNT(*) FROM PESSOA_CLIENTE WHERE login = @login";

                using (SqlCommand verificaClienteCommand = new SqlCommand(verificaClienteQuery, conexao.GetConnection()))
                {
                    verificaClienteCommand.Parameters.AddWithValue("@login", cliente.Login);
                    int count = (int)verificaClienteCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Esse Usuario já existe.");
                        return;
                    }
                }
                string sqlQuery = "INSERT INTO PESSOA_CLIENTE (login, senha, nome, data_nascimento, genero,  CPF_CNPJ, telefone, endereco, cidade, pais, email, perfil) VALUES (@login, @senha, @nome, @data_nascimento, @genero, @CPF_CNPJ, @telefone, @endereco, @cidade, @pais, @email, @perfil)";


                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@perfil", cliente.Perfil);
                    command.Parameters.AddWithValue("@nome", cliente.Nome);
                    command.Parameters.AddWithValue("@data_nascimento", cliente.DataNascimento);
                    command.Parameters.AddWithValue("@genero", cliente.Genero);
                    command.Parameters.AddWithValue("@CPF_CNPJ", cliente.CPF);
                    command.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    command.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    command.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    command.Parameters.AddWithValue("@pais", cliente.Pais);
                    command.Parameters.AddWithValue("@email", cliente.Email);
                    command.Parameters.AddWithValue("@login", cliente.Login);
                    command.Parameters.AddWithValue("@senha", cliente.Senha);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar cliente: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        /// <summary>
        /// Atualiza os dados de um cliente no banco de dados.
        /// </summary>
        /// <param name="cliente">Objeto do tipo PessoaCliente contendo os novos dados do cliente a serem atualizados.</param>
        public void update(PessoaCliente cliente)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQueryDelete = "UPDATE PESSOA_CLIENTE SET login = @login, telefone = @telefone, endereco = @endereco, cidade = @cidade, pais = @pais, email = @email, senha = @senha WHERE CPF_CNPJ = @CPF_CNPJ";

                using (SqlCommand command = new SqlCommand(sqlQueryDelete, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@telefone", cliente.Telefone);
                    command.Parameters.AddWithValue("@endereco", cliente.Endereco);
                    command.Parameters.AddWithValue("@cidade", cliente.Cidade);
                    command.Parameters.AddWithValue("@pais", cliente.Pais);
                    command.Parameters.AddWithValue("@email", cliente.Email);
                    command.Parameters.AddWithValue("@login", cliente.Login);
                    command.Parameters.AddWithValue("@senha", cliente.Senha);
                    command.Parameters.AddWithValue("@CPF_CNPJ", cliente.CPF);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Atualizar o cliente: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

    }
}