using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;


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
            objNaveEnemiga.imgNave.Location = new Point(300, 3);
            Controls.Add(objNaveEnemiga.imgNave);

            objNaveEnemiga = new clsNave();
            objNaveEnemiga.CrearEnemigo();
            objNaveEnemiga.imgNave.Location = new Point(95, 3);
            Controls.Add(objNaveEnemiga.imgNave);

            objNaveEnemiga = new clsNave();
            objNaveEnemiga.CrearEnemigo();
            objNaveEnemiga.imgNave.Location = new Point(2, 3);
            Controls.Add(objNaveEnemiga.imgNave);

            objNaveEnemiga = new clsNave();
            objNaveEnemiga.CrearEnemigo();
            objNaveEnemiga.imgNave.Location = new Point(200, 3);
            Controls.Add(objNaveEnemiga.imgNave);

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

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmJuego_KeyUp(object sender, KeyEventArgs e)
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
