using AgenciaViagem.Dal;
using AgenciaViagem.Dao;
using AgenciaViagem.Models;
using AgenciaViagem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagem.Controlls
{
    internal class CTR_Pergunta
    {
        Pergunta Pergunta;
        private DAOConexaoSqlServer conexao;

        public CTR_Pergunta()
        {
        conexao = new DAOConexaoSqlServer();
        }
        public void AdicionarPergunta(Pergunta pergunta, Categoria categoria)
        {
            try
            {
                DAOPergunta dalpergunta = new DAOPergunta(conexao);
                dalpergunta.create(pergunta, categoria);
                MessageBox.Show("Pergunta adicionada com sucesso"); //Adaptação técnica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar pergunta: " + ex.Message); //Adaptação técnica
            }
        }
        public DataTable ObterTodasPerguntasGrid()
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            return dalpergunta.Read();
        }

        public Pergunta ObterPergunta(Pergunta pergunta)
        {
            DAOPergunta dalpergunta = new DAOPergunta(conexao);
            return dalpergunta.ObterPorID(pergunta);
        }
        public void AtualizarPergunta(Pergunta pergunta)
        {
            try
            {
                DAOPergunta dalpergunta = new DAOPergunta(conexao);
                dalpergunta.update(pergunta);
            }
            catch (Exception ex)
            {
            }
        }
        public void DeletarPergunta(Pergunta pergunta)
        {
            try
            {
                DAOPergunta dalpergunta = new DAOPergunta(conexao);
                dalpergunta.delete(pergunta);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
