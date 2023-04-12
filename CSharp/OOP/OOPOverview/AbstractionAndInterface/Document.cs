namespace AbstractionAndInterface
{
    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine($"{from} adresinden {to} adresine taşındı");
        }


        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public abstract void Save();
        public abstract void Open();


    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            Console.WriteLine("PDF kaydediliyor");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı aınıyor");
        }

        public override void Save()
        {
            Console.WriteLine("Excel kaydediliyor");

        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı aınıyor");

        }

        public override void Save()
        {
            Console.WriteLine("Word kaydediliyor");

        }
    }


    public class PrinterComponent
    {
        public void SendDocumentToPrinter(IPrintable document)
        {
            document.Print();
        }
    }
}
