namespace HospitalForms
{
    partial class ListaPacientesForm
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
            this.lstbPacientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbPacientes
            // 
            this.lstbPacientes.FormattingEnabled = true;
            this.lstbPacientes.ItemHeight = 16;
            this.lstbPacientes.Location = new System.Drawing.Point(12, 12);
            this.lstbPacientes.Name = "lstbPacientes";
            this.lstbPacientes.Size = new System.Drawing.Size(303, 420);
            this.lstbPacientes.TabIndex = 0;
            // 
            // ListaPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.lstbPacientes);
            this.Name = "ListaPacientesForm";
            this.Text = "ListaPacientesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaPacientesForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbPacientes;
    }
}