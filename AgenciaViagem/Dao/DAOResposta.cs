using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System.Data.SqlClient;

namespace AgenciaViagem.Dao
{
    internal class DAOResposta
    {
        /// <summary>
        /// Classe responsável por realizar operações CRUD relacionadas à entidade Resposta no banco de dados.
        /// </summary>
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor da classe que recebe a conexão com o banco de dados.
        /// </summary>
        /// <param name="conexao">Instância da classe DAOConexaoSqlServer para conexão com o banco de dados.</param>
        public DAOResposta(DAOConexaoSqlServer conexao)
        {
            this.conexao = conexao;
        }

        /// <summary>
        /// Insere uma resposta no banco de dados, verificando se já existe uma resposta para a pergunta do cliente.
        /// </summary>
        public async void InserirResposta(Pergunta pergunta, Resposta resposta, PessoaCliente cliente, ObjetivoOpcao objetivo)
        {
            var respostaExistente = await RepostaExistente(pergunta, resposta, cliente, objetivo);

            if (respostaExistente)
            {
                await Atualizar(pergunta, resposta, cliente, objetivo);
            }
            else
            {
                await Inserir(pergunta, resposta, cliente, objetivo);
            }
        }

        /// <summary>
        /// Insere uma nova resposta no banco de dados.
        /// </summary>
        private async Task Inserir(Pergunta pergunta, Resposta resposta, PessoaCliente cliente, ObjetivoOpcao objetivo)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "INSERT INTO RESPOSTA (cpf_cnpj, id_pergunta, resposta, id_objetivo_opcao) VALUES (@cpf_cnpj, @id_pergunta, @resposta, @id_objetivo_opcao)";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_objetivo_opcao", objetivo.idObjetivoOpcao);
                    command.Parameters.AddWithValue("@cpf_cnpj", cliente.CPF);
                    command.Parameters.AddWithValue("@id_pergunta", pergunta.idPergunta);
                    command.Parameters.AddWithValue("@resposta", resposta.resposta);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar resposta no banco: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Atualiza uma resposta existente no banco de dados.
        /// </summary>
        private async Task Atualizar(Pergunta pergunta, Resposta resposta, PessoaCliente cliente, ObjetivoOpcao objetivo)
        {
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "UPDATE RESPOSTA SET resposta = @resposta WHERE id_pergunta = @id_pergunta AND cpf_cnpj = @cpf_cnpj AND @id_objetivo_opcao = ID_OBJETIVOOPCAO";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_objetivo_opcao", objetivo.idObjetivoOpcao);
                    command.Parameters.AddWithValue("@cpf_cnpj", cliente.CPF);
                    command.Parameters.AddWithValue("@id_pergunta", pergunta.idPergunta);
                    command.Parameters.AddWithValue("@resposta", resposta.resposta);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar resposta no banco: " + ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        /// <summary>
        /// Verifica se já existe uma resposta para a pergunta do cliente no banco de dados.
        /// </summary>
        private async Task<bool> RepostaExistente(Pergunta pergunta, Resposta resposta, PessoaCliente cliente, ObjetivoOpcao objetivo)
        {
            var resultado = true;
            try
            {
                conexao.AbrirConexao();

                string sqlQuery = "SELECT 1 FROM RESPOSTA WHERE id_pergunta = @id_pergunta AND cpf_cnpj = @cpf_cnpj AND @id_objetivo_opcao = id_objetivo_opcao";

                using (SqlCommand command = new SqlCommand(sqlQuery, conexao.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id_objetivo_opcao", objetivo.idObjetivoOpcao);
                    command.Parameters.AddWithValue("@cpf_cnpj", cliente.CPF);
                    command.Parameters.AddWithValue("@id_pergunta", pergunta.idPergunta);

                    var reader = await command.ExecuteReaderAsync();

                    if (!reader.Read())
                    {
                        resultado = false;
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
            return resultado;
        }
    }
}