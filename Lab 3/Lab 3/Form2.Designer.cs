namespace Lab_3
{
    partial class Form2
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblStart = new System.Windows.Forms.Label();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbStartMin = new System.Windows.Forms.ComboBox();
            this.cmbStartAM = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbEndMin = new System.Windows.Forms.ComboBox();
            this.cmbEndAM = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 25);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(632, 25);
            this.lblStart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(145, 32);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Time";
            this.lblStart.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbStartHour.Location = new System.Drawing.Point(638, 85);
            this.cmbStartHour.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(238, 39);
            this.cmbStartHour.TabIndex = 2;
            // 
            // cmbStartMin
            // 
            this.cmbStartMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartMin.FormattingEnabled = true;
            this.cmbStartMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbStartMin.Location = new System.Drawing.Point(892, 85);
            this.cmbStartMin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbStartMin.Name = "cmbStartMin";
            this.cmbStartMin.Size = new System.Drawing.Size(168, 39);
            this.cmbStartMin.TabIndex = 3;
            // 
            // cmbStartAM
            // 
            this.cmbStartAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartAM.FormattingEnabled = true;
            this.cmbStartAM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbStartAM.Location = new System.Drawing.Point(1076, 85);
            this.cmbStartAM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbStartAM.Name = "cmbStartAM";
            this.cmbStartAM.Size = new System.Drawing.Size(102, 39);
            this.cmbStartAM.TabIndex = 4;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(638, 211);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(136, 32);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End Time";
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbEndHour.Location = new System.Drawing.Point(638, 273);
            this.cmbEndHour.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(238, 39);
            this.cmbEndHour.TabIndex = 7;
            // 
            // cmbEndMin
            // 
            this.cmbEndMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndMin.FormattingEnabled = true;
            this.cmbEndMin.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbEndMin.Location = new System.Drawing.Point(894, 273);
            this.cmbEndMin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbEndMin.Name = "cmbEndMin";
            this.cmbEndMin.Size = new System.Drawing.Size(166, 39);
            this.cmbEndMin.TabIndex = 8;
            // 
            // cmbEndAM
            // 
            this.cmbEndAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndAM.FormattingEnabled = true;
            this.cmbEndAM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbEndAM.Location = new System.Drawing.Point(1078, 273);
            this.cmbEndAM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbEndAM.Name = "cmbEndAM";
            this.cmbEndAM.Size = new System.Drawing.Size(100, 39);
            this.cmbEndAM.TabIndex = 9;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(26, 477);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(238, 32);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Event Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(26, 517);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(1152, 38);
            this.txtDesc.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1016, 599);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 54);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 599);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 54);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 701);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.cmbEndAM);
            this.Controls.Add(this.cmbEndMin);
            this.Controls.Add(this.cmbEndHour);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.cmbStartAM);
            this.Controls.Add(this.cmbStartMin);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.monthCalendar1);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.Text = "New Event";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbStartMin;
        private System.Windows.Forms.ComboBox cmbStartAM;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbEndMin;
        private System.Windows.Forms.ComboBox cmbEndAM;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}