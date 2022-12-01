namespace lab1.Services;

using lab1.Interfaces;


public class NotificationSenderProvider
{
    public ISender DefaultSender { get; set; }

    public void SetDefaultSender(NotificationTypes senderType)
    {
        // sets default sender.
    }

    public ISender GetSender(NotificationTypes senderType)
    {
        // returns sender by its sender type. if not found - returns default sender.
        return null;
    }

    public void AddSender(ISender sender)
    {
        // adds available sender.
    }

    public void RemoveSender(NotificationTypes senderType)
    {
        // removes sender.
    }
}
