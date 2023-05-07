using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormAlbum : Form
    {
        private readonly List<Photo> r_PhotosList;

        internal FormAlbum(List<Photo> i_PhotosList)
        {
            InitializeComponent();
            r_PhotosList = i_PhotosList;
            setAlbumGallery();
        }

        private void setAlbumGallery()
        {
            ImageList imageList = new ImageList();
            ListViewItem currentPhotoItemInList;
            int photoKey = 1;

            imageList.ImageSize = new Size(150, 150);
            listViewAlbumPhotos.LargeImageList = imageList;
            foreach (Photo photo in r_PhotosList)
            {
                imageList.Images.Add(photoKey.ToString(), photo.ImageNormal);
                currentPhotoItemInList = listViewAlbumPhotos.Items.Add(photoKey.ToString());
                currentPhotoItemInList.ImageKey = photoKey.ToString();
                photoKey++;
            }
        }

        private void listViewAlbumPhotos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Photo selectedPhoto;

            if (listViewAlbumPhotos.SelectedIndices.Count > 0)
            {
                selectedPhoto = r_PhotosList[int.Parse(listViewAlbumPhotos.SelectedItems[0].ImageKey) - 1];
                LikesAndCommentsBehavior.ClearLikesAndComments(
                    listViewSelectedPhotoLikes,
                    listViewSelectedPhotoComments,
                    linkLabelPhotoLikes,
                    linkLabelPhotoComments);
            }
        }

        private void linkLabelPhotoLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Photo selectedPhoto = r_PhotosList[listViewAlbumPhotos.SelectedIndices[0]];

            linkLabelPhotoLikes.Enabled = false;
            LikesAndCommentsBehavior.SetListViewSelectedPostedItemLikes(listViewSelectedPhotoLikes, selectedPhoto);
        }

        private void linkLabelPhotoComments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Photo selectedPhoto = r_PhotosList[listViewAlbumPhotos.SelectedIndices[0]];

            linkLabelPhotoComments.Enabled = false;
            LikesAndCommentsBehavior.SetListViewSelectedPostedItemComments(listViewSelectedPhotoComments, selectedPhoto);
        }

        private void listViewSelectedPhotoLikesOrComments_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }
    }
}
