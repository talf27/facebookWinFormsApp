namespace BasicFacebookFeatures
{
    partial class FormActivities
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
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.listBoxSelectedMonthActivityDays = new System.Windows.Forms.ListBox();
            this.buttonCongratulateFriend = new System.Windows.Forms.Button();
            this.buttonEventDetails = new System.Windows.Forms.Button();
            this.labelBirthdays = new System.Windows.Forms.Label();
            this.labelEventsOnThisDay = new System.Windows.Forms.Label();
            this.buttonFindActivities = new System.Windows.Forms.Button();
            this.listBoxBirthdaysOnThisDay = new System.Windows.Forms.ListBox();
            this.listBoxEventsOnThisDay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(29, 21);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(180, 26);
            this.comboBoxMonth.TabIndex = 0;
            this.comboBoxMonth.TabStop = false;
            this.comboBoxMonth.Text = "--Select Month--";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(231, 21);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(163, 26);
            this.comboBoxYear.TabIndex = 1;
            this.comboBoxYear.TabStop = false;
            this.comboBoxYear.Text = "--Select Year--";
            // 
            // listBoxSelectedMonthActivityDays
            // 
            this.listBoxSelectedMonthActivityDays.FormattingEnabled = true;
            this.listBoxSelectedMonthActivityDays.ItemHeight = 16;
            this.listBoxSelectedMonthActivityDays.Location = new System.Drawing.Point(73, 145);
            this.listBoxSelectedMonthActivityDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSelectedMonthActivityDays.Name = "listBoxSelectedMonthActivityDays";
            this.listBoxSelectedMonthActivityDays.Size = new System.Drawing.Size(285, 276);
            this.listBoxSelectedMonthActivityDays.TabIndex = 1;
            this.listBoxSelectedMonthActivityDays.SelectedValueChanged += new System.EventHandler(this.listBoxSelectedMonthActivityDays_SelectedValueChanged);
            // 
            // buttonCongratulateFriend
            // 
            this.buttonCongratulateFriend.Enabled = false;
            this.buttonCongratulateFriend.Location = new System.Drawing.Point(462, 372);
            this.buttonCongratulateFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCongratulateFriend.Name = "buttonCongratulateFriend";
            this.buttonCongratulateFriend.Size = new System.Drawing.Size(167, 52);
            this.buttonCongratulateFriend.TabIndex = 2;
            this.buttonCongratulateFriend.Text = "Congratulate friend!";
            this.buttonCongratulateFriend.UseVisualStyleBackColor = true;
            this.buttonCongratulateFriend.Click += new System.EventHandler(this.buttonCongratulateFriend_Click);
            // 
            // buttonEventDetails
            // 
            this.buttonEventDetails.Enabled = false;
            this.buttonEventDetails.Location = new System.Drawing.Point(755, 372);
            this.buttonEventDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEventDetails.Name = "buttonEventDetails";
            this.buttonEventDetails.Size = new System.Drawing.Size(105, 52);
            this.buttonEventDetails.TabIndex = 2;
            this.buttonEventDetails.Text = "Event details";
            this.buttonEventDetails.UseVisualStyleBackColor = true;
            this.buttonEventDetails.Click += new System.EventHandler(this.buttonEventDetails_Click);
            // 
            // labelBirthdays
            // 
            this.labelBirthdays.AutoSize = true;
            this.labelBirthdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthdays.Location = new System.Drawing.Point(458, 86);
            this.labelBirthdays.Name = "labelBirthdays";
            this.labelBirthdays.Size = new System.Drawing.Size(171, 20);
            this.labelBirthdays.TabIndex = 4;
            this.labelBirthdays.Text = "Birthdays on this day:";
            // 
            // labelEventsOnThisDay
            // 
            this.labelEventsOnThisDay.AutoSize = true;
            this.labelEventsOnThisDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEventsOnThisDay.Location = new System.Drawing.Point(736, 86);
            this.labelEventsOnThisDay.Name = "labelEventsOnThisDay";
            this.labelEventsOnThisDay.Size = new System.Drawing.Size(151, 20);
            this.labelEventsOnThisDay.TabIndex = 4;
            this.labelEventsOnThisDay.Text = "Events on this day:";
            // 
            // buttonFindActivities
            // 
            this.buttonFindActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFindActivities.Location = new System.Drawing.Point(103, 65);
            this.buttonFindActivities.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindActivities.Name = "buttonFindActivities";
            this.buttonFindActivities.Size = new System.Drawing.Size(201, 62);
            this.buttonFindActivities.TabIndex = 5;
            this.buttonFindActivities.Text = "Find my activities on this month";
            this.buttonFindActivities.UseVisualStyleBackColor = true;
            this.buttonFindActivities.Click += new System.EventHandler(this.buttonFindActivities_Click);
            // 
            // listBoxBirthdaysOnThisDay
            // 
            this.listBoxBirthdaysOnThisDay.FormattingEnabled = true;
            this.listBoxBirthdaysOnThisDay.ItemHeight = 16;
            this.listBoxBirthdaysOnThisDay.Location = new System.Drawing.Point(453, 123);
            this.listBoxBirthdaysOnThisDay.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxBirthdaysOnThisDay.Name = "listBoxBirthdaysOnThisDay";
            this.listBoxBirthdaysOnThisDay.Size = new System.Drawing.Size(191, 228);
            this.listBoxBirthdaysOnThisDay.TabIndex = 6;
            // 
            // listBoxEventsOnThisDay
            // 
            this.listBoxEventsOnThisDay.FormattingEnabled = true;
            this.listBoxEventsOnThisDay.ItemHeight = 16;
            this.listBoxEventsOnThisDay.Location = new System.Drawing.Point(719, 123);
            this.listBoxEventsOnThisDay.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEventsOnThisDay.Name = "listBoxEventsOnThisDay";
            this.listBoxEventsOnThisDay.Size = new System.Drawing.Size(191, 228);
            this.listBoxEventsOnThisDay.TabIndex = 6;
            // 
            // FormActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 446);
            this.Controls.Add(this.listBoxEventsOnThisDay);
            this.Controls.Add(this.listBoxBirthdaysOnThisDay);
            this.Controls.Add(this.buttonFindActivities);
            this.Controls.Add(this.labelEventsOnThisDay);
            this.Controls.Add(this.labelBirthdays);
            this.Controls.Add(this.buttonEventDetails);
            this.Controls.Add(this.buttonCongratulateFriend);
            this.Controls.Add(this.listBoxSelectedMonthActivityDays);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActivities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Activities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ListBox listBoxSelectedMonthActivityDays;
        private System.Windows.Forms.Button buttonCongratulateFriend;
        private System.Windows.Forms.Button buttonEventDetails;
        private System.Windows.Forms.Label labelBirthdays;
        private System.Windows.Forms.Label labelEventsOnThisDay;
        private System.Windows.Forms.Button buttonFindActivities;
        private System.Windows.Forms.ListBox listBoxBirthdaysOnThisDay;
        private System.Windows.Forms.ListBox listBoxEventsOnThisDay;
    }
}