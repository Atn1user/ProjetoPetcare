namespace ProjetoPetcare
{
    partial class FrmCadastroVeterinario
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
            btn_voltar = new Button();
            btn_limpar = new Button();
            btn_novo = new Button();
            pgb_cadastro_veterinario = new GroupBox();
            txt_crm = new TextBox();
            txt_idade = new TextBox();
            lbl_crm = new Label();
            lbl_idade = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            pgb_cadastro_veterinario.SuspendLayout();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_voltar.Location = new Point(541, 468);
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
            btn_limpar.Location = new Point(267, 468);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(142, 49);
            btn_limpar.TabIndex = 5;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novo.Location = new Point(27, 468);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(142, 49);
            btn_novo.TabIndex = 4;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            // 
            // pgb_cadastro_veterinario
            // 
            pgb_cadastro_veterinario.BackColor = SystemColors.ActiveCaption;
            pgb_cadastro_veterinario.Controls.Add(txt_crm);
            pgb_cadastro_veterinario.Controls.Add(txt_idade);
            pgb_cadastro_veterinario.Controls.Add(lbl_crm);
            pgb_cadastro_veterinario.Controls.Add(lbl_idade);
            pgb_cadastro_veterinario.Controls.Add(txt_nome);
            pgb_cadastro_veterinario.Controls.Add(lbl_nome);
            pgb_cadastro_veterinario.Location = new Point(27, 24);
            pgb_cadastro_veterinario.Name = "pgb_cadastro_veterinario";
            pgb_cadastro_veterinario.Size = new Size(656, 269);
            pgb_cadastro_veterinario.TabIndex = 4;
            pgb_cadastro_veterinario.TabStop = false;
            pgb_cadastro_veterinario.Text = "Dados do Veterinario";
            // 
            // txt_crm
            // 
            txt_crm.Location = new Point(80, 152);
            txt_crm.Name = "txt_crm";
            txt_crm.Size = new Size(200, 23);
            txt_crm.TabIndex = 3;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(80, 97);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(200, 23);
            txt_idade.TabIndex = 2;
            // 
            // lbl_crm
            // 
            lbl_crm.AutoSize = true;
            lbl_crm.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_crm.Location = new Point(23, 152);
            lbl_crm.Name = "lbl_crm";
            lbl_crm.Size = new Size(45, 20);
            lbl_crm.TabIndex = 3;
            lbl_crm.Text = "CRM:";
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
            // FrmCadastroVeterinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(887, 600);
            Controls.Add(btn_voltar);
            Controls.Add(btn_limpar);
            Controls.Add(btn_novo);
            Controls.Add(pgb_cadastro_veterinario);
            Name = "FrmCadastroVeterinario";
            Text = "FrmCadastroVeterinario";
            pgb_cadastro_veterinario.ResumeLayout(false);
            pgb_cadastro_veterinario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_voltar;
        private Button btn_limpar;
        private Button btn_novo;
        private GroupBox pgb_cadastro_veterinario;
        private TextBox txt_crm;
        private TextBox txt_idade;
        private Label lbl_crm;
        private Label lbl_idade;
        private TextBox txt_nome;
        private Label lbl_nome;
    }
}