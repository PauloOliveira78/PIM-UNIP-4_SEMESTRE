using AgenciaViagem.Controllers;
using AgenciaViagem.Controlls;
using AgenciaViagem.Dal;
using AgenciaViagem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViagem.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace AgenciaViagem.Views
{
    public partial class fCategoriaConsultar : Form
    {
        public fCategoriaConsultar()
        {
            InitializeComponent();

        }
        public void listaDgv()
        {
            try
            {
                CTR_Categoria CTR_Categoria = new CTR_Categoria();
                DataTable categoriasDataTable = CTR_Categoria.ObterTodasCategorias();
                DGV_CatCo.DataSource = categoriasDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
        }
        private void fCategoriaConsultar_Load(object sender, EventArgs e)
        {
            listaDgv();
        }
        private void DeletarCategoria_Click(object sender, EventArgs e)
        {
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            Categoria categoria = new Categoria();

            if (DGV_CatCo.SelectedRows.Count > 0)
            {
                int categoriaId = (int)DGV_CatCo.SelectedRows[0].Cells["ID"].Value;
                categoria.idCategoria = categoriaId;
                CTR_Categoria.DeletarCategoria(categoria);
                DGV_CatCo.Rows.RemoveAt(DGV_CatCo.SelectedRows[0].Index);
                MessageBox.Show("Registro deletado com sucesso.");
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para deletar.");
            }
        }
        private void AlterarCategoria_Click_1(object sender, EventArgs e)
        {
            if (DGV_CatCo.SelectedRows.Count > 0)
            {
                int categoriaID = (int)DGV_CatCo.SelectedRows[0].Cells["ID"].Value;
                Categoria categoria = new Categoria();
                categoria.idCategoria = categoriaID;
                CTR_Categoria ctrCategoria = new CTR_Categoria();
                categoria = ctrCategoria.ObterCategoriaPorID(categoria);
                EstadoTela modo = EstadoTela.Editar;

                if (categoria != null)
                {
                    fCategoria formularioEdicao = new fCategoria(EstadoTela.Editar, categoria);
                    formularioEdicao.AlteracoesSalvas += (sender, args) => listaDgv();
                    formularioEdicao.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Categoria não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para editar.");
            }
        }
        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


