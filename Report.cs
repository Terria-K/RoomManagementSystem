using System.Text;

namespace RoomManagementSystem;

internal class Reports
{
    private static StringBuilder builder = new StringBuilder();

    public static void AddToReport(string content, string message)
    {
        builder.AppendLine($"[{DateTime.UtcNow.ToShortTimeString()}][{content}] {message}");
    }

    public static void Report(string message)
    {
        string file = DateTime.UtcNow.ToString("MM-dd-yy-hh-mm-ss");
        File.WriteAllText(Path.Combine("C:\\Documents\\Reports", file + ".txt"), builder.ToString());
    }
}
