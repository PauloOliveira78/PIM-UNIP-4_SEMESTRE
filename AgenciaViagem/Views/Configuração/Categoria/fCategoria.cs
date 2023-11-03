using AgenciaViagem.Controllers;
using AgenciaViagem.Controlls;
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

namespace AgenciaViagem.Views
{
    public partial class fCategoria : Form
    {
        private EstadoTela EstadoTelaCategoria;
        private Categoria categoriaEmEdicao;
        public fCategoria(EstadoTela modo, Categoria categoria)
        {
            InitializeComponent();
            EstadoTelaCategoria = modo;

            if (EstadoTelaCategoria == EstadoTela.Editar && categoria != null)
            {
                categoriaEmEdicao = categoria;
                txtCategoria.Text = categoriaEmEdicao.categoria;
                CadastrarCategoria.Visible = false;
                ConsultaCategoria.Visible = false;
            }
            else if (EstadoTelaCategoria == EstadoTela.Criar && categoria != null)
            {
                categoriaEmEdicao = new Categoria();
                SalvarAlteração.Visible = false;

            }
        }
        private void CadastrarCategoria_Click(object sender, EventArgs e)
        {
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            Categoria categoria = new Categoria();
            categoria.categoria = txtCategoria.Text;
            CTR_Categoria.AdicionarCategoria(categoria);
            txtCategoria.Clear();
        }

        private void ConsultaCategoria_Click(object sender, EventArgs e)
        {
            fCategoriaConsultar fCategoriaConsultar = new fCategoriaConsultar();
            this.Hide();
            fCategoriaConsultar.ShowDialog();
            this.Show();
        }

        public event EventHandler AlteracoesSalvas;
        private void SalvarAlteração_Click(object sender, EventArgs e)
        {
            if (categoriaEmEdicao == null)
            {
                MessageBox.Show("Categoria em edição inválida.");
                return;
            }
            categoriaEmEdicao.categoria = txtCategoria.Text;
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            CTR_Categoria.AtualizarCategoria(categoriaEmEdicao);
            MessageBox.Show("Alterações salvas com sucesso.");
        }

        private void Fechar_Click(object sender, EventArgs e)
        {

            if (EstadoTelaCategoria == EstadoTela.Editar)
            {
                AlteracoesSalvas?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else if (EstadoTelaCategoria == EstadoTela.Criar)
            {

            }
        }
    }
}
