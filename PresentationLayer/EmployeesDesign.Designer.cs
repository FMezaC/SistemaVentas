namespace PresentationLayer
{
    partial class EmployeesDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesDesign));
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this._CODEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDTIPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NOMEMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._APEPAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._APEMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._FECHNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._FECHCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDGENE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DIRECC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PROVIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDDIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DISTRIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDESTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NUMCEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NUMHIJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._SALARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._TIPUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._UPASSW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EMPIMG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._SUCUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDAUSUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGuardar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKardex = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnListar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnModificar = new System.Windows.Forms.ToolStripStatusLabel();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridReportes
            // 
            this.dataGridReportes.AllowUserToAddRows = false;
            this.dataGridReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._CODEMP,
            this._IDTIPD,
            this._NUMDOC,
            this._NOMEMP,
            this._APEPAT,
            this._APEMAT,
            this._FECHNA,
            this._FECHCO,
            this._IDGENE,
            this._DIRECC,
            this._PAIS,
            this._PROVIN,
            this._IDDIST,
            this._DISTRIT,
            this._IDESTC,
            this._NUMCEL,
            this._CORREO,
            this._NUMHIJ,
            this._SALARI,
            this._TIPUSER,
            this._USUARIO,
            this._UPASSW,
            this._EMPIMG,
            this._SUCUR,
            this._IDAUSUC});
            this.dataGridReportes.Location = new System.Drawing.Point(26, 32);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1073, 441);
            this.dataGridReportes.TabIndex = 1;
            // 
            // _CODEMP
            // 
            this._CODEMP.DataPropertyName = "_CODEMP";
            this._CODEMP.HeaderText = "ID";
            this._CODEMP.Name = "_CODEMP";
            this._CODEMP.Visible = false;
            // 
            // _IDTIPD
            // 
            this._IDTIPD.DataPropertyName = "_IDTIPD";
            this._IDTIPD.HeaderText = "DOCUMENTO";
            this._IDTIPD.Name = "_IDTIPD";
            // 
            // _NUMDOC
            // 
            this._NUMDOC.DataPropertyName = "_NUMDOC";
            this._NUMDOC.HeaderText = "NUMERO";
            this._NUMDOC.Name = "_NUMDOC";
            // 
            // _NOMEMP
            // 
            this._NOMEMP.DataPropertyName = "_NOMEMP";
            this._NOMEMP.HeaderText = "NOMBRE";
            this._NOMEMP.Name = "_NOMEMP";
            // 
            // _APEPAT
            // 
            this._APEPAT.DataPropertyName = "_APEPAT";
            this._APEPAT.HeaderText = "APELLIDO PATERNO";
            this._APEPAT.Name = "_APEPAT";
            // 
            // _APEMAT
            // 
            this._APEMAT.DataPropertyName = "_APEMAT";
            this._APEMAT.HeaderText = "APELLIDO MATERNO";
            this._APEMAT.Name = "_APEMAT";
            // 
            // _FECHNA
            // 
            this._FECHNA.DataPropertyName = "_FECHNA";
            this._FECHNA.HeaderText = "NACIMIENTO";
            this._FECHNA.Name = "_FECHNA";
            // 
            // _FECHCO
            // 
            this._FECHCO.DataPropertyName = "_FECHCO";
            this._FECHCO.HeaderText = "CONTRATACION";
            this._FECHCO.Name = "_FECHCO";
            // 
            // _IDGENE
            // 
            this._IDGENE.DataPropertyName = "_IDGENE";
            this._IDGENE.HeaderText = "GENERO";
            this._IDGENE.Name = "_IDGENE";
            // 
            // _DIRECC
            // 
            this._DIRECC.DataPropertyName = "_DIRECC";
            this._DIRECC.HeaderText = "DIRECCION";
            this._DIRECC.Name = "_DIRECC";
            // 
            // _PAIS
            // 
            this._PAIS.DataPropertyName = "_PAIS";
            this._PAIS.HeaderText = "PAIS";
            this._PAIS.Name = "_PAIS";
            // 
            // _PROVIN
            // 
            this._PROVIN.DataPropertyName = "_PROVIN";
            this._PROVIN.HeaderText = "PROVINCIA";
            this._PROVIN.Name = "_PROVIN";
            // 
            // _IDDIST
            // 
            this._IDDIST.DataPropertyName = "_IDDIST";
            this._IDDIST.HeaderText = "IDDIST";
            this._IDDIST.Name = "_IDDIST";
            this._IDDIST.Visible = false;
            // 
            // _DISTRIT
            // 
            this._DISTRIT.DataPropertyName = "_DISTRIT";
            this._DISTRIT.HeaderText = "DISTRITO";
            this._DISTRIT.Name = "_DISTRIT";
            // 
            // _IDESTC
            // 
            this._IDESTC.DataPropertyName = "_IDESTC";
            this._IDESTC.HeaderText = "ESTADO CIVIL";
            this._IDESTC.Name = "_IDESTC";
            // 
            // _NUMCEL
            // 
            this._NUMCEL.DataPropertyName = "_NUMCEL";
            this._NUMCEL.HeaderText = "CELULAR";
            this._NUMCEL.Name = "_NUMCEL";
            // 
            // _CORREO
            // 
            this._CORREO.DataPropertyName = "_CORREO";
            this._CORREO.HeaderText = "CORREO";
            this._CORREO.Name = "_CORREO";
            // 
            // _NUMHIJ
            // 
            this._NUMHIJ.DataPropertyName = "_NUMHIJ";
            this._NUMHIJ.HeaderText = "HIJOS";
            this._NUMHIJ.Name = "_NUMHIJ";
            // 
            // _SALARI
            // 
            this._SALARI.DataPropertyName = "_SALARI";
            this._SALARI.HeaderText = "SALARIO";
            this._SALARI.Name = "_SALARI";
            // 
            // _TIPUSER
            // 
            this._TIPUSER.DataPropertyName = "_TIPUSER";
            this._TIPUSER.HeaderText = "TIPO USUARIO";
            this._TIPUSER.Name = "_TIPUSER";
            // 
            // _USUARIO
            // 
            this._USUARIO.DataPropertyName = "_USUARIO";
            this._USUARIO.HeaderText = "USUARIO";
            this._USUARIO.Name = "_USUARIO";
            // 
            // _UPASSW
            // 
            this._UPASSW.DataPropertyName = "_UPASSW";
            this._UPASSW.HeaderText = "UPASSW";
            this._UPASSW.Name = "_UPASSW";
            this._UPASSW.Visible = false;
            // 
            // _EMPIMG
            // 
            this._EMPIMG.DataPropertyName = "_EMPIMG";
            this._EMPIMG.HeaderText = "PERFIL";
            this._EMPIMG.Name = "_EMPIMG";
            // 
            // _SUCUR
            // 
            this._SUCUR.DataPropertyName = "_SUCUR";
            this._SUCUR.HeaderText = "SUCURSAL";
            this._SUCUR.Name = "_SUCUR";
            // 
            // _IDAUSUC
            // 
            this._IDAUSUC.DataPropertyName = "_IDAUSUC";
            this._IDAUSUC.HeaderText = "_IDAUSUC";
            this._IDAUSUC.Name = "_IDAUSUC";
            this._IDAUSUC.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.dataGridReportes);
            this.groupBox6.Location = new System.Drawing.Point(12, 107);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1115, 506);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
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
            this.statusStrip1.Location = new System.Drawing.Point(502, 22);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(607, 56);
            this.statusStrip1.TabIndex = 53;
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
            this.label27.Location = new System.Drawing.Point(23, 27);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 22);
            this.label27.TabIndex = 47;
            this.label27.Text = "Empleados";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(124, 27);
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
            this.groupBox1.Size = new System.Drawing.Size(1115, 89);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // EmployeesDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1139, 621);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeesDesign";
            this.Text = "EmployeesDesign";
            this.Load += new System.EventHandler(this.EmployeesDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CODEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDTIPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NOMEMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _APEPAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _APEMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _FECHNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn _FECHCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDGENE;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DIRECC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn _PROVIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDDIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DISTRIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDESTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NUMCEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NUMHIJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn _SALARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn _TIPUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn _USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _UPASSW;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EMPIMG;
        private System.Windows.Forms.DataGridViewTextBoxColumn _SUCUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDAUSUC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel btnSalir;
        private System.Windows.Forms.ToolStripStatusLabel btnGuardar;
        private System.Windows.Forms.ToolStripStatusLabel btnKardex;
        private System.Windows.Forms.ToolStripStatusLabel btnListar;
        private System.Windows.Forms.ToolStripStatusLabel btnEliminar;
        private System.Windows.Forms.ToolStripStatusLabel btnModificar;
    }
}