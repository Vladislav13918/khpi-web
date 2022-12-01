namespace lab4;


public static class Program
{
    public static void Main(string[] args)
    {
        var emailNotification = new EmailNotification("admin@mail.com");
        emailNotification.Send("Email Title", "Email Message");

        var slackSender = new Slack("login123", "52c8ea3d-0712-414a-b3a0-7b31740aaaa3");
        var slackNotification = new SlackNotification(slackSender, "chatId123");
        slackNotification.Send("Slack Title", "Slack Message");

        var smsSender = new Sms("SmsSender");
        var smsNotification = new SmsNotification(smsSender, "+3801234567");
        smsNotification.Send("SMS Title", "SMS Message");
    }
}
