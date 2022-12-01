namespace lab3;

using lab3.Interfaces;


public static class Program
{
    public static void Main(string[] args)
    {

        var facebookCredentials = new FacebookCredentials
        {
            Login = "login",
            Password = "password"
        };

        var facebookCreator = new FacebookCreator();
        ISocialNetwork facebook = facebookCreator.Create(facebookCredentials);

        facebook.SendMessage(new Message
        {
            Text = "Facebook message"
        });


        var linkedInCredentials = new LinkedInCredentials
        {
            Email = "test@email.com",
            Password = "password"
        };

        var linkedInCreator = new LinkedInCreator();
        ISocialNetwork linkedIn = linkedInCreator.Create(linkedInCredentials);

        linkedIn.SendMessage(new Message
        {
            Text = "LinkedIn message"
        });
    }
}
