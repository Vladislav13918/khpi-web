namespace lab1.Services;

using System;
using lab1.Interfaces;
using lab1.Core;


public class NotificationSender : ISender
{
    public NotificationTypes SenderType => NotificationTypes.Messenger;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends messenger notification");
    }
}
