namespace AgenciaViagem.Views
{
    partial class fCategoria
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
            txtCategoria = new TextBox();
            CadastrarCategoria = new Button();
            ConsultaCategoria = new Button();
            label1 = new Label();
            Fechar = new Button();
            SalvarAlteração = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(371, 88);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(213, 23);
            txtCategoria.TabIndex = 0;
            // 
            // CadastrarCategoria
            // 
            CadastrarCategoria.Location = new Point(3, 75);
            CadastrarCategoria.Name = "CadastrarCategoria";
            CadastrarCategoria.Size = new Size(138, 61);
            CadastrarCategoria.TabIndex = 1;
            CadastrarCategoria.Text = "Cadastrar Categoria";
            CadastrarCategoria.UseVisualStyleBackColor = true;
            CadastrarCategoria.Click += CadastrarCategoria_Click;
            // 
            // ConsultaCategoria
            // 
            ConsultaCategoria.Location = new Point(3, 142);
            ConsultaCategoria.Name = "ConsultaCategoria";
            ConsultaCategoria.Size = new Size(138, 60);
            ConsultaCategoria.TabIndex = 2;
            ConsultaCategoria.Text = "Consultar Categorias";
            ConsultaCategoria.UseVisualStyleBackColor = true;
            ConsultaCategoria.Click += ConsultaCategoria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 91);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 3;
            label1.Text = "Descrição da Categoria:";
            // 
            // Fechar
            // 
            Fechar.Location = new Point(3, 208);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(138, 61);
            Fechar.TabIndex = 4;
            Fechar.Text = "Fechar";
            Fechar.UseVisualStyleBackColor = true;
            Fechar.Click += Fechar_Click;
            // 
            // SalvarAlteração
            // 
            SalvarAlteração.Location = new Point(3, 3);
            SalvarAlteração.Name = "SalvarAlteração";
            SalvarAlteração.Size = new Size(138, 66);
            SalvarAlteração.TabIndex = 5;
            SalvarAlteração.Text = "Salvar Alteração";
            SalvarAlteração.UseVisualStyleBackColor = true;
            SalvarAlteração.Click += SalvarAlteração_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 35);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Adm Account:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 34);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 8;
            label3.Text = "Data do Cadastro:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(322, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(548, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(105, 23);
            textBox3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Location = new Point(220, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 119);
            panel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SalvarAlteração);
            flowLayoutPanel1.Controls.Add(CadastrarCategoria);
            flowLayoutPanel1.Controls.Add(ConsultaCategoria);
            flowLayoutPanel1.Controls.Add(Fechar);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(145, 276);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // fCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 405);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategoria);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "fCategoria";
            Text = "fCategoria23";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCategoria;
        private Button CadastrarCategoria;
        private Button ConsultaCategoria;
        private Label label1;
        private Button Fechar;
        private Button SalvarAlteração;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}