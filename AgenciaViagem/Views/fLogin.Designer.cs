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
            txtCliente = new TextBox();
            txtSenha = new TextBox();
            Entrar = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(202, 232);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(380, 23);
            txtCliente.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(203, 296);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(379, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // Entrar
            // 
            Entrar.Location = new Point(342, 349);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 2;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += Entrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 211);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 278);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(237, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 174);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            guna2ImageButton1.Location = new Point(611, 262);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(22, 18);
            guna2ImageButton1.TabIndex = 6;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(490, 322);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastrar Conta";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 401);
            Controls.Add(linkLabel1);
            Controls.Add(guna2ImageButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Entrar);
            Controls.Add(txtCliente);
            Controls.Add(txtSenha);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fLogin";
            Load += fLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private TextBox txtSenha;
        private Button Entrar;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private LinkLabel linkLabel1;
    }
}