namespace lab3;
using lab3.Interfaces;


public class LinkedIn : ISocialNetwork
{
    public void SendMessage(Message post)
    {
        Console.WriteLine(post.Text);
    }
}
