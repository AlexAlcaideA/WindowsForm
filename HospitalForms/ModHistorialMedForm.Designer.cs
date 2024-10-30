namespace HospitalForms
{
    partial class ModHistorialMedForm
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
            this.lbTipoHistMed = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbMedico = new System.Windows.Forms.Label();
            this.lbDatos1 = new System.Windows.Forms.Label();
            this.lbDatos2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTipoHistMed
            // 
            this.lbTipoHistMed.AutoSize = true;
            this.lbTipoHistMed.Location = new System.Drawing.Point(12, 9);
            this.lbTipoHistMed.Name = "lbTipoHistMed";
            this.lbTipoHistMed.Size = new System.Drawing.Size(44, 16);
            this.lbTipoHistMed.TabIndex = 0;
            this.lbTipoHistMed.Text = "label1";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(12, 40);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(48, 16);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(12, 74);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(55, 16);
            this.lbMedico.TabIndex = 2;
            this.lbMedico.Text = "Medico:";
            // 
            // lbDatos1
            // 
            this.lbDatos1.AutoSize = true;
            this.lbDatos1.Location = new System.Drawing.Point(12, 109);
            this.lbDatos1.Name = "lbDatos1";
            this.lbDatos1.Size = new System.Drawing.Size(44, 16);
            this.lbDatos1.TabIndex = 3;
            this.lbDatos1.Text = "label1";
            // 
            // lbDatos2
            // 
            this.lbDatos2.AutoSize = true;
            this.lbDatos2.Location = new System.Drawing.Point(12, 145);
            this.lbDatos2.Name = "lbDatos2";
            this.lbDatos2.Size = new System.Drawing.Size(44, 16);
            this.lbDatos2.TabIndex = 4;
            this.lbDatos2.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // ModHistorialMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbDatos2);
            this.Controls.Add(this.lbDatos1);
            this.Controls.Add(this.lbMedico);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbTipoHistMed);
            this.Name = "ModHistorialMedForm";
            this.Text = "ModHistorialMedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoHistMed;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.Label lbDatos1;
        private System.Windows.Forms.Label lbDatos2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}