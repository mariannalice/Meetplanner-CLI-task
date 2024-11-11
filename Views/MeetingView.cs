public class MeetingView
{
  public void DisplayMeeting(Meeting meeting)
  {
    Console.WriteLine($"Title: {meeting.Title}");
    Console.WriteLine($"Date: {meeting.Date}");
    Console.WriteLine($"Location: {meeting.Location}");
  }

  public Meeting GetMeetingDetails()
  {
    Console.WriteLine("Enter Title: ");
    string? title = Console.ReadLine();

    Console.WriteLine("Enter Date: ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Enter Location: ");
    string? location = Console.ReadLine();

    return new Meeting(title, date, location);
  }
}