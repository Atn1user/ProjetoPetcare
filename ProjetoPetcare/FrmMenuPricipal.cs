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
    public partial class FrmMenuPricipal : Form
    {
        public FrmMenuPricipal()
        {
            InitializeComponent();
        }

        private void btn_cadastro_cliente_Click(object sender, EventArgs e)
        {
            FrmCadastro_Cliente abrir = new FrmCadastro_Cliente();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadastro_animal_Click(object sender, EventArgs e)
        {
            FrmCadastro_Animal abrir = new FrmCadastro_Animal();
            abrir.Show();
            this.Hide();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
