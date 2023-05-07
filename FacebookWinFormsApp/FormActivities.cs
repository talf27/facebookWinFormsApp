using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormActivities : Form
    {
        private readonly AppManagementFacade r_AppManagement;
        private List<ActivityDayInMonth> m_SelectedMonthActivityDays = new List<ActivityDayInMonth>();

        internal FormActivities()
        {
            InitializeComponent();
            r_AppManagement = Singleton<AppManagementFacade>.Instance;
            set10YearsInComboBox();
        }

        private void set10YearsInComboBox()
        {
            int currentYear = DateTime.Now.Year;

            for(int yearsAmountInComboBox = 1; yearsAmountInComboBox <= 10; yearsAmountInComboBox++)
            {
                comboBoxYear.Items.Add(currentYear);
                currentYear++;
            }
        }

        private void buttonFindActivities_Click(object sender, EventArgs e)
        {
            if(comboBoxMonth.SelectedItem == null || comboBoxYear.SelectedItem == null)
            {
                MessageBox.Show("Please choose month & year", "Error", MessageBoxButtons.OK);
            }
            else
            {
                clearContentForNewMonth();
                setCurrentMonthActivitiesList();
            }
        }

        private void clearContentForNewMonth()
        {
            listBoxSelectedMonthActivityDays.Items.Clear();
            clearBirthdaysAndEventsListViews();
        }

        private void clearBirthdaysAndEventsListViews()
        {
            listBoxBirthdaysOnThisDay.Items.Clear();
            listBoxEventsOnThisDay.Items.Clear();
            buttonCongratulateFriend.Enabled = false;
            buttonEventDetails.Enabled = false;
        }

        private void setCurrentMonthActivitiesList()
        {
            int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
            Enums.eMonths selectedMonth = (Enums.eMonths)Enum.Parse(
                typeof(Enums.eMonths),
                comboBoxMonth.SelectedItem.ToString());

            m_SelectedMonthActivityDays = r_AppManagement.SetMonthActivitiesList(m_SelectedMonthActivityDays, selectedMonth, selectedYear);
            setItemsOnListBoxActivities();
        }

        private void setItemsOnListBoxActivities()
        {
            foreach(ActivityDayInMonth activityDay in m_SelectedMonthActivityDays)
            {
                listBoxSelectedMonthActivityDays.Items.Add(activityDay.ToString());
            }
        }

        private void listBoxSelectedMonthActivityDays_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedDayIndexInList = listBoxSelectedMonthActivityDays.SelectedIndex;
            ActivityDayInMonth selectedActivityDay = m_SelectedMonthActivityDays[selectedDayIndexInList];
            
            clearBirthdaysAndEventsListViews();
            setBirthdaysAndEventsListViews(selectedActivityDay);
        }

        private void setBirthdaysAndEventsListViews(ActivityDayInMonth i_SelectedActivityDay)
        {
            listBoxBirthdaysOnThisDay.DisplayMember = "Name";
            foreach (User friend in i_SelectedActivityDay.BirthdayFriendsOnThisDay)
            {
                listBoxBirthdaysOnThisDay.Items.Add(friend);
            }

            listBoxEventsOnThisDay.DisplayMember = "Name";
            foreach (Event fbevent in i_SelectedActivityDay.EventsOnThisDay)
            {
                listBoxEventsOnThisDay.Items.Add(fbevent);
            }

            buttonCongratulateFriend.Enabled = listBoxBirthdaysOnThisDay.Items.Count > 0;
            buttonEventDetails.Enabled = listBoxEventsOnThisDay.Items.Count > 0;
        }

        private void buttonCongratulateFriend_Click(object sender, EventArgs e)
        {
            User friendToCongratulate;
            FormCongratulateFriend formCongratulateFriend;
            string friendToCongratulateName;
            string friendToCongratulatePictureURL;

            if (listBoxBirthdaysOnThisDay.SelectedItem == null)
            {
                MessageBox.Show("Please select a friend to congratulate", "Error", MessageBoxButtons.OK);
            }
            else
            {
                friendToCongratulate = listBoxBirthdaysOnThisDay.SelectedItem as User;
                r_AppManagement.GetFriendInfo(
                    friendToCongratulate,
                    out friendToCongratulateName,
                    out friendToCongratulatePictureURL);
                formCongratulateFriend = new FormCongratulateFriend(
                    friendToCongratulateName,
                    friendToCongratulatePictureURL);
                formCongratulateFriend.ShowDialog();
            }
        }

        private void buttonEventDetails_Click(object sender, EventArgs e)
        {
            Event selectedEvent;
            FormEventDetails formEventDetails;

            if (listBoxEventsOnThisDay.SelectedItem == null)
            {
                MessageBox.Show("Please select an event", "Error", MessageBoxButtons.OK);
            }
            else
            {
                selectedEvent = listBoxEventsOnThisDay.SelectedItem as Event;
                formEventDetails = new FormEventDetails(selectedEvent);
                formEventDetails.EventStatusChanged += this.selectedEvent_StatusChanged;
                formEventDetails.ShowDialog();
            }
        }

        private void selectedEvent_StatusChanged(Event i_Event)
        {
            object selectedActivityDayAsListBoxItem = listBoxSelectedMonthActivityDays.SelectedItem;
            int selectedActivityDayIndex = listBoxSelectedMonthActivityDays.SelectedIndex;
            int selectedEventDayNumber = i_Event.StartTime.Value.Day;
            ActivityDayInMonth selectedEventActivityDay =
                m_SelectedMonthActivityDays.Find(activityDay => activityDay.DayNumber == selectedEventDayNumber);

            selectedEventActivityDay.RemoveEvent(i_Event);
            listBoxSelectedMonthActivityDays.Items.Remove(selectedActivityDayAsListBoxItem);
            if (selectedEventActivityDay.GetBirthdayFriendsOnThisDayAmount() == 0
               && selectedEventActivityDay.GetEventsOnThisDayAmount() == 0)
            {
                clearBirthdaysAndEventsListViews();
            }
            else if (selectedActivityDayIndex > -1)
            {
                listBoxSelectedMonthActivityDays.Items.Insert(selectedActivityDayIndex, selectedActivityDayAsListBoxItem.ToString());
                listBoxEventsOnThisDay.Items.Remove(listBoxEventsOnThisDay.SelectedItem);
                buttonEventDetails.Enabled = listBoxEventsOnThisDay.Items.Count > 0;
            }
        }
    }
}
