namespace RoomManagementSystem;

internal static class Session
{
    public static int UserID = 0;
    public static string UserType = "";
    public static string CurrentRoomNameSelected = "";

    public static Dictionary<string, string> Rooms = new();
    public static Dictionary<string, string> RoomNameToID = new();

    public static void InitRooms()
    {
        Rooms = Database.GetRooms()!;
        foreach (var room in Rooms)
        {
            RoomNameToID[room.Value] = room.Key;
        }
    }
}
