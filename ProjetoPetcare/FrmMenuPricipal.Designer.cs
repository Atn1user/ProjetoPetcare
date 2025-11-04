namespace ProjetoPetcare
{
    partial class FrmMenuPricipal
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
            btn_cadastro_cliente = new Button();
            btn_cadastro_animal = new Button();
            btn_cadastro_veterinario = new Button();
            btn_produtos = new Button();
            btn_sair = new Button();
            lbl_PetCare = new Label();
            SuspendLayout();
            // 
            // btn_cadastro_cliente
            // 
            btn_cadastro_cliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastro_cliente.Location = new Point(314, 110);
            btn_cadastro_cliente.Name = "btn_cadastro_cliente";
            btn_cadastro_cliente.Size = new Size(237, 69);
            btn_cadastro_cliente.TabIndex = 2;
            btn_cadastro_cliente.Text = "Cadastro Cliente";
            btn_cadastro_cliente.UseVisualStyleBackColor = true;
            btn_cadastro_cliente.Click += btn_cadastro_cliente_Click;
            // 
            // btn_cadastro_animal
            // 
            btn_cadastro_animal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastro_animal.Location = new Point(314, 194);
            btn_cadastro_animal.Name = "btn_cadastro_animal";
            btn_cadastro_animal.Size = new Size(237, 69);
            btn_cadastro_animal.TabIndex = 3;
            btn_cadastro_animal.Text = "Cadastro Animal";
            btn_cadastro_animal.UseVisualStyleBackColor = true;
            btn_cadastro_animal.Click += btn_cadastro_animal_Click;
            // 
            // btn_cadastro_veterinario
            // 
            btn_cadastro_veterinario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastro_veterinario.Location = new Point(314, 278);
            btn_cadastro_veterinario.Name = "btn_cadastro_veterinario";
            btn_cadastro_veterinario.Size = new Size(237, 69);
            btn_cadastro_veterinario.TabIndex = 4;
            btn_cadastro_veterinario.Text = "Cadastro Veterinario";
            btn_cadastro_veterinario.UseVisualStyleBackColor = true;
            // 
            // btn_produtos
            // 
            btn_produtos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_produtos.Location = new Point(314, 362);
            btn_produtos.Name = "btn_produtos";
            btn_produtos.Size = new Size(237, 69);
            btn_produtos.TabIndex = 5;
            btn_produtos.Text = "Produtos";
            btn_produtos.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            btn_sair.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sair.Location = new Point(314, 448);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(237, 69);
            btn_sair.TabIndex = 6;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // lbl_PetCare
            // 
            lbl_PetCare.AutoSize = true;
            lbl_PetCare.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PetCare.Location = new Point(396, 44);
            lbl_PetCare.Name = "lbl_PetCare";
            lbl_PetCare.Size = new Size(69, 21);
            lbl_PetCare.TabIndex = 1;
            lbl_PetCare.Text = "PetCare";
            // 
            // FrmMenuPricipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(887, 600);
            Controls.Add(lbl_PetCare);
            Controls.Add(btn_sair);
            Controls.Add(btn_produtos);
            Controls.Add(btn_cadastro_veterinario);
            Controls.Add(btn_cadastro_animal);
            Controls.Add(btn_cadastro_cliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenuPricipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPricipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastro_cliente;
        private Button btn_cadastro_animal;
        private Button btn_cadastro_veterinario;
        private Button btn_produtos;
        private Button btn_sair;
        private Label lbl_PetCare;
    }
}