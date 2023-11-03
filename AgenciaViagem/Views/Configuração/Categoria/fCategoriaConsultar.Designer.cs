namespace AgenciaViagem.Views
{
    partial class fCategoriaConsultar
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
            components = new System.ComponentModel.Container();
            DeletarCategoria = new Button();
            DGV_CatCo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DS = new DataGridViewTextBoxColumn();
            conexaoSqlServerBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            AlterarCategoria = new Button();
            Fechar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_CatCo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoSqlServerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DeletarCategoria
            // 
            DeletarCategoria.Location = new Point(12, 100);
            DeletarCategoria.Name = "DeletarCategoria";
            DeletarCategoria.Size = new Size(138, 61);
            DeletarCategoria.TabIndex = 5;
            DeletarCategoria.Text = "Deletar Categoria";
            DeletarCategoria.UseVisualStyleBackColor = true;
            DeletarCategoria.Click += DeletarCategoria_Click;
            // 
            // DGV_CatCo
            // 
            DGV_CatCo.AutoGenerateColumns = false;
            DGV_CatCo.BorderStyle = BorderStyle.None;
            DGV_CatCo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_CatCo.Columns.AddRange(new DataGridViewColumn[] { ID, DS });
            DGV_CatCo.DataSource = conexaoSqlServerBindingSource;
            DGV_CatCo.Location = new Point(225, 90);
            DGV_CatCo.Name = "DGV_CatCo";
            DGV_CatCo.RowTemplate.Height = 25;
            DGV_CatCo.Size = new Size(384, 210);
            DGV_CatCo.TabIndex = 6;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "ID";
            ID.FillWeight = 76.1421356F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // DS
            // 
            DS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DS.DataPropertyName = "DS";
            DS.FillWeight = 123.857864F;
            DS.HeaderText = "Descrição";
            DS.Name = "DS";
            // 
            // conexaoSqlServerBindingSource
            // 
            conexaoSqlServerBindingSource.DataSource = typeof(Dal.DAOConexaoSqlServer);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(465, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 8;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(225, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 296);
            panel1.TabIndex = 9;
            // 
            // AlterarCategoria
            // 
            AlterarCategoria.Location = new Point(12, 19);
            AlterarCategoria.Name = "AlterarCategoria";
            AlterarCategoria.Size = new Size(138, 61);
            AlterarCategoria.TabIndex = 10;
            AlterarCategoria.Text = "Alterar Categoria";
            AlterarCategoria.UseVisualStyleBackColor = true;
            AlterarCategoria.Click += AlterarCategoria_Click_1;
            // 
            // Fechar
            // 
            Fechar.Location = new Point(12, 180);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(138, 61);
            Fechar.TabIndex = 11;
            Fechar.Text = "Fechar";
            Fechar.UseVisualStyleBackColor = true;
            Fechar.Click += Fechar_Click;
            // 
            // fCategoriaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 344);
            Controls.Add(Fechar);
            Controls.Add(AlterarCategoria);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(DGV_CatCo);
            Controls.Add(DeletarCategoria);
            Controls.Add(panel1);
            Name = "fCategoriaConsultar";
            Text = "fCategoriaConsultar";
            WindowState = FormWindowState.Maximized;
            Load += fCategoriaConsultar_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_CatCo).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoSqlServerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeletarCategoria;
        private DataGridView DGV_CatCo;
        private BindingSource conexaoSqlServerBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DS;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button AlterarCategoria;
        private Button Fechar;
    }
}