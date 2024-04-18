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
        clsNave objLaser;
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
                objNaveEnemiga.imgNaveEnemiga.Location = new Point(x, 50);
                Controls.Add(objNaveEnemiga.imgNaveEnemiga);
                x += objNaveEnemiga.imgNaveEnemiga.Size.Width * 2;
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
            if (e.KeyCode == Keys.Space)
            {
                objLaser.imgBala.Location = new Point(objLaser.imgBala.Location.X,
                    objLaser.imgBala.Location.Y - 35);
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
            if (e.KeyCode == Keys.Space)
            {
                objLaser.imgBala.Location = new Point(objLaser.imgBala.Location.X,
                    objLaser.imgBala.Location.Y - 35);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int y = 635;
            objLaser = new clsNave();
            objLaser.CrearBala();
            objLaser.imgBala.Location = new Point(277, y);
            Controls.Add(objLaser.imgBala);


            if (objLaser.imgBala.Location.Y > 0)
            {
                if (objLaser.imgBala.Bounds.IntersectsWith(objNaveEnemiga.imgNaveEnemiga.Bounds))
                {
                    objLaser.imgBala.Dispose();
                    objNaveEnemiga.imgNaveEnemiga.Dispose();
                }
                else
                {
                    objLaser.imgBala.Location = new Point(objLaser.imgBala.Location.X, objLaser.imgBala.Location.Y - 15);
                }

            }
            else
            {
                objLaser.imgBala.Dispose();
            }
        }
    }
}

