namespace HospitalForms
{
    partial class ModifyPacForm
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
            this.lbModEnfermedad = new System.Windows.Forms.Label();
            this.txtModEnfermedad = new System.Windows.Forms.TextBox();
            this.lbModEdad = new System.Windows.Forms.Label();
            this.txtModEdad = new System.Windows.Forms.TextBox();
            this.lbModNomMedico = new System.Windows.Forms.Label();
            this.txtModMedico = new System.Windows.Forms.TextBox();
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
            this.txtModNombre.Size = new System.Drawing.Size(184, 22);
            this.txtModNombre.TabIndex = 1;
            // 
            // lbModEnfermedad
            // 
            this.lbModEnfermedad.AutoSize = true;
            this.lbModEnfermedad.Location = new System.Drawing.Point(12, 47);
            this.lbModEnfermedad.Name = "lbModEnfermedad";
            this.lbModEnfermedad.Size = new System.Drawing.Size(84, 16);
            this.lbModEnfermedad.TabIndex = 2;
            this.lbModEnfermedad.Text = "Enfermedad:";
            // 
            // txtModEnfermedad
            // 
            this.txtModEnfermedad.Location = new System.Drawing.Point(102, 44);
            this.txtModEnfermedad.Name = "txtModEnfermedad";
            this.txtModEnfermedad.Size = new System.Drawing.Size(159, 22);
            this.txtModEnfermedad.TabIndex = 3;
            // 
            // lbModEdad
            // 
            this.lbModEdad.AutoSize = true;
            this.lbModEdad.Location = new System.Drawing.Point(12, 86);
            this.lbModEdad.Name = "lbModEdad";
            this.lbModEdad.Size = new System.Drawing.Size(43, 16);
            this.lbModEdad.TabIndex = 4;
            this.lbModEdad.Text = "Edad:";
            // 
            // txtModEdad
            // 
            this.txtModEdad.Location = new System.Drawing.Point(77, 83);
            this.txtModEdad.Name = "txtModEdad";
            this.txtModEdad.Size = new System.Drawing.Size(184, 22);
            this.txtModEdad.TabIndex = 5;
            // 
            // lbModNomMedico
            // 
            this.lbModNomMedico.AutoSize = true;
            this.lbModNomMedico.Location = new System.Drawing.Point(12, 123);
            this.lbModNomMedico.Name = "lbModNomMedico";
            this.lbModNomMedico.Size = new System.Drawing.Size(107, 16);
            this.lbModNomMedico.TabIndex = 6;
            this.lbModNomMedico.Text = "Nombre medico:";
            // 
            // txtModMedico
            // 
            this.txtModMedico.Location = new System.Drawing.Point(125, 120);
            this.txtModMedico.Name = "txtModMedico";
            this.txtModMedico.Size = new System.Drawing.Size(136, 22);
            this.txtModMedico.TabIndex = 7;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 163);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(196, 163);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 9;
            this.butConfirm.Text = "Confirmar";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // ModifyPacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 198);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.txtModMedico);
            this.Controls.Add(this.lbModNomMedico);
            this.Controls.Add(this.txtModEdad);
            this.Controls.Add(this.lbModEdad);
            this.Controls.Add(this.txtModEnfermedad);
            this.Controls.Add(this.lbModEnfermedad);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.lbModNombre);
            this.Name = "ModifyPacForm";
            this.Text = "ModifyPacForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyPacForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModNombre;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label lbModEnfermedad;
        private System.Windows.Forms.TextBox txtModEnfermedad;
        private System.Windows.Forms.Label lbModEdad;
        private System.Windows.Forms.TextBox txtModEdad;
        private System.Windows.Forms.Label lbModNomMedico;
        private System.Windows.Forms.TextBox txtModMedico;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butConfirm;
    }
}