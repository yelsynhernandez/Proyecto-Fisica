using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoFisica.Clases;

namespace ProyectoFisica
{
    public partial class FrmPrincipal : Form
    {
        private Dictionary<string, Bitmap> formulas = new Dictionary<string, Bitmap>();
        MRU mru = new MRU();
        ConvertidorMedidas  cm = new ConvertidorMedidas();
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
            CargarFormulasMRU();
            CargarTipoMedida();
            txtCantidad.Focus();
        }

        //----------------------------------------------- Convertidor
        private void cbEcuaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ecuacion = cbEcuaciones.SelectedItem.ToString();
            pbEcuacion.Image = mru.ImagenFormula(ecuacion);
        }

        private void cbTipoMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipoMedida.SelectedIndex != 0)
            {
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
        private void CargarTipoMedida()
        {
            cm.LlenarComboBox(cbTipoMedida);
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
            mru.CargarFormulas(cbEcuaciones);
        }
    }
}
