using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ProyectoFisica.Clases;
using ProyectoFisica.Properties;

namespace ProyectoFisica
{
    public partial class FrmPrincipal : Form
    {
        Formulas frm = new Formulas();
        Funciones funciones = new Funciones();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /****************************** CONTROLES GENERALES ******************************/

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarCategoriaMedida();
            txtCantidad.Focus();
            lblConsideracionesFormulario.Text = "Consideraciones:\n1.La velocidad se asume como m/s\n2.El tiempo se asume como segundos\n3.La distancia se asume en metros";
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = tcPrincipal.SelectedIndex;
            switch (indice)
            {
                case 1:
                    CargarFormulasEcuacion();
                    break;
                case 2:
                    txtFuerza.Focus();
                    break;
            }
        }

        //****************************** CONVERTIDOR ******************************/
        ConvertidorMedidas cm = new ConvertidorMedidas();
        private int ultimoIndiceTipoMedida = 0;
        private void cbTipoMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoMedida.SelectedIndex != 0 &&
                ultimoIndiceTipoMedida != cbTipoMedida.SelectedIndex)
            {
                ultimoIndiceTipoMedida = cbTipoMedida.SelectedIndex;
                cm.CargarMedidas(cbOrigen, cbDestino, cbTipoMedida.Text);
                LimpiarControles();

                string medida = cbTipoMedida.SelectedItem.ToString();
                string imagen = cm.ImagenMedida(medida);
                if (File.Exists(imagen))
                {
                    pbConvertidor.ImageLocation = imagen;
                }
                else
                {
                    pbConvertidor.Image = Resources.no_encontrado;
                }
            }
            if(cbTipoMedida.SelectedIndex == 0)
            {
                pbConvertidor.Image = Resources.espera;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool error = false;
            string msj = String.Empty;
            float cantidad = 0;

            try
            {
                cantidad = float.Parse(txtCantidad.Text);
            }
            catch(Exception)
            {
                msj = "La cantidad ingresada no es numérica";
                error = true;
            }

            if( cbOrigen.SelectedIndex == 0 || cbDestino.SelectedIndex == 0)
            {
                msj = "Deben escogerse las medidas de origen y destino para convertir";
                error = true;
            }

            if (cbOrigen.SelectedIndex != cbDestino.SelectedIndex)
            {
                txtResultado.Text = cm.ConvertirMedidas(cbOrigen.Text, cbDestino.Text, cantidad).ToString();
            }
            else
            {
                if (error)
                {
                    MessageBox.Show(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtResultado.Text = txtCantidad.Text;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void CargarCategoriaMedida()
        {
            cm.CargarUnidadesDeMedida(cbTipoMedida);
            pbConvertidor.Image = Resources.espera;
        }

        private void LimpiarControles()
        {
            txtCantidad.Text = String.Empty;
            txtResultado.Text= String.Empty;
            txtCantidad.Focus();
            cbOrigen.SelectedIndex = 0;
            cbDestino.SelectedIndex = 0;
        }

        private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
        }

        private void cbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
        }

        /****************************** FORMULARIO ******************************/
        private void CargarFormulasEcuacion()
        {
            frm.CargarCategorias(cbCategoriaEcuacion);
            pbEcuacion.Image = Resources.espera;
        }

        int ultimoIndiceEcuacion = 0;
        private void cbEcuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbEcuacion.SelectedIndex != 0 &&
                    (ultimoIndiceEcuacion != cbEcuacion.SelectedIndex))
                {
                    ultimoIndiceEcuacion = cbEcuacion.SelectedIndex;
                    string ecuacion = cbEcuacion.SelectedItem.ToString();
                    string imagen = frm.BuscarImagen(ecuacion);

                    if (File.Exists(imagen))
                    {
                        pbEcuacion.ImageLocation = imagen;
                    }
                    else
                    {
                        pbEcuacion.Image = Resources.no_encontrado;
                    }
                    frm.CargarVariables(ecuacion, dgvVariables);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEcuaciones()
        {
            frm.ActualizarListaEcuaciones(cbCategoriaEcuacion.Text);
            frm.CargarEcuaciones(cbEcuacion);
        }

        private void cbCategoriaEcuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(cbCategoriaEcuacion.Text);
            if(cbCategoriaEcuacion.SelectedIndex != 0)
            {
                ActualizarEcuaciones();
            }
            else
            {
                funciones.LimpiarComboBox(cbEcuacion);
            }
            pbEcuacion.Image = Resources.espera;
        }

        private void btnActualizarEcuaciones_Click(object sender, EventArgs e)
        {
            ActualizarEcuaciones();
        }

        private void BtnCalcularEcuacion_Click(object sender, EventArgs e)
        {
            if(dgvVariables.Rows.Count > 0)
            {
                List<float> valores = new List<float>();
                foreach (DataGridViewRow row in dgvVariables.Rows)
                {
                    if (row.Cells[1].Value != null && float.TryParse(row.Cells[1].Value.ToString(), out float valor))
                    {
                        valores.Add(valor);
                    }
                    else
                    {
                        MessageBox.Show("Todos los valores deben ser números flotantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string valoresConcatenados = string.Join(",", valores);
                float resultado = frm.ResolverEcuacion(cbEcuacion.Text, valoresConcatenados);
                txtResultadoEcuacion.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("No hay variables para enviar", "Valores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /****************************** COMPONENTES EN X/Y ******************************/
        
        private void BtnCalcularcomponentes_Click(object sender, EventArgs e)
        {
            if (txtFuerza.Text.Length > 0 && txtAngulo.Text.Length > 0)
            {
                if (funciones.EsDecimal(txtFuerza.Text) && funciones.EsDecimal(txtAngulo.Text))
                {
                    double fuerza = double.Parse(txtFuerza.Text);
                    double angulo = double.Parse(txtAngulo.Text);
                    if(angulo > 360)
                    {
                        MessageBox.Show("El ángulo no puede superar los 360 grados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        angulo = angulo * Math.PI / 180;

                        txtComponenteX.Text = (fuerza * Math.Cos(angulo)).ToString();
                        txtComponenteY.Text = (fuerza * Math.Sin(angulo)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Los valores deben ser decimales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Deben llenarse todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnLimpiarComponentes_Click(object sender, EventArgs e)
        {
            txtFuerza.Text = String.Empty;
            txtAngulo.Text = String.Empty;
            txtComponenteX.Text = String.Empty;
            txtComponenteY.Text = String.Empty;
            txtFuerza.Focus();
        }


        /****************************** CREDITOS ******************************/
        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Autor: Yelsyn Hernández\n";
            mensaje += "Carnet: 9490-17-969\n";
            mensaje += "Curso: Física I\n";
            mensaje += "Catedrático: Ferrant Fuentes\n";
            mensaje += "Repositorio: https://github.com/yelsynhernandez/Proyecto-Fisica.git";
            MessageBox.Show(mensaje, "Autor", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
