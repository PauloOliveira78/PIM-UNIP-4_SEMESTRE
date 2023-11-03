using AgenciaViagem.Controllers;
using AgenciaViagem.Controlls;
using AgenciaViagem.Enums;
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

namespace AgenciaViagem.Views
{
    public partial class fConfiguração : Form
    {
        private Categoria categoriaEmEdicao;
        private Pergunta perguntaEmEdicao;


        private EstadoTela estadoTela = EstadoTela.Criar;

        public fConfiguração()
        {
            InitializeComponent();
            SalvarAlteração.Click += SalvarAlteração_Click;
            CarregarDadosConsultarCategorias();
            CarregarCategorias();
            CarregarDadosConsultarPergunta();
            SalvarAlteração.Visible = false;
            SalvarAlteracao.Visible = false;
        }
        private void CadastrarCategoria_Click_1(object sender, EventArgs e)
        {
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            Categoria categoria = new Categoria();
            categoria.categoria = txtCategoria.Text;
            CTR_Categoria.AdicionarCategoria(categoria);
            txtCategoria.Clear();
            CarregarDadosConsultarCategorias();
            CarregarCategorias();
        }
        private void CarregarCategorias()
        {
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            DataTable categoriasDataTable = CTR_Categoria.ObterTodasCategorias();

            comboBoxCategorias.DisplayMember = "DS";
            comboBoxCategorias.ValueMember = "ID";
            comboBoxCategorias.DataSource = categoriasDataTable;
        }
        private void AlterarCategoria_Click(object sender, EventArgs e)
        {
            if (DGV_CatCo.SelectedRows.Count > 0)
            {
                int categoriaID = (int)DGV_CatCo.SelectedRows[0].Cells["ID"].Value;
                Categoria categoria = new Categoria();
                categoria.idCategoria = categoriaID;
                CTR_Categoria ctrCategoria = new CTR_Categoria();
                categoriaEmEdicao = ctrCategoria.ObterCategoriaPorID(categoria);

                if (categoriaEmEdicao != null)
                {
                    estadoTela = EstadoTela.Editar;
                    Config.SelectedTab = Categoria;
                    txtCategoria.Text = categoriaEmEdicao.categoria;
                    SalvarAlteração.Visible = true;
                    CadastrarCategoria.Visible = false;
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

        private void CarregarDadosConsultarCategorias()
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
        private void CarregarDadosConsultarPergunta()
        {
            try
            {
                CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
                DataTable perguntaDataTable = CTR_Pergunta.ObterTodasPerguntasGrid();
                DGV_PergCo.DataSource = perguntaDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Perguntas: " + ex.Message);
            }
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
                CarregarCategorias();
                CarregarDadosConsultarPergunta();


                MessageBox.Show("Registro deletado com sucesso.");
            }
            else

            {
                MessageBox.Show("Nenhum registro selecionado para deletar.");
            }
        }
        private void SalvarAlteração_Click(object sender, EventArgs e)
        {
            if (estadoTela == EstadoTela.Editar && categoriaEmEdicao != null)
            {
                categoriaEmEdicao.categoria = txtCategoria.Text;
                CTR_Categoria ctrCategoria = new CTR_Categoria();
                ctrCategoria.AtualizarCategoria(categoriaEmEdicao);
                MessageBox.Show("Alterações salvas com sucesso.");
                estadoTela = EstadoTela.Criar;
                SalvarAlteração.Visible = false;
                CadastrarCategoria.Visible = true;
                txtCategoria.Clear();
                CarregarDadosConsultarCategorias();
                CarregarCategorias();
            }
            else
            {
                MessageBox.Show("Nenhuma categoria em edição.");
            }
        }

        private void CadastrarPergunta_Click(object sender, EventArgs e)
        {
            string idCategoriaString = comboBoxCategorias.SelectedValue.ToString();
            if (int.TryParse(idCategoriaString, out int idCategoria))
            {
                Categoria categoria = new Categoria();
                categoria.idCategoria = idCategoria;
                Pergunta pergunta = new Pergunta();
                pergunta.pergunta = txtPergunta.Text;
                CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
                CTR_Pergunta.AdicionarPergunta(pergunta, categoria);
                txtPergunta.Clear();
                CarregarDadosConsultarPergunta();
            }
            else
            {
                MessageBox.Show("ID de Categoria inválido.");
            }

        }

        private void DeletarPergunta_Click(object sender, EventArgs e)
        {
            CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
            Pergunta pergunta = new Pergunta();

            if (DGV_CatCo.SelectedRows.Count > 0)
            {
                int perguntaId = (int)DGV_PergCo.SelectedRows[0].Cells["PID"].Value;
                pergunta.idPergunta = perguntaId;
                CTR_Pergunta.DeletarPergunta(pergunta);
                DGV_PergCo.Rows.RemoveAt(DGV_PergCo.SelectedRows[0].Index);
                CarregarDadosConsultarPergunta();


                MessageBox.Show("Registro deletado com sucesso.");
            }
            else

            {
                MessageBox.Show("Nenhum registro selecionado para deletar.");
            }
        }

        private void AlterarPergunta_Click(object sender, EventArgs e)
        {

            if (DGV_PergCo.SelectedRows.Count > 0)
            {
                int perguntaID = (int)DGV_PergCo.SelectedRows[0].Cells["PID"].Value;
                Pergunta pergunta = new Pergunta();
                pergunta.idPergunta = perguntaID;
                CTR_Pergunta ctrPergunta = new CTR_Pergunta();
                perguntaEmEdicao = ctrPergunta.ObterPergunta(pergunta);

                if (perguntaEmEdicao != null)
                {
                    estadoTela = EstadoTela.Editar;
                    Config.SelectedTab = Pergunta;
                    txtPergunta.Text = perguntaEmEdicao.pergunta;
                    CarregarCategorias();
                    comboBoxCategorias.SelectedValue = perguntaEmEdicao.idCategoria;
                    SalvarAlteracao.Visible = true;
                    CadastrarPergunta.Visible = false;
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

        private void SalvarAlteracao_Click(object sender, EventArgs e)
        {
            if (estadoTela == EstadoTela.Editar && perguntaEmEdicao != null)
            {
                perguntaEmEdicao.pergunta = txtPergunta.Text;

                if (comboBoxCategorias.SelectedValue != null && int.TryParse(comboBoxCategorias.SelectedValue.ToString(), out int idCategoria))
                {
                    perguntaEmEdicao.idCategoria = idCategoria;
                }
                else
                {
                    MessageBox.Show("Categoria inválida.");
                    return;
                }
                CTR_Pergunta ctrPergunta = new CTR_Pergunta();
                ctrPergunta.AtualizarPergunta(perguntaEmEdicao);
                MessageBox.Show("Alterações salvas com sucesso.");
                estadoTela = EstadoTela.Criar;
                SalvarAlteracao.Visible = false;
                CadastrarPergunta.Visible = true;
                txtPergunta.Clear();
                CarregarDadosConsultarPergunta();          }
            else
            {
                MessageBox.Show("Nenhuma pergunta em edição.");
            }
        }
    }
}
