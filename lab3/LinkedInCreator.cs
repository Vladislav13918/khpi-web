namespace lab3;
using lab3.Interfaces;


public class LinkedInCreator : ISocialNetworkCreator<LinkedInCredentials>
{
    public ISocialNetwork Create(LinkedInCredentials credentials)
    {
        return new LinkedIn();
    }
}
