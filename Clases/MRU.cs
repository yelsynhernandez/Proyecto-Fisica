using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFisica.Clases
{
    internal class MRU
    {
        private Dictionary<string, Bitmap> listaFormulas = new Dictionary<string, Bitmap>();

        public double Distancia(double v, double t)
        {
            return v * t;
        }

        public double Velocidad(double x, double t)
        {
            return x / t;
        }

        public double Tiempo(double x, double v)
        {
            return x / v;
        }

        public double DistanciaFinal(double Xo, double v, double t)
        {
            return Xo + (v * t);
        }

        public void CargarFormulas(ComboBox cb)
        {
            listaFormulas.Add("Distancia", Properties.Resources.distancia);
            listaFormulas.Add("Tiempo", Properties.Resources.tiempo);
            listaFormulas.Add("Velocidad", Properties.Resources.velocidad);
            //listaFormulas.Add("Distancia Final", Properties.Resources.distancia_final);
            cb.Items.Clear();
            cb.Items.AddRange(listaFormulas.Keys.ToArray());
        }

        public Bitmap ImagenFormula(string nombre)
        {
            return listaFormulas[nombre];
        }
    }
}
