using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class Friend
    {
        private readonly User r_LoggedInUser;
        private readonly User r_FriendUser;
        public string Name { get; }
        public string PictureUrl { get; }
        internal int FriendshipPoints { get; set; }
        public List<Event> MutualEvents { get; set; }
        public List<Group> MutualGroups { get; set; }
        public List<Page> MutualLikedPages { get; set; }
        public List<Photo> MutualTaggedInPhotos { get; set; }
        public List<Checkin> MutualCheckIns { get; set; }

        private readonly Func<int, int, int> r_CalculateFriendshipPointsStrategyMethod;

        internal Friend(User i_LoggedInUser, User i_FriendUser, Func<int, int, int> i_StrategyMethod)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_FriendUser = i_FriendUser;
            r_CalculateFriendshipPointsStrategyMethod = i_StrategyMethod;
            Name = i_FriendUser.Name;
            PictureUrl = i_FriendUser.PictureLargeURL;
        }

        internal void UpdatePointsBySocialEngagement()
        {
            foreach(Post post in r_LoggedInUser.Posts)
            {
                scanCommentsAndLikes(post);
            }

            foreach(Album album in r_LoggedInUser.Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    scanCommentsAndLikes(photo);
                }
            }
        }

        private void scanCommentsAndLikes(PostedItem i_LoggedInUserPostedItem)
        {
            foreach (Comment comment in i_LoggedInUserPostedItem.Comments)
            {
                if (comment.From == r_FriendUser)
                {
                    FriendshipPoints = r_CalculateFriendshipPointsStrategyMethod.Invoke(FriendshipPoints, 1);
                }
            }

            foreach (User likedUser in i_LoggedInUserPostedItem.LikedBy)
            {
                if (likedUser == r_FriendUser)
                {
                    FriendshipPoints = r_CalculateFriendshipPointsStrategyMethod.Invoke(FriendshipPoints, 1);
                }
            }
        }

        internal void UpdatePointsByMutualSocialLife()
        {
            MutualEvents = r_LoggedInUser.Events.Intersect(r_FriendUser.Events).ToList();
            FriendshipPoints = r_CalculateFriendshipPointsStrategyMethod.Invoke(FriendshipPoints, MutualEvents.Count);
        }

        internal void UpdatePointsByMutualInterests()
        {
            MutualGroups = r_LoggedInUser.Groups.Intersect(r_FriendUser.Groups).ToList();
            MutualLikedPages = r_LoggedInUser.LikedPages.Intersect(r_FriendUser.LikedPages).ToList();
            FriendshipPoints = r_CalculateFriendshipPointsStrategyMethod.Invoke(
                FriendshipPoints,
                MutualGroups.Count + MutualLikedPages.Count);
        }
        
        internal void UpdatePointsBySharedExperiences()
        {
            MutualTaggedInPhotos = r_LoggedInUser.PhotosTaggedIn.Intersect(r_FriendUser.PhotosTaggedIn).ToList();
            MutualCheckIns = r_LoggedInUser.Checkins.Intersect(r_FriendUser.Checkins).ToList();
            FriendshipPoints = r_CalculateFriendshipPointsStrategyMethod.Invoke(
                FriendshipPoints,
                MutualTaggedInPhotos.Count + MutualCheckIns.Count);
        }

        public override string ToString()
        {
            return string.Format(
                @"Gender: {0}
Hometown: {1}
Relationship status: {2}
Birthday: {3}
Email: {4}",
                r_FriendUser.Gender,
                r_FriendUser.Hometown,
                r_FriendUser.RelationshipStatus,
                r_FriendUser.Birthday,
                r_FriendUser.Email);
        }
    }
}
