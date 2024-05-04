using System;
using System.IO;
using System.Windows.Forms;
using ProyectoFisica.Clases;
using ProyectoFisica.Properties;

namespace ProyectoFisica
{
    public partial class FrmPrincipal : Form
    {
        Formulas frm = new Formulas();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarCategoriaMedida();
            txtCantidad.Focus();
        }

        //----------------------------------------------- Convertidor
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

        //---------------------------------------------------------------- frm
        private void CargarFormulasfrm()
        {
            frm.CargarCategorias(cbCategoriaEcuacion);
            cbEcuacion.Enabled = false;
            pbEcuacion.Image = Resources.espera;
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = tcPrincipal.SelectedIndex;
            switch (indice)
            {
                case 1:
                    CargarFormulasfrm();
                    break;
                case 2:
                    txtFuerza.Focus();
                    break;
            }
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
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCategoriaFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategoriaEcuacion.SelectedIndex != 0)
            {
                pbEcuacion.Image = Resources.espera;
                frm.ActualizarListaEcuaciones(cbCategoriaEcuacion.Text);
                frm.CargarEcuaciones(cbEcuacion);
                cbEcuacion.Enabled = true;
            }
        }

        //***************************************** Componentes en X y Y
        public static bool EsDecimal(string texto)
        {
            decimal valor;
            return decimal.TryParse(texto, out valor);
        }
        private void btnCalcularcomponentes_Click(object sender, EventArgs e)
        {
            if (txtFuerza.Text.Length > 0 && txtAngulo.Text.Length > 0)
            {
                if (EsDecimal(txtFuerza.Text) && EsDecimal(txtAngulo.Text))
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

        private void btnLimpiarComponentes_Click(object sender, EventArgs e)
        {
            txtFuerza.Text = String.Empty;
            txtAngulo.Text = String.Empty;
            txtComponenteX.Text = String.Empty;
            txtComponenteY.Text = String.Empty;
            txtFuerza.Focus();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
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
