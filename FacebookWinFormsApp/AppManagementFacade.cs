using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public sealed class AppManagementFacade
    {
        private User m_LoggedInUser = null;
        private static readonly object sr_LockObj = new Object();
        public int CurrentAlbumIndex { get; set; }
        private RankedFriendsBuilder m_RankedFriendsBuilder;
        public RankedFriends RankedFriends { get; private set; }

        private AppManagementFacade()
        {
        }

        private static ActivityDayInMonth findOrCreateActivityDayInCurrentMonth(
            List<ActivityDayInMonth> i_MonthActivityDays,
            int i_DayNumber)
        {
            ActivityDayInMonth activityDayToReturn =
                i_MonthActivityDays.Find(activityDay => activityDay.DayNumber == i_DayNumber);

            if (activityDayToReturn == null)
            {
                activityDayToReturn = new ActivityDayInMonth(i_DayNumber);
                i_MonthActivityDays.Add(activityDayToReturn);
            }

            return activityDayToReturn;
        }

        public void SetLoggedInUser(User i_LoggedInUser)
        {
            if (m_LoggedInUser == null)
            {
                lock (sr_LockObj)
                {
                    if (m_LoggedInUser == null)
                    {
                        m_LoggedInUser = i_LoggedInUser;
                    }
                }
            }
        }

        public void GetUserInfo(out string o_PictureURL, out string o_Name)
        {
            o_PictureURL = m_LoggedInUser.PictureLargeURL;
            o_Name = m_LoggedInUser.Name;
        }

        public List<Post> GetUserPosts()
        {
            return m_LoggedInUser.Posts.Where(post => post.Message != null).ToList();
        }

        public FacebookObjectCollection<User> GetUserFilteredFriends(
            bool i_FilterByGender,
            bool i_FilterByHometown,
            bool i_FilterByStatus,
            User.eGender i_GenderToFilterBy,
            Enums.eHometowns i_HometownToFilterBy,
            User.eRelationshipStatus i_StatusToFilterBy)
        {
            FacebookObjectCollection<User> filteredFriends = new FacebookObjectCollection<User>();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (i_FilterByGender && friend.Gender != i_GenderToFilterBy)
                {
                    continue;
                }

                if (i_FilterByHometown && (Enums.eHometowns)Enum.Parse(typeof(Enums.eHometowns), friend.Hometown.Name)
                    != i_HometownToFilterBy)
                {
                    continue;
                }

                if (i_FilterByStatus && friend.RelationshipStatus != i_StatusToFilterBy)
                {
                    continue;
                }

                filteredFriends.Add(friend);
            }

            return filteredFriends;
        }

        public FacebookObjectCollection<Album> GetUserAlbums()
        {
            return m_LoggedInUser.Albums;
        }

        public void GetAlbumDetails(
            out string o_Name,
            out DateTime? o_CreatedTime,
            out long? o_NumOfPhotos,
            out string o_CoverURL)
        {
            Album currentAlbum = m_LoggedInUser.Albums[CurrentAlbumIndex];

            o_Name = currentAlbum.Name;
            o_CreatedTime = currentAlbum.CreatedTime;
            o_NumOfPhotos = currentAlbum.Count;
            o_CoverURL = currentAlbum.PictureAlbumURL;
        }

        public bool IsFirstAlbum()
        {
            return CurrentAlbumIndex == 0;
        }

        public bool IsLastAlbum()
        {
            return CurrentAlbumIndex == m_LoggedInUser.Albums.Count - 1;
        }

        public Album GetCurrentAlbum()
        {
            return m_LoggedInUser.Albums[CurrentAlbumIndex];
        }

        public FacebookObjectCollection<Group> GetUserGroups()
        {
            return m_LoggedInUser.Groups;
        }

        public FacebookObjectCollection<Event> GetFilteredEvents(Event.eRsvpType i_EventRsvp)
        {
            FacebookObjectCollection<Event> filteredEvents;

            switch(i_EventRsvp)
            {
                case Event.eRsvpType.Attending:
                    filteredEvents = m_LoggedInUser.Events;
                    break;
                case Event.eRsvpType.Declined:
                    filteredEvents = m_LoggedInUser.EventsDeclined;
                    break;
                case Event.eRsvpType.Maybe:
                default:
                    filteredEvents = m_LoggedInUser.EventsMaybe;
                    break;
            }

            return filteredEvents;
        }

        public FacebookObjectCollection<Event> GetEventsNotYetReplied()
        {
            return m_LoggedInUser.EventsNotYetReplied;
        }

        public FacebookObjectCollection<Page> GetUserLikedPages()
        {
            return m_LoggedInUser.LikedPages;
        }

        public List<Page> GetUserFilteredLikedPages(string i_SelectedCategory)
        {
            return m_LoggedInUser.LikedPages.Where(page => i_SelectedCategory == "All" || page.Category == i_SelectedCategory).ToList();
        }

        public void CreateRankedFriendsList(bool i_RankBySocialEngagement,
                                            bool i_RankByMutualSocialLife,
                                            bool i_RankByMutualInterests,
                                            bool i_RankBySharedExperiences)
        {
            m_RankedFriendsBuilder = new RankedFriendsBuilder(
                m_LoggedInUser,
                i_RankBySocialEngagement,
                i_RankByMutualSocialLife,
                i_RankByMutualInterests,
                i_RankBySharedExperiences);
            RankedFriends = new RankedFriends(m_RankedFriendsBuilder.RankedFriendsProduct);
        }

        public List<ActivityDayInMonth> SetMonthActivitiesList(
            List<ActivityDayInMonth> i_SelectedMonthActivityDays,
            Enums.eMonths i_SelectedMonth,
            int i_SelectedYear)
        {
            findBirthdayFriendsOnThisMonth(i_SelectedMonthActivityDays, i_SelectedMonth);
            findEventsOnThisMonth(i_SelectedMonthActivityDays, i_SelectedMonth, i_SelectedYear);

            return i_SelectedMonthActivityDays.OrderBy(activityDay => activityDay.DayNumber).ToList();
        }

        private void findBirthdayFriendsOnThisMonth(
            List<ActivityDayInMonth> i_SelectedMonthActivityDays,
            Enums.eMonths i_SelectedMonth)
        {
            int currentFriendBirthdayMonth;
            int currentFriendBirthdayDay;
            ActivityDayInMonth foundOrCreatedActivityDay;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                currentFriendBirthdayMonth = int.Parse(friend.Birthday.Split('/')[0]);
                if ((Enums.eMonths)currentFriendBirthdayMonth == i_SelectedMonth)
                {
                    currentFriendBirthdayDay = int.Parse(friend.Birthday.Split('/')[1]);
                    foundOrCreatedActivityDay = findOrCreateActivityDayInCurrentMonth(i_SelectedMonthActivityDays, currentFriendBirthdayDay);
                    foundOrCreatedActivityDay.AddBirthdayFriend(friend);
                }
            }
        }

        private void findEventsOnThisMonth(
            List<ActivityDayInMonth> i_SelectedMonthActivityDays,
            Enums.eMonths i_SelectedMonth,
            int i_SelectedYear)
        {
            int currentEventDay;
            ActivityDayInMonth foundOrCreatedActivityDay;

            foreach (Event fbevent in m_LoggedInUser.Events)
            {
                if ((Enums.eMonths)fbevent.StartTime.Value.Month == i_SelectedMonth
                    && fbevent.StartTime.Value.Year == i_SelectedYear)
                {
                    currentEventDay = fbevent.StartTime.Value.Day;
                    foundOrCreatedActivityDay = findOrCreateActivityDayInCurrentMonth(i_SelectedMonthActivityDays, currentEventDay);
                    foundOrCreatedActivityDay.AddEvent(fbevent);
                }
            }
        }

        public void GetFriendInfo(User i_Friend, out string o_FriendName, out string o_FriendPictureURL)
        {
            o_FriendName = i_Friend.Name;
            o_FriendPictureURL = i_Friend.PictureLargeURL;
        }

        public void CongratulateFriend(string i_CongratulationText)
        {
            m_LoggedInUser.PostStatus(i_CongratulationText);
        }

        public void ChangeEventStatus(Event i_Event, Event.eRsvpType i_EventStatus)
        {
            i_Event.Respond(i_EventStatus);
        }
    }
}
