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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgenciaViagem.Views
{
    public partial class fCadastrarCliente : Form
    {
        private CTR_PessoaCliente CTR_PessoaCliente;
        public fCadastrarCliente()
        {
            InitializeComponent();
            CTR_PessoaCliente = new CTR_PessoaCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //TODO:Lucas
            // Nova instância de PessoaCliente atribuir os valores dos campos do formulário
            cboGenero.Items.Add("Masculino");
            cboGenero.Items.Add("Feminino");

            PessoaCliente cliente = new PessoaCliente
            {
                Nome = txtNome.Text,
                Idade = Convert.ToInt32(txtIdade.Text),
                Genero = cboGenero.SelectedItem.ToString(),
                CPF = txtCPF.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,
                Cidade = txtCidade.Text,
                Pais = txtPais.Text,
                Email = txtEmail.Text,
                Login = txtLogin.Text,
                Senha = Convert.ToInt32(txtSenha.Text)
            };

            // Chama o método CriarCliente do controlador para adicionar um novo cliente
            CTR_PessoaCliente.CriarCliente(cliente);

            // Exiba uma mensagem ou realize outras operações após cadastrar o cliente
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = new fLogin();
            login.Show();
            this.Visible = false;
        }
    }
}


