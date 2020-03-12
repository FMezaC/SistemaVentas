namespace PresentationLayer
{
    partial class ScheduleDesign
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORA,
            this.Lues,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo});
            this.dataGridView1.Location = new System.Drawing.Point(28, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(881, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // HORA
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            this.HORA.DefaultCellStyle = dataGridViewCellStyle1;
            this.HORA.HeaderText = "HORA";
            this.HORA.Name = "HORA";
            // 
            // Lues
            // 
            this.Lues.HeaderText = "LUNES";
            this.Lues.Name = "Lues";
            // 
            // Martes
            // 
            this.Martes.HeaderText = "MARTES";
            this.Martes.Name = "Martes";
            // 
            // Miercoles
            // 
            this.Miercoles.HeaderText = "MIERCOLES";
            this.Miercoles.Name = "Miercoles";
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "JUEVES";
            this.Jueves.Name = "Jueves";
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "VIERNES";
            this.Viernes.Name = "Viernes";
            // 
            // Sabado
            // 
            this.Sabado.HeaderText = "SÁBADO";
            this.Sabado.Name = "Sabado";
            // 
            // Domingo
            // 
            this.Domingo.HeaderText = "DOMINGO";
            this.Domingo.Name = "Domingo";
            // 
            // ScheduleDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 429);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScheduleDesign";
            this.Text = "ScheduleDesign";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lues;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domingo;
    }
}