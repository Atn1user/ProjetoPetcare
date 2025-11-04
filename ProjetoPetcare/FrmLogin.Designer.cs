namespace ProjetoPetcare
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            lbl_Senha = new Label();
            txt_senha = new TextBox();
            btn_sair = new Button();
            btn_entrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(266, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.Location = new Point(266, 349);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(66, 20);
            lbl_usuario.TabIndex = 1;
            lbl_usuario.Text = "Usuário ";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(338, 350);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(183, 23);
            txt_usuario.TabIndex = 2;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Senha.Location = new Point(266, 408);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(51, 20);
            lbl_Senha.TabIndex = 3;
            lbl_Senha.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(338, 408);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(183, 23);
            txt_senha.TabIndex = 4;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sair.Location = new Point(266, 481);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(121, 68);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_entrar
            // 
            btn_entrar.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_entrar.Location = new Point(478, 481);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(121, 68);
            btn_entrar.TabIndex = 6;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(887, 600);
            Controls.Add(btn_entrar);
            Controls.Add(btn_sair);
            Controls.Add(txt_senha);
            Controls.Add(lbl_Senha);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_usuario;
        private TextBox txt_usuario;
        private Label lbl_Senha;
        private TextBox txt_senha;
        private Button btn_sair;
        private Button btn_entrar;
    }
}
