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
        List<Tuple<string, string, string, int>> ecuacion = new List<Tuple<string, string, string, int>>();
        public void CargarCategorias(ComboBox cb)
        {
            funciones.LlenarComboBox(cb, "listar_categoria_ecuacion");
        }

        public void ActualizarListaEcuaciones(string categoria)
        {
            ecuacion.Clear();
            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("ecuaciones", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@categoria_ecuacion", categoria);

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ecuacion.Add(Tuple.Create(
                                                  reader.GetString(reader.GetOrdinal("formula")),
                                                  reader.GetString(reader.GetOrdinal("imagen")),
                                                  reader.GetString(reader.GetOrdinal("variables")),
                                                  reader.GetInt32(reader.GetOrdinal("id_ecuacion"))
                                                  )
                         
                                      );
                    }
                    reader.Close();

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CargarEcuaciones(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Seleccionar");
            try
            {
                if (ecuacion.Count > 0)
                {
                    foreach (var item in ecuacion)
                    {
                        cb.Items.Add(item.Item1);
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
            var tuplaEncontrada = ecuacion.FirstOrDefault(t => t.Item1 == _ecuacion);

            if (tuplaEncontrada != null)
            {
                return tuplaEncontrada.Item2;
            }
            else
            {
                return null;
            }
        }

        public void CargarVariables(string _ecuacion, DataGridView dgv)
        {
            // Buscar la coincidencia en la lista
            var tuplaEncontrada = ecuacion.Find(t => t.Item1 == _ecuacion);

            if (tuplaEncontrada != null)
            {
                string variables = tuplaEncontrada.Item3;
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

            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    var tuplaEncontrada = ecuacion.Find(t => t.Item1 == nombre_ecuacion);
                    int id_ecuacion;
                    if( tuplaEncontrada != null )
                    {
                        id_ecuacion = tuplaEncontrada.Item4;
                        conexion.Open();
                        SqlCommand comando = new SqlCommand("resolver_ecuacion", conexion);
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@id_ecuacion", id_ecuacion);
                        comando.Parameters.AddWithValue("@valores", valores);
                        comando.Parameters.Add("@resultado", SqlDbType.Float);
                        comando.Parameters["@resultado"].Direction = ParameterDirection.Output;

                        comando.ExecuteNonQuery();

                        resultado = float.Parse(comando.Parameters["@resultado"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar la ecuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return resultado;
        }
    }
}
