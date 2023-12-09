namespace EditXLSX
{
    public partial class Form1 : Form
    {
        private string _currentPath = string.Empty;
        private uint rowDgv = 0;
        public Form1()
        {
            InitializeComponent();
            LoadDefaultSettingApp();
        }

        private void OpenBT_Click(object sender, EventArgs e)
        {
            ExcelDGV.Columns.Clear();
            ExcelDGV.Refresh();
            if (openFileOPF.ShowDialog() == DialogResult.OK)
            {
                string[,] dataXLSX = XLSXOperation.LoadDataXLSX(openFileOPF.FileName);
                _currentPath = openFileOPF.FileName;
                rowDgv = 0;
                for (int i = 0; i < dataXLSX.GetLength(1); i++)
                {
                    ExcelDGV.Columns.Add($"{rowDgv}", $"{rowDgv}");
                    rowDgv++;
                }
                for (int i = 0; i < dataXLSX.GetLength(0); i++)
                {
                    ExcelDGV.Rows.Add();
                }
                for (int i = 0; i < dataXLSX.GetLength(0); i++)
                {
                    for (int j = 0; j < dataXLSX.GetLength(1); j++)
                    {
                        ExcelDGV.Rows[i].Cells[j].Value = dataXLSX[i, j];
                    }
                }
            }

            AddColumnBT.Enabled = true;
            DeleteColumnBT.Enabled = true;
            DeleteRowBT.Enabled = true;
            SaveBT.Enabled = true;
        }
        private void SaveBT_Click(object sender, EventArgs e)
        {
            ExcelDGV.Refresh();
            string[,] data = new string[ExcelDGV.RowCount, ExcelDGV.ColumnCount];

            for (int i = 0; i < ExcelDGV.RowCount; i++)
            {
                for (int j = 0; j < ExcelDGV.ColumnCount; j++)
                {
                    if (ExcelDGV.Rows[i].Cells[j].Value == null)
                        data[i, j] = "";
                    else
                        data[i, j] = ExcelDGV.Rows[i].Cells[j].Value.ToString()!;
                }
            }
            XLSXOperation.SaveDataXLSX(_currentPath, data);
        }
        private void SaveAsBT_Click(object sender, EventArgs e)
        {
            ExcelDGV.Refresh();
            string[,] data = new string[ExcelDGV.RowCount, ExcelDGV.ColumnCount];

            for (int i = 0; i < ExcelDGV.RowCount; i++)
            {
                for (int j = 0; j < ExcelDGV.ColumnCount; j++)
                {
                    if (ExcelDGV.Rows[i].Cells[j].Value == null)
                        data[i, j] = "";
                    else
                        data[i, j] = ExcelDGV.Rows[i].Cells[j].Value.ToString()!;
                }
            }
            if (saveFileSFD.ShowDialog() == DialogResult.OK)
            {
                XLSXOperation.SaveDataXLSX(saveFileSFD.FileName, data);
            }
        }
        private void AddColumnBT_Click(object sender, EventArgs e)
        {
            ExcelDGV.Columns.Add($"{rowDgv}", $"{rowDgv}");
            rowDgv++;
        }

        private void NewTableBT_Click(object sender, EventArgs e)
        {
            _currentPath = string.Empty;
            SaveBT.Enabled = false;
            ExcelDGV.Columns.Clear();
            rowDgv = 0;
            ExcelDGV.Columns.Add($"{rowDgv}", $"{rowDgv}");
            rowDgv++;
            AddColumnBT.Enabled = true;
            DeleteColumnBT.Enabled = true;
            DeleteRowBT.Enabled = true;
        }
        private void LoadDefaultSettingApp()
        {
            AddColumnBT.Enabled = false;
            DeleteColumnBT.Enabled = false;
            DeleteRowBT.Enabled = false;
            SaveBT.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitProgramm();
        }
        private void ExitProgramm()
        {
            Application.Exit();
        }

        private void DeleteRowBT_Click(object sender, EventArgs e)
        {
            if (ExcelDGV.CurrentCell.RowIndex < ExcelDGV.Rows.Count - 1)
            {
                ExcelDGV.Rows.RemoveAt(ExcelDGV.CurrentCell.RowIndex);
            }
        }

        private void DeleteColumnBT_Click(object sender, EventArgs e)
        {
            if (ExcelDGV.Columns.Count > 1)
            {
                ExcelDGV.Columns.RemoveAt(ExcelDGV.CurrentCell.ColumnIndex);
            }
        }


    }
}