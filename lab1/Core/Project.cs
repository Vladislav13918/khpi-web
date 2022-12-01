namespace lab1.Core;

public class Project
{
    public string Title { get; set; }
    public string Description { get; set; }
    public User Admin { get; set; }
    public User[] Users { get; set; }
    public Task[] Tasks { get; set; }
}
