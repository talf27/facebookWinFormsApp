using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal partial class FormFullFriendsRanking : Form
    {
        private readonly AppManagementFacade r_AppManagement;

        internal FormFullFriendsRanking()
        {
            InitializeComponent();
            r_AppManagement = Singleton<AppManagementFacade>.Instance;
            setFriendsInListBox();
        }

        private void setFriendsInListBox()
        {
            int rank = 1;

            listBoxFullFriendsRanking.Items.Clear();
            foreach(string friendName in r_AppManagement.RankedFriends)
            {
                listBoxFullFriendsRanking.Items.Add(string.Format("{0}. {1}", rank, friendName));
                rank++;
            }
        }

        private void listBoxFullFriendsRanking_SelectedValueChanged(object sender, EventArgs e)
        {
            Friend friendToShow = r_AppManagement.RankedFriends.GetSpecificRankedFriend(listBoxFullFriendsRanking.SelectedIndices[0]);
            FormRankedFriendDetails formRankedFriendDetails = new FormRankedFriendDetails(friendToShow);

            formRankedFriendDetails.ShowDialog();
        }
    }
}
