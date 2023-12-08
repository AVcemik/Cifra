namespace TaskList
{
    public partial class Form1 : Form
    {
        
        private List<Task> _listTask = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultSetupApp();  // Настройки программы по умолчанию
        }
        private void DefaultSetupApp()
        {
            if (File.Exists(_dataFile))

            PriorityTaskCB.SelectedIndex = 0;
        }
    }
}