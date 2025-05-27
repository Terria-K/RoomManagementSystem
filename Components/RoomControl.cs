using System.ComponentModel;
using RoomManagementSystem.Models;

namespace RoomManagementSystem.Components;

public partial class RoomControl : UserControl
{
    public enum RoomType
    {
        Occupiable,
        Miscellanous
    }

    [DefaultValue("")]
    public string RoomID { get; set; } = "";


    [DefaultValue("")]
    public string RoomName { get; set; } = "";

    [DefaultValue(RoomType.Occupiable)]
    public RoomType Type { get; set; }

    private bool occupied;
    private bool reserved;
    private int? userID;
    private string? section;
    private DateTime? timeIn;
    private DateTime? timeOut;

    public RoomControl()
    {
        InitializeComponent();

        Load += OnLoad;
        Click += OnClicked;
    }

    private void OnClicked(object? sender, EventArgs e)
    {
        Session.CurrentRoomNameSelected = RoomName;
        EventBus.InvokeClickRoom(new Models.Room(RoomID, RoomName, occupied, reserved, userID, section, timeIn, timeOut));
    }

    private void OnLoad(object? sender, EventArgs e)
    {
        text.Text = RoomName;
        text.Location = new Point(
                (Width / 2) - (text.Width / 2),
                (Height / 2) - (text.Height / 2)
            );
        
        if (Type == RoomType.Occupiable)
        {
            if (!DesignMode)
            {
                FetchData();
            }
            

            if (occupied)
            {
                BackColor = Color.Red;
            }
            else if (reserved)
            {
                BackColor = Color.Orange;
            }
            else
            {
                BackColor = Color.Lime;
                text.ForeColor = Color.Black;
            }

            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            return;
        }

        BackColor = Color.Gray;
    }

    private void FetchData()
    {
        Room? room = Database.CreateOrGetRoom(RoomID, RoomName);

        if (room != null)
        {
            occupied = room.Occupied;
            reserved = room.Reserved;
            section = room.Section;
            timeIn = room.TimeIn;
            timeOut = room.TimeOut;
            userID = room.UserID;
        }
    }

    private void OnMouseLeave(object? sender, EventArgs e)
    {
        if (occupied)
        {
            text.ForeColor = Color.White;
            BackColor = Color.Red;
        }
        else if (reserved)
        {
            BackColor = Color.Orange;
        }
        else
        {
            text.ForeColor = Color.Black;
            BackColor = Color.Lime;
        }
    }

    private void OnMouseHover(object? sender, EventArgs e)
    {
        if (occupied)
        {
            text.ForeColor = Color.White;
            BackColor = Color.DarkRed;
        }
        else if (reserved)
        {
            BackColor = Color.OrangeRed;
        }
        else
        {
            text.ForeColor = Color.White;
            BackColor = Color.DarkGreen;
        }
    }
}
