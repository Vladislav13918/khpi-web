namespace lab4;

using lab4.Interfaces;

public class SmsNotification : INotification
{
    private Sms _smsSender;
    private string _phone;

    public SmsNotification(Sms smsSender, string phone)
    {
        _smsSender = smsSender;
        _phone = phone;
    }

    public void Send(string title, string message)
    {
        _smsSender.Send(_phone, title, message);
    }
}
