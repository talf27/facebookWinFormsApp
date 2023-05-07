using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ActivityDayInMonth
    {
        public int DayNumber { get; }
        public List<User> BirthdayFriendsOnThisDay { get; } = new List<User>();
        public List<Event> EventsOnThisDay { get; } = new List<Event>();

        internal ActivityDayInMonth(int i_DayNumber)
        {
            DayNumber = i_DayNumber;
        }

        internal void AddBirthdayFriend(User i_BirthdayFriend)
        {
            BirthdayFriendsOnThisDay.Add(i_BirthdayFriend);
        }

        internal void AddEvent(Event i_Event)
        {
            EventsOnThisDay.Add(i_Event);
        }

        public void RemoveEvent(Event i_Event)
        {
            EventsOnThisDay.Remove(i_Event);
        }

        public int GetBirthdayFriendsOnThisDayAmount()
        {
            return BirthdayFriendsOnThisDay.Count;
        }

        public int GetEventsOnThisDayAmount()
        {
            return EventsOnThisDay.Count;
        }

        public override string ToString()
        {
            string activitiesKind = "birthday";

            if (BirthdayFriendsOnThisDay.Count > 0 && EventsOnThisDay.Count > 0)
            {
                activitiesKind = "birthday & event";
            }
            else if (EventsOnThisDay.Count > 0)
            {
                activitiesKind = "event";
            }

            return string.Format("{0} - {1}", DayNumber, activitiesKind);
        }
    }
}
