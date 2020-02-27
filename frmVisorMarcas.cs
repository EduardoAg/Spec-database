using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Database
{
    public partial class frmVisorMarcas : Form
    {
        public frmVisorMarcas()
        {
            InitializeComponent();
        }

        private void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            frmNuevaMarca frmNuevaMarca = new frmNuevaMarca();
            frmNuevaMarca.ShowDialog();
        }
    }
}
