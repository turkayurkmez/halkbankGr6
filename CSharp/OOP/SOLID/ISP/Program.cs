// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ISP: Interface Segregation Principle; Arayüzleri birbirlerinden ayır. Eğer bir metod bir interface'dan gelmesine rağmen KULLANILMIYOR ise bu prensibi ihlal ediyorsunuz demektir.
//Bir sınıf, bir interface'i implemente etmiş ise bu implementasyondaki tüm fonksiyonları kullanmalıdır!

public interface IMessage
{
    string From { get; set; }
    string To { get; set; }
    string Message { get; set; }
    string Subject { get; set; }
    string Body { get; set; }

}

public interface IAudioMessage : IMessage
{
    int AudioDuration { get; set; }
    string AudioFormat { get; set; }
}

public interface IVideoMessage : IMessage
{
    int VideoDuration { get; set; }
    string VideoFormat { get; set; }
}

public class TextMessage : IMessage
{
    public string From { get; set; }
    public string To { get; set; }
    public string Message { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

}

public class VideoMessage : IVideoMessage
{
    public int VideoDuration { get; set; }
    public string VideoFormat { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Message { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}