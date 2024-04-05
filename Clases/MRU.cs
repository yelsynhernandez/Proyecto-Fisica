using System.Collections.Generic;

namespace ProyectoFisica.Clases
{
    internal class MRU
    {
        private Dictionary<string, string> formulas = new Dictionary<string, string>();
        public double Velocidad(double x, double t)
        {
            return x / t;
        }

        public double Distancia(double v, double t)
        {
            return v * t;
        }

        public double Tiempo(double x, double v)
        {
            return x / v;
        }

        public double VelocidadFinal(double Xo, double v, double t)
        {
            return Xo + (v * t);
        }

        public Dictionary<string, string> DevolverFormulas()
        {
            formulas.Add("Velocidad", "global::ProyectoFisica.Properties.Resources.x_vt");
            return formulas;
        }
    }
}
