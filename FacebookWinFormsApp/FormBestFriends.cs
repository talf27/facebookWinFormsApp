using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal partial class FormBestFriends : Form
    {
        private readonly AppManagementFacade r_AppManagement;

        internal FormBestFriends()
        {
            InitializeComponent();
            r_AppManagement = Singleton<AppManagementFacade>.Instance;
        }

        private void buttonApplyFriendsRank_Click(object sender, EventArgs e)
        {
            if(!checkBoxSocialEngagement.Checked && !checkBoxMutualSocialLife.Checked
                                                 && !checkBoxMutualInterests.Checked
                                                 && !checkBoxSharedExperiences.Checked)
            {
                MessageBox.Show("Please choose at least one parameter for ranking", "Error", MessageBoxButtons.OK);
            }
            else
            {
                r_AppManagement.CreateRankedFriendsList(
                    checkBoxSocialEngagement.Checked,
                    checkBoxMutualSocialLife.Checked,
                    checkBoxMutualInterests.Checked,
                    checkBoxSharedExperiences.Checked);
                showTop3Friends();
                linkLabelShowMoreFriends.Visible = true;
            }
        }

        private void showTop3Friends()
        {
            List<PictureBox> friendsPictureBoxes =
                new List<PictureBox> { pictureBox1BestFriend, pictureBox2BestFriend, pictureBox3BestFriend };
            List<LinkLabel> friendsLinkLabels =
                new List<LinkLabel> { linkLabel1BestFriend, linkLabel2BestFriend, linkLabel3BestFriend };
            Friend friendToShow;

            for(int friendIndex = 0; friendIndex < 3 && friendIndex < r_AppManagement.RankedFriends.GetRankedFriendsCount(); friendIndex++)
            {
                friendToShow = r_AppManagement.RankedFriends.GetSpecificRankedFriend(friendIndex);
                friendsPictureBoxes[friendIndex].LoadAsync(friendToShow.PictureUrl);
                friendsLinkLabels[friendIndex].Enabled = true;
                friendsLinkLabels[friendIndex].Text = friendToShow.Name;
            }
        }

        private void linkLabel1BestFriend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFormFriendDetails(0);
        }

        private void linkLabel2BestFriend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFormFriendDetails(1);
        }

        private void linkLabel3BestFriend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowFormFriendDetails(2);
        }

        internal void ShowFormFriendDetails(int i_FriendRankToShowDetails)
        {
            Friend friendToShow = r_AppManagement.RankedFriends.GetSpecificRankedFriend(i_FriendRankToShowDetails);
            FormRankedFriendDetails formRankedFriendDetails = new FormRankedFriendDetails(friendToShow);

            formRankedFriendDetails.ShowDialog();
        }

        private void linkLabelShowMoreFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFullFriendsRanking formFullFriendsRanking = new FormFullFriendsRanking();
            
            formFullFriendsRanking.ShowDialog();
        }
    }
}
