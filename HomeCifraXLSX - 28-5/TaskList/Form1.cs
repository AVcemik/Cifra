namespace TaskList
{
    public partial class Form1 : Form
    {

        private List<Tasks> _listTask = new();
        private Tasks _currentSelectionTasks = null;
        public Form1()
        {
            InitializeComponent();
            DefaultSetupApp();
        }
        private void DefaultSetupApp()  // ��������� ��������� �� ���������
        {
            ListTasksDGV.ReadOnly = true;
            PriorityTaskCB.SelectedIndex = 0;
            _listTask = ExcelOperation.LoadDataXLSX();
            CheckStatsTask();
            UpdateDataDGV();
        }
        private void CheckStatsTask()   // �������� �� ���������� �� ������
        {
            for (int i = 0; i < _listTask.Count; i++)
            {
                if (_listTask[i].Date.Date < DateTime.Now.Date && _listTask[i].StatusTask == Status.NotCompleted)
                {
                    _listTask[i].StatusTask = Status.Overdue;
                }
            }
        }
        private void AddTaskBT_Click(object sender, EventArgs e)    // ������ ���������� ������
        {
            if (NameTaskTB.Text.Trim() != "")
            {
                string name = NameTaskTB.Text;
                DateTime date = DateTaskDTP.Value.Date;
                Priority priority = (Priority)PriorityTaskCB.SelectedIndex;
                Tasks temp = new(name, date, priority);
                _listTask.Add(temp);
                MessageBox.Show("������ ������� ���������.");
                UpdateDataDGV();
            }
            else
                MessageBox.Show("�� ��� ���� ���������!");

        }
        private void UpdateDataDGV()    // ���������� ������ � DGV
        {
            ListTasksDGV.Rows.Clear();
            for (int i = 0; i < _listTask.Count; i++)
            {
                string stats = string.Empty;
                switch (_listTask[i].StatusTask)
                {
                    case Status.NotCompleted:
                        stats = "�� ����������";
                        break;
                    case Status.Completed:
                        stats = "����������";
                        break;
                    case Status.Overdue:
                        stats = "�����������!!!";
                        break;
                }
                ListTasksDGV.Rows.Add(_listTask[i].Name, stats, _listTask[i].Date.ToShortDateString(), _listTask[i].PriorityTask);
            }
            ClearAllTB();
        }
        private void SaveBT_Click(object sender, EventArgs e)   // ���������� �����
        {
            ExcelOperation.SaveXLSX(_listTask);
            MessageBox.Show("���� ������� ��������!");
            UpdateDataDGV();
        }
        private void ExitProgramm() // ����� �� ���������
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // �������
        {
            ExitProgramm();
        }
        private void RemoveTaskBT_Click(object sender, EventArgs e) // �������� ������
        {
            if (ListTasksDGV.CurrentCell.RowIndex < ListTasksDGV.Rows.Count - 1)
            {
                _listTask.RemoveAt(ListTasksDGV.CurrentCell.RowIndex);
                UpdateDataDGV();
            }
        }
        private void ClearAllTB()   // ������� �����
        {
            NameTaskTB.Clear();
            PriorityTaskCB.SelectedIndex = 0;
        }
        private void EndTaskBT_Click(object sender, EventArgs e)    // ������ ���������� ������
        {
            if (ListTasksDGV.CurrentCell.Selected)
            {
                _listTask[ListTasksDGV.CurrentCell.RowIndex].StatusTask = Status.Completed;
            }
        }
    }
}