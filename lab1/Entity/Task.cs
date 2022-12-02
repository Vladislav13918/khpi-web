namespace lab1.Entity;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public User AssignedUser { get; set; }
}
