using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

namespace ProyectoFisica.Clases
{
    internal class Funciones
    {
        readonly BD bd = new BD();

        public void LlenarComboBox(ComboBox comboBox, string sp)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Seleccionar");
            comboBox.SelectedIndex = 0;

            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(sp, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["valor"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                    using(StreamReader sr = new StreamReader(stream))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            lineas.Add(linea);
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
