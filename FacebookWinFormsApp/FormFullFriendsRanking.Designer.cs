namespace BasicFacebookFeatures
{
    partial class FormFullFriendsRanking
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
            this.listBoxFullFriendsRanking = new System.Windows.Forms.ListBox();
            this.labelClickFriend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFullFriendsRanking
            // 
            this.listBoxFullFriendsRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFullFriendsRanking.FormattingEnabled = true;
            this.listBoxFullFriendsRanking.ItemHeight = 20;
            this.listBoxFullFriendsRanking.Location = new System.Drawing.Point(29, 61);
            this.listBoxFullFriendsRanking.Name = "listBoxFullFriendsRanking";
            this.listBoxFullFriendsRanking.Size = new System.Drawing.Size(278, 244);
            this.listBoxFullFriendsRanking.TabIndex = 0;
            this.listBoxFullFriendsRanking.SelectedValueChanged += new System.EventHandler(this.listBoxFullFriendsRanking_SelectedValueChanged);
            // 
            // labelClickFriend
            // 
            this.labelClickFriend.AutoSize = true;
            this.labelClickFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelClickFriend.Location = new System.Drawing.Point(12, 18);
            this.labelClickFriend.Name = "labelClickFriend";
            this.labelClickFriend.Size = new System.Drawing.Size(314, 20);
            this.labelClickFriend.TabIndex = 1;
            this.labelClickFriend.Text = "Click on a friend to show more about him";
            // 
            // FormFullFriendsRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 331);
            this.Controls.Add(this.labelClickFriend);
            this.Controls.Add(this.listBoxFullFriendsRanking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFullFriendsRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Full Friends Ranking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFullFriendsRanking;
        private System.Windows.Forms.Label labelClickFriend;
    }
}