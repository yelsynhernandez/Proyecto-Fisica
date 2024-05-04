﻿using System;
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
        //private Dictionary<string, string> ecuacion = new Dictionary<string, string>();ç
        List<Tuple<string, string, string>> ecuacion = new List<Tuple<string, string, string>>();
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
                        ecuacion.Add(Tuple.Create(reader["formula"].ToString(), reader["imagen"].ToString(), reader["variables"].ToString()));
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
            cb.SelectedIndex = 0;
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
        }

        //public string ImagenFormula(string nombre)
        //{
        //    return ecuacion[nombre];
        //}
        public string BuscarImagen(string _ecuacion)
        {
            // Buscar la coincidencia en el ítem 2 de cada tupla
            var tuplaEncontrada = ecuacion.FirstOrDefault(t => t.Item1 == _ecuacion);

            // Si se encuentra la coincidencia, devolver el ítem 3 de la tupla
            if (tuplaEncontrada != null)
            {
                return tuplaEncontrada.Item2;
            }
            else
            {
                return null; // Devolver null si no se encuentra la imagen
            }
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