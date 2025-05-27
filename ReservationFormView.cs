using RoomManagementSystem.Models;

namespace RoomManagementSystem
{
    public partial class ReservationFormView : Form
    {
        private ReservationRequestForm form;

        public ReservationFormView(ReservationRequestForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void OnViewLoad(object sender, EventArgs e)
        {
            roomNameText.Text = Session.Rooms[form.RoomID];
            var user = Database.GetUserByID(form.UserID);
            if (user != null)
            {
                instructorText.Text = $"{user.LastName}, {user.FirstName} {user.MiddleName}";
            }

            sectionText.Text = form.Section;
            timeInText.Text = form.TimeIn.ToShortTimeString();
            timeOutText.Text = form.TimeOut.ToShortTimeString();
            reasonBox.Text = form.Reason;
        }
    }
}
