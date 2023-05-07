namespace BasicFacebookFeatures
{
    partial class FormRankedFriendDetails
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
            this.pictureBoxFriendPhoto = new System.Windows.Forms.PictureBox();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.textBoxFriendDescription = new System.Windows.Forms.TextBox();
            this.listViewMutualEvents = new System.Windows.Forms.ListView();
            this.listViewMutualGroups = new System.Windows.Forms.ListView();
            this.listViewMutualCheckIns = new System.Windows.Forms.ListView();
            this.linkLabelMutualSocialLife = new System.Windows.Forms.LinkLabel();
            this.linkLabelMutualGroups = new System.Windows.Forms.LinkLabel();
            this.linkLabelMutualCheckIns = new System.Windows.Forms.LinkLabel();
            this.linkLabelMutualPhotosTaggedIn = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMutualLikedPages = new System.Windows.Forms.ListView();
            this.linkLabelMutualLikedPages = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFriendPhoto
            // 
            this.pictureBoxFriendPhoto.Location = new System.Drawing.Point(17, 69);
            this.pictureBoxFriendPhoto.Name = "pictureBoxFriendPhoto";
            this.pictureBoxFriendPhoto.Size = new System.Drawing.Size(216, 192);
            this.pictureBoxFriendPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFriendPhoto.TabIndex = 0;
            this.pictureBoxFriendPhoto.TabStop = false;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendName.Location = new System.Drawing.Point(299, 18);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(265, 38);
            this.labelFriendName.TabIndex = 1;
            this.labelFriendName.Text = "{Friend\'s Name}";
            // 
            // textBoxFriendDescription
            // 
            this.textBoxFriendDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendDescription.Location = new System.Drawing.Point(273, 69);
            this.textBoxFriendDescription.Multiline = true;
            this.textBoxFriendDescription.Name = "textBoxFriendDescription";
            this.textBoxFriendDescription.ReadOnly = true;
            this.textBoxFriendDescription.Size = new System.Drawing.Size(310, 192);
            this.textBoxFriendDescription.TabIndex = 2;
            // 
            // listViewMutualEvents
            // 
            this.listViewMutualEvents.HideSelection = false;
            this.listViewMutualEvents.Location = new System.Drawing.Point(81, 394);
            this.listViewMutualEvents.Name = "listViewMutualEvents";
            this.listViewMutualEvents.Size = new System.Drawing.Size(205, 133);
            this.listViewMutualEvents.TabIndex = 3;
            this.listViewMutualEvents.UseCompatibleStateImageBehavior = false;
            // 
            // listViewMutualGroups
            // 
            this.listViewMutualGroups.HideSelection = false;
            this.listViewMutualGroups.Location = new System.Drawing.Point(306, 394);
            this.listViewMutualGroups.Name = "listViewMutualGroups";
            this.listViewMutualGroups.Size = new System.Drawing.Size(205, 133);
            this.listViewMutualGroups.TabIndex = 3;
            this.listViewMutualGroups.UseCompatibleStateImageBehavior = false;
            // 
            // listViewMutualCheckIns
            // 
            this.listViewMutualCheckIns.HideSelection = false;
            this.listViewMutualCheckIns.Location = new System.Drawing.Point(306, 577);
            this.listViewMutualCheckIns.Name = "listViewMutualCheckIns";
            this.listViewMutualCheckIns.Size = new System.Drawing.Size(205, 133);
            this.listViewMutualCheckIns.TabIndex = 3;
            this.listViewMutualCheckIns.UseCompatibleStateImageBehavior = false;
            // 
            // linkLabelMutualSocialLife
            // 
            this.linkLabelMutualSocialLife.AutoSize = true;
            this.linkLabelMutualSocialLife.Location = new System.Drawing.Point(136, 366);
            this.linkLabelMutualSocialLife.Name = "linkLabelMutualSocialLife";
            this.linkLabelMutualSocialLife.Size = new System.Drawing.Size(89, 16);
            this.linkLabelMutualSocialLife.TabIndex = 4;
            this.linkLabelMutualSocialLife.TabStop = true;
            this.linkLabelMutualSocialLife.Text = "Mutual events";
            this.linkLabelMutualSocialLife.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMutualSocialLife_LinkClicked);
            // 
            // linkLabelMutualGroups
            // 
            this.linkLabelMutualGroups.AutoSize = true;
            this.linkLabelMutualGroups.Location = new System.Drawing.Point(357, 366);
            this.linkLabelMutualGroups.Name = "linkLabelMutualGroups";
            this.linkLabelMutualGroups.Size = new System.Drawing.Size(91, 16);
            this.linkLabelMutualGroups.TabIndex = 4;
            this.linkLabelMutualGroups.TabStop = true;
            this.linkLabelMutualGroups.Text = "Mutual groups";
            this.linkLabelMutualGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMutualGroups_LinkClicked);
            // 
            // linkLabelMutualCheckIns
            // 
            this.linkLabelMutualCheckIns.AutoSize = true;
            this.linkLabelMutualCheckIns.Location = new System.Drawing.Point(357, 549);
            this.linkLabelMutualCheckIns.Name = "linkLabelMutualCheckIns";
            this.linkLabelMutualCheckIns.Size = new System.Drawing.Size(105, 16);
            this.linkLabelMutualCheckIns.TabIndex = 4;
            this.linkLabelMutualCheckIns.TabStop = true;
            this.linkLabelMutualCheckIns.Text = "Mutual check ins";
            this.linkLabelMutualCheckIns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMutualCheckIns_LinkClicked);
            // 
            // linkLabelMutualPhotosTaggedIn
            // 
            this.linkLabelMutualPhotosTaggedIn.AutoSize = true;
            this.linkLabelMutualPhotosTaggedIn.Location = new System.Drawing.Point(195, 732);
            this.linkLabelMutualPhotosTaggedIn.Name = "linkLabelMutualPhotosTaggedIn";
            this.linkLabelMutualPhotosTaggedIn.Size = new System.Drawing.Size(203, 16);
            this.linkLabelMutualPhotosTaggedIn.TabIndex = 4;
            this.linkLabelMutualPhotosTaggedIn.TabStop = true;
            this.linkLabelMutualPhotosTaggedIn.Text = "Mutual photos you both tagged in";
            this.linkLabelMutualPhotosTaggedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMutualPhotosTaggedIn_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(14, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on the following to show:";
            // 
            // listViewMutualLikedPages
            // 
            this.listViewMutualLikedPages.HideSelection = false;
            this.listViewMutualLikedPages.Location = new System.Drawing.Point(81, 577);
            this.listViewMutualLikedPages.Name = "listViewMutualLikedPages";
            this.listViewMutualLikedPages.Size = new System.Drawing.Size(205, 133);
            this.listViewMutualLikedPages.TabIndex = 3;
            this.listViewMutualLikedPages.UseCompatibleStateImageBehavior = false;
            // 
            // linkLabelMutualLikedPages
            // 
            this.linkLabelMutualLikedPages.AutoSize = true;
            this.linkLabelMutualLikedPages.Location = new System.Drawing.Point(124, 549);
            this.linkLabelMutualLikedPages.Name = "linkLabelMutualLikedPages";
            this.linkLabelMutualLikedPages.Size = new System.Drawing.Size(120, 16);
            this.linkLabelMutualLikedPages.TabIndex = 4;
            this.linkLabelMutualLikedPages.TabStop = true;
            this.linkLabelMutualLikedPages.Text = "Mutual liked pages";
            this.linkLabelMutualLikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMutualLikedPages_LinkClicked);
            // 
            // FormFriendDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelMutualPhotosTaggedIn);
            this.Controls.Add(this.linkLabelMutualLikedPages);
            this.Controls.Add(this.linkLabelMutualCheckIns);
            this.Controls.Add(this.linkLabelMutualGroups);
            this.Controls.Add(this.linkLabelMutualSocialLife);
            this.Controls.Add(this.listViewMutualLikedPages);
            this.Controls.Add(this.listViewMutualCheckIns);
            this.Controls.Add(this.listViewMutualGroups);
            this.Controls.Add(this.listViewMutualEvents);
            this.Controls.Add(this.textBoxFriendDescription);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.pictureBoxFriendPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFriendDetails";
            this.Text = "Friend Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFriendPhoto;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.TextBox textBoxFriendDescription;
        private System.Windows.Forms.ListView listViewMutualEvents;
        private System.Windows.Forms.ListView listViewMutualGroups;
        private System.Windows.Forms.ListView listViewMutualCheckIns;
        private System.Windows.Forms.LinkLabel linkLabelMutualSocialLife;
        private System.Windows.Forms.LinkLabel linkLabelMutualGroups;
        private System.Windows.Forms.LinkLabel linkLabelMutualCheckIns;
        private System.Windows.Forms.LinkLabel linkLabelMutualPhotosTaggedIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMutualLikedPages;
        private System.Windows.Forms.LinkLabel linkLabelMutualLikedPages;
    }
}