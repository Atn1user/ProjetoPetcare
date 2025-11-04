namespace ProjetoPetcare
{
    partial class FrmCadastro_Animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro_Animal));
            pgb = new GroupBox();
            txt_detalhe = new TextBox();
            txt_nome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_cor = new TextBox();
            txt_peso = new TextBox();
            lbl_cor = new Label();
            lbl_peso = new Label();
            txt_id = new TextBox();
            lbl_nome = new Label();
            btn_voltar = new Button();
            btn_limpar = new Button();
            pictureBox1 = new PictureBox();
            pgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pgb
            // 
            pgb.BackColor = SystemColors.ActiveCaption;
            pgb.Controls.Add(pictureBox1);
            pgb.Controls.Add(txt_detalhe);
            pgb.Controls.Add(txt_nome);
            pgb.Controls.Add(label2);
            pgb.Controls.Add(label1);
            pgb.Controls.Add(txt_cor);
            pgb.Controls.Add(txt_peso);
            pgb.Controls.Add(lbl_cor);
            pgb.Controls.Add(lbl_peso);
            pgb.Controls.Add(txt_id);
            pgb.Controls.Add(lbl_nome);
            pgb.Location = new Point(12, 12);
            pgb.Name = "pgb";
            pgb.Size = new Size(793, 414);
            pgb.TabIndex = 1;
            pgb.TabStop = false;
            pgb.Text = "Dados do Cliente";
            // 
            // txt_detalhe
            // 
            txt_detalhe.Location = new Point(95, 238);
            txt_detalhe.Name = "txt_detalhe";
            txt_detalhe.Size = new Size(178, 23);
            txt_detalhe.TabIndex = 5;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(84, 194);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(189, 23);
            txt_nome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 237);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Detalhe:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 193);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // txt_cor
            // 
            txt_cor.Location = new Point(73, 142);
            txt_cor.Name = "txt_cor";
            txt_cor.Size = new Size(200, 23);
            txt_cor.TabIndex = 3;
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(73, 97);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(200, 23);
            txt_peso.TabIndex = 2;
            // 
            // lbl_cor
            // 
            lbl_cor.AutoSize = true;
            lbl_cor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cor.Location = new Point(23, 142);
            lbl_cor.Name = "lbl_cor";
            lbl_cor.Size = new Size(38, 20);
            lbl_cor.TabIndex = 3;
            lbl_cor.Text = "Cor:";
            lbl_cor.Click += lbl_cor_Click;
            // 
            // lbl_peso
            // 
            lbl_peso.AutoSize = true;
            lbl_peso.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_peso.Location = new Point(23, 96);
            lbl_peso.Name = "lbl_peso";
            lbl_peso.Size = new Size(44, 20);
            lbl_peso.TabIndex = 2;
            lbl_peso.Text = "Peso:";
            lbl_peso.Click += lbl_idade_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(73, 43);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(200, 23);
            txt_id.TabIndex = 1;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(23, 42);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(26, 20);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Id:";
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_voltar.Location = new Point(85, 511);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(142, 49);
            btn_voltar.TabIndex = 6;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpar.Location = new Point(341, 511);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(142, 49);
            btn_limpar.TabIndex = 7;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmCadastro_Animal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 600);
            Controls.Add(btn_limpar);
            Controls.Add(btn_voltar);
            Controls.Add(pgb);
            Name = "FrmCadastro_Animal";
            Text = "FrmCadastro_Animal";
            pgb.ResumeLayout(false);
            pgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox pgb;
        private TextBox txt_cor;
        private TextBox txt_peso;
        private Label lbl_cor;
        private Label lbl_peso;
        private TextBox txt_id;
        private Label lbl_nome;
        private Label label2;
        private Label label1;
        private TextBox txt_nome;
        private TextBox txt_detalhe;
        private Button btn_voltar;
        private Button btn_limpar;
        private PictureBox pictureBox1;
    }
}