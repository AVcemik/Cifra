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
        private void DefaultSetupApp()  // Настройки программы по умолчанию
        {
            ListTasksDGV.ReadOnly = true;
            PriorityTaskCB.SelectedIndex = 0;
            _listTask = ExcelOperation.LoadDataXLSX();
            CheckStatsTask();
            UpdateDataDGV();
        }
        private void CheckStatsTask()   // Проверка не просрочена ли задача
        {
            for (int i = 0; i < _listTask.Count; i++)
            {
                if (_listTask[i].Date.Date < DateTime.Now.Date && _listTask[i].StatusTask == Status.NotCompleted)
                {
                    _listTask[i].StatusTask = Status.Overdue;
                }
            }
        }
        private void AddTaskBT_Click(object sender, EventArgs e)    // Кнопка добавления задачи
        {
            if (NameTaskTB.Text.Trim() != "")
            {
                string name = NameTaskTB.Text;
                DateTime date = DateTaskDTP.Value.Date;
                Priority priority = (Priority)PriorityTaskCB.SelectedIndex;
                Tasks temp = new(name, date, priority);
                _listTask.Add(temp);
                MessageBox.Show("Задача успешно добавлена.");
                UpdateDataDGV();
            }
            else
                MessageBox.Show("Не все поля заполнены!");

        }
        private void UpdateDataDGV()    // Обновление данных в DGV
        {
            ListTasksDGV.Rows.Clear();
            for (int i = 0; i < _listTask.Count; i++)
            {
                string stats = string.Empty;
                switch (_listTask[i].StatusTask)
                {
                    case Status.NotCompleted:
                        stats = "Не завершенно";
                        break;
                    case Status.Completed:
                        stats = "Завершенно";
                        break;
                    case Status.Overdue:
                        stats = "Просроченно!!!";
                        break;
                }
                ListTasksDGV.Rows.Add(_listTask[i].Name, stats, _listTask[i].Date.ToShortDateString(), _listTask[i].PriorityTask);
            }
            ClearAllTB();
        }
        private void SaveBT_Click(object sender, EventArgs e)   // Сохранение файла
        {
            ExcelOperation.SaveXLSX(_listTask);
            MessageBox.Show("Файл успешно сохранен!");
            UpdateDataDGV();
        }
        private void ExitProgramm() // Выход из программы
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // Крестик
        {
            ExitProgramm();
        }
        private void RemoveTaskBT_Click(object sender, EventArgs e) // Удаление задачи
        {
            if (ListTasksDGV.CurrentCell.RowIndex < ListTasksDGV.Rows.Count - 1)
            {
                _listTask.RemoveAt(ListTasksDGV.CurrentCell.RowIndex);
                UpdateDataDGV();
            }
        }
        private void ClearAllTB()   // Очистка полей
        {
            NameTaskTB.Clear();
            PriorityTaskCB.SelectedIndex = 0;
        }
        private void EndTaskBT_Click(object sender, EventArgs e)    // Кнопка завершения задачи
        {
            if (ListTasksDGV.CurrentCell.Selected)
            {
                _listTask[ListTasksDGV.CurrentCell.RowIndex].StatusTask = Status.Completed;
            }
        }
    }
}