using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidiogeim
{
    class Objeto
    {
        protected int x;
        protected int y;
        protected int size;

        public Objeto(int x, int y)
        {
            this.x = x;
            this.y = y;
            size = 20;
        }

        private void irArriba()
        {
            if (this.y == 0)
                y = 580;
            else
                y -= size;
        }

        private void irAbajo()
        {
            if (this.y == 580)
                y = 0;
            else
                y += size;
        }

        private void irIzquierda()
        {
            if (this.x == 0)
                x = 780;
            else
                x -= size;
        }

        private void irDerecha()
        {
            if (this.x == 780)
                x = 0;
            else
                x += size;
            
        }

        public void avanzar(Graphics g, char d)
        {
            switch (d)
            {
                case 'w':
                    this.irArriba();
                    break;
                case 's':
                    this.irAbajo();
                    break;
                case 'd':
                    this.irDerecha();
                    break;
                case 'a':
                    this.irIzquierda();
                    break;
            }

            g.FillRectangle(new SolidBrush(Color.Firebrick), this.x, this.y, size, size);
        }

        public void reiniciar(Graphics g)
        {
            this.x = 0;
            this.y = 0;
            g.FillRectangle(new SolidBrush(Color.Firebrick), this.x, this.y, size, size);
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
