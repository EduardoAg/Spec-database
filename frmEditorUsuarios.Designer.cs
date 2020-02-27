namespace Master_Database
{
    partial class frmEditorUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDUsuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label iDRoleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorUsuarios));
            this.usuariosDataSet = new Master_Database.UsuariosDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Master_Database.UsuariosDataSetTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new Master_Database.UsuariosDataSetTableAdapters.TableAdapterManager();
            this.usuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.usuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.iDRoleComboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesDataSet = new Master_Database.RolesDataSet();
            this.rolesTableAdapter = new Master_Database.RolesDataSetTableAdapters.rolesTableAdapter();
            this.rolesTableAdapter1 = new Master_Database.RolesDataSetTableAdapters.rolesTableAdapter();
            this.AvtivocheckBox = new System.Windows.Forms.CheckBox();
            iDUsuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            iDRoleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).BeginInit();
            this.usuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iDUsuarioLabel
            // 
            iDUsuarioLabel.AutoSize = true;
            iDUsuarioLabel.Location = new System.Drawing.Point(20, 42);
            iDUsuarioLabel.Name = "iDUsuarioLabel";
            iDUsuarioLabel.Size = new System.Drawing.Size(74, 17);
            iDUsuarioLabel.TabIndex = 1;
            iDUsuarioLabel.Text = "IDUsuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(20, 70);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(20, 98);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(72, 17);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // iDRoleLabel
            // 
            iDRoleLabel.AutoSize = true;
            iDRoleLabel.Location = new System.Drawing.Point(20, 126);
            iDRoleLabel.Name = "iDRoleLabel";
            iDRoleLabel.Size = new System.Drawing.Size(54, 17);
            iDRoleLabel.TabIndex = 7;
            iDRoleLabel.Text = "IDRole:";
            // 
            // usuariosDataSet
            // 
            this.usuariosDataSet.DataSetName = "UsuariosDataSet";
            this.usuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.usuariosDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Master_Database.UsuariosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // usuariosBindingNavigator
            // 
            this.usuariosBindingNavigator.AddNewItem = null;
            this.usuariosBindingNavigator.BindingSource = this.usuariosBindingSource;
            this.usuariosBindingNavigator.CountItem = null;
            this.usuariosBindingNavigator.DeleteItem = null;
            this.usuariosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosBindingNavigatorSaveItem});
            this.usuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuariosBindingNavigator.MoveFirstItem = null;
            this.usuariosBindingNavigator.MoveLastItem = null;
            this.usuariosBindingNavigator.MoveNextItem = null;
            this.usuariosBindingNavigator.MovePreviousItem = null;
            this.usuariosBindingNavigator.Name = "usuariosBindingNavigator";
            this.usuariosBindingNavigator.PositionItem = null;
            this.usuariosBindingNavigator.Size = new System.Drawing.Size(374, 31);
            this.usuariosBindingNavigator.TabIndex = 0;
            this.usuariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // usuariosBindingNavigatorSaveItem
            // 
            this.usuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosBindingNavigatorSaveItem.Image")));
            this.usuariosBindingNavigatorSaveItem.Name = "usuariosBindingNavigatorSaveItem";
            this.usuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(86, 28);
            this.usuariosBindingNavigatorSaveItem.Text = "Guardar";
            this.usuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.UsuariosBindingNavigatorSaveItem_Click);
            // 
            // iDUsuarioTextBox
            // 
            this.iDUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IDUsuario", true));
            this.iDUsuarioTextBox.Location = new System.Drawing.Point(100, 39);
            this.iDUsuarioTextBox.Name = "iDUsuarioTextBox";
            this.iDUsuarioTextBox.ReadOnly = true;
            this.iDUsuarioTextBox.Size = new System.Drawing.Size(121, 22);
            this.iDUsuarioTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(100, 67);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(262, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(100, 95);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(262, 22);
            this.passwordTextBox.TabIndex = 6;
            // 
            // iDRoleComboBox
            // 
            this.iDRoleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDRoleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "IDRole", true));
            this.iDRoleComboBox.DataSource = this.rolesBindingSource;
            this.iDRoleComboBox.DisplayMember = "nombre";
            this.iDRoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iDRoleComboBox.FormattingEnabled = true;
            this.iDRoleComboBox.Location = new System.Drawing.Point(100, 123);
            this.iDRoleComboBox.Name = "iDRoleComboBox";
            this.iDRoleComboBox.Size = new System.Drawing.Size(262, 24);
            this.iDRoleComboBox.TabIndex = 8;
            this.iDRoleComboBox.ValueMember = "IDRole";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.rolesDataSet;
            // 
            // rolesDataSet
            // 
            this.rolesDataSet.DataSetName = "RolesDataSet";
            this.rolesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // AvtivocheckBox
            // 
            this.AvtivocheckBox.AutoSize = true;
            this.AvtivocheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuariosBindingSource, "activo", true));
            this.AvtivocheckBox.Location = new System.Drawing.Point(100, 153);
            this.AvtivocheckBox.Name = "AvtivocheckBox";
            this.AvtivocheckBox.Size = new System.Drawing.Size(68, 21);
            this.AvtivocheckBox.TabIndex = 9;
            this.AvtivocheckBox.Text = "Activo";
            this.AvtivocheckBox.UseVisualStyleBackColor = true;
            // 
            // frmEditorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 180);
            this.Controls.Add(this.AvtivocheckBox);
            this.Controls.Add(iDUsuarioLabel);
            this.Controls.Add(this.iDUsuarioTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(iDRoleLabel);
            this.Controls.Add(this.iDRoleComboBox);
            this.Controls.Add(this.usuariosBindingNavigator);
            this.Name = "frmEditorUsuarios";
            this.Text = "Editar usuarios";
            this.Load += new System.EventHandler(this.FrmEditorUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).EndInit();
            this.usuariosBindingNavigator.ResumeLayout(false);
            this.usuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsuariosDataSet usuariosDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private UsuariosDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private UsuariosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton usuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox iDRoleComboBox;
        private RolesDataSet rolesDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private RolesDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private RolesDataSetTableAdapters.rolesTableAdapter rolesTableAdapter1;
        private System.Windows.Forms.CheckBox AvtivocheckBox;
    }
}