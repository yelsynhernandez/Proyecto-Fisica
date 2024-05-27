using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFisica.Clases
{
    internal class Formulas
    {
        Funciones funciones = new Funciones();
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
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            if(diccionarioVariables.ContainsKey(_ecuacion))
            {
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
        }

        public float ResolverEcuacion(string nombre_ecuacion, string valores)
        {
            float resultado = 0;
            try
            {
                if (!diccionarioEcuaciones.ContainsKey(nombre_ecuacion))
                {
                    throw new ArgumentException("No se ha configurado la ecuación para operar");
                }

                //primero obtener la ecuacion
                string ecuacion = diccionarioFormulas[nombre_ecuacion];
                //Variables de la ecuacion
                string variables = diccionarioVariables[nombre_ecuacion];
                string[] arrayVariables = variables.Split(',');
                //Variables enviadas
                string[] arrayValores = valores.Split(',');

                if(arrayVariables.Length != arrayValores.Length)
                {
                    throw new ArgumentException("La cantidad de parámetros no coincide con las variables necesarias");
                }

                Console.WriteLine($"Ecuacion antes del reemplazo: {ecuacion}");
                for (int i = 0; i < arrayVariables.Length; i++)
                {
                    ecuacion = ecuacion.Replace(arrayVariables[i], arrayValores[i]);
                }

                //Luego de realizarse el reemplazo se ejecuta la consulta
                using (var dataTable = new System.Data.DataTable())
                {
                    try
                    {
                        var calculo = dataTable.Compute(ecuacion, string.Empty);
                        resultado = float.Parse(calculo.ToString());
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException("Error al evaluar la ecuación: " + ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
    }
}
