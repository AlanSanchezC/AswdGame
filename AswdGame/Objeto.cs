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

        /// <summary>
        /// Crea un nuevo punto en el plano
        /// </summary>
        /// <param name="x">Coordenada X</param>
        /// <param name="y">Coordenada Y</param>
        public Objeto(int x, int y)
        {
            this.x = x;
            this.y = y;
            size = 40;
        }

        private void irArriba()
        {
            if (this.y == 0)
                y = 680;
            else
                y -= size;
        }

        private void irAbajo()
        {
            if (this.y == 680)
                y = 0;
            else
                y += size;
        }

        private void irIzquierda()
        {
            if (this.x == 0)
                x = 1320;
            else
                x -= size;
        }

        private void irDerecha()
        {
            if (this.x == 1320)
                x = 0;
            else
                x += size;
            
        }

        /// <summary>
        /// Avanza hacia una dirección
        /// </summary>
        /// <param name="g">Canvas</param>
        /// <param name="d">Dirección</param>
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

        /// <summary>
        /// Reinicio de juego
        /// </summary>
        /// <param name="g">Canvas</param>
        public void reiniciar(Graphics g)
        {
            this.x = 0;
            this.y = 0;
            g.FillRectangle(new SolidBrush(Color.Firebrick), this.x, this.y, size, size);
        }

        /// <summary>
        /// Obtiene la coordenada del eje X
        /// </summary>
        /// <returns></returns>
        public int getX()
        {
            return x;
        }

        /// <summary>
        /// Obtiene la coordenada del eje Y
        /// </summary>
        /// <returns></returns>
        public int getY()
        {
            return y;
        }
    }
}
