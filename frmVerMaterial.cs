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
    public partial class frmVerMaterial : Form
    {
        clsMaterial clsMaterial = new clsMaterial();
        public frmVerMaterial(clsMaterial _clsMaterial)
        {
            InitializeComponent();
            clsMaterial = _clsMaterial;
        }

        private void FrmVerMaterial_Load(object sender, EventArgs e)
        {
            sqlCommands sql = new sqlCommands();
            clsMaterial = sql.buscarID(clsMaterial.id);
            this.txt_Id.Text = clsMaterial.id.ToString();
            this.txt_Familia.Text = clsMaterial.familia;
            this.txt_Marca.Text = clsMaterial.marca;
            this.txt_Catalogo.Text = clsMaterial.catalogo;
            this.txt_Comentarios.Text = clsMaterial.comentario;
            this.txt_Descripcion.Text = clsMaterial.descripcion;
            this.txt_SAP.Text = clsMaterial.codsap.ToString();
            this.txt_specCatalogo.Text = clsMaterial.speccatalogo;
            this.txt_specEnercom.Text = clsMaterial.specenercom;
            this.txt_specTexto.Text = clsMaterial.spectexto;
            this.txt_specUl.Text = clsMaterial.specul;
            this.txt_specVarias.Text = clsMaterial.specvarias;
        }

        private void Btn_openEnercom_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.openFiles(0, clsMaterial.specenercom);
        }

        private void Btn_openCatalogo_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.openFiles(1, clsMaterial.speccatalogo);
        }

        private void Btn_openUL_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.openFiles(2, clsMaterial.specul);
        }

        private void Btn_openTexto_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.openFiles(3, clsMaterial.spectexto);
        }

        private void Btn_openVarias_Click(object sender, EventArgs e)
        {
            helperFunctions help = new helperFunctions();
            help.openFiles(4, clsMaterial.specvarias);
        }
    }
}
