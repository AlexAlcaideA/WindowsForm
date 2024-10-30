namespace HospitalForms
{
    partial class ModifyPersAdmiForm
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
            this.lbModNombre = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.lbModDepartamento = new System.Windows.Forms.Label();
            this.lbModFechaContr = new System.Windows.Forms.Label();
            this.cmbModDepart = new System.Windows.Forms.ComboBox();
            this.dtpFechaContrata = new System.Windows.Forms.DateTimePicker();
            this.butCancel = new System.Windows.Forms.Button();
            this.butConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbModNombre
            // 
            this.lbModNombre.AutoSize = true;
            this.lbModNombre.Location = new System.Drawing.Point(12, 9);
            this.lbModNombre.Name = "lbModNombre";
            this.lbModNombre.Size = new System.Drawing.Size(59, 16);
            this.lbModNombre.TabIndex = 0;
            this.lbModNombre.Text = "Nombre:";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(77, 6);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(178, 22);
            this.txtModNombre.TabIndex = 1;
            // 
            // lbModDepartamento
            // 
            this.lbModDepartamento.AutoSize = true;
            this.lbModDepartamento.Location = new System.Drawing.Point(12, 48);
            this.lbModDepartamento.Name = "lbModDepartamento";
            this.lbModDepartamento.Size = new System.Drawing.Size(96, 16);
            this.lbModDepartamento.TabIndex = 2;
            this.lbModDepartamento.Text = "Departamento:";
            // 
            // lbModFechaContr
            // 
            this.lbModFechaContr.AutoSize = true;
            this.lbModFechaContr.Location = new System.Drawing.Point(12, 85);
            this.lbModFechaContr.Name = "lbModFechaContr";
            this.lbModFechaContr.Size = new System.Drawing.Size(124, 16);
            this.lbModFechaContr.TabIndex = 3;
            this.lbModFechaContr.Text = "Fecha contratacion:";
            // 
            // cmbModDepart
            // 
            this.cmbModDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModDepart.FormattingEnabled = true;
            this.cmbModDepart.Location = new System.Drawing.Point(114, 45);
            this.cmbModDepart.Name = "cmbModDepart";
            this.cmbModDepart.Size = new System.Drawing.Size(141, 24);
            this.cmbModDepart.TabIndex = 4;
            // 
            // dtpFechaContrata
            // 
            this.dtpFechaContrata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContrata.Location = new System.Drawing.Point(142, 80);
            this.dtpFechaContrata.Name = "dtpFechaContrata";
            this.dtpFechaContrata.Size = new System.Drawing.Size(113, 22);
            this.dtpFechaContrata.TabIndex = 5;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 132);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Cancelar";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(188, 132);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 7;
            this.butConfirm.Text = "Confirmar";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // ModifyPersAdmiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 167);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.dtpFechaContrata);
            this.Controls.Add(this.cmbModDepart);
            this.Controls.Add(this.lbModFechaContr);
            this.Controls.Add(this.lbModDepartamento);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.lbModNombre);
            this.Name = "ModifyPersAdmiForm";
            this.Text = "ModifyPersAdmiForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyPersAdmiForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModNombre;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label lbModDepartamento;
        private System.Windows.Forms.Label lbModFechaContr;
        private System.Windows.Forms.ComboBox cmbModDepart;
        private System.Windows.Forms.DateTimePicker dtpFechaContrata;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butConfirm;
    }
}