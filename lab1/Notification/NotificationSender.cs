namespace lab1.Notification;

using System;
using lab1.Interfaces;
using lab1.Entity;


public class NotificationSender : ISender
{
    public NotificationTypes SenderType => NotificationTypes.Messenger;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends messenger notification");
    }
}
