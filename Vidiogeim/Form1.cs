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
            s1 = new SoundPlayer(@"C:/bing.wav");
            s2 = new SoundPlayer(@"C:/bong.wav");
            r = new Random();

            g = pctCanvas.CreateGraphics();
            main = new Objeto(0, 0);            
            Cursor.Hide();
            empezar();
        }

        static Random r;
        SoundPlayer s1,s2;
        Graphics g;
        Objeto main;
        int contador;

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
            contador = 10;
            Point Punto_Inicio = pctCanvas.Location;
            Punto_Inicio.Offset(0, 0);
            Cursor.Position = PointToScreen(Punto_Inicio);
            main.reiniciar(g);

            if (r.Next(1, 3) == 1)
                s1.Play();
            else
                s2.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            lblCont.Text = contador.ToString();
            contador--;
           
            if (contador < 0)
                contador = 10;
        }

        private void Colission(object sender, EventArgs e)
        {
            empezar();
        }
    }
}
