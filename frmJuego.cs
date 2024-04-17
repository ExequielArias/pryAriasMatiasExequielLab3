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
        clsNave objRayoLaser; 
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();
            objNaveJugador.CrearJugador();
            objNaveJugador.imgNave.Location = new Point(250, 635);
            Controls.Add(objNaveJugador.imgNave);


            objNaveEnemiga = new clsNave();
            int x = 23;
            for (int i = 0; i < 7; i++)
            {
                objNaveEnemiga.CrearEnemigo();
                objNaveEnemiga.imgNave.Location = new Point(x, 50);
                Controls.Add(objNaveEnemiga.imgNave);
                x += objNaveEnemiga.imgNave.Size.Width * 2; 
            }

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
