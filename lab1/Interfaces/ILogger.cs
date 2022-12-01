namespace lab1.Interfaces;

using System;
using lab1.Core;

public interface ILogger
{
    void LogTaskChanges(Task task, DateTime dateTime);
}
