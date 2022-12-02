namespace lab1.Services;

using System;
using lab1.Interfaces;
using lab1.Notification;


public class SmsNotification : ISender
{
    public NotificationTypes SenderType => NotificationTypes.Sms;

    public void SendNotification(User recipient, Notification notification)
    {
        Console.WriteLine("Sends SMS notification");
    }
}
