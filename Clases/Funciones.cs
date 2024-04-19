using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
    }
}
