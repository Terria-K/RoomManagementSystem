namespace RoomManagementSystem.Models;

internal record class Room(
    string ID,
    string Name,
    bool Occupied,
    bool Reserved,
    int? UserID,
    string? Section,
    DateTime? TimeIn,
    DateTime? TimeOut
);
