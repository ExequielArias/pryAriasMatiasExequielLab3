using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriasMatiasExequiel
{
    public partial class frmInicioDeSesionJuego : Form
    { 
        public frmInicioDeSesionJuego()
        {
            InitializeComponent();
        }

        public void cmdIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    txtNombre.Text = "";
                    frmJuego juego = new frmJuego();
                    juego.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ingrese un Nombre", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error"); 
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog();
        }

        private void frmInicioDeSesionJuego_Load(object sender, EventArgs e)
        {

        }

        public void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
