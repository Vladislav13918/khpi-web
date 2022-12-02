namespace lab1.Notification;

using System;
using lab1.Interfaces;
using lab1.Entity;

public class FileLogger : ILogger
{
    public void LogTaskChanges(Task task, DateTime dateTime)
    {
        Console.WriteLine($"Logs task changes made by user {task.AssignedUser.FirstName}");
    }
}
