using Word = Microsoft.Office.Interop.Word;

namespace ReadWord
{
    public partial class Form1 : Form
    {
        private string? _currentPath;
        private Word.Application _wordApp = new();
        private Word.Document? _doc = new();
        public Form1()
        {
            InitializeComponent();
            SetupCheckLB("❎", Color.Green);
        }
        private void OpenFileBT_Click(object sender, EventArgs e)   // Кнопка открыть файл
        {
            if (openOFD.ShowDialog() == DialogResult.OK)
            {
                _currentPath = openOFD.FileName;
                filePathTB.Text = _currentPath;
                _doc = _wordApp.Documents?.Open(filePathTB.Text) ?? _wordApp.Documents?.Add();

                ParagraphTB.Enabled = true;
                UnBlockedAll();
                SetupCheckLB("✅", Color.Green);
            }
        }
        private void AddParagraphBT_Click(object sender, EventArgs e)   // Кнопка добавить параграф
        {
            Word.Paragraph paragraph = _doc!.Paragraphs.Add();
            paragraph.Range.Font.Name = SetFontCB.Text;

            paragraph.Range.Font.Name = SetFontCB.SelectedIndex switch
            {
                0 => "Arial",
                1 => "Calibri",
                2 => "TimesNewRoman",
                _ => "Arial"
            };

            paragraph.Range.Font.Color = Word.WdColor.wdColorBlack;

            paragraph.Range.Font.Color = SetColorFontCB.SelectedIndex switch
            {
                0 => Word.WdColor.wdColorBlack,
                1 => Word.WdColor.wdColorBlue,
                2 => Word.WdColor.wdColorGreen,
                3 => Word.WdColor.wdColorRed,
                _ => Word.WdColor.wdColorBlack
            };

            if (BoldCHB.Checked)
            {
                paragraph.Range.Font.Bold = 1;
            }
            else
            {
                paragraph.Range.Font.Bold = 0;
            }

            paragraph.Range.Font.Size = int.Parse(SetSizeFontTB.Text);
            paragraph.Range.Text = ParagraphTB.Text + "\n";
            MessageBox.Show("Параграф добавлен", "Уведомление");
            SetupCheckLB("✅", Color.Red);
        }
        public void BlockedAll()    // Блокировка контента до открытия файла
        {
            ParagraphTB.Enabled = false;
            BoldCHB.Enabled = false;
            SetColorFontCB.Enabled = false;
            SetColorFontCB.Enabled = false;
            SetSizeFontTB.Enabled = false;
            AddParagraphBT.Enabled = false;
            SaveFileBT.Enabled = false;
            SetFontCB.Enabled = false;
            AligmentParagraphCB.Enabled = false;
            SearchWordTB.Enabled = false;
            EditWordTB.Enabled = false;
            EditWordBT.Enabled = false;
        }
        public void UnBlockedAll()  // Разблокировка контента после открытия файла
        {
            ParagraphTB.Enabled = true;
            BoldCHB.Enabled = true;
            SetColorFontCB.Enabled = true;
            SetColorFontCB.Enabled = true;
            SetSizeFontTB.Enabled = true;
            AddParagraphBT.Enabled = true;
            SaveFileBT.Enabled = true;
            SetFontCB.Enabled = true;
            AligmentParagraphCB.Enabled = true;
            SearchWordTB.Enabled = true;
            EditWordTB.Enabled = true;
            EditWordBT.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // Крестик
        {
            _wordApp.Quit();
            Application.Exit();
        }
        private void SaveFileBT_Click(object sender, EventArgs e)   // Кнопка сохранить
        {
            _doc!.Save();
            MessageBox.Show("Файл успешно сохранен");
            SetupCheckLB("✅", Color.Green);
        }
        private void SetupCheckLB(string symbl, Color color)    // Установки статуса файла
        {
            editCheckLB.Text = symbl;
            editCheckLB.ForeColor = color;
        }
    }
}