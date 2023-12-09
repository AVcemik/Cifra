using CsvHelper;
using System.Globalization;

namespace CsvReaders
{
    public partial class Form1 : Form
    {
        private List<Person> _fileContent = new();
        private string _filePath = Directory.GetCurrentDirectory() + "\\Data.csv";
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenCsvFileBT_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new(_filePath);

            CsvReader csvReader = new(streamReader, CultureInfo.InvariantCulture);
            _fileContent = csvReader.GetRecords<Person>().ToList();
            streamReader.Close();
            DataCsvFileDGV.DataSource = _fileContent;
        }
        private void SaveCsvFileBT_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new(_filePath);

            CsvWriter csvWriter = new(streamWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(_fileContent);
            streamWriter.Close();
            MessageBox.Show("Файл сохранен", "Уведомление");
        }
    }
}