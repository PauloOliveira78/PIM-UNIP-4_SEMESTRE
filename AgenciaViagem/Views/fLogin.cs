using AgenciaViagem.Controlls;
using AgenciaViagem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgenciaViagem.Views
{
    public partial class fLogin : Form
    {

        private CTR_PessoaCliente CTR_PessoaCliente; // Instância do controlador

        public fLogin()
        {
            InitializeComponent();

            //TODO: Lucas
            // Inicializando o controle PessoaCliente
            CTR_PessoaCliente = new CTR_PessoaCliente();
        }
      
        private void Entrar_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //TODO: Lucas
            //Chamada do formulario fCadastrarCliente

            var cadastrar = new fCadastrarCliente();
            cadastrar.Show();

            this.Visible = false;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

    }
}

