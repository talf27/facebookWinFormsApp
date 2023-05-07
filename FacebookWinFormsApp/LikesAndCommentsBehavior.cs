using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal static class LikesAndCommentsBehavior
    {
        internal static void ClearLikesAndComments(
            ListView i_ListViewLikes,
            ListView i_ListViewComments,
            LinkLabel i_LinkLabelLikes,
            LinkLabel i_LinkLabelComments)
        {
            i_ListViewLikes.Clear();
            i_ListViewComments.Clear();
            i_LinkLabelLikes.Enabled = true;
            i_LinkLabelComments.Enabled = true;
        }

        internal static void SetListViewSelectedPostedItemLikes(ListView i_ListViewLikes, PostedItem i_SelectedPostedItem)
        {
            if (i_SelectedPostedItem.LikedBy.Count == 0)
            {
                MessageBox.Show("There are no likes for this post", "NO LIKES", MessageBoxButtons.OK);
            }
            else
            {
                i_ListViewLikes.Invoke(
                    new Action(
                        () =>
                            {
                                foreach(User likedUser in i_SelectedPostedItem.LikedBy)
                                {
                                    i_ListViewLikes.Items.Add(likedUser.Name);
                                }
                            }));
            }
        }

        internal static void SetListViewSelectedPostedItemComments(ListView i_ListViewComments, PostedItem i_SelectedPostedItem)
        {
            if (i_SelectedPostedItem.Comments.Count == 0)
            {
                MessageBox.Show("There are no comments for this post", "NO COMMENTS", MessageBoxButtons.OK);
            }
            else
            {
                i_ListViewComments.Invoke(
                    new Action(
                        () =>
                            {
                                foreach(Comment comment in i_SelectedPostedItem.Comments)
                                {
                                    i_ListViewComments.Items.Add(comment.Message);
                                }
                            }));
            }
        }
    }
}
