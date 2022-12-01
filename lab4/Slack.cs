namespace lab4;



public class Slack
{
    private string _apiKey;
    private string _login;

    public Slack(string login, string apiKey)
    {
        _login = login;
        _apiKey = apiKey;
    }

    public void Send(string chatId, string title, string message)
    {
        Console.WriteLine($"Authorized with API key {_apiKey} and login {_login}");
        Console.WriteLine($"Sent Slack message to chat {chatId} with title {title} that says {message}");
    }
}
