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
    public partial class frmDetalle : Form
    {

        //Defino el datagrid que se va a pasar a esta form al momento del initialize. 
        DataGridView dg_Seleccionado;
        public frmDetalle(DataGridView _dg_Seleccionado)
        {
            InitializeComponent();
            dg_Seleccionado = _dg_Seleccionado;
        }
        /// <summary>
        /// Cambia el tamaño de las columns a un porcentaje de la pantalla
        /// </summary>
        private void resize_Columns()
        {
            this.dg_Resumen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Resumen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Resumen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Resumen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Resumen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Resumen.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Resumen.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dg_Resumen.Columns[0].FillWeight = 4;
            this.dg_Resumen.Columns[1].FillWeight = 6;
            this.dg_Resumen.Columns[2].FillWeight = 50;
            this.dg_Resumen.Columns[3].FillWeight = 10;
            this.dg_Resumen.Columns[4].FillWeight = 10;
            this.dg_Resumen.Columns[5].FillWeight = 10;
            this.dg_Resumen.Columns[6].FillWeight = 10;
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            //Cambia el tamaño de las columnas
            this.resize_Columns();
            //Carga los datos a las columnas
            this.cargarDatos();
        }
        /// <summary>
        /// Llama a las funciones para cargar los datos al resumen.
        /// </summary>
        private void cargarDatos()
        {
            if (this.dg_Seleccionado.Rows.Count == 0)
            {
                MessageBox.Show("No existen materiales en la lista de seleccionados.");
            }
            else
            {
                sqlCommands sqlCommands = new sqlCommands();
                sqlCommands.buscarMultipleID(dg_Seleccionado, this.dg_Resumen);
            }

        }

        private void Dg_Resumen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Determina si el DataGridView esta vacio. Si esta vacio no corre las funciones. 
            helperFunctions help = new helperFunctions();
            if (!help.isDataGridEmpty(this.dg_Resumen))
            {
                clsMaterial material = new clsMaterial();
                material.id = int.Parse(this.dg_Resumen.SelectedCells[0].Value.ToString());
                frmVerMaterial frmVer = new frmVerMaterial(material);
                frmVer.ShowDialog();
            }
        }
    }
}
