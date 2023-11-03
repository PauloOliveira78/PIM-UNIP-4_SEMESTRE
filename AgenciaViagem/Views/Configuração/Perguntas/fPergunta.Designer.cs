namespace AgenciaViagem.Views
{
    partial class fPergunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            comboBoxCategorias = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SalvarAlteração = new Button();
            CadastrarPergunta = new Button();
            ConsultaPergunta = new Button();
            Fechar = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(470, 15);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(144, 23);
            comboBoxCategorias.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SalvarAlteração);
            flowLayoutPanel1.Controls.Add(CadastrarPergunta);
            flowLayoutPanel1.Controls.Add(ConsultaPergunta);
            flowLayoutPanel1.Controls.Add(Fechar);
            flowLayoutPanel1.Location = new Point(25, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(145, 276);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // SalvarAlteração
            // 
            SalvarAlteração.Location = new Point(3, 3);
            SalvarAlteração.Name = "SalvarAlteração";
            SalvarAlteração.Size = new Size(138, 66);
            SalvarAlteração.TabIndex = 5;
            SalvarAlteração.Text = "Salvar Alteração";
            SalvarAlteração.UseVisualStyleBackColor = true;
            // 
            // CadastrarPergunta
            // 
            CadastrarPergunta.Location = new Point(3, 75);
            CadastrarPergunta.Name = "CadastrarPergunta";
            CadastrarPergunta.Size = new Size(138, 61);
            CadastrarPergunta.TabIndex = 1;
            CadastrarPergunta.Text = "Cadastrar Pergunta";
            CadastrarPergunta.UseVisualStyleBackColor = true;
            // 
            // ConsultaPergunta
            // 
            ConsultaPergunta.Location = new Point(3, 142);
            ConsultaPergunta.Name = "ConsultaPergunta";
            ConsultaPergunta.Size = new Size(138, 60);
            ConsultaPergunta.TabIndex = 2;
            ConsultaPergunta.Text = "Consultar Perguntas";
            ConsultaPergunta.UseVisualStyleBackColor = true;
            // 
            // Fechar
            // 
            Fechar.Location = new Point(3, 208);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(138, 61);
            Fechar.TabIndex = 4;
            Fechar.Text = "Fechar";
            Fechar.UseVisualStyleBackColor = true;
            // 
            // fPergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboBoxCategorias);
            Controls.Add(textBox1);
            Name = "fPergunta";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBoxCategorias;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SalvarAlteração;
        private Button CadastrarPergunta;
        private Button ConsultaPergunta;
        private Button Fechar;
    }
}