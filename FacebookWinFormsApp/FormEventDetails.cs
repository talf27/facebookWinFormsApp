using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal partial class FormEventDetails : Form
    {
        private readonly AppManagementFacade r_AppManagement;
        private readonly Event r_Event;
        public event Action<Event> EventStatusChanged;

        internal FormEventDetails(Event i_Event)
        {
            InitializeComponent();
            r_AppManagement = Singleton<AppManagementFacade>.Instance;
            r_Event = i_Event;
            setEventDetails();
        }

        private void setEventDetails()
        {
            string selectedEventDescription = string.Format(
                @"{0}
start time: {1}
end time: {2}
location: {3}
number of interested people: {4}",
                r_Event.Name,
                r_Event.StartTime,
                r_Event.EndTime,
                r_Event.Location,
                r_Event.InterestedCount);

            FormFacebookApp.SetSelectedItemDetails(
                pictureBoxSelectedEvent,
                r_Event.PictureLargeURL,
                textBoxSelectedEventDescription,
                selectedEventDescription);
            comboBoxEventStatuses.Text = "--Change status--";
        }

        private void comboBoxEventStatuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSaveChanges.Enabled = true;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Event.eRsvpType selectedEventStatus = (Event.eRsvpType)Enum.Parse(
                typeof(Event.eRsvpType),
                comboBoxEventStatuses.SelectedItem.ToString());

            if(selectedEventStatus != Event.eRsvpType.Attending)
            {
                doWhenUserNotAttendingEvent(selectedEventStatus);
            }
            
            this.Close();
        }

        private void doWhenUserNotAttendingEvent(Event.eRsvpType i_UpdatedEventStatus)
        {
            r_AppManagement.ChangeEventStatus(r_Event, i_UpdatedEventStatus);
            OnEventStatusChanged();
        }

        protected virtual void OnEventStatusChanged()
        {
            EventStatusChanged?.Invoke(r_Event);
        }
    }
}
