using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormCongratulateFriend : Form
    {
        private readonly AppManagementFacade r_AppManagement;
        private readonly string r_FriendName;
        private readonly string r_FriendPictureURL;

        internal FormCongratulateFriend(string i_FriendName, string i_FriendPictureURL)
        {
            InitializeComponent();
            r_AppManagement = Singleton<AppManagementFacade>.Instance;
            r_FriendName = i_FriendName;
            r_FriendPictureURL = i_FriendPictureURL;
            setFriendCongratulations();
        }

        private void setFriendCongratulations()
        {
            pictureBoxFriendToCongratulate.LoadAsync(r_FriendPictureURL);
            textBoxFriendCongratulations.Text = string.Format(
                @"Happy Birthday, {0}!
Wish you all the best!
...",
                r_FriendName);
        }

        private void buttonPostCongratulations_Click(object sender, EventArgs e)
        {
            r_AppManagement.CongratulateFriend(textBoxFriendCongratulations.Text);
            MessageBox.Show(
                "Congratulations for birthday was posted successfully!",
                "You made your friend happy!",
                MessageBoxButtons.OK);
            this.Close();
        }
    }
}
