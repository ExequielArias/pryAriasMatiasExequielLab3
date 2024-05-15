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
    public partial class frmFirma : Form
    {
        public Bitmap archivoImagen;
        public frmFirma()
        {
            InitializeComponent();
            archivoImagen = new Bitmap(pbDibujo.Width, pbDibujo.Height);
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog();
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }

        private void pbDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
            //dibujo que vaya poniendo puntos 
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(archivoImagen))
                {
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
                pbDibujo.Invalidate();
            }
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string FechaDia = "", FechaHora = "", FechaMes = "", FechaAño = "", FechaMinutos = "", FechaHoy = "";
            FechaDia = DateTime.Now.Day.ToString();
            FechaHora = DateTime.Now.Hour.ToString();
            FechaMes = DateTime.Now.Month.ToString();
            FechaAño = DateTime.Now.Year.ToString();
            FechaMinutos = DateTime.Now.Minute.ToString();
            FechaHoy = FechaDia + "." + FechaMes + "." + FechaAño + "." + FechaHora + "." + FechaMinutos + ".";
            archivoImagen.Save(@"../../../"+"/Firma/" + FechaHoy + ".jpg");
            MessageBox.Show("La imagen se guardo correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbDibujo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(archivoImagen, Point.Empty);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(archivoImagen))
            {
                g.Clear(pbDibujo.BackColor);
            }
            pbDibujo.Image = archivoImagen;
        }
    }
}
