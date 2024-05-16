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
        public PictureBox imgNave;
        public PictureBox imgBala;
        public PictureBox imgNaveEnemiga;
        public PictureBox imgBalaEnemiga;


        public void CrearJugador() 
        {
            
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage; 
            imgNave.ImageLocation = "https://community.gamedev.tv/uploads/db2322/original/3X/c/3/c390249f863fdcbf71e18bc6414f2abb882e140f.gif";
            imgNave.BackColor = Color.Transparent;
            imgNave.Size = new Size(60, 60);
        }

        public void CrearEnemigo()
        {
            imgNaveEnemiga = new PictureBox();
            imgNaveEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemiga.ImageLocation = "https://cdnb.artstation.com/p/assets/images/images/006/503/665/original/william-robinson-gun-alien-passive-gif.gif?1499108527";
            imgNaveEnemiga.BackColor = Color.Transparent;
            imgNaveEnemiga.Size = new Size(60, 60);

        }
        public void CrearBala() 
        {
            imgBala = new PictureBox();
            imgBala.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBala.ImageLocation = "https://art.pixilart.com/d509f00ae2bee5e.png";
            imgBala.BackColor = Color.Transparent;
            imgBala.Size = new Size(15, 25);
        }

        public void CrearBalaEnemiga() 
        {
            imgBalaEnemiga = new PictureBox();
            imgBalaEnemiga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBalaEnemiga.ImageLocation = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/038be1ee-147a-40dd-b3e1-f1fcd9b12b6b/delz2ac-12133f97-2a4f-4199-a3e4-09f78d221560.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzAzOGJlMWVlLTE0N2EtNDBkZC1iM2UxLWYxZmNkOWIxMmI2YlwvZGVsejJhYy0xMjEzM2Y5Ny0yYTRmLTQxOTktYTNlNC0wOWY3OGQyMjE1NjAucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.swBX60DOO2Eg8ciO83wMTLWi4kivzBTsfwpTmTr3zlg";
            imgBalaEnemiga.BackColor = Color.Transparent;
            imgBalaEnemiga.Size = new Size(30, 50);
        }
    }
}
