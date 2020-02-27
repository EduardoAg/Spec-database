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
    public partial class frmEditorUsuarios : Form
    {
        public bool Nuevo = false;
        public int IDUsuario = 0;
        public frmEditorUsuarios()
        {
            InitializeComponent();
        }

        private void UsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usuariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.usuariosDataSet);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void FrmEditorUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                this.rolesTableAdapter.Fill(this.rolesDataSet.roles);
                if (Nuevo)
                    this.usuariosBindingSource.AddNew();
                else
                {
                    this.usuariosTableAdapter.FillByIDUsuario(this.usuariosDataSet.usuarios, IDUsuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
