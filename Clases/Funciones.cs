using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFisica.Clases
{
    internal class Funciones
    {
        public bool EsDecimal(string texto)
        {
            decimal valor;
            return decimal.TryParse(texto, out valor);
        }

        public void LimpiarComboBox(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Seleccionar");
            cb.SelectedIndex = 0;
        }

        public List<string> ObtenerLineasArchivo(string nombreArchivo)
        {
            List<string> lineas = new List<string>();
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string archivo = $"ProyectoFisica.Resources.txt.{nombreArchivo}.txt";
                string[] recursos = assembly.GetManifestResourceNames();

                using (Stream stream = assembly.GetManifestResourceStream(archivo))
                {
                    if(stream == null)
                    {
                        throw new FileNotFoundException($"No se pudo encontrar el recurso incrustado '{archivo}'");
                    }

                    using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            lineas.Add(linea.Trim());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lineas;
        }
    }
}
