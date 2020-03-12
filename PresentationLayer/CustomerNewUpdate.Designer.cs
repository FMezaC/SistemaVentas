namespace PresentationLayer
{
    partial class CustomerNewUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerNewUpdate));
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCel = new System.Windows.Forms.MaskedTextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboProv = new System.Windows.Forms.ComboBox();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboDistri = new System.Windows.Forms.ComboBox();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cboEstdCivil = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cboDoc = new System.Windows.Forms.ComboBox();
            this.txtocupass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.dtpNacim = new System.Windows.Forms.DateTimePicker();
            this.txtApeMater = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtApePater = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.txtNomb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Provincia";
            // 
            // txtNumCel
            // 
            this.txtNumCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCel.Location = new System.Drawing.Point(394, 158);
            this.txtNumCel.Mask = "000-000-0000";
            this.txtNumCel.Name = "txtNumCel";
            this.txtNumCel.Size = new System.Drawing.Size(163, 21);
            this.txtNumCel.TabIndex = 54;
            this.txtNumCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(598, 108);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(163, 20);
            this.txtCorreo.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 57);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // cboProv
            // 
            this.cboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProv.FormattingEnabled = true;
            this.cboProv.Location = new System.Drawing.Point(219, 31);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(163, 21);
            this.cboProv.TabIndex = 57;
            this.cboProv.SelectionChangeCommitted += new System.EventHandler(this.cboProv_SelectionChangeCommitted);
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(26, 31);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(163, 21);
            this.cboPais.TabIndex = 55;
            this.cboPais.SelectionChangeCommitted += new System.EventHandler(this.cboPais_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Pais";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(400, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Distrito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(598, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dirección";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboProv);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cboPais);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboDistri);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDirecc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(49, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 70);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            // 
            // cboDistri
            // 
            this.cboDistri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistri.FormattingEnabled = true;
            this.cboDistri.Location = new System.Drawing.Point(403, 31);
            this.cboDistri.Name = "cboDistri";
            this.cboDistri.Size = new System.Drawing.Size(163, 21);
            this.cboDistri.TabIndex = 41;
            // 
            // txtDirecc
            // 
            this.txtDirecc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDirecc.Location = new System.Drawing.Point(601, 32);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(163, 20);
            this.txtDirecc.TabIndex = 32;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.BackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(685, 363);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(128, 39);
            this.btnCerrar.TabIndex = 55;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNew.BackColor = System.Drawing.Color.Green;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(541, 363);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 39);
            this.btnNew.TabIndex = 56;
            this.btnNew.Text = "Registrar";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cboEstdCivil
            // 
            this.cboEstdCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstdCivil.FormattingEnabled = true;
            this.cboEstdCivil.Location = new System.Drawing.Point(189, 160);
            this.cboEstdCivil.Name = "cboEstdCivil";
            this.cboEstdCivil.Size = new System.Drawing.Size(163, 21);
            this.cboEstdCivil.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(24, 140);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 17);
            this.label23.TabIndex = 46;
            this.label23.Text = "Género";
            // 
            // cboDoc
            // 
            this.cboDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoc.ForeColor = System.Drawing.Color.Navy;
            this.cboDoc.FormattingEnabled = true;
            this.cboDoc.Location = new System.Drawing.Point(26, 107);
            this.cboDoc.Name = "cboDoc";
            this.cboDoc.Size = new System.Drawing.Size(132, 21);
            this.cboDoc.TabIndex = 45;
            // 
            // txtocupass
            // 
            this.txtocupass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtocupass.Location = new System.Drawing.Point(599, 160);
            this.txtocupass.Name = "txtocupass";
            this.txtocupass.Size = new System.Drawing.Size(163, 20);
            this.txtocupass.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(599, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ocupción";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(26, 158);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(132, 21);
            this.cboGenero.TabIndex = 37;
            // 
            // dtpNacim
            // 
            this.dtpNacim.Location = new System.Drawing.Point(394, 105);
            this.dtpNacim.Name = "dtpNacim";
            this.dtpNacim.Size = new System.Drawing.Size(163, 20);
            this.dtpNacim.TabIndex = 30;
            // 
            // txtApeMater
            // 
            this.txtApeMater.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMater.Location = new System.Drawing.Point(598, 52);
            this.txtApeMater.Name = "txtApeMater";
            this.txtApeMater.Size = new System.Drawing.Size(163, 20);
            this.txtApeMater.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtApePater
            // 
            this.txtApePater.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePater.Location = new System.Drawing.Point(394, 52);
            this.txtApePater.Name = "txtApePater";
            this.txtApePater.Size = new System.Drawing.Size(163, 20);
            this.txtApePater.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumCel);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cboEstdCivil);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.cboDoc);
            this.groupBox2.Controls.Add(this.txtocupass);
            this.groupBox2.Controls.Add(this.txtNumDoc);
            this.groupBox2.Controls.Add(this.cboGenero);
            this.groupBox2.Controls.Add(this.dtpNacim);
            this.groupBox2.Controls.Add(this.txtApeMater);
            this.groupBox2.Controls.Add(this.txtApePater);
            this.groupBox2.Controls.Add(this.txtNomb);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(49, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 215);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumDoc.Location = new System.Drawing.Point(189, 104);
            this.txtNumDoc.MaxLength = 10;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(163, 20);
            this.txtNumDoc.TabIndex = 38;
            // 
            // txtNomb
            // 
            this.txtNomb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomb.Location = new System.Drawing.Point(189, 52);
            this.txtNomb.Name = "txtNomb";
            this.txtNomb.Size = new System.Drawing.Size(163, 20);
            this.txtNomb.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(598, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Correo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(391, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Fecha Nacimiento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(391, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Número Celular";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(186, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Estado Civil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Número Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // CustomerNewUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerNewUpdate";
            this.Text = "CustomerNewUpdate";
            this.Load += new System.EventHandler(this.CustomerNewUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txtNumCel;
        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cboProv;
        public System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox cboDistri;
        public System.Windows.Forms.TextBox txtDirecc;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.ComboBox cboEstdCivil;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox cboDoc;
        public System.Windows.Forms.TextBox txtocupass;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cboGenero;
        public System.Windows.Forms.DateTimePicker dtpNacim;
        public System.Windows.Forms.TextBox txtApeMater;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtNumDoc;
        public System.Windows.Forms.TextBox txtApePater;
        public System.Windows.Forms.TextBox txtNomb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}