namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Laço de repetição que testa a condição no início
            int i = 0;
            lsbMostra.Items.Clear();
            lsbMostra.Items.Add("Tabuada do 5");
            while ( i <= 10)
            {
                int a = 5;                
                lsbMostra.Items.Add(a + "x" + i.ToString() + "= "+ a*i );
                i++;
            }
        }
    }
}
