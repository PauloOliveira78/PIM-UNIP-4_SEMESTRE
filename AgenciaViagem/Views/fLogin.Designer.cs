namespace AgenciaViagem.Views
{
    partial class fLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            txtCliente = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            Entrar = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(245, 340);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(245, 412);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackColor = Color.White;
            guna2ImageButton1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = Properties.Resources.olho;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(15, 15);
            guna2ImageButton1.Location = new Point(584, 363);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(22, 18);
            guna2ImageButton1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(532, 469);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastrar Conta";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(278, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // txtCliente
            // 
            txtCliente.BorderRadius = 9;
            txtCliente.CustomizableEdges = customizableEdges2;
            txtCliente.DefaultText = "";
            txtCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCliente.Location = new Point(245, 363);
            txtCliente.Name = "txtCliente";
            txtCliente.PasswordChar = '\0';
            txtCliente.PlaceholderText = "";
            txtCliente.SelectedText = "";
            txtCliente.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtCliente.Size = new Size(379, 36);
            txtCliente.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 9;
            txtSenha.CustomizableEdges = customizableEdges4;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(245, 430);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '\0';
            txtSenha.PlaceholderText = "";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtSenha.Size = new Size(379, 36);
            txtSenha.TabIndex = 10;
            // 
            // Entrar
            // 
            Entrar.BorderRadius = 9;
            Entrar.CustomizableEdges = customizableEdges6;
            Entrar.DisabledState.BorderColor = Color.DarkGray;
            Entrar.DisabledState.CustomBorderColor = Color.DarkGray;
            Entrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Entrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Entrar.FillColor = Color.White;
            Entrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Entrar.ForeColor = Color.FromArgb(33, 42, 57);
            Entrar.Location = new Point(341, 502);
            Entrar.Name = "Entrar";
            Entrar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Entrar.Size = new Size(180, 33);
            Entrar.TabIndex = 11;
            Entrar.Text = "Entrar";
            Entrar.Click += Entrar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(390, 212);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 12;
            label3.Text = "embarque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(397, 226);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 13;
            label4.Text = "imeadiato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(246, 135, 18);
            label5.Location = new Point(381, 296);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 14;
            label5.Text = "INICIAR SESSÃO";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(885, 548);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(guna2ImageButton1);
            Controls.Add(Entrar);
            Controls.Add(txtSenha);
            Controls.Add(txtCliente);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2Button Entrar;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}