namespace HospitalForms
{
    partial class AddPersonnelForm
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
            this.lbAnyNombre = new System.Windows.Forms.Label();
            this.txtAnyNombre = new System.Windows.Forms.TextBox();
            this.lbTipoPeronal = new System.Windows.Forms.Label();
            this.cmbAnyTipo = new System.Windows.Forms.ComboBox();
            this.butAnyAlta = new System.Windows.Forms.Button();
            this.lbAnyDatos1 = new System.Windows.Forms.Label();
            this.txtAnyDatos1 = new System.Windows.Forms.TextBox();
            this.txtAnyDatos2 = new System.Windows.Forms.TextBox();
            this.lbAnyDatos2 = new System.Windows.Forms.Label();
            this.txtAnyDatos3 = new System.Windows.Forms.TextBox();
            this.lbAnyDatos3 = new System.Windows.Forms.Label();
            this.lbAnyFechaContrato = new System.Windows.Forms.Label();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.cmbAnyDatosLista = new System.Windows.Forms.ComboBox();
            this.lbListaMedicos = new System.Windows.Forms.Label();
            this.lstbMedicos = new System.Windows.Forms.ListBox();
            this.lbFiltroNombre = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAnyNombre
            // 
            this.lbAnyNombre.AutoSize = true;
            this.lbAnyNombre.Location = new System.Drawing.Point(12, 42);
            this.lbAnyNombre.Name = "lbAnyNombre";
            this.lbAnyNombre.Size = new System.Drawing.Size(59, 16);
            this.lbAnyNombre.TabIndex = 0;
            this.lbAnyNombre.Text = "Nombre:";
            // 
            // txtAnyNombre
            // 
            this.txtAnyNombre.Location = new System.Drawing.Point(77, 39);
            this.txtAnyNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnyNombre.Name = "txtAnyNombre";
            this.txtAnyNombre.Size = new System.Drawing.Size(177, 22);
            this.txtAnyNombre.TabIndex = 1;
            // 
            // lbTipoPeronal
            // 
            this.lbTipoPeronal.AutoSize = true;
            this.lbTipoPeronal.Location = new System.Drawing.Point(12, 86);
            this.lbTipoPeronal.Name = "lbTipoPeronal";
            this.lbTipoPeronal.Size = new System.Drawing.Size(38, 16);
            this.lbTipoPeronal.TabIndex = 2;
            this.lbTipoPeronal.Text = "Tipo:";
            // 
            // cmbAnyTipo
            // 
            this.cmbAnyTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Medico",
            "Paciente",
            "Personal Administrativo"});
            this.cmbAnyTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnyTipo.FormattingEnabled = true;
            this.cmbAnyTipo.Items.AddRange(new object[] {
            "Doctor",
            "Paciente",
            "Personal Administrativo"});
            this.cmbAnyTipo.Location = new System.Drawing.Point(141, 82);
            this.cmbAnyTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAnyTipo.Name = "cmbAnyTipo";
            this.cmbAnyTipo.Size = new System.Drawing.Size(113, 24);
            this.cmbAnyTipo.TabIndex = 3;
            this.cmbAnyTipo.SelectedIndexChanged += new System.EventHandler(this.cmbAnyTipo_SelectedIndexChanged);
            // 
            // butAnyAlta
            // 
            this.butAnyAlta.Location = new System.Drawing.Point(104, 415);
            this.butAnyAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAnyAlta.Name = "butAnyAlta";
            this.butAnyAlta.Size = new System.Drawing.Size(91, 23);
            this.butAnyAlta.TabIndex = 4;
            this.butAnyAlta.Text = "Dar de alta";
            this.butAnyAlta.UseVisualStyleBackColor = true;
            this.butAnyAlta.Click += new System.EventHandler(this.butAnyAlta_Click);
            // 
            // lbAnyDatos1
            // 
            this.lbAnyDatos1.AutoSize = true;
            this.lbAnyDatos1.Location = new System.Drawing.Point(12, 140);
            this.lbAnyDatos1.Name = "lbAnyDatos1";
            this.lbAnyDatos1.Size = new System.Drawing.Size(44, 16);
            this.lbAnyDatos1.TabIndex = 5;
            this.lbAnyDatos1.Text = "label1";
            this.lbAnyDatos1.Visible = false;
            // 
            // txtAnyDatos1
            // 
            this.txtAnyDatos1.Location = new System.Drawing.Point(141, 137);
            this.txtAnyDatos1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnyDatos1.Name = "txtAnyDatos1";
            this.txtAnyDatos1.Size = new System.Drawing.Size(113, 22);
            this.txtAnyDatos1.TabIndex = 6;
            this.txtAnyDatos1.Visible = false;
            // 
            // txtAnyDatos2
            // 
            this.txtAnyDatos2.Location = new System.Drawing.Point(141, 186);
            this.txtAnyDatos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnyDatos2.Name = "txtAnyDatos2";
            this.txtAnyDatos2.Size = new System.Drawing.Size(113, 22);
            this.txtAnyDatos2.TabIndex = 8;
            this.txtAnyDatos2.Visible = false;
            // 
            // lbAnyDatos2
            // 
            this.lbAnyDatos2.AutoSize = true;
            this.lbAnyDatos2.Location = new System.Drawing.Point(12, 190);
            this.lbAnyDatos2.Name = "lbAnyDatos2";
            this.lbAnyDatos2.Size = new System.Drawing.Size(44, 16);
            this.lbAnyDatos2.TabIndex = 7;
            this.lbAnyDatos2.Text = "label1";
            this.lbAnyDatos2.Visible = false;
            // 
            // txtAnyDatos3
            // 
            this.txtAnyDatos3.Location = new System.Drawing.Point(141, 236);
            this.txtAnyDatos3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnyDatos3.Name = "txtAnyDatos3";
            this.txtAnyDatos3.Size = new System.Drawing.Size(113, 22);
            this.txtAnyDatos3.TabIndex = 10;
            this.txtAnyDatos3.Visible = false;
            // 
            // lbAnyDatos3
            // 
            this.lbAnyDatos3.AutoSize = true;
            this.lbAnyDatos3.Location = new System.Drawing.Point(12, 239);
            this.lbAnyDatos3.Name = "lbAnyDatos3";
            this.lbAnyDatos3.Size = new System.Drawing.Size(44, 16);
            this.lbAnyDatos3.TabIndex = 9;
            this.lbAnyDatos3.Text = "label1";
            this.lbAnyDatos3.Visible = false;
            // 
            // lbAnyFechaContrato
            // 
            this.lbAnyFechaContrato.AutoSize = true;
            this.lbAnyFechaContrato.Location = new System.Drawing.Point(12, 313);
            this.lbAnyFechaContrato.Name = "lbAnyFechaContrato";
            this.lbAnyFechaContrato.Size = new System.Drawing.Size(99, 16);
            this.lbAnyFechaContrato.TabIndex = 11;
            this.lbAnyFechaContrato.Text = "Fecha contrato:";
            this.lbAnyFechaContrato.Visible = false;
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Checked = false;
            this.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContrato.Location = new System.Drawing.Point(117, 306);
            this.dtpFechaContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.ShowCheckBox = true;
            this.dtpFechaContrato.Size = new System.Drawing.Size(137, 22);
            this.dtpFechaContrato.TabIndex = 12;
            this.dtpFechaContrato.Visible = false;
            // 
            // cmbAnyDatosLista
            // 
            this.cmbAnyDatosLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnyDatosLista.FormattingEnabled = true;
            this.cmbAnyDatosLista.Items.AddRange(new object[] {
            "Oftalmologo",
            "Quirurgica",
            "Endocrinologia",
            "Famacologia",
            "Geriatria"});
            this.cmbAnyDatosLista.Location = new System.Drawing.Point(141, 135);
            this.cmbAnyDatosLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAnyDatosLista.Name = "cmbAnyDatosLista";
            this.cmbAnyDatosLista.Size = new System.Drawing.Size(113, 24);
            this.cmbAnyDatosLista.TabIndex = 13;
            this.cmbAnyDatosLista.Visible = false;
            // 
            // lbListaMedicos
            // 
            this.lbListaMedicos.AutoSize = true;
            this.lbListaMedicos.Location = new System.Drawing.Point(324, 42);
            this.lbListaMedicos.Name = "lbListaMedicos";
            this.lbListaMedicos.Size = new System.Drawing.Size(62, 16);
            this.lbListaMedicos.TabIndex = 14;
            this.lbListaMedicos.Text = "Medicos:";
            // 
            // lstbMedicos
            // 
            this.lstbMedicos.FormattingEnabled = true;
            this.lstbMedicos.ItemHeight = 16;
            this.lstbMedicos.Location = new System.Drawing.Point(327, 82);
            this.lstbMedicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbMedicos.Name = "lstbMedicos";
            this.lstbMedicos.Size = new System.Drawing.Size(160, 244);
            this.lstbMedicos.TabIndex = 15;
            // 
            // lbFiltroNombre
            // 
            this.lbFiltroNombre.AutoSize = true;
            this.lbFiltroNombre.Location = new System.Drawing.Point(443, 42);
            this.lbFiltroNombre.Name = "lbFiltroNombre";
            this.lbFiltroNombre.Size = new System.Drawing.Size(59, 16);
            this.lbFiltroNombre.TabIndex = 16;
            this.lbFiltroNombre.Text = "Nombre:";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(508, 39);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroNombre.TabIndex = 17;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            // 
            // AddPersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.lbFiltroNombre);
            this.Controls.Add(this.lstbMedicos);
            this.Controls.Add(this.lbListaMedicos);
            this.Controls.Add(this.cmbAnyDatosLista);
            this.Controls.Add(this.dtpFechaContrato);
            this.Controls.Add(this.lbAnyFechaContrato);
            this.Controls.Add(this.txtAnyDatos3);
            this.Controls.Add(this.lbAnyDatos3);
            this.Controls.Add(this.txtAnyDatos2);
            this.Controls.Add(this.lbAnyDatos2);
            this.Controls.Add(this.txtAnyDatos1);
            this.Controls.Add(this.lbAnyDatos1);
            this.Controls.Add(this.butAnyAlta);
            this.Controls.Add(this.cmbAnyTipo);
            this.Controls.Add(this.lbTipoPeronal);
            this.Controls.Add(this.txtAnyNombre);
            this.Controls.Add(this.lbAnyNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddPersonnelForm";
            this.Text = "AddPersonnelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPersonnelForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnyNombre;
        private System.Windows.Forms.TextBox txtAnyNombre;
        private System.Windows.Forms.Label lbTipoPeronal;
        private System.Windows.Forms.ComboBox cmbAnyTipo;
        private System.Windows.Forms.Button butAnyAlta;
        private System.Windows.Forms.Label lbAnyDatos1;
        private System.Windows.Forms.TextBox txtAnyDatos1;
        private System.Windows.Forms.TextBox txtAnyDatos2;
        private System.Windows.Forms.Label lbAnyDatos2;
        private System.Windows.Forms.TextBox txtAnyDatos3;
        private System.Windows.Forms.Label lbAnyDatos3;
        private System.Windows.Forms.Label lbAnyFechaContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.ComboBox cmbAnyDatosLista;
        private System.Windows.Forms.Label lbListaMedicos;
        private System.Windows.Forms.ListBox lstbMedicos;
        private System.Windows.Forms.Label lbFiltroNombre;
        private System.Windows.Forms.TextBox txtFiltroNombre;
    }
}