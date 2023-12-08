namespace TaskList
{
    public partial class Form1 : Form
    {
        
        private List<Tasks> _listTask = new();
        public Form1()
        {
            InitializeComponent();
            DefaultSetupApp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultSetupApp();  
        }
        private void DefaultSetupApp()  // ��������� ��������� �� ���������
        {
            PriorityTaskCB.SelectedIndex = 0;
            ExcelOperation.CheckFileXLSX();
            _listTask = ExcelOperation.LoadDataXLSX();
            UpdateDataDGV();
        }
        private void AddTaskBT_Click(object sender, EventArgs e)    // ������ ���������� ������
        {
            if (NameTaskTB.Text.Trim() != "")
            {
                string name = NameTaskTB.Text;
                DateTime date = DateTaskDTP.Value;
                Priority priority = (Priority)PriorityTaskCB.SelectedIndex;
                Tasks temp = new(name, date, priority);
                _listTask.Add(temp);
                MessageBox.Show("������ ������� ���������.");
            }
            else
                MessageBox.Show("�� ��� ���� ���������!");

            UpdateDataDGV();
        }
        private void UpdateDataDGV()    // ���������� ������ � DGV
        {
            ListTasksDGV.DataSource = _listTask;
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            ExcelOperation.SaveXLSX(_listTask);
            MessageBox.Show("���� ������� ��������!");
        }
        private void ExitProgramm()
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitProgramm();
        }
    }
}