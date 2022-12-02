namespace lab1.Notification;

using System;
using lab1.Interfaces;
using lab1.Entity;


public class SmsNotification : ISender
{
    public NotificationTypes SenderType => NotificationTypes.Sms;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends SMS notification");
    }
}
