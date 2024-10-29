namespace HospitalForms
{
    partial class ModifyMedicForm
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
            this.butCancel = new System.Windows.Forms.Button();
            this.lbModNombre = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.lbModExperiencia = new System.Windows.Forms.Label();
            this.txtModExp = new System.Windows.Forms.TextBox();
            this.lbModEspecialidad = new System.Windows.Forms.Label();
            this.txtModEspecialidad = new System.Windows.Forms.TextBox();
            this.butConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(12, 141);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 0;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // lbModNombre
            // 
            this.lbModNombre.AutoSize = true;
            this.lbModNombre.Location = new System.Drawing.Point(9, 9);
            this.lbModNombre.Name = "lbModNombre";
            this.lbModNombre.Size = new System.Drawing.Size(59, 16);
            this.lbModNombre.TabIndex = 1;
            this.lbModNombre.Text = "Nombre:";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(74, 6);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(179, 22);
            this.txtModNombre.TabIndex = 2;
            // 
            // lbModExperiencia
            // 
            this.lbModExperiencia.AutoSize = true;
            this.lbModExperiencia.Location = new System.Drawing.Point(9, 61);
            this.lbModExperiencia.Name = "lbModExperiencia";
            this.lbModExperiencia.Size = new System.Drawing.Size(114, 16);
            this.lbModExperiencia.TabIndex = 3;
            this.lbModExperiencia.Text = "Años experiencia:";
            // 
            // txtModExp
            // 
            this.txtModExp.Location = new System.Drawing.Point(129, 58);
            this.txtModExp.Name = "txtModExp";
            this.txtModExp.Size = new System.Drawing.Size(124, 22);
            this.txtModExp.TabIndex = 4;
            // 
            // lbModEspecialidad
            // 
            this.lbModEspecialidad.AutoSize = true;
            this.lbModEspecialidad.Location = new System.Drawing.Point(9, 98);
            this.lbModEspecialidad.Name = "lbModEspecialidad";
            this.lbModEspecialidad.Size = new System.Drawing.Size(90, 16);
            this.lbModEspecialidad.TabIndex = 5;
            this.lbModEspecialidad.Text = "Especialidad:";
            // 
            // txtModEspecialidad
            // 
            this.txtModEspecialidad.Location = new System.Drawing.Point(105, 95);
            this.txtModEspecialidad.Name = "txtModEspecialidad";
            this.txtModEspecialidad.Size = new System.Drawing.Size(148, 22);
            this.txtModEspecialidad.TabIndex = 6;
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(205, 143);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 7;
            this.butConfirm.Text = "Confirmar";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // ModifyMedicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 178);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.txtModEspecialidad);
            this.Controls.Add(this.lbModEspecialidad);
            this.Controls.Add(this.txtModExp);
            this.Controls.Add(this.lbModExperiencia);
            this.Controls.Add(this.txtModNombre);
            this.Controls.Add(this.lbModNombre);
            this.Controls.Add(this.butCancel);
            this.Name = "ModifyMedicForm";
            this.Text = "ModifyMedicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label lbModNombre;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Label lbModExperiencia;
        private System.Windows.Forms.TextBox txtModExp;
        private System.Windows.Forms.Label lbModEspecialidad;
        private System.Windows.Forms.TextBox txtModEspecialidad;
        private System.Windows.Forms.Button butConfirm;
    }
}