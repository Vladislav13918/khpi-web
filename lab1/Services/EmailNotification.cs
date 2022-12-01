namespace lab1.Services;

using System;
using lab1.Interfaces;
using lab1.Core;

public class EmailNotification : ISender
{
    public NotificationTypes SenderType => NotificationTypes.Email;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends email notification");
    }
}
