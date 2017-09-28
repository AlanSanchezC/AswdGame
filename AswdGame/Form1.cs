using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidiogeim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //s1 = new SoundPlayer(@"C:/____.wav");
            //s2 = new SoundPlayer(@"C:/____.wav");
            r = new Random();

            g = pctCanvas.CreateGraphics();
            main = new Objeto(0, 0);            
            empezar();
        }

        static Random r;
        //SoundPlayer s1,s2;
        Graphics g;
        Objeto main;

        private void reproducirSonido(int p)
        {
            //Se reproduce un sonido aleatorio de los 2 sonidos precargados.
            //if (p == 1)
            //    s1.Play();
            //else
            //    s2.Play();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            g.Clear(Color.PaleGoldenrod);
            main.avanzar(g, e.KeyChar);

            Point nav = pctCanvas.Location;
            nav.Offset(main.getX(), main.getY());
            Cursor.Position = PointToScreen(nav);
        }

        private void empezar()
        {
            //El punto vuelve a la esquina superior derecha
            main.reiniciar(g);

            //El cursor se va a la posición del punto
            Point Punto_Inicio = pctCanvas.Location;
            Punto_Inicio.Offset(0, 0);
            Cursor.Position = PointToScreen(Punto_Inicio);            

            //reproducirSonido(r.Next(1, 3));         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Colission(object sender, EventArgs e)
        {
            //Al chocar con una pared se reinicia el juego
            empezar();
        }

        private void pctCanvas_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
    }
}
