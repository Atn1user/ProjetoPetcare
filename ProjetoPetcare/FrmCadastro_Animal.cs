using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetcare
{
    public partial class FrmCadastro_Animal : Form
    {
        public FrmCadastro_Animal()
        {
            InitializeComponent();
        }

        private void lbl_idade_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FrmMenuPricipal abrir = new FrmMenuPricipal();
            abrir.Show();
            this.Hide();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_peso.Clear();
            txt_cor.Clear();
            txt_nome.Clear();
            txt_detalhe.Clear();
        }
    }
}
