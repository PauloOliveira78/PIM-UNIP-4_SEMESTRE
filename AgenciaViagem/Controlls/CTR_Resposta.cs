using AgenciaViagem.Dal;
using AgenciaViagem.Dao;
using AgenciaViagem.Models;

namespace AgenciaViagem.Controlls
{
    /// <summary>
    /// Controlador para manipulação de operações relacionadas a respostas.
    /// </summary>
    internal class CTR_Resposta
    {
        private DAOConexaoSqlServer conexao;

        /// <summary>
        /// Construtor padrão que inicializa as propriedades da classe.
        /// </summary>
        public CTR_Resposta()
        {
            conexao = new DAOConexaoSqlServer();
        }

        /// <summary>
        /// Salva uma resposta no banco de dados.
        /// </summary>
        /// <param name="objetivo">Objetivo relacionado à resposta.</param>
        /// <param name="usuario">Usuário que respondeu a pergunta.</param>
        /// <param name="pergunta">Pergunta à qual a resposta está associada.</param>
        /// <param name="resposta">Resposta a ser salva.</param>
        public void SalvarRespostaNoBanco(ObjetivoOpcao objetivo, PessoaCliente usuario, Pergunta pergunta, Resposta resposta)
        {
            DAOResposta daoresposta = new DAOResposta(conexao);
            daoresposta.InserirResposta(pergunta, resposta, usuario, objetivo);
        }
    }
}
