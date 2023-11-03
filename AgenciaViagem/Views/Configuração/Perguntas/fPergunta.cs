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
    public partial class fPergunta : Form
    {
        private EstadoTela EstadoTelaPergunta;
        private Pergunta perguntaEmEdicao;
        private Categoria categoriaSelecionada;

        public fPergunta(EstadoTela modo, Pergunta pergunta)
        {
            InitializeComponent();
            EstadoTelaPergunta = modo;

            if (EstadoTelaPergunta == EstadoTela.Editar && pergunta != null)
            {
                perguntaEmEdicao = pergunta;
                textBox1.Text = perguntaEmEdicao.pergunta;
                CadastrarPergunta.Visible = false;
                ConsultaPergunta.Visible = false;
            }
            else if (EstadoTelaPergunta == EstadoTela.Criar && pergunta != null)
            {
                perguntaEmEdicao = new Pergunta();
                SalvarAlteração.Visible = false;

            }
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

        private void CadastrarPergunta_Click(object sender, EventArgs e)
        {
            if (comboBoxCategorias.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria.");
                return;
            }
            Categoria categoriaSelecionada = (Categoria)comboBoxCategorias.SelectedItem;
            string pergunta = textBox1.Text;

            if (string.IsNullOrWhiteSpace(pergunta))
            {
                MessageBox.Show("Digite a pergunta.");
                return;
            }
            Pergunta novaPergunta = new Pergunta
            {
                idCategoria = categoriaSelecionada.idCategoria,
                pergunta = pergunta
            };
            CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
            MessageBox.Show("Pergunta adicionada com sucesso.");
            textBox1.Clear();
        }

        private void ConsultaPergunta_Click(object sender, EventArgs e)
        {
            fPerguntaConsultar fPerguntaConsultar = new fPerguntaConsultar();
            this.Hide();
            fPerguntaConsultar.ShowDialog();
            this.Show();
        }

        public event EventHandler AlteracoesSalvas;
        private void SalvarAlteração_Click(object sender, EventArgs e)
        {
            if (perguntaEmEdicao == null)
            {
                MessageBox.Show("Pergunta em edição inválida.");
                return;
            }
            perguntaEmEdicao.pergunta = textBox1.Text;
            CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
            CTR_Pergunta.AtualizarPergunta(perguntaEmEdicao);
            MessageBox.Show("Alterações salvas com sucesso.");
        }

        private void Fechar_Click(object sender, EventArgs e)
        {

            if (EstadoTelaPergunta == EstadoTela.Editar)
            {
                AlteracoesSalvas?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            else if (EstadoTelaPergunta == EstadoTela.Criar)
            {

            }
        }
    }
}

