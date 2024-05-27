using ProyectoFisica.Properties;
using System;
using System.Windows.Forms;

namespace ProyectoFisica
{
    public partial class FrmGuiaFormulas : Form
    {
        public FrmGuiaFormulas()
        {
            InitializeComponent();
        }

        private void FrmGuiaFormulas_Load(object sender, EventArgs e)
        {
            this.pbGuiaFormulas.Image = Resources.GuiaVariables;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
