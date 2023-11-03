using AgenciaViagem.Controlls;
using AgenciaViagem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViagem.Views
{
    public partial class fSugestChatgpt : Form
    {
        private PerfilCliente perfilCliente;
        private ApiChatGPT API;

        public fSugestChatgpt(PerfilCliente perfilCliente)
        {
            InitializeComponent();
            API = new ApiChatGPT("");
            this.perfilCliente = perfilCliente; 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            API.SetPrompt($"Sugira um nome de uma cidade e de um lugar específico dessa cidade com base no clima ome da cidade e do lugal especifico");
            string sugestao = await API.GetChatSuggestion();
            label1.Text = sugestao;
        }

    }
}

