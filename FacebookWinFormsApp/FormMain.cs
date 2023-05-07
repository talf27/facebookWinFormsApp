using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User loggedInUser;
            AppManagementFacade facadeInstance;
            FormFacebookApp formFacebookApp;

            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "453116690239055", 
                    /// requested permissions:
					"email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                    );

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                loggedInUser = loginResult.LoggedInUser;
                facadeInstance = Singleton<AppManagementFacade>.Instance;
                facadeInstance.SetLoggedInUser(loggedInUser);
                formFacebookApp = new FormFacebookApp();
                formFacebookApp.ShowDialog();
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed", MessageBoxButtons.OK);
            }
        }
    }
}
