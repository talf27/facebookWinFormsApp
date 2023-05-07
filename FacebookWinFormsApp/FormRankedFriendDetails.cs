using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormRankedFriendDetails : Form
    {
        private readonly Friend r_RankedFriend;

        internal FormRankedFriendDetails(Friend i_RankedFriend)
        {
            InitializeComponent();
            r_RankedFriend = i_RankedFriend;
            initializeRankedFriendDetails();
        }

        private static void checkIfListViewIsEmpty(ListView i_ListView)
        {
            if (i_ListView.Items.Count == 0)
            {
                MessageBox.Show(
                    "There are no mutual items matching that choice\nor you didn't choose to rank your friends by that parameter",
                    "No result",
                    MessageBoxButtons.OK);
            }
        }

        private void initializeRankedFriendDetails()
        {
            pictureBoxFriendPhoto.LoadAsync(r_RankedFriend.PictureUrl);
            labelFriendName.Text = r_RankedFriend.Name;
            textBoxFriendDescription.Text = r_RankedFriend.ToString();
        }

        private void linkLabelMutualSocialLife_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMutualSocialLife.Enabled = false;
            linkLabelMutualSocialLife.Text += string.Format(" ({0})", r_RankedFriend.MutualEvents.Count);
            foreach (Event fbevent in r_RankedFriend.MutualEvents)
            {
                listViewMutualEvents.Items.Add(fbevent.Name);
            }

            checkIfListViewIsEmpty(listViewMutualEvents);
        }

        private void linkLabelMutualGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMutualGroups.Enabled = false;
            linkLabelMutualGroups.Text += string.Format(" ({0})", r_RankedFriend.MutualGroups.Count);
            foreach (Group group in r_RankedFriend.MutualGroups)
            {
                listViewMutualGroups.Items.Add(group.Name);
            }

            checkIfListViewIsEmpty(listViewMutualGroups);
        }

        private void linkLabelMutualLikedPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMutualLikedPages.Enabled = false;
            linkLabelMutualLikedPages.Text += string.Format(" ({0})", r_RankedFriend.MutualLikedPages.Count);
            foreach (Page likedPage in r_RankedFriend.MutualLikedPages)
            {
                listViewMutualLikedPages.Items.Add(likedPage.Name);
            }

            checkIfListViewIsEmpty(listViewMutualLikedPages);
        }

        private void linkLabelMutualCheckIns_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelMutualCheckIns.Enabled = false;
            linkLabelMutualCheckIns.Text += string.Format(" ({0})", r_RankedFriend.MutualCheckIns.Count);
            foreach (Checkin checkin in r_RankedFriend.MutualCheckIns)
            {
                listViewMutualCheckIns.Items.Add(checkin.Name);
            }

            checkIfListViewIsEmpty(listViewMutualCheckIns);
        }

        private void linkLabelMutualPhotosTaggedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAlbum formAlbum = new FormAlbum(r_RankedFriend.MutualTaggedInPhotos);
            
            linkLabelMutualPhotosTaggedIn.Enabled = false;
            formAlbum.Text = string.Format("Mutual tagged-in photos with {0}", r_RankedFriend.Name);
            formAlbum.ShowDialog();
        }
    }
}
