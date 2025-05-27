using RoomManagementSystem.Models;

namespace RoomManagementSystem;

public partial class MainPage : Form
{
    private string currentRoomId = "";
    private Type? currentControlType = null;

    public MainPage()
    {
        InitializeComponent();

        UC_Floor1 uC_Floor1 = new UC_Floor1();
        addUserControl(uC_Floor1);
        lbl_CurrentFloor.Text = "Floor 1";

        EventBus.RoomClicked += OnRoomClicked;
        EventBus.AcceptedReservationForm += RefreshPage;
    }

    private void RefreshPage()
    {
        if (currentControlType != null)
        {
            var control = (UserControl)Activator.CreateInstance(currentControlType)!;
            addUserControl(control);
        }
    }

    private void MainPage_Load(object sender, EventArgs e)
    {
        Session.InitRooms();
        btnAccVerification.Visible = Session.UserType == "ADMIN";
        btn_Reserve.Visible = btn_Occupy.Visible = btn_ReservationRequest.Visible = Session.UserType == "ADMIN" || Session.UserType == "INSTRUCTOR";
        Reset();
    }

    private void OnRoomClicked(Room room)
    {
        Reset();
        currentRoomId = room.ID;
        roomID.Text = room.Name;
        if (room.Occupied)
        {
            statusText.Text = "Occupied";
            SetData(room);

            if (room.UserID == Session.UserID)
            {
                btn_Occupy.Text = "Unoccupy";
            }
        }
        else if (room.Reserved)
        {
            btn_Occupy.Text = "Occupy";
            statusText.Text = "Reserved";
            SetData(room);
        }
        else
        {
            btn_Occupy.Text = "Occupy";
            statusText.Text = "Vacant";
            instructorText.Text = "";
        }
    }

    private void SetData(Room room)
    {
        if (room.UserID is null)
        {
            return;
        }
        var user = Database.GetUserByID(room.UserID.Value);
        if (user != null)
        {
            instructorText.Text = $"{user.LastName}, {user.FirstName} {user.MiddleName}";
        }
        sectionText.Text = room.Section ?? "";

        timeInText.Text = room.TimeIn?.ToShortTimeString() ?? "";
        timeOutText.Text = room.TimeOut?.ToShortTimeString() ?? "";
    }

    private void Reset()
    {
        instructorText.Text = "";
        sectionText.Text = "";
        timeInText.Text = "";
        statusText.Text = "";
        roomID.Text = "";
        timeInText.Text = "";
        timeOutText.Text = "";

        var availability = Database.GetRoomAvailability();

        lbl_countLecRoom.Text = $"{availability["lectureRooms"]} / 15";
        lbl_countComLab.Text = $"{availability["lab"]} / 3";
        lbl_countLibrary.Text = $"{availability["library"]} / 1";
        lbl_countAVR.Text = $"{availability["avr"]} / 1";
        lbl_countBar.Text = $"{availability["bar"]} / 1";
        lbl_countGym.Text = $"{availability["gym"]} / 1";
        lbl_countKitchen.Text = $"{availability["kitchen"]} / 1";
    }


    private void addUserControl<T>(T userControl)
    where T : UserControl
    {
        Reset();
        currentRoomId = "";
        userControl.Dock = DockStyle.Fill;
        pnl_roomMapContainer.Controls.Clear();
        pnl_roomMapContainer.Controls.Add(userControl);
        userControl.BringToFront();

        currentControlType = userControl.GetType();
    }

    private void button1_Click_2(object sender, EventArgs e)
    {
        UC_Floor1 uC_Floor1 = new UC_Floor1();
        addUserControl(uC_Floor1);
        lbl_CurrentFloor.Text = "Floor 1";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        UC_Floor2 uC_Floor2 = new UC_Floor2();
        addUserControl(uC_Floor2);
        lbl_CurrentFloor.Text = "Floor 2";
    }

    private void button3_Click(object sender, EventArgs e)
    {
        UC_Floor3 uC_Floor3 = new UC_Floor3();
        addUserControl(uC_Floor3);
        lbl_CurrentFloor.Text = "Floor 3";
    }

    private void button4_Click(object sender, EventArgs e)
    {
        UC_Floor4 uC_Floor4 = new UC_Floor4();
        addUserControl(uC_Floor4);
        lbl_CurrentFloor.Text = "Floor 4";
    }

    private void button5_Click(object sender, EventArgs e)
    {
        UC_Floor5 uC_Floor5 = new UC_Floor5();
        addUserControl(uC_Floor5);
        lbl_CurrentFloor.Text = "Floor 5";
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        AccountVerificationPage accountVerificationPage = new AccountVerificationPage();
        accountVerificationPage.ShowDialog();
        accountVerificationPage.BringToFront();
    }

    private void btn_Reserve_Click(object sender, EventArgs e)
    {
        ReservationForm reservationForm = new ReservationForm();
        reservationForm.ShowDialog();
        reservationForm.BringToFront();
    }

    private void OnLogout(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
        $"Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);
        if (result != DialogResult.Yes)
        {
            return;
        }

        this.Hide();
        LoginPage loginPage = new LoginPage();
        loginPage.Show();
    }

    private void OnReservationRequestClicked(object sender, EventArgs e)
    {
        ReservationFormPage reservationFormPage = new ReservationFormPage();
        reservationFormPage.ShowDialog();
        reservationFormPage.BringToFront();
    }

    private void OnOccupyRoom(object sender, EventArgs e)
    {
        if (!Database.OccupyOrUnoccupyRoom(currentRoomId, out int isOccupied))
        {
            MessageBox.Show("Cannot occupy this room. Possible that you did not reserve for this room, the time in has not met yet or it has been already occupied.", "Occupy failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        RefreshPage();

        if (isOccupied == 1)
        {
            MessageBox.Show("Occupied.", "Occupy Success.", MessageBoxButtons.OK);
        }
        else
        {
            btn_Occupy.Text = "Occupy";
            MessageBox.Show("Unoccupied.", "Unoccupy Success.", MessageBoxButtons.OK);
        }
    }

    private void OnRefresh(object sender, EventArgs e)
    {
        RefreshPage();
    }
}
