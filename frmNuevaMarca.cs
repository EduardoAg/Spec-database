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
    public partial class frmNuevaMarca : Form
    {
        public frmNuevaMarca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guarda una nueva marca en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //Definicion de las variables del formulario
            string marca = this.txt_Marca.Text;

            bool null_marca = string.IsNullOrWhiteSpace(marca);

            //Funciones de ayuda
            helperFunctions help = new helperFunctions();

            //Revision de valores vacios y mensaje de advertencia para el usuario
            if (help.mensajeAdvEmpty(null_marca, "la marca.")) { return; }

            //Revision que el nombre no contenga plecas o contra plecas y mensaje de advertencia para el usuario
            if (help.mensajeAdvPleca(marca, "marca")) { return; }

            //Corre el comando SQL. Si la funcion regresa 1 fue exitoso, si regresa 0 es fallido.
            sqlCommands sql = new sqlCommands();
            int result = sql.nuevaMarca(marca);
            if (result == 1)
            {
                MessageBox.Show("Datos guardados exitosamente.");
                this.limpiarFormulario();
            }
        }

        private void limpiarFormulario()
        {
            this.txt_Marca.Text = "";
        }
    }
}
