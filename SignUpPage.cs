namespace RoomManagementSystem;

public partial class SignUpPage : Form
{
    public SignUpPage()
    {
        InitializeComponent();
        tBox_Password.UseSystemPasswordChar = true;
        tBox_ComfirmPassword.UseSystemPasswordChar = true;
    }

    private void cBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (cBox_ShowPassword.Checked)
        {
            tBox_Password.UseSystemPasswordChar = false;
        }
        else
        {
            tBox_Password.UseSystemPasswordChar = true;
        }
    }

    private void btn_SignUp_Click(object sender, EventArgs e)
    {
        string inputID = tBox_UserID.Text.Trim();
        string inputLName = tBox_LName.Text.Trim();
        string inputFName = tBox_FName.Text.Trim();
        string inputMName = tBox_MName.Text.Trim();
        string inputUserType = cBox_UserType.SelectedItem?.ToString();
        string inputPassword = tBox_Password.Text.Trim();
        string inputConfirmPassword = tBox_ComfirmPassword.Text.Trim();

        if (inputPassword != inputConfirmPassword)
        {
            MessageBox.Show("Passwords do not match.");
            return;
        }

        int id = int.Parse(inputID);

        if (Database.AddUser(id, inputPassword, inputLName, inputFName, inputMName, inputUserType))
        {
            MessageBox.Show("User sucessfully added to account verification.");

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
            return;
        }
        MessageBox.Show("Failed to insert user.");
    }
    private void SignUpPage_Load(object sender, EventArgs e)
    {

    }
}
