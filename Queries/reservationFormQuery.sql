USE RoomDirectoryManagementSystem;

CREATE TABLE ReservationForm(
	id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	userID int FOREIGN KEY (userID) REFERENCES Users(userID),
	roomID nvarchar(50) FOREIGN KEY (roomID) REFERENCES Room(id),
	dateTimeIn dateTime,
	dateTimeOut dateTime,
	section nvarchar(20),
	reason nvarchar(200),
	accepted bit DEFAULT 0
);