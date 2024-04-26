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

        }

        private void dibujarFirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdFirma_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirma firma = new frmFirma();
            firma.ShowDialog();
        }

        private void cmdJuego_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frmInicioDeSesionJuego inicioSesion = new frmInicioDeSesionJuego();
            inicioSesion.ShowDialog();  
        }
    }
}