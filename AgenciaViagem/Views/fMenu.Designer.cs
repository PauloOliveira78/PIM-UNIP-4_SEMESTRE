namespace AgenciaViagem.Views
{
    partial class fMenu
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            Fechar = new Button();
            AlterarCategoria = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            DGV_CatCo = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            DS = new DataGridViewTextBoxColumn();
            DeletarCategoria = new Button();
            panel1 = new Panel();
            guna2TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_CatCo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2TabControl1
            // 
            guna2TabControl1.Alignment = TabAlignment.Left;
            guna2TabControl1.Controls.Add(tabPage1);
            guna2TabControl1.Controls.Add(tabPage2);
            guna2TabControl1.ItemSize = new Size(180, 40);
            guna2TabControl1.Location = new Point(163, 1);
            guna2TabControl1.Name = "guna2TabControl1";
            guna2TabControl1.SelectedIndex = 0;
            guna2TabControl1.Size = new Size(1102, 708);
            guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonHoverState.ForeColor = Color.White;
            guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            guna2TabControl1.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White;
            guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            guna2TabControl1.TabButtonSize = new Size(180, 40);
            guna2TabControl1.TabIndex = 0;
            guna2TabControl1.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(184, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(914, 700);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categoria";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(184, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(447, 444);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar Categoria";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Fechar
            // 
            Fechar.Location = new Point(12, 166);
            Fechar.Name = "Fechar";
            Fechar.Size = new Size(138, 61);
            Fechar.TabIndex = 18;
            Fechar.Text = "Configurações";
            Fechar.UseVisualStyleBackColor = true;
            // 
            // AlterarCategoria
            // 
            AlterarCategoria.Location = new Point(12, 5);
            AlterarCategoria.Name = "AlterarCategoria";
            AlterarCategoria.Size = new Size(138, 61);
            AlterarCategoria.TabIndex = 17;
            AlterarCategoria.Text = "Rota";
            AlterarCategoria.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(469, 52);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 15;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 14;
            // 
            // DGV_CatCo
            // 
            DGV_CatCo.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DGV_CatCo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DGV_CatCo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_CatCo.BorderStyle = BorderStyle.None;
            DGV_CatCo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_CatCo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV_CatCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV_CatCo.Columns.AddRange(new DataGridViewColumn[] { ID, DS });
            DGV_CatCo.EnableHeadersVisualStyles = false;
            DGV_CatCo.Location = new Point(-3, 83);
            DGV_CatCo.Name = "DGV_CatCo";
            DGV_CatCo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DGV_CatCo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DGV_CatCo.RowTemplate.Height = 25;
            DGV_CatCo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_CatCo.Size = new Size(384, 210);
            DGV_CatCo.TabIndex = 13;
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
            // DeletarCategoria
            // 
            DeletarCategoria.Location = new Point(12, 86);
            DeletarCategoria.Name = "DeletarCategoria";
            DeletarCategoria.Size = new Size(138, 61);
            DeletarCategoria.TabIndex = 12;
            DeletarCategoria.Text = "Perfil";
            DeletarCategoria.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(DGV_CatCo);
            panel1.Location = new Point(229, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 296);
            panel1.TabIndex = 16;
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 450);
            Controls.Add(Fechar);
            Controls.Add(guna2TabControl1);
            Controls.Add(AlterarCategoria);
            Controls.Add(DeletarCategoria);
            Name = "fMenu";
            Text = "fMenu";
            guna2TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_CatCo).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Button Fechar;
        private Button AlterarCategoria;
        private Button button1;
        private TextBox textBox1;
        private Button DeletarCategoria;
        private Panel panel1;
        private DataGridView DGV_CatCo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DS;
    }
}