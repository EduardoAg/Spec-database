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
    public partial class frmNuevaFamilia : Form
    {
        public frmNuevaFamilia()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //Definicion de las variables del formulario
            string familia = this.txt_Familia.Text;
            string descripcion = this.txt_Descripcion.Text;

            bool null_familia = string.IsNullOrWhiteSpace(familia);
            bool null_descripcion = string.IsNullOrWhiteSpace(descripcion);

            //Funciones de ayuda
            helperFunctions help = new helperFunctions();

            //Revision de valores vacios y mensaje de advertencia para el usuario
            if (help.mensajeAdvEmpty(null_familia, "la familia.")) { return; }
            if (help.mensajeAdvEmpty(null_descripcion, "la descripcion tipica.")) { return; }

            //Revision que el nombre no contenga plecas o contra plecas y mensaje de advertencia para el usuario
            if (help.mensajeAdvPleca(familia, "marca")) { return; }

            //Corre el comando SQL. Si la funcion regresa 1 fue exitoso, si regresa 0 es fallido.
            sqlCommands sql = new sqlCommands();
            int result = sql.nuevaFamilia(familia, descripcion);
            if (result == 1)
            {
                MessageBox.Show("Datos guardados exitosamente.");
                this.limpiarFormulario();
            }
        }
        private void limpiarFormulario()
        {
            this.txt_Familia.Text = "";
            this.txt_Descripcion.Text = "";
        }
    }
}
