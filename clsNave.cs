using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAriasMatiasExequiel
{
    internal class clsNave
    {
        //Caracteristicas
        public int Vida;
        public string Nombre;
        int PuntosDaño;
        public PictureBox imgNave;
        public PictureBox imgBala;
        public PictureBox imgNaveEnemiga;


        public void CrearJugador() 
        {
            Vida = 100;
            Nombre = "Jugador1";
            PuntosDaño = 20; 
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage; 
            imgNave.ImageLocation = "https://community.gamedev.tv/uploads/db2322/original/3X/c/3/c390249f863fdcbf71e18bc6414f2abb882e140f.gif";
            imgNave.BackColor = Color.Transparent;
            imgNave.Size = new Size(60, 60);
        }

        public void CrearEnemigo()
        {
            Vida = 1;
            Nombre = "Enemigo1";
            PuntosDaño = 2;
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga.ImageLocation = "https://cdnb.artstation.com/p/assets/images/images/006/503/665/original/william-robinson-gun-alien-passive-gif.gif?1499108527";
            imgNaveEnemiga.BackColor = Color.Transparent;
            imgNaveEnemiga.Size = new Size(60, 60);

        }
        public void CrearBala() 
        {
            PuntosDaño = 20;
            imgBala = new PictureBox();
            imgBala.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBala.ImageLocation = "https://art.pixilart.com/d509f00ae2bee5e.png";
            imgBala.BackColor = Color.Transparent;
            imgBala.Size = new Size(15, 25);
        }
        
    }
}
