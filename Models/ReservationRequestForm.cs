namespace RoomManagementSystem.Models;

public record ReservationRequestForm(
    Guid ID,
    int UserID,
    string RoomID,
    DateTime TimeIn,
    DateTime TimeOut,
    string Section,
    string Reason
);
