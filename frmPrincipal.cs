using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;


namespace Master_Database
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void BtnNuevoMaterial_Click(object sender, EventArgs e)
        {
            if (globalVars.TienePermiso(globalVars.IDUsuario, globalVars.Permisos.AgregarMateriales))
            {
                frmNuevoMat frmNuevo = new frmNuevoMat();
                frmNuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
                
            
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            this.buscar_db();
        }

        /// <summary>
        /// Cambia el tamaño de las columnas a un valor porcentual del dataGridView width
        /// </summary>
        private void resizeGrid()
        {

            this.dg_Buscado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Buscado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Buscado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Buscado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Buscado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Buscado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Buscado.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dg_Buscado.Columns[0].FillWeight = 4;
            this.dg_Buscado.Columns[1].FillWeight = 4;
            this.dg_Buscado.Columns[2].FillWeight = 4;
            this.dg_Buscado.Columns[3].FillWeight = 10;
            this.dg_Buscado.Columns[4].FillWeight = 62;
            this.dg_Buscado.Columns[5].FillWeight = 10;
            this.dg_Buscado.Columns[6].FillWeight = 10;
            
        }

        private void resizeGridSelec()
        {
            this.dg_Selec.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dg_Selec.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dg_Selec.Columns[0].FillWeight = 25;
            this.dg_Selec.Columns[1].FillWeight = 75;
        }

        private void Dg_Buscado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            helperFunctions help = new helperFunctions();
            if (!help.isDataGridEmpty(this.dg_Buscado))
            {
                clsMaterial material = new clsMaterial();
                material.id = int.Parse(dg_Buscado.SelectedCells[1].Value.ToString());
                frmVerMaterial frmVer = new frmVerMaterial(material);
                frmVer.ShowDialog();
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            sqlCommands sql = new sqlCommands();
            sql.llenarListBoxMarcasFamilias(lstFamilias,lstMarcas);
            this.resizeGridSelec();
        }
        /// <summary>
        /// Regresa una lista con las marcas seleccionadas del listbox
        /// </summary> 
        /// <returns></returns>
        private List<long> listSelectedMarcas()
        {
            List<long> marcas = new List<long>();
            for (int i = 0; i < this.lstMarcas.Items.Count; i++)
            {
                if (this.lstMarcas.GetItemChecked(i))
                {
                    DataRow row = ((DataRowView)this.lstMarcas.Items[i]).Row;
                    long value = Int64.Parse((row[this.lstMarcas.ValueMember]).ToString());
                    marcas.Add(value);
                }
            }
            return marcas;
        }
        /// <summary>
        /// Regresa una lista con las familias seleccionadas del listbox
        /// </summary>
        /// <returns></returns>
        private List<long> listSelectedFamilias()
        {
            List<long> familias = new List<long>();
            for (int i = 0; i < this.lstFamilias.Items.Count; i++)
            {
                if (this.lstFamilias.GetItemChecked(i))
                {
                    DataRow row = ((DataRowView)this.lstFamilias.Items[i]).Row;
                    long value = Int64.Parse((row[this.lstFamilias.ValueMember]).ToString());
                    familias.Add(value);
                }
            }
            return familias;
        }
        private void buscar_db()
        {
            sqlCommands sql = new sqlCommands();
            helperFunctions help = new helperFunctions();

            //Orden de las operaciones al momento de buscar la base de datos. El orden es el siguiente: ID, codSap, catalogo, descripcion
            if (!(string.IsNullOrWhiteSpace(this.txt_ID.Text)))
            {
                this.dg_Buscado.DataSource = null;
                this.dg_Buscado.Rows.Clear();
                clsMaterial material = new clsMaterial();
                if (!help.mensajeAdvInt(this.txt_ID.Text, "el ID del material. Solo se aceptan numeros enteros.").boolean) { return; };
                long id = Int64.Parse(this.txt_ID.Text);
                material = sql.buscarID(id);
                this.dg_Buscado.Rows.Add("1", id, material.catalogo, material.codsap, material.descripcion, material.marca, material.familia);
                this.resizeGrid();
                dg_Buscado.Focus();
            }
            else if (!(string.IsNullOrWhiteSpace(this.txt_SAP.Text)))
            {
                this.dg_Buscado.DataSource = null;
                this.dg_Buscado.Rows.Clear();
                clsMaterial material = new clsMaterial();
                if (!help.mensajeAdvInt(this.txt_SAP.Text, "el codigo SAP del material. Solo se aceptan numeros enteros.").boolean) { return; };
                long codsap = Int64.Parse(this.txt_SAP.Text);
                material = sql.buscarPorCodigoSAP(codsap);
                this.dg_Buscado.Rows.Add("1", material.id, material.catalogo, material.codsap, material.descripcion, material.marca, material.familia);
                this.resizeGrid();
                dg_Buscado.Focus();
            }
            else if (!(string.IsNullOrWhiteSpace(this.txt_Catalogo.Text)))
            {
                this.dg_Buscado.DataSource = null;
                this.dg_Buscado.Rows.Clear();
                string catalogo = this.txt_Catalogo.Text;
                sql.buscarDB(this.txt_Catalogo.Text, this.dg_Buscado);
                this.resizeGrid();
                dg_Buscado.Focus();
            }
            else
            {
                List<long> marcas = this.listSelectedMarcas();
                List<long> familias = this.listSelectedFamilias();
                sql.buscarDBFiltrado(this.txt_Descripcion.Text, familias, marcas, this.dg_Buscado);
                this.resizeGrid();
                dg_Buscado.Focus();
            }
        }
        /// <summary>
        /// Verifica si se presiono enter
        /// </summary>
        /// <param name="e"></param>
        private void enterKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.buscar_db();
            }
        }
        
        /// <summary>
        /// Hace que el ctrl + F ponga el focus en la descripcion del material para buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
            {
                this.txt_Descripcion.Focus();
            }
        }
        /// <summary>
        /// Agrega el material al listado de materiales resumido de la derecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AgregarListado_Click(object sender, EventArgs e)
        {
            this.agregarListado();
        }
        /// <summary>
        /// Agrega al listado todas las rows seleccionadas dado que no existan en la lista secundaria
        /// </summary>
        private void agregarListado()
        {
            //El data grid principal
            DataGridView gridPrincipal = this.dg_Buscado;
            //El data grid secundario
            DataGridView gridSecundario = this.dg_Selec;
            for (int i = 0; i < gridPrincipal.SelectedRows.Count; i++)
            {
                string actual = gridPrincipal.SelectedRows[i].Cells[1].Value.ToString();
                string familia = gridPrincipal.SelectedRows[i].Cells[6].Value.ToString();
                if (!existeLista(actual))
                {
                    gridSecundario.Rows.Add(int.Parse(actual), familia);
                }
            }
        }
        /// <summary>
        /// Determina si el id seleccionado en la lista principal ya existe en la lista secundaria
        /// </summary>
        /// <param name="id">El id seleccionado de la lista principal</param>
        private bool existeLista(string id)
        {
            //El data grid de los seleccionados
            DataGridView dgSelec = this.dg_Selec;
            for (int i = 0; i < dgSelec.Rows.Count; i++)
            {
                string actual = dgSelec.Rows[i].Cells[0].Value.ToString();
                if (actual == id)
                {
                    return true;
                }
            }
            return false;
        }
        //Boton para remover los items seleccionados de la lista
        private void Btn_RmvListado_Click(object sender, EventArgs e)
        {
            this.removeListado(this.dg_Selec);
        }
        /// <summary>
        /// Remueve las rows seleccionadas del dataGrid
        /// </summary>
        /// <param name="dataGrid">El DataGridView del cual se remueven las rows</param>
        private void removeListado(DataGridView dataGrid)
        {
            foreach (DataGridViewRow item in dataGrid.SelectedRows)
            {
                dataGrid.Rows.RemoveAt(item.Index);
            }
        }

        private void Btn_VerDetalle_Click(object sender, EventArgs e)
        {
            frmDetalle frmDetalle = new frmDetalle(this.dg_Selec);
            frmDetalle.ShowDialog();
        }

        private void Btn_BorrarMaterial_Click(object sender, EventArgs e)
        {
            if (globalVars.TienePermiso(globalVars.IDUsuario, globalVars.Permisos.EliminarMateriales))
            {

            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
        }

        private void Dg_Selec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            helperFunctions help = new helperFunctions();
            if (!help.isDataGridEmpty(this.dg_Selec))
            {
                clsMaterial material = new clsMaterial();
                material.id = int.Parse(dg_Selec.SelectedCells[0].Value.ToString());
                frmVerMaterial frmVer = new frmVerMaterial(material);
                frmVer.ShowDialog();
            }
            
        }

        private void Btn_Descargar_Click(object sender, EventArgs e)
        {
            if (this.dg_Selec.Rows.Count == 0)
            {
                MessageBox.Show("Necesita seleccionar al menos un material para descargar los archivos asociados.");
            }
            else
            {
                helperFunctions help = new helperFunctions();
                sqlCommands sql = new sqlCommands();
                help.descargarArchivos(sql.buscarDirectoriosID(this.dg_Selec));
            }
        }

        private void Btn_CargarListadoMateriales_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePick = new OpenFileDialog();
            DialogResult resultado1 = filePick.ShowDialog();
            filePick.CheckFileExists = true;
            filePick.CheckPathExists = true;
            string filePath = filePick.FileName;
            string ultimaFila;
            string nombreHoja;

            if (resultado1 == DialogResult.OK)
            {
                using (var form = new frmUltimaFila())
                {

                    Excel.Application excelApp = new Excel.Application();
                    string workbookPath = filePath;
                    Excel.Workbook excelWorkbook = null;
                    excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                    foreach (Excel.Worksheet worksheet in excelWorkbook.Worksheets)
                    {
                        form.cmbListado.Items.Add(worksheet.Name);
                    }
                    excelWorkbook.Close(false);
                    excelApp.Quit();


                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ultimaFila = form.ultimaFila;
                        nombreHoja = form.nombreHoja;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                return;
            }
            
            //Hace la conexion con el archivo de excel 
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = '" + filePath + "';Extended Properties=\"Excel 8.0;HDR=NO;\"";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + nombreHoja + "$K2:K" + ultimaFila + "]", conn);
                OleDbDataAdapter objDA = new OleDbDataAdapter(cmd);

                DataSet excelDataSet = new DataSet();
                objDA.Fill(excelDataSet);
                foreach (DataTable table in excelDataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            if (!(string.IsNullOrWhiteSpace(item.ToString())) && int.Parse(item.ToString()) != 0)
                            {
                                dg_Selec.Rows.Add(item.ToString());
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Evento keyDown del txt_descripcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_Descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            this.enterKey(e);
        }
        /// <summary>
        /// Evento keyDown del txt_SAP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_SAP_KeyDown(object sender, KeyEventArgs e)
        {
            this.enterKey(e);
        }
        /// <summary>
        /// Evento keyDown del txt_Cataogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_Catalogo_KeyDown(object sender, KeyEventArgs e)
        {
            this.enterKey(e);
        }
        /// <summary>
        /// Evento keyDown del txt_Cataogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            this.enterKey(e);
        }

        private void RolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globalVars.TienePermiso(globalVars.IDUsuario, globalVars.Permisos.AdministrarRoles))
            {
                frmEditorRoles roles = new frmEditorRoles();
                roles.Show();
            }
            else
                MessageBox.Show("Acceso Denegado");
            
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globalVars.TienePermiso(globalVars.IDUsuario,globalVars.Permisos.AdministrarUsuarios))
            {
                frmVisorUsuarios usuarios = new frmVisorUsuarios();
                usuarios.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

    }
}
