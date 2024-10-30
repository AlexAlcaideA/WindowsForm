namespace HospitalForms
{
    partial class HistorialMedicoForm
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
            this.lstbHistorial = new System.Windows.Forms.ListBox();
            this.lbHistorialPac = new System.Windows.Forms.Label();
            this.butAnyadir = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbFiltroMes = new System.Windows.Forms.Label();
            this.lbFiltroAnyo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNombrePac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbHistorial
            // 
            this.lstbHistorial.FormattingEnabled = true;
            this.lstbHistorial.ItemHeight = 16;
            this.lstbHistorial.Location = new System.Drawing.Point(12, 43);
            this.lstbHistorial.Name = "lstbHistorial";
            this.lstbHistorial.Size = new System.Drawing.Size(284, 356);
            this.lstbHistorial.TabIndex = 0;
            // 
            // lbHistorialPac
            // 
            this.lbHistorialPac.AutoSize = true;
            this.lbHistorialPac.Location = new System.Drawing.Point(12, 9);
            this.lbHistorialPac.Name = "lbHistorialPac";
            this.lbHistorialPac.Size = new System.Drawing.Size(136, 16);
            this.lbHistorialPac.TabIndex = 1;
            this.lbHistorialPac.Text = "Historial del paciente:";
            // 
            // butAnyadir
            // 
            this.butAnyadir.Location = new System.Drawing.Point(12, 415);
            this.butAnyadir.Name = "butAnyadir";
            this.butAnyadir.Size = new System.Drawing.Size(75, 23);
            this.butAnyadir.TabIndex = 2;
            this.butAnyadir.Text = "Añadir";
            this.butAnyadir.UseVisualStyleBackColor = true;
            this.butAnyadir.Click += new System.EventHandler(this.butAnyadir_Click);
            // 
            // butMod
            // 
            this.butMod.Location = new System.Drawing.Point(221, 415);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(75, 23);
            this.butMod.TabIndex = 3;
            this.butMod.Text = "Modificar";
            this.butMod.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboBox1.Location = new System.Drawing.Point(302, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lbFiltroMes
            // 
            this.lbFiltroMes.AutoSize = true;
            this.lbFiltroMes.Location = new System.Drawing.Point(302, 43);
            this.lbFiltroMes.Name = "lbFiltroMes";
            this.lbFiltroMes.Size = new System.Drawing.Size(36, 16);
            this.lbFiltroMes.TabIndex = 5;
            this.lbFiltroMes.Text = "Mes:";
            // 
            // lbFiltroAnyo
            // 
            this.lbFiltroAnyo.AutoSize = true;
            this.lbFiltroAnyo.Location = new System.Drawing.Point(435, 43);
            this.lbFiltroAnyo.Name = "lbFiltroAnyo";
            this.lbFiltroAnyo.Size = new System.Drawing.Size(34, 16);
            this.lbFiltroAnyo.TabIndex = 6;
            this.lbFiltroAnyo.Text = "Año:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // lbNombrePac
            // 
            this.lbNombrePac.AutoSize = true;
            this.lbNombrePac.Location = new System.Drawing.Point(154, 9);
            this.lbNombrePac.Name = "lbNombrePac";
            this.lbNombrePac.Size = new System.Drawing.Size(44, 16);
            this.lbNombrePac.TabIndex = 8;
            this.lbNombrePac.Text = "label1";
            // 
            // HistorialMedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.lbNombrePac);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbFiltroAnyo);
            this.Controls.Add(this.lbFiltroMes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butAnyadir);
            this.Controls.Add(this.lbHistorialPac);
            this.Controls.Add(this.lstbHistorial);
            this.Name = "HistorialMedicoForm";
            this.Text = "HistorialMedicoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbHistorial;
        private System.Windows.Forms.Label lbHistorialPac;
        private System.Windows.Forms.Button butAnyadir;
        private System.Windows.Forms.Button butMod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbFiltroMes;
        private System.Windows.Forms.Label lbFiltroAnyo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNombrePac;
    }
}