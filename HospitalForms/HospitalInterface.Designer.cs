namespace HospitalForms
{
    partial class HospitalInterface
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPersonas = new System.Windows.Forms.TabPage();
            this.tabCitas = new System.Windows.Forms.TabPage();
            this.lbNombrePersona = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTipoPersona = new System.Windows.Forms.Label();
            this.lstbPersonal = new System.Windows.Forms.ListBox();
            this.cmbTipoPersonas = new System.Windows.Forms.ComboBox();
            this.butAnyadirPersonal = new System.Windows.Forms.Button();
            this.butModDatos = new System.Windows.Forms.Button();
            this.butActualizarLista = new System.Windows.Forms.Button();
            this.tbcPrincipal.SuspendLayout();
            this.tabPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tabPersonas);
            this.tbcPrincipal.Controls.Add(this.tabCitas);
            this.tbcPrincipal.Location = new System.Drawing.Point(-2, -1);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(475, 452);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // tabPersonas
            // 
            this.tabPersonas.Controls.Add(this.butActualizarLista);
            this.tabPersonas.Controls.Add(this.butModDatos);
            this.tabPersonas.Controls.Add(this.butAnyadirPersonal);
            this.tabPersonas.Controls.Add(this.cmbTipoPersonas);
            this.tabPersonas.Controls.Add(this.lstbPersonal);
            this.tabPersonas.Controls.Add(this.lbTipoPersona);
            this.tabPersonas.Controls.Add(this.textBox1);
            this.tabPersonas.Controls.Add(this.lbNombrePersona);
            this.tabPersonas.Location = new System.Drawing.Point(4, 25);
            this.tabPersonas.Name = "tabPersonas";
            this.tabPersonas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonas.Size = new System.Drawing.Size(467, 423);
            this.tabPersonas.TabIndex = 0;
            this.tabPersonas.Text = "Personas";
            this.tabPersonas.UseVisualStyleBackColor = true;
            // 
            // tabCitas
            // 
            this.tabCitas.Location = new System.Drawing.Point(4, 25);
            this.tabCitas.Name = "tabCitas";
            this.tabCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCitas.Size = new System.Drawing.Size(467, 423);
            this.tabCitas.TabIndex = 1;
            this.tabCitas.Text = "Citas";
            this.tabCitas.UseVisualStyleBackColor = true;
            // 
            // lbNombrePersona
            // 
            this.lbNombrePersona.AutoSize = true;
            this.lbNombrePersona.Location = new System.Drawing.Point(10, 27);
            this.lbNombrePersona.Name = "lbNombrePersona";
            this.lbNombrePersona.Size = new System.Drawing.Size(59, 16);
            this.lbNombrePersona.TabIndex = 0;
            this.lbNombrePersona.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lbTipoPersona
            // 
            this.lbTipoPersona.AutoSize = true;
            this.lbTipoPersona.Location = new System.Drawing.Point(210, 27);
            this.lbTipoPersona.Name = "lbTipoPersona";
            this.lbTipoPersona.Size = new System.Drawing.Size(38, 16);
            this.lbTipoPersona.TabIndex = 2;
            this.lbTipoPersona.Text = "Tipo:";
            // 
            // lstbPersonal
            // 
            this.lstbPersonal.FormattingEnabled = true;
            this.lstbPersonal.ItemHeight = 16;
            this.lstbPersonal.Location = new System.Drawing.Point(13, 69);
            this.lstbPersonal.Name = "lstbPersonal";
            this.lstbPersonal.ScrollAlwaysVisible = true;
            this.lstbPersonal.Size = new System.Drawing.Size(235, 308);
            this.lstbPersonal.TabIndex = 3;
            this.lstbPersonal.SelectedIndexChanged += new System.EventHandler(this.lstbPersonal_SelectedIndexChanged);
            // 
            // cmbTipoPersonas
            // 
            this.cmbTipoPersonas.AutoCompleteCustomSource.AddRange(new string[] {
            "Medic",
            "Doctor",
            "Administrative Personnel"});
            this.cmbTipoPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersonas.FormattingEnabled = true;
            this.cmbTipoPersonas.Location = new System.Drawing.Point(254, 24);
            this.cmbTipoPersonas.Name = "cmbTipoPersonas";
            this.cmbTipoPersonas.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoPersonas.TabIndex = 4;
            // 
            // butAnyadirPersonal
            // 
            this.butAnyadirPersonal.Location = new System.Drawing.Point(13, 391);
            this.butAnyadirPersonal.Name = "butAnyadirPersonal";
            this.butAnyadirPersonal.Size = new System.Drawing.Size(105, 23);
            this.butAnyadirPersonal.TabIndex = 5;
            this.butAnyadirPersonal.Text = "Añadir";
            this.butAnyadirPersonal.UseVisualStyleBackColor = true;
            this.butAnyadirPersonal.Click += new System.EventHandler(this.butAnyadirPersonal_Click);
            // 
            // butModDatos
            // 
            this.butModDatos.Location = new System.Drawing.Point(137, 391);
            this.butModDatos.Name = "butModDatos";
            this.butModDatos.Size = new System.Drawing.Size(111, 23);
            this.butModDatos.TabIndex = 6;
            this.butModDatos.Text = "Modificar datos";
            this.butModDatos.UseVisualStyleBackColor = true;
            // 
            // butActualizarLista
            // 
            this.butActualizarLista.Location = new System.Drawing.Point(254, 69);
            this.butActualizarLista.Name = "butActualizarLista";
            this.butActualizarLista.Size = new System.Drawing.Size(105, 23);
            this.butActualizarLista.TabIndex = 7;
            this.butActualizarLista.Text = "Actualizar lista";
            this.butActualizarLista.UseVisualStyleBackColor = true;
            this.butActualizarLista.Click += new System.EventHandler(this.butActualizarLista_Click);
            // 
            // HospitalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.tbcPrincipal);
            this.Name = "HospitalInterface";
            this.Text = "Form1";
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPersonas.ResumeLayout(false);
            this.tabPersonas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabPersonas;
        private System.Windows.Forms.TabPage tabCitas;
        private System.Windows.Forms.Button butAnyadirPersonal;
        private System.Windows.Forms.ComboBox cmbTipoPersonas;
        private System.Windows.Forms.ListBox lstbPersonal;
        private System.Windows.Forms.Label lbTipoPersona;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNombrePersona;
        private System.Windows.Forms.Button butModDatos;
        private System.Windows.Forms.Button butActualizarLista;
    }
}

