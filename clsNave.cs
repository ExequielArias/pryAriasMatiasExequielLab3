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


        public void CrearJugador() 
        {
            Vida = 100;
            Nombre = "Jugador1";
            PuntosDaño = 20; 
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage; 
            imgNave.ImageLocation = "https://ideascdn.lego.com/media/generate/lego_ci/c9841b69-dddb-464d-88df-43778b2a2a44/resize:950:633/jpg"; 
        }

        public void CrearEnemigo()
        {
            Vida = 20;
            Nombre = "Enemigo1";
            PuntosDaño = 2;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://w7.pngwing.com/pngs/48/397/png-transparent-galaxian-pac-man-space-invaders-galaga-dig-dug-ghost-ship-flag-text-rectangle-thumbnail.png";

        }
    }
}
