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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.togglePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblButtonToggle = new VentaProductos.LabelCirculo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.togglePanel.SuspendLayout();
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
            this._EMPIMG});
            this.dataGridReportes.Location = new System.Drawing.Point(26, 32);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1025, 358);
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
            this.label27.Size = new System.Drawing.Size(99, 22);
            this.label27.TabIndex = 47;
            this.label27.Text = "Empleados";
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
            // togglePanel
            // 
            this.togglePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.togglePanel.BackColor = System.Drawing.Color.ForestGreen;
            this.togglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.togglePanel.Controls.Add(this.lblButtonToggle);
            this.togglePanel.Location = new System.Drawing.Point(572, 33);
            this.togglePanel.Name = "togglePanel";
            this.togglePanel.Size = new System.Drawing.Size(80, 29);
            this.togglePanel.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.togglePanel);
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
            // lblButtonToggle
            // 
            this.lblButtonToggle.BackColor = System.Drawing.SystemColors.Menu;
            this.lblButtonToggle.Location = new System.Drawing.Point(54, 3);
            this.lblButtonToggle.Name = "lblButtonToggle";
            this.lblButtonToggle.Size = new System.Drawing.Size(21, 20);
            this.lblButtonToggle.TabIndex = 1;
            // 
            // EmployeesDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1091, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeesDesign";
            this.Text = "EmployeesDesign";
            this.Load += new System.EventHandler(this.EmployeesDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.togglePanel.ResumeLayout(false);
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
        private VentaProductos.LabelCirculo lblButtonToggle;
        private System.Windows.Forms.Panel togglePanel;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridView dataGridReportes;
    }
}