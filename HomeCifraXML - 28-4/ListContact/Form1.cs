using OfficeOpenXml;

namespace ListContact
{
    public partial class Form1 : Form
    {
        List<Contact> listContact = new();
        public Form1()
        {
            InitializeComponent();
            AppSetup();
        }
        private void AppSetup()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (!File.Exists(Other.GetFilePath()))
                File.Create(Other.GetFilePath());
            ExcelOperation.CheckFile();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Other.ExitApp();
        }

        private void SaveFileBT_Click(object sender, EventArgs e)
        {

        }
    }
}