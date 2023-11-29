using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CsvReaders
{
    public partial class Form1 : Form
    {
        private List<Person> _fileContent = new();
        private string _filePath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenCsvFileBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new())
            {
                ofd.InitialDirectory = Directory.GetCurrentDirectory();
                ofd.Filter = "csv files (*.csv) | *.csv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _filePath = ofd.FileName;

                    StreamReader streamReader = new(_filePath);

                    CsvReader csvReader = new(streamReader, CultureInfo.InvariantCulture);
                    _fileContent = csvReader.GetRecords<Person>().ToList();
                    streamReader.Close();
                }
            }
            DataCsvFileDGV.DataSource = _fileContent;
        }

        private void SaveCsvFileBT_Click(object sender, EventArgs e)
        {
            _fileContent.Clear();
            for (int i = 0; i < DataCsvFileDGV.Rows.Count; i++)
            {
                
            };

            StreamWriter streamWriter = new(_filePath);

            CsvWriter csvWriter = new(streamWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(_fileContent);
            streamWriter.Close();
        }
    }
}