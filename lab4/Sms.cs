namespace lab4;

public class Sms
{
    private string _sender;

    public Sms(string sender)
    {
        _sender = sender;
    }

    public void Send(string phone, string title, string message)
    {
        Console.WriteLine($"Sent SMS from {_sender} to {phone} with title {title} that says {message}");
    }
}
