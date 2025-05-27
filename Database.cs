using System.Diagnostics;
using Microsoft.Data.SqlClient;
using RoomManagementSystem.Models;

namespace RoomManagementSystem;

internal static class Database
{
    private static string connectionString = "Data Source=localhost;Initial Catalog=RoomDirectoryManagementSystem;User ID=teuria;Password=admin;Encrypt=False";

    public static void Init()
    {
       
    }

    public static void ChangeIP(string ipAddress)
    {
        connectionString = $"Data Source={ipAddress};Initial Catalog=RoomDirectoryManagementSystem;User ID=teuria;Password=admin;Encrypt=False";
    }

    public static bool AddUser(int inputID, string inputPassword, string inputLName, string inputFName, string inputMName, string inputUserType)
    {
        using var conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();
            

            var cmd = conn.CreateCommand();
            cmd.CommandText = 
            """
            INSERT INTO Users (
                userID, userPassword, userLName, userFName, userMName, userType, verified
            )
            VALUES (
                @userID, @userPassword, @userLName, @userFName, @userMName, @userType, 0
            )   
            """;

            cmd.Parameters.AddWithValue("@userID", inputID);
            cmd.Parameters.AddWithValue("@userPassword", inputPassword);
            cmd.Parameters.AddWithValue("@userLName", inputLName);
            cmd.Parameters.AddWithValue("@userFName", inputFName);
            cmd.Parameters.AddWithValue("@userMName", inputMName);
            cmd.Parameters.AddWithValue("@userType", inputUserType);

            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return false;
        }
    }

    public static IReadOnlyList<User> GetAllUnverifiedUsers()
    {
        var list = new List<User>();
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
            """
            SELECT userID, userLName, userFName, userMName, userType 
            FROM Users
            WHERE verified = 0;
            """;

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                    new User(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), reader.GetString(3), reader.GetString(4))
                );
            }
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
        }

        return list;
    }

    public static bool RejectUser(User user)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = "DELETE FROM Users WHERE userID = @userID";

            cmd.Parameters.AddWithValue("@userID", user.ID);

            cmd.ExecuteNonQuery();

            return true;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return false;
        }
    }

    public static bool VerifyUser(User user)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText =
            """
            UPDATE Users
            SET verified = 1
            WHERE userID = @userID
            """;

            cmd.Parameters.AddWithValue("@userID", user.ID);

            cmd.ExecuteNonQuery();

            return true;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return false;
        }
    }

    public static User? GetUserByID(int userID)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT userID, userLName, userFName, userMName, userType FROM Users WHERE userID=@userID";

            cmd.Parameters.AddWithValue("@userID", userID);

            var reader = cmd.ExecuteReader();

            User user;
            reader.Read();
            user = new User(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), reader.GetString(3), reader.GetString(4));

            return user;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null;
        }
    }

    public static UserResult LoginUser(int inputUserName, string inputUserPassword, out string type)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            var cmd = conn.CreateCommand();

            cmd.CommandText =
            """
            SELECT COUNT(1), userType
            FROM Users 
            WHERE userID = @userID AND userPassword = @password
            GROUP BY userType;
            """;

            cmd.Parameters.AddWithValue("@userID", inputUserName);
            cmd.Parameters.AddWithValue("@password", inputUserPassword);


            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                var reader = cmd.ExecuteReader();
                reader.Read();
                type = reader.GetString(1);
                
                return UserResult.Success;
            }

            type = null!;
            return UserResult.InvalidUser;
        }
        catch (Exception e)
        {
            type = null;
            Debug.WriteLine(e);
            return UserResult.ConnectionError;
        }
    }

    public static Dictionary<string, string>? GetRooms()
    {
        var list = new Dictionary<string, string>();

        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id, roomName FROM Room";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);

                list.Add(id, name);
            }

            return list;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null;
        }
    }

    public static Room? CreateOrGetRoom(string roomID, string roomName)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            var cmd = conn.CreateCommand();

            cmd.CommandText =
                """
                BEGIN
                    IF NOT EXISTS (SELECT * FROM Room WHERE id=@roomID)
                    BEGIN
                        INSERT INTO Room (id, roomName)
                        VALUES (@roomID, @roomName)
                    END
                END;

                BEGIN
                    SELECT id, roomName, roomStatus, userID, section, timeIn, timeOut FROM Room WHERE id=@roomID;
                END;
                """;

            cmd.Parameters.AddWithValue("@roomID", roomID);
            cmd.Parameters.AddWithValue("@roomName", roomName);

            var reader = cmd.ExecuteReader();

            reader.Read();
            
            var outRoomID = reader.GetString(0);
            var outRoomName = reader.GetString(1);
            var status = reader.GetInt32(2);

            int? userID = null;
            string? section = null;
            DateTime? timeIn = null;
            DateTime? timeOut = null;

            if (!reader.IsDBNull(3))
            {
                userID = reader.GetInt32(3);
            }

            if (!reader.IsDBNull(4))
            {
                section = reader.GetString(4);
            }

            if (!reader.IsDBNull(5))
            {
                timeIn = reader.GetDateTime(5);
            }

            if (!reader.IsDBNull(6))
            {
                timeOut = reader.GetDateTime(6);
            }

            return new Room(outRoomID, outRoomName, status == 1, status == 2, userID, section, timeIn, timeOut);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            return null;
        }
    }

    public static bool OccupyOrUnoccupyRoom(string roomID, out int occupied)
    {
        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT roomStatus FROM Room WHERE id=@id AND userID=@userID";
            cmd.Parameters.AddWithValue("@id", roomID);
            cmd.Parameters.AddWithValue("@userID", Session.UserID);
            var reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                occupied = 1;
                return false;
            }

            using SqlConnection conn2 = new SqlConnection(connectionString);

            conn2.Open();

            int status = reader.GetInt32(0);
            cmd = conn2.CreateCommand();

            if (status == 1)
            {
                cmd.CommandText =
                """
                UPDATE Room
                SET roomStatus=0,
                    userID=NULL,
                    timeIn=NULL,
                    timeOut=NULL,
                    section=NULL
                WHERE id=@id AND userID=@userID
                """;

                cmd.Parameters.AddWithValue("@id", roomID);
                cmd.Parameters.AddWithValue("@userID", Session.UserID);

                cmd.ExecuteNonQuery();
                occupied = 2;
                return true;
            }

            cmd.CommandText =
                """
                UPDATE Room
                SET roomStatus=1
                WHERE id=@id AND userID=@userID AND NOT roomStatus=1
                """;

            cmd.Parameters.AddWithValue("@id", roomID);
            cmd.Parameters.AddWithValue("@userID", Session.UserID);

            int rows = cmd.ExecuteNonQuery();
            occupied = 1;
            return rows > 0;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
            occupied = 0;
            return false;
        }
    }

    public static void AddReservationForm(ReservationRequestForm reservationRequest)
    {
        using var conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();


            var cmd = conn.CreateCommand();
            cmd.CommandText =
            """
            INSERT INTO ReservationForm (
                id, userID, roomID, dateTimeIn, dateTimeOut, section, reason, accepted
            )
            VALUES (
                @id, @userID, @roomID, @dateTimeIn, @dateTimeOut, @section, @reason, 0
            )   
            """;

            cmd.Parameters.AddWithValue("@id", reservationRequest.ID);
            cmd.Parameters.AddWithValue("@userID", reservationRequest.UserID);
            cmd.Parameters.AddWithValue("@roomID", reservationRequest.RoomID);
            cmd.Parameters.AddWithValue("@dateTimeIn", reservationRequest.TimeIn);
            cmd.Parameters.AddWithValue("@dateTimeOut", reservationRequest.TimeOut);
            cmd.Parameters.AddWithValue("@section", reservationRequest.Section);
            cmd.Parameters.AddWithValue("@reason", reservationRequest.Reason);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    public static void RejectReservationForm(ReservationRequestForm reservationRequest)
    {
        using var conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();


            var cmd = conn.CreateCommand();
            cmd.CommandText =
            """
            DELETE FROM ReservationForm
            WHERE id=@id
            """;

            cmd.Parameters.AddWithValue("@id", reservationRequest.ID);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    public static List<ReservationRequestForm> GetAllPendingReservationForms()
    {
        var list = new List<ReservationRequestForm>();
        using var conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();


            var cmd = conn.CreateCommand();
            cmd.CommandText =
            """
            SELECT id, userID, roomID, dateTimeIn, dateTimeOut, section, reason 
            FROM ReservationForm
            WHERE accepted=0
            """;


            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ReservationRequestForm(
                    reader.GetGuid(0),
                    reader.GetInt32(1), 
                    reader.GetString(2), 
                    reader.GetDateTime(3), 
                    reader.GetDateTime(4), 
                    reader.GetString(5), 
                    reader.GetString(6)
                ));
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }

        return list;
    }

    public static void AcceptReservationForm(ReservationRequestForm form)
    {
        var list = new List<ReservationRequestForm>();
        using var conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();


            var cmd = conn.CreateCommand();
            cmd.CommandText =
            """
            BEGIN
                UPDATE ReservationForm
                SET accepted = 1
                WHERE id = @id
            END;

            BEGIN
            	UPDATE Room
            	SET Room.roomStatus = 2,
                    Room.userID = @userID,
                    Room.timeIn = @timeIn,
                    Room.timeOut = @timeOut,
                    Room.section = @section
            	FROM Room r
            	JOIN ReservationForm rf
            		ON r.id=rf.roomID
            	WHERE r.id = @roomID
            END;
            """;

            cmd.Parameters.AddWithValue("@id", form.ID);
            cmd.Parameters.AddWithValue("@userID", form.UserID);
            cmd.Parameters.AddWithValue("@timeIn", form.TimeIn);
            cmd.Parameters.AddWithValue("@timeOut", form.TimeOut);
            cmd.Parameters.AddWithValue("@section", form.Section);
            cmd.Parameters.AddWithValue("@roomID", form.RoomID);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    public static List<ReservationRequestForm> GetAllAcceptedReservationForms()
    {
        var list = new List<ReservationRequestForm>();
        using var conn = new SqlConnection(connectionString);
        try
        {
            conn.Open();


            var cmd = conn.CreateCommand();
            cmd.CommandText =
            """
            SELECT id, userID, roomID, dateTimeIn, dateTimeOut, section, reason 
            FROM ReservationForm
            WHERE accepted=1
            """;


            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ReservationRequestForm(
                    reader.GetGuid(0),
                    reader.GetInt32(1),
                    reader.GetString(2),
                    reader.GetDateTime(3),
                    reader.GetDateTime(4),
                    reader.GetString(5),
                    reader.GetString(6)
                ));
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }

        return list;
    }

    public static Dictionary<string, int> GetRoomAvailability()
    {
        var list = new Dictionary<string, int>()
        {
            ["lectureRooms"] = 0,
            ["lab"] = 0,
            ["kitchen"] = 0,
            ["gym"] = 0,
            ["avr"] = 0,
            ["bar"] = 0,
            ["library"] = 0,
            ["mockHotel"] = 0
        };

        try
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            var cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id, roomStatus FROM Room";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string id = reader.GetString(0);
                int status = reader.GetInt32(1);

                if (status == 1)
                {
                    continue;
                }

                if (id.StartsWith("room"))
                {
                    if (!id.Contains("302"))
                    {
                        list["lectureRooms"] += 1;
                    }
                    else
                    {
                        list["bar"] += 1;
                    }
                }
                else if (id.Contains("lab"))
                {
                    list["lab"] += 1;
                }
                else
                {
                    list[id] += 1;
                }
            }

            return list;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
        }

        return list;
    }
}

            
                