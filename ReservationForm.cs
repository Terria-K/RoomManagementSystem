using System.Diagnostics;

namespace RoomManagementSystem
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            var timeInTimes = new List<string>();

            int firstIndex = 7;

            for (int i = firstIndex; i < 12; i += 1)
            {
                timeInTimes.Add($"{i}:00 AM");
                timeInTimes.Add($"{i}:30 AM");
            }
            timeInTimes.Add($"12:00 PM");
            timeInTimes.Add($"12:30 PM");

            firstIndex = 1;
            for (int i = firstIndex; i < 9; i += 1)
            {
                timeInTimes.Add($"{i}:00 PM");
                timeInTimes.Add($"{i}:30 PM");
            }

            var list = Session.Rooms.Select(x => x.Value).ToList();
            roomList.DataSource = list;


            if (!string.IsNullOrEmpty(Session.CurrentRoomNameSelected))
            {
                roomList.Text = Session.CurrentRoomNameSelected;
            }


            timeInBox.DataSource = timeInTimes;
            timeOutBox.DataSource = new List<string>(timeInTimes);

            var user = Database.GetUserByID(Session.UserID);
            if (user == null)
            {
                return;
            }

            instructorName.Text = $"{user.LastName}, {user.FirstName} {user.MiddleName}";
        }

        private void OnReserveClicked(object sender, EventArgs e)
        {
            string roomName = roomList.Text;

            string date = dateBox.Text;
            string? timeIn = timeInBox.SelectedValue?.ToString();
            string? timeOut = timeOutBox.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(timeIn))
            {
                MessageBox.Show("Time In field is required.", "Field Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(timeOut))
            {
                MessageBox.Show("Time Out field is required.", "Field Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime timeInDate = DateTime.Parse(date + " " + timeIn);
            DateTime timeOutDate = DateTime.Parse(date + " " + timeOut);

            string section = sectionBox.Text;
            string reason = reasonBox.Text;

            if (string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Section field is required.", "Field Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Reason field is required.", "Field Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Database.AddReservationForm(
                new Models.ReservationRequestForm(Guid.CreateVersion7(), Session.UserID, Session.RoomNameToID[roomName], timeInDate, timeOutDate, section, reason)
            );

            MessageBox.Show("Reservation Completed!", "Reserved", MessageBoxButtons.OK);
            this.Dispose();
        }
    }
}
