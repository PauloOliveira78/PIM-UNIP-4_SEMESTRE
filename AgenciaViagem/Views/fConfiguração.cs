using AgenciaViagem.Controllers;
using AgenciaViagem.Controlls;
using AgenciaViagem.Models;
using System.Data;
using static AgenciaViagem.Models.Enum;

namespace AgenciaViagem.Views
{
    /// <summary>
    /// Classe parcial responsável pelo formulário de configuração da aplicação.
    /// </summary>
    public partial class fConfiguração : Form
    {
        private Categoria categoriaEmEdicao;
        private Pergunta perguntaEmEdicao;
        private EstadoTela estadoTela = EstadoTela.Criar;

        public fConfiguração()
        {
            InitializeComponent();
            CarregarDadosConsultarCategorias();
            CarregarDadosConsultarPergunta();
            CarregarDadosConsultarObjetivos();
            CarregarCategorias();
            CarregarObjetivos();
            SalvarAlteração.Visible = false;
            SalvarAlteracao.Visible = false;
            SalvarAlteração.Click += SalvarAlteração_Click;
        }

        /// <summary>
        /// Adiciona uma nova categoria.
        /// </summary>
        private void CadastrarCategoria_Click_1(object sender, EventArgs e)
        {
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            Categoria categoria = new Categoria();

            categoria.categoria = txtCategoria.Text;
            CTR_Categoria.AdicionarCategoria(categoria);
            txtCategoria.Clear();
            CarregarDadosConsultarCategorias();
            CarregarCategorias();
            MessageBox.Show("Categoria cadastrada com sucesso.");
        }

        /// <summary>
        /// Carrega as categorias disponíveis no banco de dados.
        /// </summary>
        private void CarregarCategorias()
        {
            CTR_Categoria CTR_Categoria = new CTR_Categoria();
            List<Categoria> categorias = new List<Categoria>();
            categorias = CTR_Categoria.ObterTodasCategorias();

            DataTable categoriasDataTable = new DataTable();
            categoriasDataTable.Columns.Add("ID", typeof(int));
            categoriasDataTable.Columns.Add("DS", typeof(string));

            foreach (Categoria categoria in categorias)
            {
                DataRow row = categoriasDataTable.NewRow();
                row["ID"] = categoria.idCategoria;
                row["DS"] = categoria.categoria;
                categoriasDataTable.Rows.Add(row);
            }
            comboBoxCategorias.DisplayMember = "DS";
            comboBoxCategorias.ValueMember = "ID";
            comboBoxCategorias.DataSource = categoriasDataTable;
        }

        /// <summary>
        /// Altera uma categoria existente.
        /// </summary>
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

