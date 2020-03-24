namespace PresentationLayer
{
    partial class EmployeePaymentsDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePaymentsDesign));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this.NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLEADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUPAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEUPEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BONUSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALNET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPInicio = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
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
            this.groupBox6.Location = new System.Drawing.Point(12, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1141, 494);
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
            this.NUMDOC,
            this.EMPLEADO,
            this.SALARY,
            this.USUPAG,
            this.FECHCO,
            this.FECHPA,
            this.DEUPEN,
            this.DESCUE,
            this.BONUSP,
            this.SALNET});
            this.dataGridReportes.Location = new System.Drawing.Point(26, 32);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1099, 443);
            this.dataGridReportes.TabIndex = 1;
            // 
            // NUMDOC
            // 
            this.NUMDOC.DataPropertyName = "NUMDOC";
            this.NUMDOC.HeaderText = "DOCUMENTO";
            this.NUMDOC.Name = "NUMDOC";
            this.NUMDOC.Width = 110;
            // 
            // EMPLEADO
            // 
            this.EMPLEADO.DataPropertyName = "EMPLEADO";
            this.EMPLEADO.HeaderText = "EMPLEADO";
            this.EMPLEADO.Name = "EMPLEADO";
            this.EMPLEADO.Width = 300;
            // 
            // SALARY
            // 
            this.SALARY.DataPropertyName = "SALARY";
            this.SALARY.HeaderText = "SALARIO";
            this.SALARY.Name = "SALARY";
            this.SALARY.Width = 110;
            // 
            // USUPAG
            // 
            this.USUPAG.DataPropertyName = "USUPAG";
            this.USUPAG.HeaderText = "USUPAG";
            this.USUPAG.Name = "USUPAG";
            this.USUPAG.Visible = false;
            // 
            // FECHCO
            // 
            this.FECHCO.DataPropertyName = "FECHCO";
            this.FECHCO.HeaderText = "FECHA CONTRATACION";
            this.FECHCO.Name = "FECHCO";
            this.FECHCO.Width = 110;
            // 
            // FECHPA
            // 
            this.FECHPA.DataPropertyName = "FECHPA";
            this.FECHPA.HeaderText = "FECHA PAGADO";
            this.FECHPA.Name = "FECHPA";
            this.FECHPA.Width = 110;
            // 
            // DEUPEN
            // 
            this.DEUPEN.DataPropertyName = "DEUPEN";
            this.DEUPEN.HeaderText = "DEUDA PENDIENTE";
            this.DEUPEN.Name = "DEUPEN";
            this.DEUPEN.Width = 110;
            // 
            // DESCUE
            // 
            this.DESCUE.DataPropertyName = "DESCUE";
            this.DESCUE.HeaderText = "DESCUENTO";
            this.DESCUE.Name = "DESCUE";
            this.DESCUE.Width = 110;
            // 
            // BONUSP
            // 
            this.BONUSP.DataPropertyName = "BONUSP";
            this.BONUSP.HeaderText = "BONUS";
            this.BONUSP.Name = "BONUSP";
            this.BONUSP.Width = 110;
            // 
            // SALNET
            // 
            this.SALNET.DataPropertyName = "SALNET";
            this.SALNET.HeaderText = "SALARIO NETO";
            this.SALNET.Name = "SALNET";
            this.SALNET.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.dTPFin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTPInicio);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 69);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // dTPFin
            // 
            this.dTPFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFin.Location = new System.Drawing.Point(393, 21);
            this.dTPFin.Name = "dTPFin";
            this.dTPFin.Size = new System.Drawing.Size(99, 23);
            this.dTPFin.TabIndex = 50;
            this.dTPFin.ValueChanged += new System.EventHandler(this.dTPFin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hasta:";
            // 
            // dTPInicio
            // 
            this.dTPInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPInicio.Location = new System.Drawing.Point(159, 21);
            this.dTPInicio.Name = "dTPInicio";
            this.dTPInicio.Size = new System.Drawing.Size(99, 23);
            this.dTPInicio.TabIndex = 48;
            this.dTPInicio.ValueChanged += new System.EventHandler(this.dTPInicio_ValueChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(70, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 22);
            this.label27.TabIndex = 47;
            this.label27.Text = "Desde:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowItemReorder = true;
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.statusStrip1.Location = new System.Drawing.Point(560, 12);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(575, 56);
            this.statusStrip1.TabIndex = 52;
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
            this.btnSalir.Size = new System.Drawing.Size(88, 51);
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
            this.btnGuardar.Size = new System.Drawing.Size(88, 51);
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
            // 
            // EmployeePaymentsDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1165, 621);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeePaymentsDesign";
            this.Text = "EmployeePaymentsDesign";
            this.Load += new System.EventHandler(this.EmployeePaymentsDesign_Load);
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
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnSalir;
        private System.Windows.Forms.ToolStripStatusLabel btnKardex;
        private System.Windows.Forms.ToolStripStatusLabel btnListar;
        private System.Windows.Forms.ToolStripStatusLabel btnEliminar;
        private System.Windows.Forms.ToolStripStatusLabel btnModificar;
        private System.Windows.Forms.ToolStripStatusLabel btnGuardar;
        private System.Windows.Forms.DateTimePicker dTPFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPInicio;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUPAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEUPEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BONUSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALNET;
    }
}