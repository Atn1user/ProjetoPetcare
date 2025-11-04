namespace ProjetoPetcare
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario = txt_usuario.Text;
            senha = Convert.ToInt32(txt_senha.Text);

            if (usuario == "admin" & senha == 123)
            {
                FrmMenuPricipal abrir = new FrmMenuPricipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Um dos dois está errado ai, chefe. Descubra!");
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




