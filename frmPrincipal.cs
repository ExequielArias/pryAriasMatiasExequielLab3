namespace pryAriasMatiasExequiel
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dibujarFirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirma firma = new frmFirma();
            firma.ShowDialog();
        }
    }
}