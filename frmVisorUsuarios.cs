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
    public partial class frmVisorUsuarios : Form
    {
        public frmVisorUsuarios()
        {
            InitializeComponent();
        }

        private void FrmEditorUsuarios_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                this.usuariosTableAdapter.FillByConRole(this.usuariosDataSet.usuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void UsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmEditorUsuarios frmNew = new frmEditorUsuarios();
            frmNew.Nuevo = true;
            frmNew.ShowDialog();
            CargarDatos();
        }

        private void ModificartoolStripButton_Click(object sender, EventArgs e)
        {
            DataRowView Linea = (DataRowView)this.usuariosBindingSource.Current;
            frmEditorUsuarios frmNew = new frmEditorUsuarios();
            frmNew.Nuevo = false;
            frmNew.IDUsuario = (int)Linea["IDUsuario"];
            frmNew.ShowDialog();
            CargarDatos();
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta completamente seguro que desea eliminar el usuario seleccionado?\nEste proceso es IRREVERSIBLE.","Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.usuariosBindingSource.RemoveCurrent();
                try
                {
                    this.Validate();
                    this.usuariosBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.usuariosDataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }
    }
}
