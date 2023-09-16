namespace Project1Fixed
{
    partial class FormInitial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.comboBoxTicker = new System.Windows.Forms.ComboBox();
            this.labelTickerFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(74, 74);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.MaxDate = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(2022, 1, 4, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEndDate.TabIndex = 43;
            this.dateTimePickerEndDate.Value = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(74, 47);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerStartDate.TabIndex = 42;
            this.dateTimePickerStartDate.Value = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(4, 80);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(61, 15);
            this.labelEndDate.TabIndex = 41;
            this.labelEndDate.Text = "End Date:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(1, 51);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(64, 15);
            this.labelStartDate.TabIndex = 40;
            this.labelStartDate.Text = "Start Date:";
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(163, 133);
            this.radioButtonMonthly.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(71, 19);
            this.radioButtonMonthly.TabIndex = 39;
            this.radioButtonMonthly.TabStop = true;
            this.radioButtonMonthly.Text = "Monthly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(88, 133);
            this.radioButtonWeekly.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(67, 19);
            this.radioButtonWeekly.TabIndex = 38;
            this.radioButtonWeekly.TabStop = true;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.radioButtonWeekly_CheckedChanged);
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(24, 133);
            this.radioButtonDay.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(55, 19);
            this.radioButtonDay.TabIndex = 37;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Daily";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            this.radioButtonDay.CheckedChanged += new System.EventHandler(this.radioButtonDay_CheckedChanged);
            // 
            // comboBoxTicker
            // 
            this.comboBoxTicker.FormattingEnabled = true;
            this.comboBoxTicker.Location = new System.Drawing.Point(74, 102);
            this.comboBoxTicker.Name = "comboBoxTicker";
            this.comboBoxTicker.Size = new System.Drawing.Size(151, 21);
            this.comboBoxTicker.TabIndex = 47;
            this.comboBoxTicker.SelectedIndexChanged += new System.EventHandler(this.comboBoxTicker_SelectedIndexChanged);
            // 
            // labelTickerFile
            // 
            this.labelTickerFile.AutoSize = true;
            this.labelTickerFile.Location = new System.Drawing.Point(0, 105);
            this.labelTickerFile.Name = "labelTickerFile";
            this.labelTickerFile.Size = new System.Drawing.Size(66, 15);
            this.labelTickerFile.TabIndex = 48;
            this.labelTickerFile.Text = "Ticker File:";
            // 
            // FormInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 186);
            this.Controls.Add(this.labelTickerFile);
            this.Controls.Add(this.comboBoxTicker);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.radioButtonMonthly);
            this.Controls.Add(this.radioButtonWeekly);
            this.Controls.Add(this.radioButtonDay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInitial";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        public System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        public System.Windows.Forms.Label labelEndDate;
        public System.Windows.Forms.Label labelStartDate;
        public System.Windows.Forms.RadioButton radioButtonMonthly;
        public System.Windows.Forms.RadioButton radioButtonWeekly;
        public System.Windows.Forms.RadioButton radioButtonDay;
        public System.Windows.Forms.ComboBox comboBoxTicker;
        public System.Windows.Forms.Label labelTickerFile;
    }
}

