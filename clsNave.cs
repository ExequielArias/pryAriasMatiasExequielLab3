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


        public void CrearJugador() 
        {
            Vida = 100;
            Nombre = "Jugador1";
            PuntosDaño = 20; 
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage; 
            imgNave.ImageLocation = "https://opengameart.org/sites/default/files/lighter.gif";
            imgNave.BackColor = Color.Transparent;
            imgNave.Size = new Size(60, 60);
        }

        public void CrearEnemigo()
        {
            Vida = 20;
            Nombre = "Enemigo1";
            PuntosDaño = 2;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://cdnb.artstation.com/p/assets/images/images/006/503/665/original/william-robinson-gun-alien-passive-gif.gif?1499108527";
            imgNave.BackColor = Color.Transparent;
            imgNave.Size = new Size(60, 60);

        }
        
    }
}
