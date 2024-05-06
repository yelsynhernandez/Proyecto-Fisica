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
                        /*
                         * ecuacion.Add(Tuple.Create(
                                                  reader.GetString(reader.GetOrdinal("formula")
                                                  (string)reader["formula"],
                                                  (string)reader["imagen"],
                                                  (string)reader["variables"].ToString(),
                                                  reader.GetInt32(reader.GetOrdinal("id_categoria"))
                                                  )
                         */
                        ecuacion.Add(Tuple.Create(
                                                  reader.GetString(reader.GetOrdinal("formula")),
                                                  reader.GetString(reader.GetOrdinal("imagen")),
                                                  reader.GetString(reader.GetOrdinal("variables")),
                                                  reader.GetInt32(reader.GetOrdinal("id_categoria"))
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
            // Buscar la coincidencia en el ítem 2 de cada tupla
            var tuplaEncontrada = ecuacion.FirstOrDefault(t => t.Item1 == _ecuacion);

            // Si se encuentra la coincidencia, devolver la ruta de la imagen
            if (tuplaEncontrada != null)
            {
                return tuplaEncontrada.Item2;
            }
            else
            {
                return null; // Devolver null si no se encuentra la imagen
            }
        }

        public void CargarVariables(string _ecuacion, DataGridView dgv)
        {
            // Buscar la coincidencia en la lista
            var tuplaEncontrada = ecuacion.Find(t => t.Item1 == _ecuacion);

            if (tuplaEncontrada != null)
            {
                // Obtener las variables y contarlas
                string variables = tuplaEncontrada.Item3;
                string[] variablesArray = variables.Split(',');
                int cantidadVariables = variablesArray.Length;

                // Crear columnas en el DataGridView
                dgv.ColumnCount = 2;
                dgv.Columns[0].Name = "Variables";
                dgv.Columns[1].Name = "Valores";

                // Agregar filas al DataGridView
                dgv.Rows.Clear();
                dgv.Rows.Add(cantidadVariables);

                // Mostrar las variables en la primera columna del DataGridView
                for (int i = 0; i < cantidadVariables; i++)
                {
                    dgv.Rows[i].Cells[0].Value = variablesArray[i].Trim();
                    dgv.Rows[i].Cells[0].ReadOnly = true;
                }

                // Colocar el foco en la segunda columna, fila 1
                dgv.CurrentCell = dgv.Rows[0].Cells[1];
                dgv.BeginEdit(true);

                // Configurar el ancho de la primera columna según el contenido
                dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Configurar el ancho de la segunda columna para ocupar el espacio restante
                dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Bloquear el cambio de tamaño de las columnas
                dgv.Columns[0].Resizable = DataGridViewTriState.False;
                dgv.Columns[1].Resizable = DataGridViewTriState.False;

                // Ocultar la última fila en blanco
                dgv.AllowUserToAddRows = false;
            }
            else
            {
                // Limpiar el DataGridView si no se encuentra la ecuación
                dgv.Rows.Clear();
            }
        }
    }
}
