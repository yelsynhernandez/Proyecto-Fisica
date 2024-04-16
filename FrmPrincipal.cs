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
        }

        private void CargarFormulasMRU()
        {
            mru.CargarFormulas(cbEcuaciones);
        }

        private void CargarTipoMedida()
        {
            cm.LlenarComboBox(cbTipoMedida,"listado_categorias");
        }

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
            }            
        }
    }
}
