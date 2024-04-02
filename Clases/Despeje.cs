using System.Text.RegularExpressions;

namespace ProyectoFisica.Clases
{
    internal class Despeje
    {
        public string DespejarVariable(string ecuacion, char variable)
        {
            // Patrón para buscar la variable en la ecuación
            string patronVariable = variable + @"(\s*=\s*|-|\+|\*|\/)";

            // Busca la variable en la ecuación
            Match match = Regex.Match(ecuacion, patronVariable);

            // Si la variable no está en la ecuación, devuelve un mensaje de error
            if (!match.Success)
            {
                return "La variable especificada no está en la ecuación.";
            }

            // Obtiene el índice donde comienza la variable
            int indiceVariable = match.Index;

            // Divide la ecuación en dos partes: izquierda y derecha de la variable
            string izquierda = ecuacion.Substring(0, indiceVariable);
            string derecha = ecuacion.Substring(indiceVariable);

            // Si la variable está al inicio de la ecuación, no es necesario despejarla
            if (indiceVariable == 0)
            {
                return ecuacion;
            }

            // Si la variable está al final de la ecuación, se despeja dividiendo ambos lados por el coeficiente
            if (indiceVariable == ecuacion.Length - 1)
            {
                double coeficiente = double.Parse(izquierda);
                return $"{derecha} / {coeficiente}";
            }

            // Si la variable está en el medio de la ecuación, se despeja moviendo términos
            return $"{derecha} / {izquierda}";
        }
    }
}
