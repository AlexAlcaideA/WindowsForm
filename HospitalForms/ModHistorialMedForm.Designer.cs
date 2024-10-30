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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.txtDatos1 = new System.Windows.Forms.TextBox();
            this.txtDatos2 = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTipoHistMed
            // 
            this.lbTipoHistMed.AutoSize = true;
            this.lbTipoHistMed.Location = new System.Drawing.Point(9, 7);
            this.lbTipoHistMed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoHistMed.Name = "lbTipoHistMed";
            this.lbTipoHistMed.Size = new System.Drawing.Size(35, 13);
            this.lbTipoHistMed.TabIndex = 0;
            this.lbTipoHistMed.Text = "label1";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(9, 32);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 13);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(9, 60);
            this.lbMedico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(45, 13);
            this.lbMedico.TabIndex = 2;
            this.lbMedico.Text = "Medico:";
            // 
            // lbDatos1
            // 
            this.lbDatos1.AutoSize = true;
            this.lbDatos1.Location = new System.Drawing.Point(9, 94);
            this.lbDatos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDatos1.Name = "lbDatos1";
            this.lbDatos1.Size = new System.Drawing.Size(35, 13);
            this.lbDatos1.TabIndex = 3;
            this.lbDatos1.Text = "label1";
            // 
            // lbDatos2
            // 
            this.lbDatos2.AutoSize = true;
            this.lbDatos2.Location = new System.Drawing.Point(9, 154);
            this.lbDatos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDatos2.Name = "lbDatos2";
            this.lbDatos2.Size = new System.Drawing.Size(35, 13);
            this.lbDatos2.TabIndex = 4;
            this.lbDatos2.Text = "label1";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(55, 28);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(135, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // cmbMedico
            // 
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(55, 58);
            this.cmbMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(135, 21);
            this.cmbMedico.TabIndex = 6;
            // 
            // txtDatos1
            // 
            this.txtDatos1.Location = new System.Drawing.Point(55, 91);
            this.txtDatos1.Multiline = true;
            this.txtDatos1.Name = "txtDatos1";
            this.txtDatos1.Size = new System.Drawing.Size(135, 50);
            this.txtDatos1.TabIndex = 7;
            // 
            // txtDatos2
            // 
            this.txtDatos2.Location = new System.Drawing.Point(55, 151);
            this.txtDatos2.Multiline = true;
            this.txtDatos2.Name = "txtDatos2";
            this.txtDatos2.Size = new System.Drawing.Size(135, 51);
            this.txtDatos2.TabIndex = 8;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 215);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "Cancelar";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(144, 215);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 10;
            this.butConfirm.Text = "Confirmar";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // ModHistorialMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 250);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.txtDatos2);
            this.Controls.Add(this.txtDatos1);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbDatos2);
            this.Controls.Add(this.lbDatos1);
            this.Controls.Add(this.lbMedico);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbTipoHistMed);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModHistorialMedForm";
            this.Text = "ModHistorialMedForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModHistorialMedForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoHistMed;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.Label lbDatos1;
        private System.Windows.Forms.Label lbDatos2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.TextBox txtDatos1;
        private System.Windows.Forms.TextBox txtDatos2;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butConfirm;
    }
}