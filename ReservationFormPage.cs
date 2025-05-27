using RoomManagementSystem.Models;

namespace RoomManagementSystem
{
    public partial class ReservationFormPage : Form
    {
        public ReservationFormPage()
        {
            InitializeComponent();
        }

        private void OnAccept(object sender, EventArgs e)
        {
            if (requestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = requestGrid.SelectedRows[0];

            ReservationRequestForm? requestForm = (ReservationRequestForm?)selectedRow.DataBoundItem;

            if (requestForm == null)
            {
                return;
            }

            Database.AcceptReservationForm(requestForm);

            MessageBox.Show("Request has been accepted!");
            LoadReservationFormPage(null!, null!);
        }

        private void OnReject(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Are you sure you want to reject this request form?",
            "Confirm Rejection",
            MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }
            if (requestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = requestGrid.SelectedRows[0];

            ReservationRequestForm? requestForm = (ReservationRequestForm?)selectedRow.DataBoundItem;

            if (requestForm == null)
            {
                return;
            }

            Database.RejectReservationForm(requestForm);

            MessageBox.Show("Request has been rejected!");
            LoadReservationFormPage(null!, null!);
        }

        private void LoadReservationFormPage(object sender, EventArgs e)
        {
            var list = Database.GetAllPendingReservationForms();
            if (Session.UserType != "ADMIN")
            {
                tabPanel.TabPages.RemoveAt(0);
            }
            else
            {
                requestGrid.DataSource = list;
                requestGrid.Columns["ID"]!.Visible = false;
            }

            pendingGrid.DataSource = list;
            if (list.Count != 0)
            {
                
                pendingGrid.Columns["ID"]!.Visible = false;
            }

            var acceptList = Database.GetAllAcceptedReservationForms();

            acceptedGrid.DataSource = acceptList;

            if (acceptList.Count != 0)
            {
                acceptedGrid.Columns["ID"]!.Visible = false;
            }
        }

        private void OnViewFromRequests(object sender, EventArgs e)
        {
            if (requestGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = requestGrid.SelectedRows[0];

            ReservationRequestForm? requestForm = (ReservationRequestForm?)selectedRow.DataBoundItem;

            if (requestForm == null)
            {
                return;
            }

            OnView(requestForm);
        }

        private void OnView(ReservationRequestForm form)
        {
            ReservationFormView viewPage = new ReservationFormView(form);
            viewPage.ShowDialog();
            viewPage.BringToFront();
        }

        private void OnViewFromPending(object sender, EventArgs e)
        {
            if (pendingGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = pendingGrid.SelectedRows[0];

            ReservationRequestForm? requestForm = (ReservationRequestForm?)selectedRow.DataBoundItem;

            if (requestForm == null)
            {
                return;
            }

            OnView(requestForm);
        }

        private void OnViewFromAccepted(object sender, EventArgs e)
        {
            if (acceptedGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = acceptedGrid.SelectedRows[0];

            ReservationRequestForm? requestForm = (ReservationRequestForm?)selectedRow.DataBoundItem;

            if (requestForm == null)
            {
                return;
            }

            OnView(requestForm);
            EventBus.InvokeAcceptReservationForm();
        }
    }
}
