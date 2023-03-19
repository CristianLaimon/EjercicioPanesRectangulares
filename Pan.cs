using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPanesRectangulares
{
    internal class Pan
    {
        private int ancho, largo, area;

        public Pan()
        {
            ancho = 0;
            largo = 0;
            area = 0;
        }

        public Pan(int ancho, int largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        public int Ancho { get => ancho; set => ancho = value; }
        public int Largo { get => largo; set => largo = value; }
        public int Area { get => area; set => area = value; }
    }
}
