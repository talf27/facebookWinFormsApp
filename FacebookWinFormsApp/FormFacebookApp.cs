using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormFacebookApp : Form
    {
        private readonly AppManagementFacade r_AppManagement;
        private FormBestFriends m_FormBestFriends;
        private FormActivities m_FormActivities;

        internal FormFacebookApp()
        {
            r_AppManagement = Singleton<AppManagementFacade>.Instance;
            InitializeComponent();
            initializeProfileMainTab();
        }

        private void initializeProfileMainTab()
        {
            string userPictureURL;
            string userName;

            r_AppManagement.GetUserInfo(out userPictureURL, out userName);
            pictureBoxProfile.LoadAsync(userPictureURL);
            pictureBoxProfile.Left = this.ClientSize.Width / 2 - pictureBoxProfile.Width / 2;
            LabelUserName.Text = string.Format("Welcome, {0}!", userName);
            LabelUserName.Left = this.ClientSize.Width / 2 - LabelUserName.Width / 2;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPagePosts)
            {
                new Thread(loadPosts).Start();
            }
            else if(tabControl.SelectedTab == tabPageAlbums)
            {
                initializeAlbumsTab();
            }
            else if (tabControl.SelectedTab == tabPageGroups)
            {
                new Thread(initializeGroupsTab).Start();
            }
            else if (tabControl.SelectedTab == tabPageLikedPages)
            {
                new Thread(initializeLikedPagesTab).Start();
            }
        }

        private void loadPosts()
        {
            List<Post> userPosts = r_AppManagement.GetUserPosts();

            listBoxPosts.Invoke(new Action(
                () =>
                    {
                        listBoxPosts.DisplayMember = "Message";
                        foreach(Post post in userPosts)
                        {
                            listBoxPosts.Items.Add(post);
                        }

                        if(listBoxPosts.Items.Count == 0)
                        {
                            listBoxPosts.Items.Add("No Posts to retrieve :(");
                        }
                    }));
        }

        private void listBoxPosts_SelectedValueChanged(object sender, EventArgs e)
        {
            LikesAndCommentsBehavior.ClearLikesAndComments(listViewSelectedPostLikes, listViewSelectedPostComments, linkLabelPostLikes, linkLabelPostComments);
        }

        private void linkLabelPostLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Post selectedPost = listBoxPosts.SelectedItem as Post;

            linkLabelPostLikes.Enabled = false;
            new Thread(() => LikesAndCommentsBehavior.SetListViewSelectedPostedItemLikes(listViewSelectedPostLikes, selectedPost)).Start();
        }

        private void linkLabelPostComments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Post selectedPost = listBoxPosts.SelectedItem as Post;

            linkLabelPostComments.Enabled = false;
            new Thread(() => LikesAndCommentsBehavior.SetListViewSelectedPostedItemComments(listViewSelectedPostComments, selectedPost)).Start();
        }

        private void listViewSelectedPostLikesOrComments_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;
            }
        }

        private void buttonApplyFriendsFilter_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<User> filteredFriends;
            bool filterByGender;
            bool filterByHometown;
            bool filterByStatus;
            User.eGender genderToFilterBy;
            Enums.eHometowns hometownToFilterBy;
            User.eRelationshipStatus statusToFilterBy;

            if (comboBoxGenderFriendsFilter.SelectedItem == null || comboBoxStatusFriendsFilter.SelectedItem == null
                                                                 || comboBoxTownFriendsFilter == null)
            {
                MessageBox.Show(
                    "Please select filters to show your friends (or choose \"None\")",
                    "Error",
                    MessageBoxButtons.OK);
            }
            else
            {
                buttonApplyFriendsFilter.Enabled = false;
                setFriendsFilters(
                    out filterByGender,
                    out filterByHometown,
                    out filterByStatus,
                    out genderToFilterBy,
                    out hometownToFilterBy,
                    out statusToFilterBy);
                new Thread(
                    () =>
                            {
                                filteredFriends = r_AppManagement.GetUserFilteredFriends(
                                    filterByGender,
                                    filterByHometown,
                                    filterByStatus,
                                    genderToFilterBy,
                                    hometownToFilterBy,
                                    statusToFilterBy);
                                setListBoxFriends(filteredFriends);
                            });
            }
        }

        private void setFriendsFilters(
            out bool o_FilterByGender,
            out bool o_FilterByHometown,
            out bool o_FilterByStatus,
            out User.eGender o_GenderToFilterBy,
            out Enums.eHometowns o_HometowmToFilterBy,
            out User.eRelationshipStatus o_StatusToFilterBy)
        {
            string selectedGenderFilter = comboBoxGenderFriendsFilter.SelectedItem.ToString();
            string selectedTownFilter = comboBoxTownFriendsFilter.SelectedItem.ToString();
            string selectedStatusFilter = comboBoxStatusFriendsFilter.SelectedItem.ToString();

            o_GenderToFilterBy = User.eGender.male;
            o_HometowmToFilterBy = Enums.eHometowns.None;
            o_StatusToFilterBy = User.eRelationshipStatus.None;
            if (o_FilterByGender = (selectedGenderFilter != "None"))
            {
                o_GenderToFilterBy = selectedGenderFilter == "Male"
                                         ? User.eGender.male
                                         : User.eGender.female;
            }

            if(o_FilterByHometown = (selectedTownFilter != "None"))
            {
                o_HometowmToFilterBy = (Enums.eHometowns)Enum.Parse(typeof(Enums.eHometowns), selectedTownFilter);
            }

            if (o_FilterByStatus = (selectedStatusFilter != "None"))
            {
                o_StatusToFilterBy = (User.eRelationshipStatus)Enum.Parse(
                    typeof(User.eRelationshipStatus),
                    selectedStatusFilter);
            }
        }

        private void setListBoxFriends(FacebookObjectCollection<User> i_Friends)
        {
            listBoxFriends.Invoke(new Action(() => userBindingSource.DataSource = i_Friends));
            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show(
                    "There are no friends matching those filters",
                    "No match",
                    MessageBoxButtons.OK);
            }
        }

        private void comboBoxFriendsFilters_SelectedValueChanged(object sender, EventArgs e)
        {
            buttonApplyFriendsFilter.Enabled = true;
        }

        private void initializeAlbumsTab()
        {
            FacebookObjectCollection<Album> userAlbums = r_AppManagement.GetUserAlbums();

            if(userAlbums.Count == 0)
            {
                setNoAlbumsVisibility();
            }
            else
            {
                setAlbumDetails();
            }
        }

        private void setNoAlbumsVisibility()
        {
            labelClickAlbum.Visible = false;
            buttonNextAlbum.Enabled = false;
            labelNoAlbumsMessage.Visible = true;
            textBoxAlbumDescription.Visible = false;
        }

        private void setAlbumDetails()
        {
            string albumName;
            DateTime? albumCreatedTime;
            long? albumNumOfPhotos;
            string albumCoverURL;

            r_AppManagement.GetAlbumDetails(
                out albumName,
                out albumCreatedTime,
                out albumNumOfPhotos,
                out albumCoverURL);
            string currentAlbumDescription = string.Format(
                @"Album Name: {0}

Created At: {1}

Number Of Photos: {2}",
                albumName,
                albumCreatedTime,
                albumNumOfPhotos);
            SetSelectedItemDetails(
                pictureBoxAlbum,
                albumCoverURL,
                textBoxAlbumDescription,
                currentAlbumDescription);
            buttonPreviousAlbum.Enabled = !r_AppManagement.IsFirstAlbum();
            buttonNextAlbum.Enabled = !r_AppManagement.IsLastAlbum();
        }

        internal static void SetSelectedItemDetails(
            PictureBox i_PictureBox,
            string i_PictureUrl,
            TextBox i_TextBox,
            string i_Description)
        {
            i_PictureBox.LoadAsync(i_PictureUrl);
            i_TextBox.Text = i_Description;
        }

        private void buttonNextAlbum_Click(object sender, EventArgs e)
        {
            r_AppManagement.CurrentAlbumIndex++;
            setAlbumDetails();
        }

        private void buttonPreviousAlbum_Click(object sender, EventArgs e)
        {
            r_AppManagement.CurrentAlbumIndex--;
            setAlbumDetails();
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {
            Album currentAlbum = r_AppManagement.GetCurrentAlbum();
            FormAlbum formAlbum = new FormAlbum(currentAlbum.Photos.ToList());

            formAlbum.Text = currentAlbum.Name;
            formAlbum.ShowDialog();
        }

        private void initializeGroupsTab()
        {
            listBoxGroups.Invoke(new Action(() => groupBindingSource.DataSource = r_AppManagement.GetUserGroups()));

            if (listBoxGroups.Items.Count == 0)
            {
                setNoGroupsVisibility();
            }
        }

        private void setNoGroupsVisibility()
        {
            tabPageGroups.Invoke(new Action(() =>
                {
                    labelNoGroupMessage.Visible = true;
                    listBoxGroups.Visible = false;
                    panelGroupDetails.Visible = false;
                }));
        }

        private void radioButtonEventsFilters_CheckedChanged(object sender, EventArgs e)
        {
            FacebookObjectCollection<Event> filteredEvents;
            RadioButton selectedEventsFilter = sender as RadioButton;
            Event.eRsvpType eventRsvp = Event.eRsvpType.Attending;

            if (selectedEventsFilter.Checked)
            {
                if(selectedEventsFilter.Text == "Not replied yet")
                {
                    filteredEvents = r_AppManagement.GetEventsNotYetReplied();
                }
                else
                {
                    switch (selectedEventsFilter.Text)
                    {
                        case "Declined":
                            eventRsvp = Event.eRsvpType.Declined;
                            break;
                        case "Maybe":
                            eventRsvp = Event.eRsvpType.Maybe;
                            break;
                    }

                    filteredEvents = r_AppManagement.GetFilteredEvents(eventRsvp);
                }

                setFilteredListBoxEvents(filteredEvents);
            }
        }

        private void setFilteredListBoxEvents(FacebookObjectCollection<Event> i_FilteredEvents)
        {
            if (i_FilteredEvents.Count == 0)
            {
                MessageBox.Show("There are no events matching that filter", "No match", MessageBoxButtons.OK);
            }
            else
            {
                eventBindingSource.DataSource = i_FilteredEvents;
            }
        }

        private void initializeLikedPagesTab()
        {
            /*
             * method is written in comment because Facebook Graph server gives
             * for each liked page's category "null" so the application can't run without exception.
             * At real world, each facebook's page must have a category,
             * so we decided not to change this method's behavior...
             */

            /*FacebookObjectCollection<Page> likedPages = r_AppManagement.GetUserLikedPages();

            foreach (Page page in likedPages)
            {
                comboBoxLikedPagesCategories.Invoke(
                    new Action(
                        () =>
                                {
                                    if(!comboBoxLikedPagesCategories.Items.Contains(page.Category))
                                    {
                                        comboBoxLikedPagesCategories.Items.Add(page.Category);
                                    }
                                }));
            }*/
        }

        private void comboBoxLikedPagesCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxLikedPagesCategories.SelectedItem.ToString();

            new Thread(() => setListBoxLikedPages(selectedCategory)).Start();
        }

        private void setListBoxLikedPages(string i_SelectedCategory)
        {
            List<Page> filteredLikedPages = r_AppManagement.GetUserFilteredLikedPages(i_SelectedCategory);

            if (filteredLikedPages.Count == 0)
            {
                MessageBox.Show("You have no liked pages from that category", "No match", MessageBoxButtons.OK);
            }

            listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = filteredLikedPages));
        }

        private void buttonBestFriends_Click(object sender, EventArgs e)
        {
            m_FormBestFriends = new FormBestFriends();
            m_FormBestFriends.ShowDialog();
        }

        private void buttonMonthlyActivities_Click(object sender, EventArgs e)
        {
            m_FormActivities = new FormActivities();
            m_FormActivities.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            DialogResult = DialogResult.Cancel;
        }
    }
}
