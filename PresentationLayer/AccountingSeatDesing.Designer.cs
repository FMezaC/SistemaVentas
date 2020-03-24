namespace PresentationLayer
{
    partial class AccountingSeatDesing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingSeatDesing));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this._IDASI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMASI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCUENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONCEPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETALL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HABER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTDEB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTHAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESTAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGuardar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKardex = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnListar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnModificar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
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
            this.groupBox6.Size = new System.Drawing.Size(1242, 409);
            this.groupBox6.TabIndex = 51;
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
            this._IDASI,
            this.NUMASI,
            this.FECHA,
            this.NOTA,
            this.IDCUENT,
            this.CONCEPT,
            this.DETALL,
            this.CUENTA,
            this.DEBE,
            this.HABER,
            this.TOTDEB,
            this.TOTHAB,
            this.RESTAN});
            this.dataGridReportes.Location = new System.Drawing.Point(26, 32);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1200, 358);
            this.dataGridReportes.TabIndex = 1;
            // 
            // _IDASI
            // 
            this._IDASI.DataPropertyName = "_IDASI";
            this._IDASI.HeaderText = "_IDASI";
            this._IDASI.Name = "_IDASI";
            this._IDASI.Visible = false;
            // 
            // NUMASI
            // 
            this.NUMASI.DataPropertyName = "_NUMASI";
            this.NUMASI.HeaderText = "NÚMERO DE ASIENTO";
            this.NUMASI.Name = "NUMASI";
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "_FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // NOTA
            // 
            this.NOTA.DataPropertyName = "_NOTA";
            this.NOTA.HeaderText = "NOTA";
            this.NOTA.Name = "NOTA";
            // 
            // IDCUENT
            // 
            this.IDCUENT.DataPropertyName = "_IDCUENT";
            this.IDCUENT.HeaderText = "C.T.A";
            this.IDCUENT.Name = "IDCUENT";
            // 
            // CONCEPT
            // 
            this.CONCEPT.DataPropertyName = "_CONCEP";
            this.CONCEPT.HeaderText = "CONCEPTO";
            this.CONCEPT.Name = "CONCEPT";
            // 
            // DETALL
            // 
            this.DETALL.DataPropertyName = "_DETALL";
            this.DETALL.HeaderText = "DETALLE";
            this.DETALL.Name = "DETALL";
            // 
            // CUENTA
            // 
            this.CUENTA.DataPropertyName = "_CUENTA";
            this.CUENTA.HeaderText = "CUENTA";
            this.CUENTA.Name = "CUENTA";
            // 
            // DEBE
            // 
            this.DEBE.DataPropertyName = "_DEBE";
            this.DEBE.HeaderText = "DEBE";
            this.DEBE.Name = "DEBE";
            // 
            // HABER
            // 
            this.HABER.DataPropertyName = "_HABER";
            this.HABER.HeaderText = "HABER";
            this.HABER.Name = "HABER";
            // 
            // TOTDEB
            // 
            this.TOTDEB.DataPropertyName = "_TOTDEB";
            this.TOTDEB.HeaderText = "TOTAL DEBE";
            this.TOTDEB.Name = "TOTDEB";
            // 
            // TOTHAB
            // 
            this.TOTHAB.DataPropertyName = "_TOTHAB";
            this.TOTHAB.HeaderText = "TOTAL HABER";
            this.TOTHAB.Name = "TOTHAB";
            // 
            // RESTAN
            // 
            this.RESTAN.DataPropertyName = "_RESTAN";
            this.RESTAN.HeaderText = "RESTANTE";
            this.RESTAN.Name = "RESTAN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.statusStrip2);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1242, 86);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(414, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker2.TabIndex = 60;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 23);
            this.dateTimePicker1.TabIndex = 58;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Desde:";
            // 
            // statusStrip2
            // 
            this.statusStrip2.AllowItemReorder = true;
            this.statusStrip2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnGuardar,
            this.btnKardex,
            this.btnListar,
            this.btnEliminar,
            this.btnModificar});
            this.statusStrip2.Location = new System.Drawing.Point(627, 20);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip2.Size = new System.Drawing.Size(607, 56);
            this.statusStrip2.TabIndex = 56;
            this.statusStrip2.Text = "statusStrip2";
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
            // AccountingSeatDesing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1266, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Name = "AccountingSeatDesing";
            this.Text = "AccountingSeatDesing";
            this.Load += new System.EventHandler(this.AccountingSeatDesing_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDASI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMASI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCUENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETALL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HABER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTDEB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTHAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESTAN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel btnSalir;
        private System.Windows.Forms.ToolStripStatusLabel btnGuardar;
        private System.Windows.Forms.ToolStripStatusLabel btnKardex;
        private System.Windows.Forms.ToolStripStatusLabel btnListar;
        private System.Windows.Forms.ToolStripStatusLabel btnEliminar;
        private System.Windows.Forms.ToolStripStatusLabel btnModificar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}