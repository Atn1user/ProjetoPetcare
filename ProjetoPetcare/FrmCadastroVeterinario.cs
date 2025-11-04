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
    public partial class FrmCadastroVeterinario : Form
    {
        public FrmCadastroVeterinario()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            FrmMenuPricipal abrir = new FrmMenuPricipal();
            abrir.Show();
            this.Hide();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_idade.Clear();
            txt_crm.Clear();
        }
    }
}
