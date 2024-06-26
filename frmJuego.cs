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
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;

namespace pryAriasMatiasExequiel
{
    public partial class frmJuego : Form
    {
        clsNave objNaveJugador;
        clsNave objNaveEnemiga;
        clsNave objLaser;
        clsNave objBalaEnemiga;
        int puntos = 0;
        int muertes = 0;
        string NombreJugador;
        List<clsNave> ListaEnemigos = new List<clsNave>();
        List<clsNave> ListaBalas = new List<clsNave>();
        List<clsNave> ListaBalasEnemigas = new List<clsNave>();         

        public frmJuego(string NombreJugador)
        {
            InitializeComponent();
            this.NombreJugador = NombreJugador;
            this.Text += $" - {this.NombreJugador}";
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();
            objNaveJugador.CrearJugador();
            objNaveJugador.imgNave.Location = new Point(250, 635);
            Controls.Add(objNaveJugador.imgNave);
            temporizadorEnemigo.Enabled = true;
            temporizadorBala.Enabled = true;
            objLaser = new clsNave();
            objNaveEnemiga = new clsNave();
            objBalaEnemiga = new clsNave();
            lblPuntos.Text = Convert.ToString(puntos);
            lblNombreJugador.Text = NombreJugador;
        }


        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(
                objNaveJugador.imgNave.Location.X + 30, objNaveJugador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(
                objNaveJugador.imgNave.Location.X - 30, objNaveJugador.imgNave.Location.Y);


            }

            if (e.KeyCode == Keys.Space)
            {
                objLaser = new clsNave();
                objLaser.CrearBala();
                ListaBalas.Add(objLaser);
                objLaser.imgBala.Location = new Point(objNaveJugador.imgNave.Location.X + 20, objNaveJugador.imgNave.Location.Y - 20);
                objNaveJugador.imgNave.BringToFront();
                Controls.Add(objLaser.imgBala);
            }

        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmJuego_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void temporizadorBala_Tick(object sender, EventArgs e)
        {
            objNaveEnemiga = new clsNave();
            objNaveEnemiga.CrearEnemigo();
            foreach (clsNave bala in ListaBalas)
            {
                if (bala.imgBala.Location.Y > 0)
                {
                    bala.imgBala.Location = new Point(bala.imgBala.Location.X, bala.imgBala.Location.Y - 100);
                    foreach (Control imagen in Controls)
                    {
                        if (imagen.Tag == "enemigo")
                        {
                            if (bala.imgBala.Bounds.IntersectsWith(imagen.Bounds))
                            {

                                bala.imgBala.Dispose();
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
                    bala.imgBala.Dispose();
                }
            }

        }
        int contador, PosX, PosY;
        Random randomX = new Random();
        Random randomY = new Random();
        //Random DisparoEnemigo = new Random();
        //int PosBalaE;
        private void temporizadorEnemigo_Tick(object sender, EventArgs e)
        {

            if (contador < 1)
            {
                int x = 23;
                for (int i = 0; i < 5; i++)
                {
                    PosX = randomX.Next(0, 650);
                    PosY = randomY.Next(30, 40);

                    objNaveEnemiga = new clsNave();
                    objNaveEnemiga.CrearEnemigo();
                    objNaveEnemiga.CrearBalaEnemiga();

                    ListaEnemigos.Add(objNaveEnemiga);
                    

                    objNaveEnemiga.imgNaveEnemiga.Location = new Point(x, PosY);

                    Controls.Add(objNaveEnemiga.imgNaveEnemiga);
                    objNaveEnemiga.imgNaveEnemiga.Tag = "enemigo";
                    x += objNaveEnemiga.imgNaveEnemiga.Size.Width * 2;
                    ListaBalasEnemigas.Add(objBalaEnemiga);
                }
                contador++;
            }

            if (contador < 1)
            {
                int x = 23;
                for (int i = 0; i < 5; i++)
                {
                    PosX = randomX.Next(0, 650);
                    PosY = randomY.Next(30, 40);

                    objNaveEnemiga = new clsNave();
                    objNaveEnemiga.CrearEnemigo();


                    ListaEnemigos.Add(objNaveEnemiga);


                    objNaveEnemiga.imgNaveEnemiga.Location = new Point(x, PosY);

                    Controls.Add(objNaveEnemiga.imgNaveEnemiga);

                    objNaveEnemiga.imgNaveEnemiga.Tag = "enemigo";
                    x += objNaveEnemiga.imgNaveEnemiga.Size.Width * 2;
                }
                contador++;
            }
            //PosBalaE = DisparoEnemigo.Next(1, 500);
            //foreach (clsNave NaveE in ListaEnemigos)
            //{
            //    if (DisparoEnemigo.Next(1, 300) == 10)
            //    {
            //        objNaveEnemiga = new clsNave();
            //        objNaveEnemiga.CrearBalaEnemiga();
            //        ListaBalasEnemigas.Add(objNaveEnemiga);
            //        Controls.Add(objNaveEnemiga.imgBalaEnemiga);
            //        foreach (clsNave BalasE in ListaBalasEnemigas)
            //        {
            //            BalasE.imgBalaEnemiga.Location = new Point(NaveE.imgBalaEnemiga.Location.X, BalasE.imgBalaEnemiga.Location.Y + 15);
            //            if (BalasE.imgBalaEnemiga.Bounds.IntersectsWith(objNaveJugador.imgNave.Bounds))
            //            {
            //                BalasE.imgBalaEnemiga.Dispose();
            //                objNaveJugador.imgNave.Dispose();
            //                MessageBox.Show("Partida Finalizada", "FIN");
            //            }
            //        }
            //    }
            //}
        }

        private void lblNombreJugador_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreJugador_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

