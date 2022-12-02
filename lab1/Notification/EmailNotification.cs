namespace lab1.Notification;

using System;
using lab1.Interfaces;
using lab1.Entity;

public class EmailNotification : ISender
{
    public NotificationTypes SenderType => NotificationTypes.Email;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends email notification");
    }
}
