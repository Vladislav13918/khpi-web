namespace lab3;
using lab3.Interfaces;

public class FacebookCreator : ISocialNetworkCreator<FacebookCredentials>
{
    public ISocialNetwork Create(FacebookCredentials credentials)
    {
        return new Facebook();
    }
}
