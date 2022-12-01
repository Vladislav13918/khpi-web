namespace lab4;

using lab4.Interfaces;

public class SlackNotification : INotification
{
    private Slack _slackSender;
    private string _chatId;

    public SlackNotification(Slack slackSender, string chatId)
    {
        _slackSender = slackSender;
        _chatId = chatId;
    }

    public void Send(string title, string message)
    {
        _slackSender.Send(_chatId, title, message);
    }
}
