namespace HospitalForms
{
    partial class AddCitaForm
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
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lbMedico = new System.Windows.Forms.Label();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(12, 9);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(48, 16);
            this.lbFecha.TabIndex = 0;
            this.lbFecha.Text = "Fecha:";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Checked = false;
            this.dtpFechaCita.CustomFormat = "dd/MM/yyyy a la hh:mm";
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCita.Location = new System.Drawing.Point(66, 4);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.ShowCheckBox = true;
            this.dtpFechaCita.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaCita.TabIndex = 1;
            // 
            // lbMedico
            // 
            this.lbMedico.AutoSize = true;
            this.lbMedico.Location = new System.Drawing.Point(12, 43);
            this.lbMedico.Name = "lbMedico";
            this.lbMedico.Size = new System.Drawing.Size(55, 16);
            this.lbMedico.TabIndex = 2;
            this.lbMedico.Text = "Medico:";
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Location = new System.Drawing.Point(12, 80);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(63, 16);
            this.lbPaciente.TabIndex = 3;
            this.lbPaciente.Text = "Paciente:";
            // 
            // cmbMedico
            // 
            this.cmbMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(73, 40);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(193, 24);
            this.cmbMedico.TabIndex = 4;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(81, 77);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(185, 24);
            this.cmbPaciente.TabIndex = 5;
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(12, 122);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 6;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(191, 122);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 7;
            this.butConfirm.Text = "Confirmar";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // AddCitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 157);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.cmbPaciente);
            this.Controls.Add(this.cmbMedico);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.lbMedico);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.lbFecha);
            this.Name = "AddCitaForm";
            this.Text = "AddCitaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lbMedico;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butConfirm;
    }
}