namespace BasicFacebookFeatures
{
    partial class FormCongratulateFriend
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
            this.pictureBoxFriendToCongratulate = new System.Windows.Forms.PictureBox();
            this.textBoxFriendCongratulations = new System.Windows.Forms.TextBox();
            this.buttonPostCongratulations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendToCongratulate)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFriendToCongratulate
            // 
            this.pictureBoxFriendToCongratulate.Location = new System.Drawing.Point(26, 27);
            this.pictureBoxFriendToCongratulate.Name = "pictureBoxFriendToCongratulate";
            this.pictureBoxFriendToCongratulate.Size = new System.Drawing.Size(149, 139);
            this.pictureBoxFriendToCongratulate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFriendToCongratulate.TabIndex = 0;
            this.pictureBoxFriendToCongratulate.TabStop = false;
            // 
            // textBoxFriendCongratulations
            // 
            this.textBoxFriendCongratulations.Location = new System.Drawing.Point(213, 27);
            this.textBoxFriendCongratulations.Multiline = true;
            this.textBoxFriendCongratulations.Name = "textBoxFriendCongratulations";
            this.textBoxFriendCongratulations.Size = new System.Drawing.Size(286, 94);
            this.textBoxFriendCongratulations.TabIndex = 1;
            // 
            // buttonPostCongratulations
            // 
            this.buttonPostCongratulations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostCongratulations.Location = new System.Drawing.Point(308, 133);
            this.buttonPostCongratulations.Name = "buttonPostCongratulations";
            this.buttonPostCongratulations.Size = new System.Drawing.Size(92, 39);
            this.buttonPostCongratulations.TabIndex = 2;
            this.buttonPostCongratulations.Text = "Post";
            this.buttonPostCongratulations.UseVisualStyleBackColor = true;
            this.buttonPostCongratulations.Click += new System.EventHandler(this.buttonPostCongratulations_Click);
            // 
            // FormCongratulateFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 184);
            this.Controls.Add(this.buttonPostCongratulations);
            this.Controls.Add(this.textBoxFriendCongratulations);
            this.Controls.Add(this.pictureBoxFriendToCongratulate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCongratulateFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Congratulate Your Friend!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendToCongratulate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFriendToCongratulate;
        private System.Windows.Forms.TextBox textBoxFriendCongratulations;
        private System.Windows.Forms.Button buttonPostCongratulations;
    }
}