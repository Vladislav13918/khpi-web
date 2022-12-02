namespace lab1.Interfaces;

using System;
using lab1.Notification;

public interface ILogger
{
    void LogTaskChanges(Task task, DateTime dateTime);
}
