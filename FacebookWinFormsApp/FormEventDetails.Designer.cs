namespace BasicFacebookFeatures
{
    partial class FormEventDetails
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
            this.pictureBoxSelectedEvent = new System.Windows.Forms.PictureBox();
            this.textBoxSelectedEventDescription = new System.Windows.Forms.TextBox();
            this.comboBoxEventStatuses = new System.Windows.Forms.ComboBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSelectedEvent
            // 
            this.pictureBoxSelectedEvent.Location = new System.Drawing.Point(31, 29);
            this.pictureBoxSelectedEvent.Name = "pictureBoxSelectedEvent";
            this.pictureBoxSelectedEvent.Size = new System.Drawing.Size(148, 141);
            this.pictureBoxSelectedEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSelectedEvent.TabIndex = 0;
            this.pictureBoxSelectedEvent.TabStop = false;
            // 
            // textBoxSelectedEventDescription
            // 
            this.textBoxSelectedEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSelectedEventDescription.Location = new System.Drawing.Point(210, 29);
            this.textBoxSelectedEventDescription.Multiline = true;
            this.textBoxSelectedEventDescription.Name = "textBoxSelectedEventDescription";
            this.textBoxSelectedEventDescription.ReadOnly = true;
            this.textBoxSelectedEventDescription.Size = new System.Drawing.Size(213, 180);
            this.textBoxSelectedEventDescription.TabIndex = 1;
            // 
            // comboBoxEventStatuses
            // 
            this.comboBoxEventStatuses.FormattingEnabled = true;
            this.comboBoxEventStatuses.Items.AddRange(new object[] {
            "Attending",
            "Declined",
            "Maybe"});
            this.comboBoxEventStatuses.Location = new System.Drawing.Point(31, 185);
            this.comboBoxEventStatuses.Name = "comboBoxEventStatuses";
            this.comboBoxEventStatuses.Size = new System.Drawing.Size(148, 24);
            this.comboBoxEventStatuses.TabIndex = 2;
            this.comboBoxEventStatuses.Text = "--Change status--";
            this.comboBoxEventStatuses.SelectedIndexChanged += new System.EventHandler(this.comboBoxEventStatuses_SelectedIndexChanged);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Enabled = false;
            this.buttonSaveChanges.Location = new System.Drawing.Point(31, 223);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(148, 34);
            this.buttonSaveChanges.TabIndex = 3;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // FormEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 269);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.comboBoxEventStatuses);
            this.Controls.Add(this.textBoxSelectedEventDescription);
            this.Controls.Add(this.pictureBoxSelectedEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEventDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSelectedEvent;
        private System.Windows.Forms.TextBox textBoxSelectedEventDescription;
        private System.Windows.Forms.ComboBox comboBoxEventStatuses;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}