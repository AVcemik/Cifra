namespace ListContact
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AppSetup();
        }
        private void AppSetup()
        {
            if (!File.Exists(Other.GetFilePath()))
                File.Create(Other.GetFilePath());
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}