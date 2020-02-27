using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Master_Database
{
    public partial class frmNuevoMat : Form
    {
        public frmNuevoMat()
        {
            InitializeComponent();
        }

        private void BtnEditarMarcas_Click(object sender, EventArgs e)
        {
            frmVisorMarcas frmVisorMarcas = new frmVisorMarcas();
            frmVisorMarcas.ShowDialog();
        }

        private void BtnEditarFamilias_Click(object sender, EventArgs e)
        {
            frmVisorFamilias frmVisorFamilias = new frmVisorFamilias();
            frmVisorFamilias.ShowDialog();
        }

        private void Btn_guardarNuevoMat_Click(object sender, EventArgs e)
        {
            this.nuevoMaterial();
        }

        //Funcion para el guardado de materiales
        private void nuevoMaterial()
        {
            
            //Funciones de ayuda
            helperFunctions help = new helperFunctions();

            //Extrae la informacion del combobox. El value y el text.
            keyValue dtMarca = help.validarCombos(cmb_Marca);
            keyValue dtFamilia = help.validarCombos(cmb_Familia);

            //Definicion de las variables del formulario
            string catalogo = this.txt_Catalogo.Text;
            string codigosap = this.txt_SAP.Text;
            string marca = dtMarca.Text;
            string familia = dtFamilia.Text;
            string descripcion = this.txt_Descripcion.Text;
            string comentarios = this.txt_Comentarios.Text;
            string specenercom = this.txt_specEnercom.Text;
            string speccatalogo = this.txt_specCatalogo.Text;
            string specul = this.txt_specUl.Text;
            string spectexto = this.txt_specUl.Text;
            string specvarias = this.txt_specVarias.Text;
            int idMarca = dtMarca.Value;
            int idFamilia = dtMarca.Value;

            //Validacion de variables
            bool null_catalogo = string.IsNullOrWhiteSpace(catalogo);
            bool null_codigosap = string.IsNullOrWhiteSpace(codigosap);
            bool null_marca = string.IsNullOrWhiteSpace(marca);
            bool null_familia = string.IsNullOrWhiteSpace(familia);
            bool null_descripcion = string.IsNullOrWhiteSpace(descripcion);
            bool null_comentarios = string.IsNullOrWhiteSpace(comentarios);
            bool null_specenercom = string.IsNullOrWhiteSpace(specenercom);
            bool null_speccatalogo = string.IsNullOrWhiteSpace(speccatalogo);
            bool null_specul = string.IsNullOrWhiteSpace(specul);
            bool null_spectexto = string.IsNullOrWhiteSpace(spectexto);
            bool null_specvarias = string.IsNullOrWhiteSpace(specvarias);

            //Revision de valores vacios y mensaje de advertencia para el usuario
            if (help.mensajeAdvEmpty(null_marca, "la marca.")) { return; }
            if (help.mensajeAdvEmpty(null_familia, "la familia.")) { return; }
            if (help.mensajeAdvEmpty(null_descripcion, "la descripcion.")) { return; }

            //Revision de valores que solo pueden ser de tipo int como el codigo SAP
            keyBoolean resultado = help.mensajeAdvSap(codigosap, "el codigo SAP. Solo se pueden ingresar numeros enteros.");
            if (!resultado.boolean) { return; }

            //Guardado de codigo SAP a integer
            int intCodigosap = resultado.key;

            //Guardado de los items que son strings en listas para pasarlos al SQL 
            List<string> strCampos = new List<string>() {catalogo, descripcion, comentarios, specenercom, speccatalogo,
            specul, spectexto, specvarias, familia, marca};

            //Guardado de los items que son ints en listas para pasarlos al SQL 
            List<int> intCampos = new List<int>() {idFamilia, idMarca, intCodigosap};

            //Guardado de las validaciones de strings en lista para pasarlos al SQL 
            List<bool> null_strCampos = new List<bool>() {null_catalogo, null_descripcion, null_comentarios, null_specenercom,
            null_speccatalogo, null_specul, null_spectexto, null_specvarias};

            //Guardado de las validaciones de strings en lista para pasarlos al SQL 
            List<bool> null_intCampos = new List<bool>() {null_marca, null_familia, null_codigosap};

            //Corre el comando SQL. Si la funcion regresa 1 fue exitoso, si regresa 0 es fallido.
            sqlCommands sql = new sqlCommands();
            int result = sql.nuevoMaterial(strCampos, intCampos, null_strCampos, null_intCampos);
            if (result == 1)
            {
                MessageBox.Show("Datos guardados exitosamente.");
                this.limpiarFormulario();
            }
        }

        private void limpiarFormulario()
        {
            this.txt_Catalogo.Text = "";
            this.txt_Comentarios.Text = "";
            this.txt_Descripcion.Text = "";
            this.txt_SAP.Text = "";
            this.txt_specCatalogo.Text = "";
            this.txt_specEnercom.Text = "";
            this.txt_specTexto.Text = "";
            this.txt_specUl.Text = "";
            this.txt_specVarias.Text = "";
            this.cmb_Familia.SelectedIndex = -1;
            this.cmb_Marca.SelectedIndex = -1;
        }

        private void FrmNuevoMat_Load(object sender, EventArgs e)
        {
            sqlCommands sql = new sqlCommands();
            sql.llenarMarcasFamilias(this.cmb_Familia, this.cmb_Marca);
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botones de los filepickers
        private void Btn_browEnercom_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.mostrarFilePicker(this.txt_specEnercom);
        }
        private void Btn_browCatalogo_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.mostrarFilePicker(this.txt_specCatalogo);
        }
        private void Btn_browUL_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.mostrarFilePicker(this.txt_specUl);
        }
        private void Btn_browTexto_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.mostrarFilePicker(this.txt_specTexto);
        }
        private void Btn_browVarias_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.mostrarFilePicker(this.txt_specVarias);
        }

        //Llena la descripciono tipica en el textbox de la descripcion
        private void Btn_descTipica_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            this.txt_Descripcion.Text = help.getDescTipica(this.cmb_Familia);
        }
    }
}
