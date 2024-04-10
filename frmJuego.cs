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
    public partial class frmJuego : Form
    {
        clsNave objNaveJugador;
        clsNave objNaveEnemiga;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();
            objNaveJugador.CrearJugador();
            objNaveJugador.imgNave.Location = new Point(150, 750);
            Controls.Add(objNaveJugador.imgNave);

            objNaveEnemiga = new clsNave();
            objNaveEnemiga.CrearEnemigo();
            objNaveEnemiga.imgNaveEnemiga.Location = new Point(400, 200);
            Controls.Add(objNaveEnemiga.imgNaveEnemiga);

        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(
                    objNaveJugador.imgNave.Location.X + 5, objNaveJugador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(
                    objNaveJugador.imgNave.Location.X - 5, objNaveJugador.imgNave.Location.Y);
            }
        }
    }
}
