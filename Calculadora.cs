using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPanesRectangulares
{
    internal class Calculadora
    {
        public static void CalcularPanArea(ref Pan panesito)
        {
            int area;
            panesito.Largo += 2;
            panesito.Ancho += 2;
            area = panesito.Largo * panesito.Ancho;
            MessageBox.Show("Dimensiones del pan: " + panesito.Ancho + " por " + panesito.Largo + ". El área del pane mide: " + area, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
