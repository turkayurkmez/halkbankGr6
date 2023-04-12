// See https://aka.ms/new-console-template for more information
using Constructor;

Report performance = new Report("C:\\ikperformans.xlsx");
Console.WriteLine(performance.ReportFormat);
Report sales = new Report("C:\\MartSatis.xlsx");

Report report = new Report("C:\\muhasebe.xlsx", "1. Çeyrek bütçe planlaması");
Console.WriteLine(report.Title);
Console.WriteLine(report.ExcelFilePath);

Report init = new Report()
{
    Title = "Başlığınız",
    IsChangable = false,
    IsIncludeGraphic = false,
    ReportFormat = "Excel"
};

//object initializtion kullanarak bir nesnenin özellikleri kolaylıkla set edilebilir. Ancak bu, constructor'un pabucunu dama atmaz
