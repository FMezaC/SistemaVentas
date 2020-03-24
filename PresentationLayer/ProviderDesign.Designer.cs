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
            this.label27 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGuardar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKardex = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnListar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnModificar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.groupBox6.Size = new System.Drawing.Size(1086, 409);
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
            this.dataGridReportes.Size = new System.Drawing.Size(1044, 358);
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
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 81);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = true;
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnGuardar,
            this.btnKardex,
            this.btnListar,
            this.btnEliminar,
            this.btnModificar});
            this.statusStrip1.Location = new System.Drawing.Point(472, 16);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(607, 56);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnSalir.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 51);
            this.btnSalir.Spring = true;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGuardar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnGuardar.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 51);
            this.btnGuardar.Spring = true;
            this.btnGuardar.Text = "Exportar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnKardex
            // 
            this.btnKardex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKardex.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnKardex.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.btnKardex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKardex.Image = ((System.Drawing.Image)(resources.GetObject("btnKardex.Image")));
            this.btnKardex.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKardex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Size = new System.Drawing.Size(93, 51);
            this.btnKardex.Spring = true;
            this.btnKardex.Text = "Kardex";
            this.btnKardex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKardex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnListar
            // 
            this.btnListar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnListar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnListar.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 51);
            this.btnListar.Spring = true;
            this.btnListar.Text = "Nuevo";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnEliminar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnEliminar.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 51);
            this.btnEliminar.Spring = true;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnModificar
            // 
            this.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnModificar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.btnModificar.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 51);
            this.btnModificar.Spring = true;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // ProviderDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1110, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProviderDesign";
            this.Text = "ProviderDesign";
            this.Load += new System.EventHandler(this.ProviderDesign_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnSalir;
        private System.Windows.Forms.ToolStripStatusLabel btnGuardar;
        private System.Windows.Forms.ToolStripStatusLabel btnKardex;
        private System.Windows.Forms.ToolStripStatusLabel btnListar;
        private System.Windows.Forms.ToolStripStatusLabel btnEliminar;
        private System.Windows.Forms.ToolStripStatusLabel btnModificar;
    }
}