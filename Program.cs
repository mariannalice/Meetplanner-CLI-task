namespace Meetplanner_CLI_task;
class Program
{
    static void Main(string[] args)
    {
        var view = new MeetingView();
        var controller = new MeetingController(view);

        controller.CreateMeeting();
    }
}
