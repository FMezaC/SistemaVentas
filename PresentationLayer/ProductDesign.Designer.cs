namespace PresentationLayer
{
    partial class ProductDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDesign));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGuardar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKardex = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnListar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnModificar = new System.Windows.Forms.ToolStripStatusLabel();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this._CODPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DESCPRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PROCEDENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CODBARR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._UMSTOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._VOLPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CODEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._FECHPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._FECHVEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CODLINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CODCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PREUNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CANTRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._FACTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CANTPRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(1104, 81);
            this.groupBox1.TabIndex = 1;
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
            this.statusStrip1.Location = new System.Drawing.Point(486, 18);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(607, 56);
            this.statusStrip1.TabIndex = 54;
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
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(23, 33);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 22);
            this.label27.TabIndex = 47;
            this.label27.Text = "Productos";
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
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.dataGridReportes);
            this.groupBox6.Location = new System.Drawing.Point(12, 117);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1104, 409);
            this.groupBox6.TabIndex = 47;
            this.groupBox6.TabStop = false;
            // 
            // dataGridReportes
            // 
            this.dataGridReportes.AllowUserToAddRows = false;
            this.dataGridReportes.AllowUserToOrderColumns = true;
            this.dataGridReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._CODPROD,
            this._DESCPRO,
            this._PROCEDENCIA,
            this._CODBARR,
            this._UMSTOCK,
            this._VOLPROD,
            this._CODEST,
            this._FECHPROD,
            this._FECHVEN,
            this._CODLINE,
            this._CODCLASS,
            this._PREUNIT,
            this._CANTRES,
            this._FACTOR,
            this._CANTPRO,
            this._UNIDADES,
            this.IMPUEST});
            this.dataGridReportes.Location = new System.Drawing.Point(26, 32);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1062, 358);
            this.dataGridReportes.TabIndex = 1;
            this.dataGridReportes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridReportes_CellFormatting);
            this.dataGridReportes.Sorted += new System.EventHandler(this.dataGridReportes_Sorted);
            // 
            // _CODPROD
            // 
            this._CODPROD.DataPropertyName = "_CODPROD";
            this._CODPROD.HeaderText = "CODIGO";
            this._CODPROD.Name = "_CODPROD";
            // 
            // _DESCPRO
            // 
            this._DESCPRO.DataPropertyName = "_DESCPRO";
            this._DESCPRO.HeaderText = "DESCRIPCION";
            this._DESCPRO.Name = "_DESCPRO";
            // 
            // _PROCEDENCIA
            // 
            this._PROCEDENCIA.DataPropertyName = "_PROCEDENCIA";
            this._PROCEDENCIA.HeaderText = "PROCEDENCIA";
            this._PROCEDENCIA.Name = "_PROCEDENCIA";
            // 
            // _CODBARR
            // 
            this._CODBARR.DataPropertyName = "_CODBARR";
            this._CODBARR.HeaderText = "CODIGO DE BARRA";
            this._CODBARR.Name = "_CODBARR";
            // 
            // _UMSTOCK
            // 
            this._UMSTOCK.DataPropertyName = "_UMSTOCK";
            this._UMSTOCK.HeaderText = "UMSTOCK";
            this._UMSTOCK.Name = "_UMSTOCK";
            // 
            // _VOLPROD
            // 
            this._VOLPROD.DataPropertyName = "_VOLPROD";
            this._VOLPROD.HeaderText = "VOLUMEN";
            this._VOLPROD.Name = "_VOLPROD";
            // 
            // _CODEST
            // 
            this._CODEST.DataPropertyName = "_CODEST";
            this._CODEST.HeaderText = "ESTADO";
            this._CODEST.Name = "_CODEST";
            // 
            // _FECHPROD
            // 
            this._FECHPROD.DataPropertyName = "_FECHPROD";
            this._FECHPROD.HeaderText = "PRODUCCION";
            this._FECHPROD.Name = "_FECHPROD";
            // 
            // _FECHVEN
            // 
            this._FECHVEN.DataPropertyName = "_FECHVEN";
            this._FECHVEN.HeaderText = "VENCIMIENTO";
            this._FECHVEN.Name = "_FECHVEN";
            // 
            // _CODLINE
            // 
            this._CODLINE.DataPropertyName = "_CODLINE";
            this._CODLINE.HeaderText = "LINEA";
            this._CODLINE.Name = "_CODLINE";
            // 
            // _CODCLASS
            // 
            this._CODCLASS.DataPropertyName = "_CODCLASS";
            this._CODCLASS.HeaderText = "CLASE";
            this._CODCLASS.Name = "_CODCLASS";
            // 
            // _PREUNIT
            // 
            this._PREUNIT.DataPropertyName = "_PREUNIT";
            this._PREUNIT.HeaderText = "PRECIO";
            this._PREUNIT.Name = "_PREUNIT";
            // 
            // _CANTRES
            // 
            this._CANTRES.DataPropertyName = "_CANTRES";
            this._CANTRES.HeaderText = "RESERVADO";
            this._CANTRES.Name = "_CANTRES";
            // 
            // _FACTOR
            // 
            this._FACTOR.DataPropertyName = "_FACTOR";
            this._FACTOR.HeaderText = "FACTOR";
            this._FACTOR.Name = "_FACTOR";
            // 
            // _CANTPRO
            // 
            this._CANTPRO.DataPropertyName = "_CANTPRO";
            this._CANTPRO.HeaderText = "CANTIDAD";
            this._CANTPRO.Name = "_CANTPRO";
            // 
            // _UNIDADES
            // 
            this._UNIDADES.DataPropertyName = "_UNIDADES";
            this._UNIDADES.HeaderText = "STOCK";
            this._UNIDADES.Name = "_UNIDADES";
            // 
            // IMPUEST
            // 
            this.IMPUEST.DataPropertyName = "_IMPUEST";
            this.IMPUEST.HeaderText = "IMPUESTO";
            this.IMPUEST.Name = "IMPUEST";
            // 
            // ProductDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1128, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductDesign";
            this.Text = "ProductDesign";
            this.Load += new System.EventHandler(this.ProductDesign_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DESCPRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PROCEDENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODBARR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _UMSTOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn _VOLPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn _FECHPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn _FECHVEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODLINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODCLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PREUNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CANTRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn _FACTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CANTPRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUEST;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnSalir;
        private System.Windows.Forms.ToolStripStatusLabel btnGuardar;
        private System.Windows.Forms.ToolStripStatusLabel btnKardex;
        private System.Windows.Forms.ToolStripStatusLabel btnListar;
        private System.Windows.Forms.ToolStripStatusLabel btnEliminar;
        private System.Windows.Forms.ToolStripStatusLabel btnModificar;
    }
}