using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFisica.Clases
{
    internal class Formulas
    {
        Funciones funciones = new Funciones();
        BD bd = new BD();
        //List<Tuple<string, string, string, int>> ecuacion = new List<Tuple<string, string, string, int>>();
        //List<Tuple<string, string, string>> ecuacion = new List<Tuple<string, string, string>>();
        Dictionary<string, string> diccionarioEcuaciones = new Dictionary<string, string>();
        Dictionary<string, string> diccionarioVariables = new Dictionary<string, string>();
        Dictionary<string, string> diccionarioFormulas = new Dictionary<string, string>();
        public void CargarCategorias(ComboBox cbEcuacion)
        {
            try
            {
                List<string> lineas = funciones.ObtenerLineasArchivo("tipo_ecuacion");
                funciones.LimpiarComboBox(cbEcuacion);
                foreach(string linea in lineas)
                {
                    cbEcuacion.Items.Add(linea);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarListaEcuaciones(string categoria)
        {
            diccionarioEcuaciones.Clear();
            diccionarioFormulas.Clear();
            diccionarioVariables.Clear();
            List<string> lineas = funciones.ObtenerLineasArchivo("ecuaciones");

            foreach(string linea in lineas)
            {
                string[] parte = linea.Split('|');
                if(parte.Length == 5)
                {
                    if (categoria == parte[0])
                    {
                        diccionarioEcuaciones.Add(parte[1], parte[2]);
                        diccionarioVariables.Add(parte[1], parte[3]);
                        diccionarioFormulas.Add(parte[1], parte[4]);
                    }
                }
            }
        }

        public void CargarEcuaciones(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Seleccionar");
            try
            {
                if (diccionarioEcuaciones.Count > 0)
                {
                    foreach (var item in diccionarioEcuaciones)
                    {
                        cb.Items.Add(item.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cb.SelectedIndex = 0;
        }

        public string BuscarImagen(string _ecuacion)
        {
            return diccionarioEcuaciones.ContainsKey(_ecuacion) ? diccionarioEcuaciones[_ecuacion] : null;
        }

        public void CargarVariables(string _ecuacion, DataGridView dgv)
        {
            // Buscar la coincidencia en la lista
            //var tuplaEncontrada = ecuacion.Find(t => t.Item1 == _ecuacion);

            //if (tuplaEncontrada != null)
            if(diccionarioVariables.ContainsKey(_ecuacion))
            {
                //string variables = tuplaEncontrada.Item3;
                string variables = diccionarioVariables[_ecuacion];
                string[] variablesArray = variables.Split(',');
                int cantidadVariables = variablesArray.Length;

                dgv.ColumnCount = 2;
                dgv.Columns[0].Name = "Variables";
                dgv.Columns[1].Name = "Valores";

                dgv.Rows.Clear();
                dgv.Rows.Add(cantidadVariables);

                for (int i = 0; i < cantidadVariables; i++)
                {
                    dgv.Rows[i].Cells[0].Value = variablesArray[i].Trim();
                    dgv.Rows[i].Cells[0].ReadOnly = true;
                }

                dgv.CurrentCell = dgv.Rows[0].Cells[1];
                dgv.BeginEdit(true);
                dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[0].Resizable = DataGridViewTriState.False;
                dgv.Columns[1].Resizable = DataGridViewTriState.False;
                dgv.AllowUserToAddRows = false;
            }
            else
            {
                dgv.Rows.Clear();
            }
        }

        public float ResolverEcuacion(string nombre_ecuacion, string valores)
        {
            float resultado = 0;

            //using (SqlConnection conexion = bd.CrearConexion())
            //{
            //    try
            //    {
            //        var tuplaEncontrada = ecuacion.Find(t => t.Item1 == nombre_ecuacion);
            //        int id_ecuacion;
            //        if( tuplaEncontrada != null )
            //        {
            //            id_ecuacion = tuplaEncontrada.Item4;
            //            conexion.Open();
            //            SqlCommand comando = new SqlCommand("resolver_ecuacion", conexion);
            //            comando.CommandType = CommandType.StoredProcedure;

            //            comando.Parameters.AddWithValue("@id_ecuacion", id_ecuacion);
            //            comando.Parameters.AddWithValue("@valores", valores);
            //            comando.Parameters.Add("@resultado", SqlDbType.Float);
            //            comando.Parameters["@resultado"].Direction = ParameterDirection.Output;

            //            comando.ExecuteNonQuery();

            //            resultado = float.Parse(comando.Parameters["@resultado"].Value.ToString());
            //        }
            //        else
            //        {
            //            MessageBox.Show("No se pudo encontrar la ecuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

                   
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            return resultado;
        }
    }
}
