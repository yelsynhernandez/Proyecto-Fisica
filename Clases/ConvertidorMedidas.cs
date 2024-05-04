using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFisica.Clases
{
    internal class ConvertidorMedidas
    {
        BD bd = new BD();
        private Dictionary<string, string> unidadMedida = new Dictionary<string, string>();
        public void CargarUnidadesDeMedida(ComboBox cb)
        {
            ListarUnidadesDeMedida();
            cb.Items.Clear();
            cb.Items.Add("Seleccionar");
            cb.SelectedIndex = 0;
            try
            {
                if (unidadMedida.Count > 0)
                {
                    foreach (var item in unidadMedida)
                    {
                        cb.Items.Add(item.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarUnidadesDeMedida()
        {
            unidadMedida.Clear();
            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("listado_categorias", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        unidadMedida.Add(reader["clave"].ToString(), reader["valor"].ToString());
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

        public string ImagenMedida(string nombre)
        {
            return unidadMedida[nombre];
        }

        public void CargarMedidas(ComboBox cb1,ComboBox cb2, string tipo_medida)
        {
            cb1.Items.Clear();
            cb1.Items.Add("Seleccionar");
            cb1.SelectedIndex = 0;

            cb2.Items.Clear();
            cb2.Items.Add("Seleccionar");
            cb2.SelectedIndex = 0;

            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("listado_medidas", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@tipo_medida", tipo_medida);

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        cb1.Items.Add(reader["nombre"].ToString());
                        cb2.Items.Add(reader["nombre"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LlenarDataGridViewDesdeVista(string nombreVista, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter($"SELECT * FROM {nombreVista}", conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridView.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public float ConvertirMedidas(string medida_origen, string medida_destino, float cantidad)
        {
            float resultado = 0;

            using (SqlConnection conexion = bd.CrearConexion())
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("convertir", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@medida_origen", medida_origen);
                    comando.Parameters.AddWithValue("@medida_destino", medida_destino);
                    comando.Parameters.AddWithValue("@cantidad", cantidad);
                    comando.Parameters.Add("@valor", SqlDbType.Float);
                    comando.Parameters["@valor"].Direction = ParameterDirection.Output;

                    comando.ExecuteNonQuery();

                    resultado = float.Parse(comando.Parameters["@valor"].Value.ToString());
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
