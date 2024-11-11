public class MeetingController
{
  private readonly MeetingView _view;
  public MeetingController(MeetingView view)
  {
    _view = view;
  }

  public void CreateMeeting()
  {
    var meeting = _view.GetMeetingDetails();
    _view.DisplayMeeting(meeting);
  }
}