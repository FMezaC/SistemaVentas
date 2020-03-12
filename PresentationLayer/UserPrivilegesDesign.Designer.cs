namespace PresentationLayer
{
    partial class UserPrivilegesDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPrivilegesDesign));
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._IDSUBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDMENU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._IDSB_MN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._SUB_IDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EMPLEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._TIPUSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NOMSBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._USUARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._PRIVILEG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this._IDSUBT,
            this._IDMENU,
            this._IDSB_MN,
            this._SUB_IDT,
            this._NUMDOC,
            this._EMPLEA,
            this._TIPUSU,
            this._ESTADO,
            this._NOMSBT,
            this._USUARI,
            this._PRIVILEG});
            this.dataGridReportes.Location = new System.Drawing.Point(26, 32);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReportes.Size = new System.Drawing.Size(1025, 358);
            this.dataGridReportes.TabIndex = 1;
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
            this.label27.Size = new System.Drawing.Size(90, 22);
            this.label27.TabIndex = 47;
            this.label27.Text = "Empleado";
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
            // _IDSUBT
            // 
            this._IDSUBT.DataPropertyName = "_IDSUBT";
            this._IDSUBT.HeaderText = "CODIGO";
            this._IDSUBT.Name = "_IDSUBT";
            this._IDSUBT.Visible = false;
            // 
            // _IDMENU
            // 
            this._IDMENU.DataPropertyName = "_IDMENU";
            this._IDMENU.HeaderText = "_IDMENU";
            this._IDMENU.Name = "_IDMENU";
            this._IDMENU.Visible = false;
            // 
            // _IDSB_MN
            // 
            this._IDSB_MN.DataPropertyName = "_IDSB_MN";
            this._IDSB_MN.HeaderText = "_IDSB_MN";
            this._IDSB_MN.Name = "_IDSB_MN";
            this._IDSB_MN.Visible = false;
            // 
            // _SUB_IDT
            // 
            this._SUB_IDT.DataPropertyName = "_SUB_IDT";
            this._SUB_IDT.HeaderText = "_SUB_IDT";
            this._SUB_IDT.Name = "_SUB_IDT";
            this._SUB_IDT.Visible = false;
            // 
            // _NUMDOC
            // 
            this._NUMDOC.DataPropertyName = "_NUMDOC";
            this._NUMDOC.HeaderText = "NUMERO DOCUMENTO";
            this._NUMDOC.Name = "_NUMDOC";
            // 
            // _EMPLEA
            // 
            this._EMPLEA.DataPropertyName = "_EMPLEA";
            this._EMPLEA.HeaderText = "EMPLEADO";
            this._EMPLEA.Name = "_EMPLEA";
            this._EMPLEA.Width = 200;
            // 
            // _TIPUSU
            // 
            this._TIPUSU.DataPropertyName = "_TIPUSU";
            this._TIPUSU.HeaderText = "TIPO USUARIO";
            this._TIPUSU.Name = "_TIPUSU";
            this._TIPUSU.Width = 150;
            // 
            // _ESTADO
            // 
            this._ESTADO.DataPropertyName = "_ESTADO";
            this._ESTADO.HeaderText = "ESTADO";
            this._ESTADO.Name = "_ESTADO";
            // 
            // _NOMSBT
            // 
            this._NOMSBT.DataPropertyName = "_NOMSBT";
            this._NOMSBT.HeaderText = "MENU";
            this._NOMSBT.Name = "_NOMSBT";
            this._NOMSBT.Width = 200;
            // 
            // _USUARI
            // 
            this._USUARI.DataPropertyName = "_USUARI";
            this._USUARI.HeaderText = "_USUARI";
            this._USUARI.Name = "_USUARI";
            this._USUARI.Visible = false;
            // 
            // _PRIVILEG
            // 
            this._PRIVILEG.DataPropertyName = "_PRIVILEG";
            this._PRIVILEG.FalseValue = "0";
            this._PRIVILEG.HeaderText = "PRIVILEGIO";
            this._PRIVILEG.Name = "_PRIVILEG";
            this._PRIVILEG.TrueValue = "1";
            // 
            // UserPrivilegesDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1091, 538);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserPrivilegesDesign";
            this.Text = "UserPrivilegesDesign";
            this.Load += new System.EventHandler(this.UserPrivilegesDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDSUBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDMENU;
        private System.Windows.Forms.DataGridViewTextBoxColumn _IDSB_MN;
        private System.Windows.Forms.DataGridViewTextBoxColumn _SUB_IDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn _EMPLEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn _TIPUSU;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NOMSBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _USUARI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _PRIVILEG;
    }
}