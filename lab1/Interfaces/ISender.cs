namespace lab1.Interfaces;

using lab1.Core;


public interface ISender
{
    public NotificationTypes SenderType { get; }
    void SendNotification(User recipient, Notification notification);
}
