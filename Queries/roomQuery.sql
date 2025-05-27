USE RoomDirectoryManagementSystem;

CREATE TABLE Room(
	id nvarchar(50) NOT NULL PRIMARY KEY,
	roomName nvarchar(50),
	roomStatus int NOT NULL DEFAULT 0,
	userID int FOREIGN KEY (userID) REFERENCES Users(userID),
	timeIn dateTime,
	timeOut dateTime,
	section nvarchar(20)
);