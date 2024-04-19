using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFisica.Clases
{
    internal class MRU
    {
        Funciones funciones = new Funciones();
        BD bd = new BD();
        private Dictionary<string, string> ecuacion = new Dictionary<string, string>();
        public void CargarCategorias(ComboBox cb)
        {
            funciones.LlenarComboBox(cb, "listar_categoria_formulas");
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
                        ecuacion.Add(reader["clave"].ToString(), reader["valor"].ToString());
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
                        cb.Items.Add(item.Key);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ImagenFormula(string nombre)
        {
            return ecuacion[nombre];
        }
    }

        //public double Distancia(double v, double t)
        //{
        //    return v * t;
        //}

        //public double Velocidad(double x, double t)
        //{
        //    return x / t;
        //}

        //public double Tiempo(double x, double v)
        //{
        //    return x / v;
        //}

        //public double DistanciaFinal(double Xo, double v, double t)
        //{
        //    return Xo + (v * t);
        //
}
