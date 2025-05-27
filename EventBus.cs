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
}
