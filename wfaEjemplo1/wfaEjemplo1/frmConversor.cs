using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEjemplo1
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {

        }

        Funciones fnc = new Funciones(); 
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            txtSalida.Text = fnc.DecBin(int.Parse(txtEntrada.Text));
        }
    }
}
