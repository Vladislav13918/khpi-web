namespace lab3;
using lab3.Interfaces;


public class Facebook : ISocialNetwork
{
    public void SendMessage(Message post)
    {
        Console.WriteLine(post.Text);
    }
}
