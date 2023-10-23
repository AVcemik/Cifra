namespace Redaction
{
    public partial class Form1 : Form
    {
        public static string fileData = Directory.GetCurrentDirectory() + "\\UserData.json";
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(fileData))
            {
                File.CreateText(fileData);
            }
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}