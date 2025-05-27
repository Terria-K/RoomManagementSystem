namespace RoomManagementSystem.Models;

internal record User(
    int ID, 
    string FirstName, 
    string LastName, 
    string MiddleName, 
    string UserType
);
