CREATE TABLE Users (
	userID int PRIMARY KEY NOT NULL,
	userPassword nvarchar(50) NOT NULL,
	userLName nvarchar(50),
	userFName nvarchar(50),
	userMName nvarchar(50),
	userType nvarchar(50) NOT NULL,
	verified bit
);
