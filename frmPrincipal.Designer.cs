namespace Master_Database
{
    partial class frmPrincipal
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lstFamilias = new System.Windows.Forms.CheckedListBox();
            this.lstMarcas = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoMaterial = new System.Windows.Forms.Button();
            this.btn_BorrarMaterial = new System.Windows.Forms.Button();
            this.btn_CargarListadoMateriales = new System.Windows.Forms.Button();
            this.btn_AgregarListado = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Catalogo = new System.Windows.Forms.TextBox();
            this.txt_SAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dg_Buscado = new System.Windows.Forms.DataGridView();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Descargar = new System.Windows.Forms.Button();
            this.btn_VerDetalle = new System.Windows.Forms.Button();
            this.btn_RmvListado = new System.Windows.Forms.Button();
            this.dg_Selec = new System.Windows.Forms.DataGridView();
            this.id_selec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_Selec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tstripUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripItemRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Buscado)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Selec)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 654F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 654);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lstFamilias, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lstMarcas, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(101, 648);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lstFamilias
            // 
            this.lstFamilias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFamilias.FormattingEnabled = true;
            this.lstFamilias.HorizontalScrollbar = true;
            this.lstFamilias.Location = new System.Drawing.Point(3, 3);
            this.lstFamilias.Name = "lstFamilias";
            this.lstFamilias.Size = new System.Drawing.Size(95, 318);
            this.lstFamilias.TabIndex = 0;
            // 
            // lstMarcas
            // 
            this.lstMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMarcas.FormattingEnabled = true;
            this.lstMarcas.HorizontalScrollbar = true;
            this.lstMarcas.Location = new System.Drawing.Point(3, 327);
            this.lstMarcas.Name = "lstMarcas";
            this.lstMarcas.Size = new System.Drawing.Size(95, 318);
            this.lstMarcas.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(110, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 648);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnNuevoMaterial, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_BorrarMaterial, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_CargarListadoMateriales, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_AgregarListado, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 611);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(844, 34);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // btnNuevoMaterial
            // 
            this.btnNuevoMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoMaterial.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoMaterial.Name = "btnNuevoMaterial";
            this.btnNuevoMaterial.Size = new System.Drawing.Size(205, 28);
            this.btnNuevoMaterial.TabIndex = 0;
            this.btnNuevoMaterial.Text = "Nuevo material";
            this.btnNuevoMaterial.UseVisualStyleBackColor = true;
            this.btnNuevoMaterial.Click += new System.EventHandler(this.BtnNuevoMaterial_Click);
            // 
            // btn_BorrarMaterial
            // 
            this.btn_BorrarMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BorrarMaterial.Location = new System.Drawing.Point(214, 3);
            this.btn_BorrarMaterial.Name = "btn_BorrarMaterial";
            this.btn_BorrarMaterial.Size = new System.Drawing.Size(205, 28);
            this.btn_BorrarMaterial.TabIndex = 1;
            this.btn_BorrarMaterial.Text = "Borrar material";
            this.btn_BorrarMaterial.UseVisualStyleBackColor = true;
            this.btn_BorrarMaterial.Click += new System.EventHandler(this.Btn_BorrarMaterial_Click);
            // 
            // btn_CargarListadoMateriales
            // 
            this.btn_CargarListadoMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CargarListadoMateriales.Location = new System.Drawing.Point(425, 3);
            this.btn_CargarListadoMateriales.Name = "btn_CargarListadoMateriales";
            this.btn_CargarListadoMateriales.Size = new System.Drawing.Size(205, 28);
            this.btn_CargarListadoMateriales.TabIndex = 2;
            this.btn_CargarListadoMateriales.Text = "Cargar listado materiales";
            this.btn_CargarListadoMateriales.UseVisualStyleBackColor = true;
            this.btn_CargarListadoMateriales.Click += new System.EventHandler(this.Btn_CargarListadoMateriales_Click);
            // 
            // btn_AgregarListado
            // 
            this.btn_AgregarListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AgregarListado.Location = new System.Drawing.Point(636, 3);
            this.btn_AgregarListado.Name = "btn_AgregarListado";
            this.btn_AgregarListado.Size = new System.Drawing.Size(205, 28);
            this.btn_AgregarListado.TabIndex = 3;
            this.btn_AgregarListado.Text = "Agregar a listado temporal";
            this.btn_AgregarListado.UseVisualStyleBackColor = true;
            this.btn_AgregarListado.Click += new System.EventHandler(this.Btn_AgregarListado_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dg_Buscado, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(844, 602);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btn_Buscar, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(838, 74);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Buscar.Location = new System.Drawing.Point(741, 3);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(94, 68);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(732, 68);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txt_Descripcion, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(726, 28);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Descripcion.Location = new System.Drawing.Point(95, 3);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(628, 22);
            this.txt_Descripcion.TabIndex = 1;
            this.txt_Descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Descripcion_KeyDown);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 6;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.txt_Catalogo, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.txt_SAP, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.txt_ID, 5, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(726, 28);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "# Catalogo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "SAP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Catalogo
            // 
            this.txt_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Catalogo.Location = new System.Drawing.Point(95, 3);
            this.txt_Catalogo.Name = "txt_Catalogo";
            this.txt_Catalogo.Size = new System.Drawing.Size(178, 22);
            this.txt_Catalogo.TabIndex = 3;
            this.txt_Catalogo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Catalogo_KeyDown);
            // 
            // txt_SAP
            // 
            this.txt_SAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SAP.Location = new System.Drawing.Point(328, 3);
            this.txt_SAP.Name = "txt_SAP";
            this.txt_SAP.Size = new System.Drawing.Size(178, 22);
            this.txt_SAP.TabIndex = 4;
            this.txt_SAP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SAP_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ID.Location = new System.Drawing.Point(545, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(178, 22);
            this.txt_ID.TabIndex = 7;
            this.txt_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ID_KeyDown);
            // 
            // dg_Buscado
            // 
            this.dg_Buscado.AllowUserToAddRows = false;
            this.dg_Buscado.AllowUserToDeleteRows = false;
            this.dg_Buscado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Buscado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Buscado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.score,
            this.id,
            this.sap,
            this.catalogo,
            this.descripcion,
            this.marca,
            this.familia});
            this.dg_Buscado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Buscado.Location = new System.Drawing.Point(3, 83);
            this.dg_Buscado.Name = "dg_Buscado";
            this.dg_Buscado.ReadOnly = true;
            this.dg_Buscado.RowHeadersVisible = false;
            this.dg_Buscado.RowHeadersWidth = 51;
            this.dg_Buscado.RowTemplate.Height = 24;
            this.dg_Buscado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dg_Buscado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Buscado.ShowCellToolTips = false;
            this.dg_Buscado.Size = new System.Drawing.Size(838, 516);
            this.dg_Buscado.TabIndex = 1;
            this.dg_Buscado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dg_Buscado_MouseDoubleClick);
            // 
            // score
            // 
            this.score.HeaderText = "#";
            this.score.MinimumWidth = 6;
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // sap
            // 
            this.sap.HeaderText = "SAP";
            this.sap.MinimumWidth = 6;
            this.sap.Name = "sap";
            this.sap.ReadOnly = true;
            // 
            // catalogo
            // 
            this.catalogo.HeaderText = "Catalogo";
            this.catalogo.MinimumWidth = 6;
            this.catalogo.Name = "catalogo";
            this.catalogo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // familia
            // 
            this.familia.HeaderText = "Familia";
            this.familia.MinimumWidth = 6;
            this.familia.Name = "familia";
            this.familia.ReadOnly = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.btn_Descargar, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.btn_VerDetalle, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.btn_RmvListado, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.dg_Selec, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(966, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 4;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(102, 648);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // btn_Descargar
            // 
            this.btn_Descargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Descargar.Location = new System.Drawing.Point(3, 614);
            this.btn_Descargar.Name = "btn_Descargar";
            this.btn_Descargar.Size = new System.Drawing.Size(96, 31);
            this.btn_Descargar.TabIndex = 4;
            this.btn_Descargar.Text = "Descargar";
            this.btn_Descargar.UseVisualStyleBackColor = true;
            this.btn_Descargar.Click += new System.EventHandler(this.Btn_Descargar_Click);
            // 
            // btn_VerDetalle
            // 
            this.btn_VerDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VerDetalle.Location = new System.Drawing.Point(3, 540);
            this.btn_VerDetalle.Name = "btn_VerDetalle";
            this.btn_VerDetalle.Size = new System.Drawing.Size(96, 31);
            this.btn_VerDetalle.TabIndex = 1;
            this.btn_VerDetalle.Text = "Ver detalle";
            this.btn_VerDetalle.UseVisualStyleBackColor = true;
            this.btn_VerDetalle.Click += new System.EventHandler(this.Btn_VerDetalle_Click);
            // 
            // btn_RmvListado
            // 
            this.btn_RmvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RmvListado.Location = new System.Drawing.Point(3, 577);
            this.btn_RmvListado.Name = "btn_RmvListado";
            this.btn_RmvListado.Size = new System.Drawing.Size(96, 31);
            this.btn_RmvListado.TabIndex = 2;
            this.btn_RmvListado.Text = "Remover";
            this.btn_RmvListado.UseVisualStyleBackColor = true;
            this.btn_RmvListado.Click += new System.EventHandler(this.Btn_RmvListado_Click);
            // 
            // dg_Selec
            // 
            this.dg_Selec.AllowUserToAddRows = false;
            this.dg_Selec.AllowUserToDeleteRows = false;
            this.dg_Selec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Selec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Selec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_selec,
            this.fam_Selec});
            this.dg_Selec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Selec.Location = new System.Drawing.Point(3, 3);
            this.dg_Selec.Name = "dg_Selec";
            this.dg_Selec.ReadOnly = true;
            this.dg_Selec.RowHeadersVisible = false;
            this.dg_Selec.RowHeadersWidth = 51;
            this.dg_Selec.RowTemplate.Height = 24;
            this.dg_Selec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Selec.Size = new System.Drawing.Size(96, 531);
            this.dg_Selec.TabIndex = 3;
            this.dg_Selec.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dg_Selec_MouseDoubleClick);
            // 
            // id_selec
            // 
            this.id_selec.HeaderText = "ID";
            this.id_selec.MinimumWidth = 6;
            this.id_selec.Name = "id_selec";
            this.id_selec.ReadOnly = true;
            // 
            // fam_Selec
            // 
            this.fam_Selec.HeaderText = "Familia";
            this.fam_Selec.MinimumWidth = 6;
            this.fam_Selec.Name = "fam_Selec";
            this.fam_Selec.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripUsuarios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tstripUsuarios
            // 
            this.tstripUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripItemRoles,
            this.tStripItemUsuarios});
            this.tstripUsuarios.Name = "tstripUsuarios";
            this.tstripUsuarios.Size = new System.Drawing.Size(79, 24);
            this.tstripUsuarios.Text = "Usuarios";
            // 
            // tStripItemRoles
            // 
            this.tStripItemRoles.Name = "tStripItemRoles";
            this.tStripItemRoles.Size = new System.Drawing.Size(148, 26);
            this.tStripItemRoles.Text = "Roles";
            this.tStripItemRoles.Click += new System.EventHandler(this.RolesToolStripMenuItem_Click);
            // 
            // tStripItemUsuarios
            // 
            this.tStripItemUsuarios.Name = "tStripItemUsuarios";
            this.tStripItemUsuarios.Size = new System.Drawing.Size(148, 26);
            this.tStripItemUsuarios.Text = "Usuarios";
            this.tStripItemUsuarios.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Base de especificaciones";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Buscado)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Selec)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox lstFamilias;
        private System.Windows.Forms.CheckedListBox lstMarcas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnNuevoMaterial;
        private System.Windows.Forms.Button btn_BorrarMaterial;
        private System.Windows.Forms.Button btn_CargarListadoMateriales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Buscado;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Catalogo;
        private System.Windows.Forms.TextBox txt_SAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_AgregarListado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btn_VerDetalle;
        private System.Windows.Forms.Button btn_RmvListado;
        private System.Windows.Forms.DataGridView dg_Selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_selec;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_Selec;
        private System.Windows.Forms.Button btn_Descargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sap;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn familia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstripUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tStripItemRoles;
        private System.Windows.Forms.ToolStripMenuItem tStripItemUsuarios;
    }
}

