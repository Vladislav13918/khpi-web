namespace lab1.Interfaces;

using lab1.Notification;


public interface ISender
{
    public NotificationTypes SenderType { get; }
    void SendNotification(User recipient, Notification notification);
}
