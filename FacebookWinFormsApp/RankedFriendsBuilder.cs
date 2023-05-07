using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class RankedFriendsBuilder
    {
        internal List<Friend> RankedFriendsProduct { get; private set; }

        private readonly User r_LoggedInUser;
        private readonly bool r_RankBySocialEngagement;
        private readonly bool r_RankByMutualSocialLife;
        private readonly bool r_RankByMutualInterests;
        private readonly bool r_RankBySharedExperiences;

        internal RankedFriendsBuilder(
            User i_LoggedInUser,
            bool i_RankBySocialEngagement,
            bool i_RankByMutualSocialLife,
            bool i_RankByMutualInterests,
            bool i_RankBySharedExperiences)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_RankBySocialEngagement = i_RankBySocialEngagement;
            r_RankByMutualSocialLife = i_RankByMutualSocialLife;
            r_RankByMutualInterests = i_RankByMutualInterests;
            r_RankBySharedExperiences = i_RankBySharedExperiences;
            buildRankedFriendsList();
        }
        
        private void buildRankedFriendsList()
        {
            List<Friend> unSortedRankedFriends = new List<Friend>();
            Friend currentFriend;

            foreach (User friend in r_LoggedInUser.Friends)
            {
                currentFriend = new Friend(
                    r_LoggedInUser,
                    friend,
                    (currentFriendshipPoints, mutualElementsAmount) => currentFriendshipPoints + mutualElementsAmount);
                unSortedRankedFriends.Add(currentFriend);
                currentFriend.FriendshipPoints = 0;
                if (r_RankBySocialEngagement)
                {
                    currentFriend.UpdatePointsBySocialEngagement();
                }

                if (r_RankByMutualSocialLife)
                {
                    currentFriend.UpdatePointsByMutualSocialLife();
                }

                if (r_RankByMutualInterests)
                {
                    currentFriend.UpdatePointsByMutualInterests();
                }

                if (r_RankBySharedExperiences)
                {
                    currentFriend.UpdatePointsBySharedExperiences();
                }
            }

            RankedFriendsProduct = unSortedRankedFriends.OrderByDescending(friend => friend.FriendshipPoints).ToList();
        }
    }
}
