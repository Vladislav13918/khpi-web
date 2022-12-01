namespace lab2;

public static class Program
{
    public static void Main(string[] args)
    {
        User user1 = new User
        {
            FirstName = "Emmi",
            LastName = "Adans",
            FileStorage = AmazonS3.CreateInstance()
        };

        User user2 = new User
        {
            FirstName = "Taylor",
            LastName = "Hebert",
            FileStorage = LocalFile.CreateInstance()
        };
    }
}
