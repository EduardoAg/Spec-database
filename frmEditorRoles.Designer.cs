namespace Master_Database
{
    partial class frmEditorRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorRoles));
            this.rolesDataSet = new Master_Database.RolesDataSet();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Master_Database.RolesDataSetTableAdapters.rolesTableAdapter();
            this.tableAdapterManager = new Master_Database.RolesDataSetTableAdapters.TableAdapterManager();
            this.rolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.rolesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rolesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).BeginInit();
            this.rolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.rolesPermisosTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Master_Database.RolesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rolesBindingNavigator
            // 
            this.rolesBindingNavigator.AddNewItem = null;
            this.rolesBindingNavigator.BindingSource = this.rolesBindingSource;
            this.rolesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rolesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rolesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.rolesBindingNavigatorSaveItem});
            this.rolesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rolesBindingNavigator.MoveFirstItem = null;
            this.rolesBindingNavigator.MoveLastItem = null;
            this.rolesBindingNavigator.MoveNextItem = null;
            this.rolesBindingNavigator.MovePreviousItem = null;
            this.rolesBindingNavigator.Name = "rolesBindingNavigator";
            this.rolesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rolesBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.rolesBindingNavigator.TabIndex = 0;
            this.rolesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(87, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(87, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 28);
            this.toolStripButton1.Text = "Modificar";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // rolesBindingNavigatorSaveItem
            // 
            this.rolesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rolesBindingNavigatorSaveItem.Image")));
            this.rolesBindingNavigatorSaveItem.Name = "rolesBindingNavigatorSaveItem";
            this.rolesBindingNavigatorSaveItem.Size = new System.Drawing.Size(86, 28);
            this.rolesBindingNavigatorSaveItem.Text = "Guardar";
            this.rolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.RolesBindingNavigatorSaveItem_Click_1);
            // 
            // rolesDataGridView
            // 
            this.rolesDataGridView.AllowUserToAddRows = false;
            this.rolesDataGridView.AllowUserToDeleteRows = false;
            this.rolesDataGridView.AutoGenerateColumns = false;
            this.rolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.rolesDataGridView.DataSource = this.rolesBindingSource;
            this.rolesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesDataGridView.Location = new System.Drawing.Point(0, 31);
            this.rolesDataGridView.Name = "rolesDataGridView";
            this.rolesDataGridView.ReadOnly = true;
            this.rolesDataGridView.RowHeadersWidth = 51;
            this.rolesDataGridView.RowTemplate.Height = 24;
            this.rolesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesDataGridView.Size = new System.Drawing.Size(800, 423);
            this.rolesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDRole";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDRole";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmEditorRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.rolesDataGridView);
            this.Controls.Add(this.rolesBindingNavigator);
            this.Name = "frmEditorRoles";
            this.Text = "Editor de usuarios";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingNavigator)).EndInit();
            this.rolesBindingNavigator.ResumeLayout(false);
            this.rolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RolesDataSet rolesDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private RolesDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private RolesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rolesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView rolesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripButton rolesBindingNavigatorSaveItem;
    }
}