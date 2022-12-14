namespace lab1;

using lab1.Interfaces;
using lab1.Entity;
using lab1.Notification;

public static class Program
{
    public static void Main(string[] args)
    {
        NotificationProvider senderProvider = new NotificationProvider();
        ILogger taskChangesLogger = new FileTaskChangesLogger();

        ProjectService projectService = new ProjectService(taskChangesLogger, senderProvider);

        User user1 = new User
        {
            FirstName = "Freddie",
            LastName = "Mercury"
        };

        User user2 = new User
        {
            FirstName = "Vladislav",
            LastName = "Kravtsov"
        };

        Task task = new Task
        {
            Title = "Some task",
            Description = "Excellent task",
            AssignedUser = user1
        };

        Project project = new Project
        {
            Admin = user2,
            Title = "Test project",
            Description = "Excellent project",
            Tasks = new[] { task },
            Users = new[] { user1 }
        };

        projectService.CreateTask(project, user1, new Task());
        projectService.UpdateTask(task);
        projectService.AddUserToProject(
            project,
            new User
            {
                FirstName = "Ivan",
                LastName = "Khludenev"
            },
            NotificationTypes.Messenger);
    }
}