        /// <summary>
        /// Carrega os dados para consultar categorias preenchendo a GRID
        /// </summary>
        private void CarregarDadosConsultarCategorias()
        {
            try
            {
                CTR_Categoria CTR_Categoria = new CTR_Categoria();
                List<Categoria> categorias = new List<Categoria>();
                categorias = CTR_Categoria.ObterTodasCategorias();

                DataTable categoriasDataTable = new DataTable();
                categoriasDataTable.Columns.Add("ID", typeof(int));
                categoriasDataTable.Columns.Add("DS", typeof(string));

                foreach (Categoria categoria in categorias)
                {
                    DataRow row = categoriasDataTable.NewRow();
                    row["ID"] = categoria.idCategoria;
                    row["DS"] = categoria.categoria;
                    categoriasDataTable.Rows.Add(row);
                }

                DGV_CatCo.AutoGenerateColumns = false;
                DGV_CatCo.DataSource = categoriasDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
        }
        /// <summary>
        /// Carrega os dados para consulta de perguntas preenchendo a GRID
        /// </summary>
        private void CarregarDadosConsultarPergunta()
        {
            try
            {
                CTR_Pergunta ctr_pergunta = new CTR_Pergunta();
                List<Pergunta> perguntas = new List<Pergunta>();
                perguntas = ctr_pergunta.ObterTodasPerguntasGrid();

                DataTable PerguntasDataTable = new DataTable();
                PerguntasDataTable.Columns.Add("DSC", typeof(string));
                PerguntasDataTable.Columns.Add("DSP", typeof(string));
                PerguntasDataTable.Columns.Add("PID", typeof(int));

                foreach (Pergunta pergunta in perguntas)
                {
                    DataRow row = PerguntasDataTable.NewRow();
                    row["DSC"] = pergunta.categoria.categoria;
                    row["DSP"] = pergunta.pergunta;
                    row["PID"] = pergunta.idPergunta;
                    PerguntasDataTable.Rows.Add(row);
                }

                DGV_PergCo.AutoGenerateColumns = false;
                DGV_PergCo.DataSource = PerguntasDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Perguntas: " + ex.Message);
            }
        }

        /// <summary>
        /// Deleta uma categoria.
        /// </summary>
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

        /// <summary>
        /// Salva as alterações feitas em uma categoria.
        /// </summary>
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

        /// <summary>
        /// Cadastra uma nova pergunta.
        /// </summary>
        private void CadastrarPergunta_Click(object sender, EventArgs e)
        {
            string idCategoriaString = comboBoxCategorias.SelectedValue.ToString();
            if (int.TryParse(idCategoriaString, out int idCategoria))
            {
                Pergunta pergunta = new Pergunta();
                pergunta.categoria.idCategoria = idCategoria;
                pergunta.pergunta = txtPergunta.Text;
                CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
                CTR_Pergunta.AdicionarPergunta(pergunta);
                txtPergunta.Clear();
                CarregarDadosConsultarPergunta();
                MessageBox.Show("Pergunta cadastrada com sucesso.");
            }
            else
            {
                MessageBox.Show("ID de Categoria inválido.");
            }
        }

        /// <summary>
        /// Deleta uma pergunta.
        /// </summary>
        private void DeletarPergunta_Click(object sender, EventArgs e)
        {
            CTR_Pergunta CTR_Pergunta = new CTR_Pergunta();
            Pergunta pergunta = new Pergunta();

            if (DGV_PergCo.SelectedRows.Count > 0)
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

        /// <summary>
        /// Altera uma pergunta existente.
        /// </summary>
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
                    comboBoxCategorias.SelectedValue = perguntaEmEdicao.categoria.idCategoria;
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

        /// <summary>
        /// Salva as alterações feitas em uma pergunta.
        /// </summary>
        private void SalvarAlteracao_Click(object sender, EventArgs e)
        {
            if (estadoTela == EstadoTela.Editar && perguntaEmEdicao != null)
            {
                perguntaEmEdicao.pergunta = txtPergunta.Text;

                if (comboBoxCategorias.SelectedValue != null && int.TryParse(comboBoxCategorias.SelectedValue.ToString(), out int idCategoria))
                {
                    perguntaEmEdicao.categoria.idCategoria= idCategoria;
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
                CarregarDadosConsultarPergunta();
            }
            else
            {
                MessageBox.Show("Nenhuma pergunta em edição.");
            }
        }

        /// <summary>
        /// Cadastra um novo objetivo.
        /// </summary>
        private void btnCadastrarObjetivo_Click(object sender, EventArgs e)
        {
            Objetivo objetivo = new Objetivo();
            CTR_Objetivo ctr_objetivo = new CTR_Objetivo();
            try
            {
                objetivo.objetivo = txtObjetivo.Text;
                ctr_objetivo.AdicionarObjetivo(objetivo);
                txtObjetivo.Clear();
                MessageBox.Show("Objetivo adicionado com sucesso");
                CarregarObjetivos();
                CarregarDadosConsultarObjetivos();
            }
            catch
            {
                MessageBox.Show("Não foi possivel adicionar o Objetivo");
            }
        }
        /// <summary>
        /// Carrega os objetivos disponíveis no banco de dados
        /// </summary>
        private void CarregarObjetivos()
        {
            CTR_Objetivo ctr_objetivo = new CTR_Objetivo();
            List<Objetivo> objetivos = new List<Objetivo>();
            objetivos = ctr_objetivo.ObterTodosObjetivos();
            DataTable objetivosDataTable = new DataTable();
            objetivosDataTable.Columns.Add("OID", typeof(int));
            objetivosDataTable.Columns.Add("ODS", typeof(string));
            foreach (Objetivo objetivo in objetivos)
            {
                DataRow row = objetivosDataTable.NewRow();
                row["OID"] = objetivo.idObjetivo;
                row["ODS"] = objetivo.objetivo;
                objetivosDataTable.Rows.Add(row);
            }
            comboBoxObjetivos.DisplayMember = "ODS";
            comboBoxObjetivos.ValueMember = "OID";
            comboBoxObjetivos.DataSource = objetivosDataTable;
        }

        /// <summary>
        /// Adiciona uma opção de objetivo.
        /// </summary>
        private void btnOpcaoObjetivo_Click(object sender, EventArgs e)
        {
            string idCObjetivoString = comboBoxObjetivos.SelectedValue.ToString();
            if (int.TryParse(idCObjetivoString, out int idObjetivo))
            {
                ObjetivoOpcao objetivoopcao = new ObjetivoOpcao();
                objetivoopcao.objetivo.idObjetivo = idObjetivo;
                objetivoopcao.objetivoopcao = txtOpcaoObjetivo.Text;

                CTR_ObjetivoOpcao ctr_objetivoopcao = new CTR_ObjetivoOpcao();
                ctr_objetivoopcao.AdicionarObjetivoOpcao(objetivoopcao);

                txtOpcaoObjetivo.Clear();
                CarregarDadosConsultarObjetivos();

                MessageBox.Show("Opção Cadastrada!");

            }
            else
            {
                MessageBox.Show("ID de Objetivo inválido.");
            }
        }

        /// <summary>
        /// Carrega os dados para consulta de objetivos preenchendo a GRID.
        /// </summary>
        private void CarregarDadosConsultarObjetivos()
        {
            try
            {
                CTR_Objetivo ctr_objetivo = new CTR_Objetivo();
                List<Objetivo> objetivos = new List<Objetivo>();

                objetivos = ctr_objetivo.ObterTodosObjetivos();

                DataTable objetivosDataTable = new DataTable();
                objetivosDataTable.Columns.Add("OID", typeof(int));
                objetivosDataTable.Columns.Add("ODS", typeof(string));

                foreach (Objetivo objetivo in objetivos)
                {
                    DataRow row = objetivosDataTable.NewRow();
                    row["OID"] = objetivo.idObjetivo;
                    row["ODS"] = objetivo.objetivo;
                    objetivosDataTable.Rows.Add(row);
                }
                DGV_Obj.AutoGenerateColumns = false;
                DGV_Obj.DataSource = objetivosDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar objetivos: " + ex.Message);
            }
        }

        /// <summary>
        /// Deleta um objetivo.
        /// </summary>
        private void DeletarObjetivo_Click(object sender, EventArgs e)
        {
            try
            {
                CTR_Objetivo ctr_objetivo = new CTR_Objetivo();
                Objetivo objetivo = new Objetivo();
                if (DGV_Obj.SelectedRows.Count > 0)
                {
                    int objetivoId = (int)DGV_Obj.SelectedRows[0].Cells["OID"].Value;
                    objetivo.idObjetivo = objetivoId;
                    ctr_objetivo.DeletarObjetivo(objetivo);
                    DGV_Obj.Rows.RemoveAt(DGV_Obj.SelectedRows[0].Index);
                    CarregarDadosConsultarObjetivos();
                    MessageBox.Show("Registro deletado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Nenhum registro selecionado para deletar.");
                }
            }
            catch
            {
                MessageBox.Show("Não será possivel realizar a exclusão do Objetivo, pois o mesmo já está associado a uma resposta");
            }
        }
    }
}
