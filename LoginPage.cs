using System.Data;
using Microsoft.Data.SqlClient;


namespace RoomManagementSystem;

public partial class LoginPage : Form
{
    public LoginPage()
    {
        InitializeComponent();

        tBox_Password.UseSystemPasswordChar = true;
    }

    private void lbl_SignUp_Click(object sender, EventArgs e)
    {
        this.Hide();
        SignUpPage signUpPage = new SignUpPage();
        signUpPage.ShowDialog();
    }

    private void btn_Login_Click(object sender, EventArgs e)
    {
        string inputUserName = tBox_UserID.Text.Trim();
        string inputUserPassword = tBox_Password.Text;

        if (string.IsNullOrEmpty(inputUserName) || string.IsNullOrEmpty(inputUserPassword))
        {
            MessageBox.Show("Please enter both User ID and Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int id = int.Parse(inputUserName);

        switch (Database.LoginUser(id, inputUserPassword, out string userType))
        {
            case Models.UserResult.Success:
                Session.UserID = id;
                Session.UserType = userType;
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
                break;
            case Models.UserResult.InvalidUser:
                MessageBox.Show("Invalid User ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            case Models.UserResult.ConnectionError:
                MessageBox.Show($"Database connection error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
        }

        tBox_UserID.Clear();
        tBox_Password.Clear();
        cBox_ShowPassword.Checked = false;
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

    private void OnIPChange(object sender, EventArgs e)
    {
        string ip = ipBox.Text;

        if (string.IsNullOrEmpty(ip))
        {
            return;
        }

        Database.ChangeIP(ip);
    }
}
