namespace lab1.Interfaces;

using lab1.Entity;


public interface ISender
{
    public NotificationTypes SenderType { get; }
    void SendNotification(User recipient, Notification notification);
}
