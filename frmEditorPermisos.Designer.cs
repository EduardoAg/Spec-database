namespace Master_Database
{
    partial class frmEditorPermisos
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
            System.Windows.Forms.Label iDRoleLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorPermisos));
            this.rolesDataSet = new Master_Database.RolesDataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Master_Database.RolesDataSetTableAdapters.rolesTableAdapter();
            this.tableAdapterManager = new Master_Database.RolesDataSetTableAdapters.TableAdapterManager();
            this.rolesPermisosTableAdapter = new Master_Database.RolesDataSetTableAdapters.rolesPermisosTableAdapter();
            this.rolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.rolesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDRoleTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.rolesPermisosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesPermisosDataGridView = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPermisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisosDataSet = new Master_Database.PermisosDataSet();
            this.permisosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permisosTableAdapter = new Master_Database.PermisosDataSetTableAdapters.permisosTableAdapter();
            this.tableAdapterManager1 = new Master_Database.PermisosDataSetTableAdapters.TableAdapterManager();
            this.permisosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Todosbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            iDRoleLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).BeginInit();
            this.rolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPermisosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPermisosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDRoleLabel
            // 
            iDRoleLabel.AutoSize = true;
            iDRoleLabel.Location = new System.Drawing.Point(25, 33);
            iDRoleLabel.Name = "iDRoleLabel";
            iDRoleLabel.Size = new System.Drawing.Size(54, 17);
            iDRoleLabel.TabIndex = 1;
            iDRoleLabel.Text = "IDRole:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(25, 61);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // rolesDataSet
            // 
            this.rolesDataSet.DataSetName = "RolesDataSet";
            this.rolesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.rolesDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.rolesPermisosTableAdapter = this.rolesPermisosTableAdapter;
            this.tableAdapterManager.rolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Master_Database.RolesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rolesPermisosTableAdapter
            // 
            this.rolesPermisosTableAdapter.ClearBeforeFill = true;
            // 
            // rolesBindingNavigator
            // 
            this.rolesBindingNavigator.AddNewItem = null;
            this.rolesBindingNavigator.BindingSource = this.rolesBindingSource;
            this.rolesBindingNavigator.CountItem = null;
            this.rolesBindingNavigator.DeleteItem = null;
            this.rolesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesBindingNavigatorSaveItem});
            this.rolesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rolesBindingNavigator.MoveFirstItem = null;
            this.rolesBindingNavigator.MoveLastItem = null;
            this.rolesBindingNavigator.MoveNextItem = null;
            this.rolesBindingNavigator.MovePreviousItem = null;
            this.rolesBindingNavigator.Name = "rolesBindingNavigator";
            this.rolesBindingNavigator.PositionItem = null;
            this.rolesBindingNavigator.Size = new System.Drawing.Size(835, 27);
            this.rolesBindingNavigator.TabIndex = 0;
            this.rolesBindingNavigator.Text = "bindingNavigator1";
            // 
            // rolesBindingNavigatorSaveItem
            // 
            this.rolesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesBindingNavigatorSaveItem.Image")));
            this.rolesBindingNavigatorSaveItem.Name = "rolesBindingNavigatorSaveItem";
            this.rolesBindingNavigatorSaveItem.Size = new System.Drawing.Size(86, 24);
            this.rolesBindingNavigatorSaveItem.Text = "Guardar";
            this.rolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.RolesBindingNavigatorSaveItem_Click);
            // 
            // iDRoleTextBox
            // 
            this.iDRoleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "IDRole", true));
            this.iDRoleTextBox.Location = new System.Drawing.Point(91, 30);
            this.iDRoleTextBox.Name = "iDRoleTextBox";
            this.iDRoleTextBox.ReadOnly = true;
            this.iDRoleTextBox.Size = new System.Drawing.Size(100, 22);
            this.iDRoleTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rolesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(91, 58);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(732, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // rolesPermisosBindingSource
            // 
            this.rolesPermisosBindingSource.DataMember = "FK_rolesPermisos_roles";
            this.rolesPermisosBindingSource.DataSource = this.rolesBindingSource;
            // 
            // rolesPermisosDataGridView
            // 
            this.rolesPermisosDataGridView.AllowUserToAddRows = false;
            this.rolesPermisosDataGridView.AllowUserToDeleteRows = false;
            this.rolesPermisosDataGridView.AutoGenerateColumns = false;
            this.rolesPermisosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesPermisosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.iDRoleDataGridViewTextBoxColumn,
            this.iDPermisoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.rolesPermisosDataGridView.DataSource = this.rolesPermisosBindingSource;
            this.rolesPermisosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesPermisosDataGridView.Location = new System.Drawing.Point(95, 0);
            this.rolesPermisosDataGridView.Name = "rolesPermisosDataGridView";
            this.rolesPermisosDataGridView.ReadOnly = true;
            this.rolesPermisosDataGridView.RowHeadersWidth = 51;
            this.rolesPermisosDataGridView.RowTemplate.Height = 24;
            this.rolesPermisosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesPermisosDataGridView.Size = new System.Drawing.Size(381, 462);
            this.rolesPermisosDataGridView.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // iDRoleDataGridViewTextBoxColumn
            // 
            this.iDRoleDataGridViewTextBoxColumn.DataPropertyName = "IDRole";
            this.iDRoleDataGridViewTextBoxColumn.HeaderText = "IDRole";
            this.iDRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRoleDataGridViewTextBoxColumn.Name = "iDRoleDataGridViewTextBoxColumn";
            this.iDRoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDPermisoDataGridViewTextBoxColumn
            // 
            this.iDPermisoDataGridViewTextBoxColumn.DataPropertyName = "IDPermiso";
            this.iDPermisoDataGridViewTextBoxColumn.HeaderText = "IDPermiso";
            this.iDPermisoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPermisoDataGridViewTextBoxColumn.Name = "iDPermisoDataGridViewTextBoxColumn";
            this.iDPermisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPermisoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // permisosDataSet
            // 
            this.permisosDataSet.DataSetName = "PermisosDataSet";
            this.permisosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permisosBindingSource
            // 
            this.permisosBindingSource.DataMember = "permisos";
            this.permisosBindingSource.DataSource = this.permisosDataSet;
            // 
            // permisosTableAdapter
            // 
            this.permisosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.permisosTableAdapter = this.permisosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Master_Database.PermisosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // permisosDataGridView
            // 
            this.permisosDataGridView.AllowUserToAddRows = false;
            this.permisosDataGridView.AllowUserToDeleteRows = false;
            this.permisosDataGridView.AutoGenerateColumns = false;
            this.permisosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permisosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permisosDataGridView.DataSource = this.permisosBindingSource;
            this.permisosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permisosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.permisosDataGridView.Name = "permisosDataGridView";
            this.permisosDataGridView.ReadOnly = true;
            this.permisosDataGridView.RowHeadersWidth = 51;
            this.permisosDataGridView.RowTemplate.Height = 24;
            this.permisosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.permisosDataGridView.Size = new System.Drawing.Size(331, 462);
            this.permisosDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 86);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.permisosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rolesPermisosDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(811, 462);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Removerbutton);
            this.panel1.Controls.Add(this.Todosbutton);
            this.panel1.Controls.Add(this.Agregarbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 462);
            this.panel1.TabIndex = 6;
            // 
            // Removerbutton
            // 
            this.Removerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Removerbutton.Location = new System.Drawing.Point(3, 395);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(86, 64);
            this.Removerbutton.TabIndex = 2;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Todosbutton
            // 
            this.Todosbutton.Location = new System.Drawing.Point(3, 74);
            this.Todosbutton.Name = "Todosbutton";
            this.Todosbutton.Size = new System.Drawing.Size(86, 61);
            this.Todosbutton.TabIndex = 1;
            this.Todosbutton.Text = "Agregar Todos";
            this.Todosbutton.UseVisualStyleBackColor = true;
            this.Todosbutton.Click += new System.EventHandler(this.Todosbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(3, 3);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(86, 65);
            this.Agregarbutton.TabIndex = 0;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // frmEditorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 560);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(iDRoleLabel);
            this.Controls.Add(this.iDRoleTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.rolesBindingNavigator);
            this.Name = "frmEditorPermisos";
            this.Text = "Editor de permisos";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).EndInit();
            this.rolesBindingNavigator.ResumeLayout(false);
            this.rolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPermisosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPermisosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisosDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RolesDataSet rolesDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private RolesDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private RolesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rolesBindingNavigator;
        private System.Windows.Forms.ToolStripButton rolesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDRoleTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private RolesDataSetTableAdapters.rolesPermisosTableAdapter rolesPermisosTableAdapter;
        private System.Windows.Forms.BindingSource rolesPermisosBindingSource;
        private System.Windows.Forms.DataGridView rolesPermisosDataGridView;
        private PermisosDataSet permisosDataSet;
        private System.Windows.Forms.BindingSource permisosBindingSource;
        private PermisosDataSetTableAdapters.permisosTableAdapter permisosTableAdapter;
        private PermisosDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView permisosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Button Todosbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPermisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}