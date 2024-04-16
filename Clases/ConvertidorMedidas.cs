using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFisica.Clases
{
    internal class ConvertidorMedidas
    {
        private SqlConnection CrearConexion()
        {
            return new SqlConnection($"Data Source=localhost;Initial Catalog=proyecto_fisica;Integrated Security=True;");
        }
        public void LlenarComboBox(ComboBox comboBox, string nombreProcedimiento)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Seleccionar");
            comboBox.SelectedIndex = 0;

            using (SqlConnection conexion = CrearConexion())
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(nombreProcedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader["nombre"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void CargarMedidas(ComboBox cb1,ComboBox cb2, string tipo_medida)
        {
            cb1.Items.Clear();
            cb1.Items.Add("Seleccionar");
            cb1.SelectedIndex = 0;

            cb2.Items.Clear();
            cb2.Items.Add("Seleccionar");
            cb2.SelectedIndex = 0;

            using (SqlConnection conexion = CrearConexion())
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

            using (SqlConnection conexion = CrearConexion())
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

        public decimal ConvertirMedidas(int idMedidaOrigen, int idMedidaDestino, decimal valor)
        {
            decimal resultado = 0;

            using (SqlConnection conexion = CrearConexion())
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("convertir", conexion);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id_medida_origen", idMedidaOrigen);
                    comando.Parameters.AddWithValue("@id_medida_destino", idMedidaDestino);
                    comando.Parameters.AddWithValue("@valor", valor);
                    comando.Parameters["@valor"].Direction = ParameterDirection.Output;

                    comando.ExecuteNonQuery();

                    resultado = Convert.ToDecimal(comando.Parameters["@valor"].Value);
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
