using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using AgenciaViagem.Views;
using System.Data;
using System.Data.SqlClient;


namespace AgenciaViagem.Controllers
{
    internal class CTR_Categoria
    {
        private DAOConexaoSqlServer conexao;

        public CTR_Categoria()
        {
            conexao = new DAOConexaoSqlServer();
        }

        public void AdicionarCategoria(Categoria categoria)
        {
            try
            {
                DAOCategoria dalcategoria = new DAOCategoria(conexao);
                dalcategoria.create(categoria);
                MessageBox.Show("Categoria adicionada com sucesso"); //Adaptação técnica
            }
            catch (Exception ex)
            {
               MessageBox.Show("Erro ao adicionar categoria: " + ex.Message); //Adaptação técnica
            }
        }
        public DataTable ObterTodasCategorias()
        {
            DAOCategoria daoCategoria = new DAOCategoria(conexao);
            return daoCategoria.Read();
        }

        public Categoria ObterCategoriaPorID(Categoria categoria)
        {
            DAOCategoria daoCategoria = new DAOCategoria(new DAOConexaoSqlServer());
            return daoCategoria.ObterPorID(categoria);
        }
        public void AtualizarCategoria(Categoria categoria)
        {
            try
            {
                DAOCategoria dalcategoria = new DAOCategoria(conexao);
                dalcategoria.update(categoria);
            }
            catch (Exception ex)
            {
            }
        }
        public void DeletarCategoria(Categoria categoria)
        {
            try
            {
                DAOCategoria dalcategoria = new DAOCategoria(conexao);
                dalcategoria.delete(categoria);
            }
            catch (Exception ex)
            {
            }
        }
    }
}