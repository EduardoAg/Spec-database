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
    public partial class frmUltimaFila : Form
    {

        public string ultimaFila { get; set; }
        public string nombreHoja { get; set; }
        public frmUltimaFila()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.ultimaFila = this.txt_UltimaFila.Text;
            this.nombreHoja = this.cmbListado.Text;
            
            helperFunctions help = new helperFunctions();

            bool null_ultimaFila = string.IsNullOrWhiteSpace(this.txt_UltimaFila.Text);
            bool null_nombreHoja = string.IsNullOrWhiteSpace(this.cmbListado.Text);

            if (help.mensajeAdvEmpty(null_nombreHoja, "el nombre de la hoja."))
            {
                return;
            }
            else if (help.mensajeAdvEmpty(null_ultimaFila, "la ultima fila del corrido de materiales."))
            {
                return;
            }
            else if (!help.mensajeAdvInt(this.txt_UltimaFila.Text, "la ultima fila del corrido de materiales. Solo se aceptan numeros enteros.").boolean)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
