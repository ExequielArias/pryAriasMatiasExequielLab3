﻿using System;
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
        int puntos = 0;
        List<clsNave> enemigos = new List<clsNave>();
        List<clsNave> balas = new List<clsNave>();

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
            temporizadorEnemigo.Enabled = true;
            objLaser = new clsNave();
            objNaveEnemiga = new clsNave(); 
            lblPuntos.Text = Convert.ToString(puntos);

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
                objLaser = new clsNave();
                objLaser.CrearBala();
                objLaser.imgBala.Location = new Point(objNaveJugador.imgNave.Location.X + 20, objNaveJugador.imgNave.Location.Y - 20);
                objNaveJugador.imgNave.BringToFront();
                Controls.Add(objLaser.imgBala);
                temporizadorBala.Enabled = true;
            }

        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmJuego_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
        
        int muertes = 0;
        private void temporizadorBala_Tick(object sender, EventArgs e)
        {  
            objNaveEnemiga = new clsNave();
            objNaveEnemiga.CrearEnemigo();
            if (objLaser.imgBala.Location.Y > 0)
            {
                objLaser.imgBala.Location = new Point(objLaser.imgBala.Location.X, objLaser.imgBala.Location.Y - 100);
                foreach (Control imagen in Controls)
                {
                    if (imagen.Tag == "enemigo")
                    {
                        if (objLaser.imgBala.Bounds.IntersectsWith(imagen.Bounds))
                        {
                            
                            objLaser.imgBala.Dispose();
                            imagen.Dispose();
                            puntos += 10;
                            lblPuntos.Text = puntos.ToString();

                            muertes = muertes + 1;
                            if (muertes == 5)
                            {
                                contador = 0;
                                muertes = 0;
                            }  

                        }
                    }
                }
            }
            else
            {
                objLaser.imgBala.Dispose();
            } 
        }
        int contador, PosX, PosY;
        Random randomX = new Random();
        Random randomY = new Random();
        private void temporizadorEnemigo_Tick(object sender, EventArgs e)
        {
            
            if (contador < 1)
            {
                int x = 23;
                for (int i = 0; i < 5; i++)
                {
                    PosX = randomX.Next(0, 10);
                    PosY = randomY.Next(30, 40);
                    objNaveEnemiga = new clsNave();
                    objNaveEnemiga.CrearEnemigo();
                    enemigos.Add(objNaveEnemiga);
                    objNaveEnemiga.imgNaveEnemiga.Location = new Point(x, PosY);
                    Controls.Add(objNaveEnemiga.imgNaveEnemiga);
                    objNaveEnemiga.imgNaveEnemiga.Tag = "enemigo"; 
                    x += objNaveEnemiga.imgNaveEnemiga.Size.Width * 2;
                }
                contador ++;
            } 
        }
    }
}

