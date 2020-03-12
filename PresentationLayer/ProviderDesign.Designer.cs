namespace PresentationLayer
{
    partial class ProviderDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderDesign));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this._IDEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EMPRUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EMPDIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CODPOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PROVEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CIUDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._TELEF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDRUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RUBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDACTEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ACTEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.dataGridReportes);
            this.groupBox6.Location = new System.Drawing.Point(12, 117);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1067, 409);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            // 
            // dataGridReportes
            // 
            this.dataGridReportes.AllowUserToAddRows = false;
            this.dataGridReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._IDEMP,
            this._RUC,
            this._EMPRUB,
            this._EMPDIR,
            this._CODPOST,
            this._PAIS,
            this._PROVEMP,
            this._CIUDAD,
            this._TELEF,
            this._EMAIL,
            this._IDRUB,
            this._RUBRO,
            this._IDACTEMP,
            this._ACTEMP});
            this.dataGridReportes.Location = new System.Drawing.Point(21, 25);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1025, 358);
            this.dataGridReportes.TabIndex = 2;
            // 
            // _IDEMP
            // 
            this._IDEMP.DataPropertyName = "_IDEMP";
            this._IDEMP.HeaderText = "CODIGO";
            this._IDEMP.Name = "_IDEMP";
            // 
            // _RUC
            // 
            this._RUC.DataPropertyName = "_RUC";
            this._RUC.HeaderText = "NUMERO RUC";
            this._RUC.Name = "_RUC";
            // 
            // _EMPRUB
            // 
            this._EMPRUB.DataPropertyName = "_EMPRUB";
            this._EMPRUB.HeaderText = "NOMBRE EMPRESA";
            this._EMPRUB.Name = "_EMPRUB";
            // 
            // _EMPDIR
            // 
            this._EMPDIR.DataPropertyName = "_EMPDIR";
            this._EMPDIR.HeaderText = "DIRECCIÓN";
            this._EMPDIR.Name = "_EMPDIR";
            // 
            // _CODPOST
            // 
            this._CODPOST.DataPropertyName = "_CODPOST";
            this._CODPOST.HeaderText = "CODIGO POSTAL";
            this._CODPOST.Name = "_CODPOST";
            // 
            // _PAIS
            // 
            this._PAIS.DataPropertyName = "_PAIS";
            this._PAIS.HeaderText = "PAIS";
            this._PAIS.Name = "_PAIS";
            // 
            // _PROVEMP
            // 
            this._PROVEMP.DataPropertyName = "_PROVEMP";
            this._PROVEMP.HeaderText = "PROVINCIA";
            this._PROVEMP.Name = "_PROVEMP";
            // 
            // _CIUDAD
            // 
            this._CIUDAD.DataPropertyName = "_CIUDAD";
            this._CIUDAD.HeaderText = "DISTRITO";
            this._CIUDAD.Name = "_CIUDAD";
            // 
            // _TELEF
            // 
            this._TELEF.DataPropertyName = "_TELEF";
            this._TELEF.HeaderText = "TELÉFONO";
            this._TELEF.Name = "_TELEF";
            // 
            // _EMAIL
            // 
            this._EMAIL.DataPropertyName = "_EMAIL";
            this._EMAIL.HeaderText = "CORREO";
            this._EMAIL.Name = "_EMAIL";
            // 
            // _IDRUB
            // 
            this._IDRUB.DataPropertyName = "_IDRUB";
            this._IDRUB.HeaderText = "_IDRUB";
            this._IDRUB.Name = "_IDRUB";
            this._IDRUB.Visible = false;
            // 
            // _RUBRO
            // 
            this._RUBRO.DataPropertyName = "_RUBRO";
            this._RUBRO.HeaderText = "RUBRO";
            this._RUBRO.Name = "_RUBRO";
            // 
            // _IDACTEMP
            // 
            this._IDACTEMP.DataPropertyName = "_IDACTEMP";
            this._IDACTEMP.HeaderText = "_IDACTEMP";
            this._IDACTEMP.Name = "_IDACTEMP";
            this._IDACTEMP.Visible = false;
            // 
            // _ACTEMP
            // 
            this._ACTEMP.DataPropertyName = "_ACTEMP";
            this._ACTEMP.HeaderText = "ACTIVIDAD EMPRESARIAL";
            this._ACTEMP.Name = "_ACTEMP";
            this._ACTEMP.Width = 250;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(680, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 39);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.BackColor = System.Drawing.Color.Green;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(787, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 39);
            this.btnNew.TabIndex = 48;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(894, 27);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 39);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1001, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(23, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 22);
            this.label27.TabIndex = 47;
            this.label27.Text = "Proveedor";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(124, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(332, 24);
            this.txtBuscar.TabIndex = 46;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 81);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // ProviderDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1091, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProviderDesign";
            this.Text = "ProviderDesign";
            this.Load += new System.EventHandler(this.ProviderDesign_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EMPRUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EMPDIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODPOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PROVEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CIUDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn _TELEF;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDRUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RUBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDACTEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ACTEMP;
    }
}