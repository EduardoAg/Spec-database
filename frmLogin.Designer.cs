namespace Master_Database
{
    partial class frmLogin
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
            this.UsuarioslistBox = new System.Windows.Forms.ListBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataSet = new Master_Database.UsuariosDataSet();
            this.usuariosTableAdapter = new Master_Database.UsuariosDataSetTableAdapters.usuariosTableAdapter();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioslistBox
            // 
            this.UsuarioslistBox.DataSource = this.usuariosBindingSource;
            this.UsuarioslistBox.DisplayMember = "nombre";
            this.UsuarioslistBox.FormattingEnabled = true;
            this.UsuarioslistBox.ItemHeight = 16;
            this.UsuarioslistBox.Location = new System.Drawing.Point(12, 25);
            this.UsuarioslistBox.Name = "UsuarioslistBox";
            this.UsuarioslistBox.Size = new System.Drawing.Size(340, 212);
            this.UsuarioslistBox.TabIndex = 0;
            this.UsuarioslistBox.ValueMember = "IDUsuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.usuariosDataSet;
            // 
            // usuariosDataSet
            // 
            this.usuariosDataSet.DataSetName = "UsuariosDataSet";
            this.usuariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(12, 260);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '•';
            this.PasswordtextBox.Size = new System.Drawing.Size(340, 22);
            this.PasswordtextBox.TabIndex = 1;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Location = new System.Drawing.Point(160, 288);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(93, 31);
            this.Aceptarbutton.TabIndex = 2;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Location = new System.Drawing.Point(259, 288);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(93, 31);
            this.Cancelarbutton.TabIndex = 3;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(364, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UsuarioslistBox);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UsuarioslistBox;
        private UsuariosDataSet usuariosDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private UsuariosDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}