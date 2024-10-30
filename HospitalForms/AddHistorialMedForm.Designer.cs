namespace HospitalForms
{
    partial class AddHistorialMedForm
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
            this.cmbHistMed = new System.Windows.Forms.ComboBox();
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
            this.lbTipoHistMed.Location = new System.Drawing.Point(12, 9);
            this.lbTipoHistMed.Name = "lbTipoHistMed";
            this.lbTipoHistMed.Size = new System.Drawing.Size(135, 16);
            this.lbTipoHistMed.TabIndex = 0;
            this.lbTipoHistMed.Text = "Tipo historial medico:";
            // 
            // cmbHistMed
            // 
            this.cmbHistMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHistMed.FormattingEnabled = true;
            this.cmbHistMed.Items.AddRange(new object[] {
            "Tratamiento",
            "Diagnostico"});
            this.cmbHistMed.Location = new System.Drawing.Point(153, 6);
            this.cmbHistMed.Name = "cmbHistMed";
            this.cmbHistMed.Size = new System.Drawing.Size(121, 24);
            this.cmbHistMed.TabIndex = 1;
            this.cmbHistMed.SelectedIndexChanged += new System.EventHandler(this.cmbHistMed_SelectedIndexChanged);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(12, 50);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(48, 16);
            this.lbFecha.TabIndex = 2;
            this.lbFecha.Text = "Fecha:";
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(12, 81);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(55, 16);
            this.lbMedico.TabIndex = 3;
            this.lbMedico.Text = "Medico:";
            // 
            // lbDatos1
            // 
            this.lbDatos1.AutoSize = true;
            this.lbDatos1.Location = new System.Drawing.Point(12, 113);
            this.lbDatos1.Name = "lbDatos1";
            this.lbDatos1.Size = new System.Drawing.Size(44, 16);
            this.lbDatos1.TabIndex = 4;
            this.lbDatos1.Text = "label1";
            // 
            // lbDatos2
            // 
            this.lbDatos2.AutoSize = true;
            this.lbDatos2.Location = new System.Drawing.Point(12, 193);
            this.lbDatos2.Name = "lbDatos2";
            this.lbDatos2.Size = new System.Drawing.Size(44, 16);
            this.lbDatos2.TabIndex = 5;
            this.lbDatos2.Text = "label1";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(74, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowCheckBox = true;
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 6;
            // 
            // cmbMedico
            // 
            this.cmbMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(73, 78);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(201, 24);
            this.cmbMedico.TabIndex = 7;
            // 
            // txtDatos1
            // 
            this.txtDatos1.Location = new System.Drawing.Point(104, 110);
            this.txtDatos1.Multiline = true;
            this.txtDatos1.Name = "txtDatos1";
            this.txtDatos1.Size = new System.Drawing.Size(170, 57);
            this.txtDatos1.TabIndex = 8;
            // 
            // txtDatos2
            // 
            this.txtDatos2.Location = new System.Drawing.Point(104, 190);
            this.txtDatos2.Multiline = true;
            this.txtDatos2.Name = "txtDatos2";
            this.txtDatos2.Size = new System.Drawing.Size(169, 56);
            this.txtDatos2.TabIndex = 9;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 257);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 10;
            this.butCancel.Text = "Cancelar";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(204, 257);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 11;
            this.butConfirm.Text = "Confirmar";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // AddHistorialMedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 292);
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
            this.Controls.Add(this.cmbHistMed);
            this.Controls.Add(this.lbTipoHistMed);
            this.Name = "AddHistorialMedForm";
            this.Text = "AddHistorialMedForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddHistorialMedForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoHistMed;
        private System.Windows.Forms.ComboBox cmbHistMed;
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