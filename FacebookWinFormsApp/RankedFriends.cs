using System.Collections;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class RankedFriends : IEnumerable<string>
    {
        private readonly List<Friend> r_RankedFriendsList;

        public RankedFriends(List<Friend> i_RankedFriendsList)
        {
            r_RankedFriendsList = i_RankedFriendsList;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(Friend rankedFriend in r_RankedFriendsList)
            {
                yield return rankedFriend.Name;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int GetRankedFriendsCount()
        {
            return r_RankedFriendsList.Count;
        }

        public Friend GetSpecificRankedFriend(int i_FriendRank)
        {
            return r_RankedFriendsList[i_FriendRank];
        }
    }
}
