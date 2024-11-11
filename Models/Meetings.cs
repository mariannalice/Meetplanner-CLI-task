public class Meeting
{
  public string? Title { get; set; }
  public DateTime Date { get; set; }
  public string? Location { get; set; }

  public Meeting(string title, DateTime date, string location)
  {
    Title = title;
    Date = date;
    Location = location;
  }
}