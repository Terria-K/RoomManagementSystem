using RoomManagementSystem.Models;

namespace RoomManagementSystem;

internal static class EventBus
{
    public delegate void ClickRoom(Room room);
    public static event ClickRoom? RoomClicked;

    internal static void InvokeClickRoom(Room room)
    {
        RoomClicked?.Invoke(room);
    }

    public delegate void AcceptReservationForm();
    public static event AcceptReservationForm? AcceptedReservationForm;

    internal static void InvokeAcceptReservationForm()
    {
        AcceptedReservationForm?.Invoke();
    }
}
