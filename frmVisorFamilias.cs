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
    public partial class frmVisorFamilias : Form
    {
        public frmVisorFamilias()
        {
            InitializeComponent();
        }

        private void BtnNuevaFamilia_Click(object sender, EventArgs e)
        {
            frmNuevaFamilia frmNuevaFamilia = new frmNuevaFamilia();
            frmNuevaFamilia.ShowDialog();
        }
    }
}
