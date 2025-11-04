namespace ProjetoPetcare
{
    partial class FrmCadastro_Cliente
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
            pgb = new GroupBox();
            txt_codigo = new TextBox();
            txt_idade = new TextBox();
            lbl_codigo = new Label();
            lbl_idade = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            btn_novo = new Button();
            btn_limpar = new Button();
            btn_voltar = new Button();
            pgb.SuspendLayout();
            SuspendLayout();
            // 
            // pgb
            // 
            pgb.BackColor = SystemColors.ActiveCaption;
            pgb.Controls.Add(txt_codigo);
            pgb.Controls.Add(txt_idade);
            pgb.Controls.Add(lbl_codigo);
            pgb.Controls.Add(lbl_idade);
            pgb.Controls.Add(txt_nome);
            pgb.Controls.Add(lbl_nome);
            pgb.Location = new Point(12, 12);
            pgb.Name = "pgb";
            pgb.Size = new Size(656, 269);
            pgb.TabIndex = 0;
            pgb.TabStop = false;
            pgb.Text = "Dados do Cliente";
            pgb.Enter += groupBox1_Enter;
            // 
            // txt_codigo
            // 
            txt_codigo.Location = new Point(87, 152);
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(193, 23);
            txt_codigo.TabIndex = 5;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(80, 97);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(200, 23);
            txt_idade.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_codigo.Location = new Point(23, 152);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(62, 20);
            lbl_codigo.TabIndex = 3;
            lbl_codigo.Text = "Código:";
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_idade.Location = new Point(23, 97);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(51, 20);
            lbl_idade.TabIndex = 2;
            lbl_idade.Text = "Idade:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(80, 43);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(200, 23);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(23, 42);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(55, 20);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome:";
            // 
            // btn_novo
            // 
            btn_novo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novo.Location = new Point(35, 489);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(142, 49);
            btn_novo.TabIndex = 1;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_limpar.Location = new Point(284, 489);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(142, 49);
            btn_limpar.TabIndex = 2;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_voltar.Location = new Point(526, 489);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(142, 49);
            btn_voltar.TabIndex = 3;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // FrmCadastro_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(887, 600);
            Controls.Add(btn_voltar);
            Controls.Add(btn_limpar);
            Controls.Add(btn_novo);
            Controls.Add(pgb);
            Name = "FrmCadastro_Cliente";
            Text = "FrmCadastro_Cliente";
            pgb.ResumeLayout(false);
            pgb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox pgb;
        private Label lbl_nome;
        private Label lbl_codigo;
        private Label lbl_idade;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_codigo;
        private Button btn_novo;
        private Button btn_limpar;
        private Button btn_voltar;
    }
}