namespace WindowsForm
{
    partial class NewTaskForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.butSubmit = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblNewTask = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chbProd = new System.Windows.Forms.CheckBox();
            this.chbDemo = new System.Windows.Forms.CheckBox();
            this.chbPreProd = new System.Windows.Forms.CheckBox();
            this.lblEnvironmento = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCriticity = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCriticity = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbPercentComplete = new System.Windows.Forms.ComboBox();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.cbSendEmail = new System.Windows.Forms.CheckBox();
            this.butCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // butSubmit
            // 
            this.butSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butSubmit.Location = new System.Drawing.Point(315, 507);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(100, 30);
            this.butSubmit.TabIndex = 1;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 74);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(182, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // lblNewTask
            // 
            this.lblNewTask.AutoSize = true;
            this.lblNewTask.Location = new System.Drawing.Point(12, 9);
            this.lblNewTask.Name = "lblNewTask";
            this.lblNewTask.Size = new System.Drawing.Size(102, 16);
            this.lblNewTask.TabIndex = 4;
            this.lblNewTask.Text = "Create new task";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 209);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 85);
            this.txtDescription.TabIndex = 6;
            // 
            // chbProd
            // 
            this.chbProd.AutoSize = true;
            this.chbProd.Location = new System.Drawing.Point(315, 134);
            this.chbProd.Name = "chbProd";
            this.chbProd.Size = new System.Drawing.Size(58, 20);
            this.chbProd.TabIndex = 7;
            this.chbProd.Text = "Prod";
            this.chbProd.UseVisualStyleBackColor = true;
            this.chbProd.CheckedChanged += new System.EventHandler(this.chbProd_CheckedChanged);
            // 
            // chbDemo
            // 
            this.chbDemo.AutoSize = true;
            this.chbDemo.Location = new System.Drawing.Point(315, 186);
            this.chbDemo.Name = "chbDemo";
            this.chbDemo.Size = new System.Drawing.Size(66, 20);
            this.chbDemo.TabIndex = 8;
            this.chbDemo.Text = "Demo";
            this.chbDemo.UseVisualStyleBackColor = true;
            this.chbDemo.CheckedChanged += new System.EventHandler(this.chbDemo_CheckedChanged);
            // 
            // chbPreProd
            // 
            this.chbPreProd.AutoSize = true;
            this.chbPreProd.Location = new System.Drawing.Point(315, 160);
            this.chbPreProd.Name = "chbPreProd";
            this.chbPreProd.Size = new System.Drawing.Size(79, 20);
            this.chbPreProd.TabIndex = 9;
            this.chbPreProd.Text = "PreProd";
            this.chbPreProd.UseVisualStyleBackColor = true;
            this.chbPreProd.CheckedChanged += new System.EventHandler(this.chbPreProd_CheckedChanged);
            // 
            // lblEnvironmento
            // 
            this.lblEnvironmento.AutoSize = true;
            this.lblEnvironmento.Location = new System.Drawing.Point(312, 115);
            this.lblEnvironmento.Name = "lblEnvironmento";
            this.lblEnvironmento.Size = new System.Drawing.Size(84, 16);
            this.lblEnvironmento.TabIndex = 10;
            this.lblEnvironmento.Text = "Environment:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Spain",
            "America",
            "Russia",
            "China",
            "Japan"});
            this.cmbLocation.Location = new System.Drawing.Point(246, 74);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(169, 24);
            this.cmbLocation.TabIndex = 11;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(243, 55);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 115);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lblCriticity
            // 
            this.lblCriticity.AutoSize = true;
            this.lblCriticity.Location = new System.Drawing.Point(167, 115);
            this.lblCriticity.Name = "lblCriticity";
            this.lblCriticity.Size = new System.Drawing.Size(49, 16);
            this.lblCriticity.TabIndex = 14;
            this.lblCriticity.Text = "Criticity";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Incident",
            "Bug"});
            this.cmbType.Location = new System.Drawing.Point(12, 143);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(102, 24);
            this.cmbType.TabIndex = 15;
            // 
            // cmbCriticity
            // 
            this.cmbCriticity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriticity.FormattingEnabled = true;
            this.cmbCriticity.Items.AddRange(new object[] {
            "Minor",
            "Medium",
            "Critical"});
            this.cmbCriticity.Location = new System.Drawing.Point(170, 143);
            this.cmbCriticity.Name = "cmbCriticity";
            this.cmbCriticity.Size = new System.Drawing.Size(102, 24);
            this.cmbCriticity.TabIndex = 16;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 328);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(64, 16);
            this.lblStartDate.TabIndex = 17;
            this.lblStartDate.Text = "Start date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.AllowDrop = true;
            this.dtpStartDate.CustomFormat = "";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(15, 347);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(182, 22);
            this.dtpStartDate.TabIndex = 18;
            this.dtpStartDate.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(246, 347);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(169, 22);
            this.numericUpDown1.TabIndex = 19;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(243, 328);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(114, 16);
            this.lblDuration.TabIndex = 20;
            this.lblDuration.Text = "Duration (in hours)";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 415);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbStatus.Items.AddRange(new object[] {
            "Started",
            "Planned",
            "Finished"});
            this.cmbStatus.Location = new System.Drawing.Point(16, 434);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(181, 24);
            this.cmbStatus.TabIndex = 22;
            // 
            // cmbPercentComplete
            // 
            this.cmbPercentComplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPercentComplete.FormattingEnabled = true;
            this.cmbPercentComplete.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "90%",
            "100%"});
            this.cmbPercentComplete.Location = new System.Drawing.Point(246, 434);
            this.cmbPercentComplete.Name = "cmbPercentComplete";
            this.cmbPercentComplete.Size = new System.Drawing.Size(169, 24);
            this.cmbPercentComplete.TabIndex = 24;
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.Location = new System.Drawing.Point(243, 415);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(112, 16);
            this.lblPercentComplete.TabIndex = 23;
            this.lblPercentComplete.Text = "Percent complete";
            // 
            // cbSendEmail
            // 
            this.cbSendEmail.AutoSize = true;
            this.cbSendEmail.Location = new System.Drawing.Point(16, 483);
            this.cbSendEmail.Name = "cbSendEmail";
            this.cbSendEmail.Size = new System.Drawing.Size(262, 20);
            this.cbSendEmail.TabIndex = 25;
            this.cbSendEmail.Text = "Check here if you want to send an email";
            this.cbSendEmail.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(201, 507);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(100, 30);
            this.butCancel.TabIndex = 26;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 549);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.cbSendEmail);
            this.Controls.Add(this.cmbPercentComplete);
            this.Controls.Add(this.lblPercentComplete);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cmbCriticity);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblCriticity);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblEnvironmento);
            this.Controls.Add(this.chbPreProd);
            this.Controls.Add(this.chbDemo);
            this.Controls.Add(this.chbProd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNewTask);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.lblTitle);
            this.Name = "NewTaskForm";
            this.Text = "Create new task";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblNewTask;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chbProd;
        private System.Windows.Forms.CheckBox chbDemo;
        private System.Windows.Forms.CheckBox chbPreProd;
        private System.Windows.Forms.Label lblEnvironmento;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCriticity;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCriticity;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbPercentComplete;
        private System.Windows.Forms.Label lblPercentComplete;
        private System.Windows.Forms.CheckBox cbSendEmail;
        private System.Windows.Forms.Button butCancel;
    }
}

