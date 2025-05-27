using RoomManagementSystem.Models;

namespace RoomManagementSystem
{
    public partial class AccountVerificationPage : Form
    {
        public AccountVerificationPage()
        {
            InitializeComponent();
        }
        private void sqlDataAdapter1_RowUpdated(object sender, Microsoft.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void RefreshDataSource()
        {
            var unverifiedUsers = Database.GetAllUnverifiedUsers();

            unverifiedUserGrid.DataSource = unverifiedUsers;
        }

        private void AccountVerificationPage_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void btn_Approve_Click(object sender, EventArgs e)
        {
            if (unverifiedUserGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = unverifiedUserGrid.SelectedRows[0];

            User? user = (User?)selectedRow.DataBoundItem;

            if (user == null)
            {
                return;
            }

            if (!Database.VerifyUser(user))
            {
                MessageBox.Show("Failed to verify this user.");
                return;
            }
            MessageBox.Show("User has been verified!");

            RefreshDataSource();
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            if (unverifiedUserGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow selectedRow = unverifiedUserGrid.SelectedRows[0];

            User? user = (User?)selectedRow.DataBoundItem;

            if (user == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to reject account verification of: {user.FirstName + " " + user.MiddleName + " " + user.LastName}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (!Database.RejectUser(user))
            {
                MessageBox.Show("Failed to reject this user.");
                return;
            }
            MessageBox.Show("User has been rejected!");

            RefreshDataSource();
        }
    }
}
