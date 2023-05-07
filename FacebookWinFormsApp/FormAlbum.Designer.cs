namespace BasicFacebookFeatures
{
    partial class FormAlbum
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
            this.listViewAlbumPhotos = new System.Windows.Forms.ListView();
            this.listViewSelectedPhotoLikes = new System.Windows.Forms.ListView();
            this.listViewSelectedPhotoComments = new System.Windows.Forms.ListView();
            this.linkLabelPhotoLikes = new System.Windows.Forms.LinkLabel();
            this.linkLabelPhotoComments = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listViewAlbumPhotos
            // 
            this.listViewAlbumPhotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAlbumPhotos.HideSelection = false;
            this.listViewAlbumPhotos.Location = new System.Drawing.Point(12, 12);
            this.listViewAlbumPhotos.Name = "listViewAlbumPhotos";
            this.listViewAlbumPhotos.Size = new System.Drawing.Size(1299, 789);
            this.listViewAlbumPhotos.TabIndex = 0;
            this.listViewAlbumPhotos.TabStop = false;
            this.listViewAlbumPhotos.UseCompatibleStateImageBehavior = false;
            this.listViewAlbumPhotos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAlbumPhotos_ItemSelectionChanged);
            // 
            // listViewSelectedPhotoLikes
            // 
            this.listViewSelectedPhotoLikes.HideSelection = false;
            this.listViewSelectedPhotoLikes.Location = new System.Drawing.Point(1364, 105);
            this.listViewSelectedPhotoLikes.Name = "listViewSelectedPhotoLikes";
            this.listViewSelectedPhotoLikes.Size = new System.Drawing.Size(209, 201);
            this.listViewSelectedPhotoLikes.TabIndex = 1;
            this.listViewSelectedPhotoLikes.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedPhotoLikes.View = System.Windows.Forms.View.List;
            this.listViewSelectedPhotoLikes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewSelectedPhotoLikesOrComments_ItemSelectionChanged);
            // 
            // listViewSelectedPhotoComments
            // 
            this.listViewSelectedPhotoComments.HideSelection = false;
            this.listViewSelectedPhotoComments.Location = new System.Drawing.Point(1364, 439);
            this.listViewSelectedPhotoComments.Name = "listViewSelectedPhotoComments";
            this.listViewSelectedPhotoComments.Size = new System.Drawing.Size(209, 201);
            this.listViewSelectedPhotoComments.TabIndex = 1;
            this.listViewSelectedPhotoComments.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedPhotoComments.View = System.Windows.Forms.View.List;
            this.listViewSelectedPhotoComments.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewSelectedPhotoLikesOrComments_ItemSelectionChanged);
            // 
            // linkLabelPhotoLikes
            // 
            this.linkLabelPhotoLikes.AutoSize = true;
            this.linkLabelPhotoLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelPhotoLikes.Location = new System.Drawing.Point(1411, 68);
            this.linkLabelPhotoLikes.Name = "linkLabelPhotoLikes";
            this.linkLabelPhotoLikes.Size = new System.Drawing.Size(95, 20);
            this.linkLabelPhotoLikes.TabIndex = 2;
            this.linkLabelPhotoLikes.TabStop = true;
            this.linkLabelPhotoLikes.Text = "Show Likes";
            this.linkLabelPhotoLikes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhotoLikes_LinkClicked);
            // 
            // linkLabelPhotoComments
            // 
            this.linkLabelPhotoComments.AutoSize = true;
            this.linkLabelPhotoComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelPhotoComments.Location = new System.Drawing.Point(1403, 401);
            this.linkLabelPhotoComments.Name = "linkLabelPhotoComments";
            this.linkLabelPhotoComments.Size = new System.Drawing.Size(136, 20);
            this.linkLabelPhotoComments.TabIndex = 2;
            this.linkLabelPhotoComments.TabStop = true;
            this.linkLabelPhotoComments.Text = "Show Comments";
            this.linkLabelPhotoComments.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhotoComments_LinkClicked);
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 807);
            this.Controls.Add(this.linkLabelPhotoComments);
            this.Controls.Add(this.linkLabelPhotoLikes);
            this.Controls.Add(this.listViewSelectedPhotoComments);
            this.Controls.Add(this.listViewSelectedPhotoLikes);
            this.Controls.Add(this.listViewAlbumPhotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAlbumPhotos;
        private System.Windows.Forms.ListView listViewSelectedPhotoLikes;
        private System.Windows.Forms.ListView listViewSelectedPhotoComments;
        private System.Windows.Forms.LinkLabel linkLabelPhotoLikes;
        private System.Windows.Forms.LinkLabel linkLabelPhotoComments;
    }
}