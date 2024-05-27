using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoFisica.Clases
{
    internal class ConvertidorMedidas
    {
        private Dictionary<string, string> unidadMedida = new Dictionary<string, string>();
        Funciones funciones = new Funciones();
        public void CargarUnidadesDeMedida(ComboBox cb)
        {   
            try
            {
                ListarUnidadesDeMedida();
                funciones.LimpiarComboBox(cb);
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
            List<string> lineasArchivo = funciones.ObtenerLineasArchivo("tipo_medida");

            foreach (string linea in lineasArchivo)
            {
                string[] partes = linea.Split(',');
                if(partes.Length == 2)
                {
                    unidadMedida.Add(partes[0], partes[1]);
                }
            }
        }

        public string ImagenMedida(string nombre)
        {
            return unidadMedida[nombre];
        }

        public void CargarMedidas(ComboBox cbOrigen,ComboBox cbDestino, string tipo_medida)
        {
            try
            {
                List<string> lineasArchivo = funciones.ObtenerLineasArchivo("medida");
                funciones.LimpiarComboBox(cbOrigen);
                funciones.LimpiarComboBox(cbDestino);

                foreach(string linea in lineasArchivo)
                {
                    string[] partes = linea.Split(',');
                    if (tipo_medida == partes[0])
                    {
                        cbOrigen.Items.Add(partes[1]);
                        cbDestino.Items.Add(partes[1]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarDataGridViewDesdeVista(string nombreVista, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            /*
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
            */
        }

        public float ConvertirMedidas(string medida_origen, string medida_destino, float cantidad)
        {
            float resultado = 0;
            try
            {
                List<string> lineasArchivo = funciones.ObtenerLineasArchivo("equivalencia_medida");

                foreach(string linea in lineasArchivo)
                {
                    string[] partes = linea.Split(',');
                    if(partes.Length == 3)
                    {
                        if (medida_origen == partes[0] && medida_destino == partes[1])
                        {
                            float valor = float.Parse(partes[2]);
                            resultado = cantidad * valor;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }
    }
}
