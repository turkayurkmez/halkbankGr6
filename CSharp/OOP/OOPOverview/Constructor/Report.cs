namespace Constructor
{
    public class Report
    {
        //Bu rapor, bilgisayarınızda bulunan bir excel dosyasından veri okunarak oluşturulmaktadır.
        public string ReportFormat { get; set; }
        public bool IsChangable { get; set; }

        public string Title { get; set; }
        public string ExcelFilePath { get; set; }

        public bool IsIncludeGraphic { get; set; }
        public Report()
        {
            ReportFormat = "PDF";
            IsChangable = true;
            ExcelFilePath = "C:\\Documents\\myFile.xlsx";
            initialize();
        }

        private void initialize()
        {

        }

        public Report(string excelFilePath)
        {
            ReportFormat = "PDF";
            IsChangable = true;
            ExcelFilePath = excelFilePath;
        }

        public Report(string excelFilePath, string title) : this(excelFilePath)
        {
            Title = title;
        }

        public Report(string excelFilePath, bool isIncludeGraphic) : this(excelFilePath)
        {
            IsIncludeGraphic = isIncludeGraphic;
        }




    }
}
