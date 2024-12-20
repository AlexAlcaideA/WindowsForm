﻿namespace HospitalForms
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
            this.butListPacMed = new System.Windows.Forms.Button();
            this.butElimPaciente = new System.Windows.Forms.Button();
            this.butModHistorialMed = new System.Windows.Forms.Button();
            this.butActualizarLista = new System.Windows.Forms.Button();
            this.butModDatos = new System.Windows.Forms.Button();
            this.butAnyadirPersonal = new System.Windows.Forms.Button();
            this.cmbTipoPersonas = new System.Windows.Forms.ComboBox();
            this.lstbPersonal = new System.Windows.Forms.ListBox();
            this.lbTipoPersona = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.lbNombrePersona = new System.Windows.Forms.Label();
            this.tabCitas = new System.Windows.Forms.TabPage();
            this.dgvListaCitas = new System.Windows.Forms.DataGridView();
            this.CitaColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitaColMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CitaColPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butAdd = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.tbcPrincipal.SuspendLayout();
            this.tabPersonas.SuspendLayout();
            this.tabCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).BeginInit();
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
            this.tabPersonas.Controls.Add(this.butListPacMed);
            this.tabPersonas.Controls.Add(this.butElimPaciente);
            this.tabPersonas.Controls.Add(this.butModHistorialMed);
            this.tabPersonas.Controls.Add(this.butActualizarLista);
            this.tabPersonas.Controls.Add(this.butModDatos);
            this.tabPersonas.Controls.Add(this.butAnyadirPersonal);
            this.tabPersonas.Controls.Add(this.cmbTipoPersonas);
            this.tabPersonas.Controls.Add(this.lstbPersonal);
            this.tabPersonas.Controls.Add(this.lbTipoPersona);
            this.tabPersonas.Controls.Add(this.txtBuscarNombre);
            this.tabPersonas.Controls.Add(this.lbNombrePersona);
            this.tabPersonas.Location = new System.Drawing.Point(4, 25);
            this.tabPersonas.Name = "tabPersonas";
            this.tabPersonas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonas.Size = new System.Drawing.Size(467, 423);
            this.tabPersonas.TabIndex = 0;
            this.tabPersonas.Text = "Personas";
            this.tabPersonas.UseVisualStyleBackColor = true;
            // 
            // butListPacMed
            // 
            this.butListPacMed.BackColor = System.Drawing.Color.Gray;
            this.butListPacMed.ForeColor = System.Drawing.Color.DarkGray;
            this.butListPacMed.Location = new System.Drawing.Point(254, 229);
            this.butListPacMed.Name = "butListPacMed";
            this.butListPacMed.Size = new System.Drawing.Size(121, 42);
            this.butListPacMed.TabIndex = 10;
            this.butListPacMed.Text = "Lista pacientes medico";
            this.butListPacMed.UseVisualStyleBackColor = false;
            this.butListPacMed.Click += new System.EventHandler(this.butListPacMed_Click);
            // 
            // butElimPaciente
            // 
            this.butElimPaciente.BackColor = System.Drawing.Color.Gray;
            this.butElimPaciente.ForeColor = System.Drawing.Color.DarkGray;
            this.butElimPaciente.Location = new System.Drawing.Point(254, 169);
            this.butElimPaciente.Name = "butElimPaciente";
            this.butElimPaciente.Size = new System.Drawing.Size(121, 23);
            this.butElimPaciente.TabIndex = 9;
            this.butElimPaciente.Text = "Eliminar paciente";
            this.butElimPaciente.UseVisualStyleBackColor = false;
            this.butElimPaciente.Click += new System.EventHandler(this.butElimPaciente_Click);
            // 
            // butModHistorialMed
            // 
            this.butModHistorialMed.BackColor = System.Drawing.Color.Gray;
            this.butModHistorialMed.Enabled = false;
            this.butModHistorialMed.ForeColor = System.Drawing.Color.DarkGray;
            this.butModHistorialMed.Location = new System.Drawing.Point(254, 123);
            this.butModHistorialMed.Name = "butModHistorialMed";
            this.butModHistorialMed.Size = new System.Drawing.Size(121, 40);
            this.butModHistorialMed.TabIndex = 8;
            this.butModHistorialMed.Text = "Historial medico paciente";
            this.butModHistorialMed.UseVisualStyleBackColor = false;
            this.butModHistorialMed.Click += new System.EventHandler(this.butModHistorialMed_Click);
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
            // butModDatos
            // 
            this.butModDatos.Location = new System.Drawing.Point(137, 391);
            this.butModDatos.Name = "butModDatos";
            this.butModDatos.Size = new System.Drawing.Size(111, 23);
            this.butModDatos.TabIndex = 6;
            this.butModDatos.Text = "Modificar datos";
            this.butModDatos.UseVisualStyleBackColor = true;
            this.butModDatos.Click += new System.EventHandler(this.butModDatos_Click);
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
            // cmbTipoPersonas
            // 
            this.cmbTipoPersonas.AutoCompleteCustomSource.AddRange(new string[] {
            "Medic",
            "Doctor",
            "Administrative Personnel"});
            this.cmbTipoPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersonas.FormattingEnabled = true;
            this.cmbTipoPersonas.Items.AddRange(new object[] {
            "",
            "Medico",
            "Paciente",
            "Pers. Administrativo"});
            this.cmbTipoPersonas.Location = new System.Drawing.Point(254, 24);
            this.cmbTipoPersonas.Name = "cmbTipoPersonas";
            this.cmbTipoPersonas.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoPersonas.TabIndex = 4;
            this.cmbTipoPersonas.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersonas_SelectedIndexChanged);
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
            // lbTipoPersona
            // 
            this.lbTipoPersona.AutoSize = true;
            this.lbTipoPersona.Location = new System.Drawing.Point(210, 27);
            this.lbTipoPersona.Name = "lbTipoPersona";
            this.lbTipoPersona.Size = new System.Drawing.Size(38, 16);
            this.lbTipoPersona.TabIndex = 2;
            this.lbTipoPersona.Text = "Tipo:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(75, 24);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarNombre.TabIndex = 1;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
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
            // tabCitas
            // 
            this.tabCitas.Controls.Add(this.butEliminar);
            this.tabCitas.Controls.Add(this.butMod);
            this.tabCitas.Controls.Add(this.butAdd);
            this.tabCitas.Controls.Add(this.dgvListaCitas);
            this.tabCitas.Location = new System.Drawing.Point(4, 25);
            this.tabCitas.Name = "tabCitas";
            this.tabCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCitas.Size = new System.Drawing.Size(467, 423);
            this.tabCitas.TabIndex = 1;
            this.tabCitas.Text = "Citas";
            this.tabCitas.UseVisualStyleBackColor = true;
            // 
            // dgvListaCitas
            // 
            this.dgvListaCitas.AllowUserToAddRows = false;
            this.dgvListaCitas.AllowUserToDeleteRows = false;
            this.dgvListaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CitaColFecha,
            this.CitaColMedico,
            this.CitaColPaciente});
            this.dgvListaCitas.Location = new System.Drawing.Point(10, 6);
            this.dgvListaCitas.Name = "dgvListaCitas";
            this.dgvListaCitas.ReadOnly = true;
            this.dgvListaCitas.RowHeadersWidth = 51;
            this.dgvListaCitas.RowTemplate.Height = 24;
            this.dgvListaCitas.Size = new System.Drawing.Size(449, 379);
            this.dgvListaCitas.TabIndex = 0;
            // 
            // CitaColFecha
            // 
            this.CitaColFecha.HeaderText = "Fecha";
            this.CitaColFecha.MinimumWidth = 6;
            this.CitaColFecha.Name = "CitaColFecha";
            this.CitaColFecha.ReadOnly = true;
            this.CitaColFecha.Width = 125;
            // 
            // CitaColMedico
            // 
            this.CitaColMedico.HeaderText = "Medico";
            this.CitaColMedico.MinimumWidth = 6;
            this.CitaColMedico.Name = "CitaColMedico";
            this.CitaColMedico.ReadOnly = true;
            this.CitaColMedico.Width = 125;
            // 
            // CitaColPaciente
            // 
            this.CitaColPaciente.HeaderText = "Paciente";
            this.CitaColPaciente.MinimumWidth = 6;
            this.CitaColPaciente.Name = "CitaColPaciente";
            this.CitaColPaciente.ReadOnly = true;
            this.CitaColPaciente.Width = 125;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(10, 391);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Añadir";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // butMod
            // 
            this.butMod.Location = new System.Drawing.Point(188, 391);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(75, 23);
            this.butMod.TabIndex = 2;
            this.butMod.Text = "Modificar";
            this.butMod.UseVisualStyleBackColor = true;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(384, 391);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(75, 23);
            this.butEliminar.TabIndex = 3;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
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
            this.tabCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCitas)).EndInit();
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
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label lbNombrePersona;
        private System.Windows.Forms.Button butModDatos;
        private System.Windows.Forms.Button butActualizarLista;
        private System.Windows.Forms.Button butModHistorialMed;
        private System.Windows.Forms.Button butListPacMed;
        private System.Windows.Forms.Button butElimPaciente;
        private System.Windows.Forms.DataGridView dgvListaCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaColMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CitaColPaciente;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butMod;
        private System.Windows.Forms.Button butAdd;
    }
}

