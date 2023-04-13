// See https://aka.ms/new-console-template for more information
MailSender mailSender = new MailSender();
Report report = new Report(mailSender);

Report report1 = new Report(new WhatsAppSender());
Report report2 = new Report(new TelegramSender());



report.Send("");

Console.WriteLine("Hello, World!");
//Dependency Inversion Principle:
//Bağımlılığı Tersine çevirme prensibi

//Ram çalışmazsa Laptop çalışmaz.
//Laptop Ram'a bağımlıdır.
//Matkap; ucuna bağımlıdır.

public class Report
{
    private ISender sender;

    public Report(ISender sender)
    {
        this.sender = sender;
    }
    public void Send(string to)
    {
        //MailSender sender = new MailSender();
        sender.Send(to);
    }
}

public class MailSender : ISender
{
    public void Send(string to)
    {
        Console.WriteLine("mail ile gönderildi");
    }
}

public interface ISender
{
    void Send(string to);
}

public class WhatsAppSender : ISender
{
    public void Send(string to)
    {
        Console.WriteLine("Whatsapp ile gönderildi");

    }
}
public class TelegramSender : ISender
{
    public void Send(string to)
    {
        Console.WriteLine("Telegram ile gönderildi");
    }
}
