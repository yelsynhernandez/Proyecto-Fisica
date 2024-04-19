using System;
using System.IO;
using System.Windows.Forms;
using ProyectoFisica.Clases;

namespace ProyectoFisica
{
    public partial class FrmPrincipal : Form
    {
        MRU mru = new MRU();
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
            cm.CargarCategorias(cbTipoMedida);
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

        //---------------------------------------------------------------- MRU
        private void CargarFormulasMRU()
        {
            mru.CargarCategorias(cbCategoriaEcuacion);
        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = tcPrincipal.SelectedIndex;
            switch (indice)
            {
                case 1:
                    CargarFormulasMRU();
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
                    string imagen = mru.ImagenFormula(ecuacion);

                    if (File.Exists(imagen))
                    {
                        pbEcuacion.ImageLocation = imagen;
                    }
                    else
                    {
                        pbEcuacion.ImageLocation = "C:/img/no_encontrado.png";
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
                mru.ActualizarListaEcuaciones(cbCategoriaEcuacion.Text);
                mru.CargarEcuaciones(cbEcuacion);
            }
        }
    }
}
