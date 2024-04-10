using ProyectoFisica.Clases;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFisica
{
    public partial class FrmPrincipal : Form
    {
        private Dictionary<string, Bitmap> formulas = new Dictionary<string, Bitmap>();
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
            CargarFormulasMRU();
        }

        private void CargarFormulasMRU()
        {
            mru.CargarFormulas(cbEcuaciones);
        }

        private void cbEcuaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ecuacion = cbEcuaciones.SelectedItem.ToString();
            pbEcuacion.Image = mru.ImagenFormula(ecuacion);
        }
    }
}
