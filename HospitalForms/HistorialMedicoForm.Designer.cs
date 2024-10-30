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
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lbFiltroMes = new System.Windows.Forms.Label();
            this.lbFiltroAnyo = new System.Windows.Forms.Label();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.lbNombrePac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbHistorial
            // 
            this.lstbHistorial.FormattingEnabled = true;
            this.lstbHistorial.Location = new System.Drawing.Point(9, 35);
            this.lstbHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstbHistorial.Name = "lstbHistorial";
            this.lstbHistorial.Size = new System.Drawing.Size(319, 290);
            this.lstbHistorial.TabIndex = 0;
            // 
            // lbHistorialPac
            // 
            this.lbHistorialPac.AutoSize = true;
            this.lbHistorialPac.Location = new System.Drawing.Point(9, 7);
            this.lbHistorialPac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHistorialPac.Name = "lbHistorialPac";
            this.lbHistorialPac.Size = new System.Drawing.Size(108, 13);
            this.lbHistorialPac.TabIndex = 1;
            this.lbHistorialPac.Text = "Historial del paciente:";
            // 
            // butAnyadir
            // 
            this.butAnyadir.Location = new System.Drawing.Point(9, 337);
            this.butAnyadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAnyadir.Name = "butAnyadir";
            this.butAnyadir.Size = new System.Drawing.Size(56, 19);
            this.butAnyadir.TabIndex = 2;
            this.butAnyadir.Text = "Añadir";
            this.butAnyadir.UseVisualStyleBackColor = true;
            this.butAnyadir.Click += new System.EventHandler(this.butAnyadir_Click);
            // 
            // butMod
            // 
            this.butMod.Location = new System.Drawing.Point(272, 337);
            this.butMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(56, 19);
            this.butMod.TabIndex = 3;
            this.butMod.Text = "Modificar";
            this.butMod.UseVisualStyleBackColor = true;
            this.butMod.Click += new System.EventHandler(this.butMod_Click);
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
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
            this.cmbMes.Location = new System.Drawing.Point(335, 62);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(76, 21);
            this.cmbMes.TabIndex = 4;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // lbFiltroMes
            // 
            this.lbFiltroMes.AutoSize = true;
            this.lbFiltroMes.Location = new System.Drawing.Point(332, 36);
            this.lbFiltroMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiltroMes.Name = "lbFiltroMes";
            this.lbFiltroMes.Size = new System.Drawing.Size(30, 13);
            this.lbFiltroMes.TabIndex = 5;
            this.lbFiltroMes.Text = "Mes:";
            // 
            // lbFiltroAnyo
            // 
            this.lbFiltroAnyo.AutoSize = true;
            this.lbFiltroAnyo.Location = new System.Drawing.Point(333, 94);
            this.lbFiltroAnyo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiltroAnyo.Name = "lbFiltroAnyo";
            this.lbFiltroAnyo.Size = new System.Drawing.Size(29, 13);
            this.lbFiltroAnyo.TabIndex = 6;
            this.lbFiltroAnyo.Text = "Año:";
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(335, 117);
            this.txtAnyo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(76, 20);
            this.txtAnyo.TabIndex = 7;
            this.txtAnyo.TextChanged += new System.EventHandler(this.txtAnyo_TextChanged);
            // 
            // lbNombrePac
            // 
            this.lbNombrePac.AutoSize = true;
            this.lbNombrePac.Location = new System.Drawing.Point(116, 7);
            this.lbNombrePac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombrePac.Name = "lbNombrePac";
            this.lbNombrePac.Size = new System.Drawing.Size(35, 13);
            this.lbNombrePac.TabIndex = 8;
            this.lbNombrePac.Text = "label1";
            // 
            // HistorialMedicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 366);
            this.Controls.Add(this.lbNombrePac);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.lbFiltroAnyo);
            this.Controls.Add(this.lbFiltroMes);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butAnyadir);
            this.Controls.Add(this.lbHistorialPac);
            this.Controls.Add(this.lstbHistorial);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lbFiltroMes;
        private System.Windows.Forms.Label lbFiltroAnyo;
        private System.Windows.Forms.TextBox txtAnyo;
        private System.Windows.Forms.Label lbNombrePac;
    }
}