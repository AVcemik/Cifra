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
            DefaultSetingApp();
        }
        private void OpenFileBT_Click(object sender, EventArgs e)   // Кнопка открыть файл
        {
            OpenFileBT.Enabled = false;
            if (openOFD.ShowDialog() == DialogResult.OK)
            {
                _currentPath = openOFD.FileName;
                filePathTB.Text = _currentPath;
                _doc = _wordApp.Documents?.Open(filePathTB.Text) ?? _wordApp.Documents?.Add();

                ParagraphTB.Enabled = true;
                UnBlockedAll();
                SetupCheckLB("✅", Color.Green);
            }
            OpenFileBT.Enabled = true;
        }
        private void AddParagraphBT_Click(object sender, EventArgs e)   // Кнопка добавить параграф
        {
            BlockedAll();
            Word.Paragraph paragraph = _doc!.Paragraphs.Add();

            paragraph.Range.ParagraphFormat.Alignment = SetAligmentParagraphCB.SelectedIndex switch
            {
                0 => Word.WdParagraphAlignment.wdAlignParagraphLeft,
                1 => Word.WdParagraphAlignment.wdAlignParagraphRight,
                2 => Word.WdParagraphAlignment.wdAlignParagraphCenter,
                3 => Word.WdParagraphAlignment.wdAlignParagraphJustify,
                _ => Word.WdParagraphAlignment.wdAlignParagraphLeft
            };

            paragraph.Range.Font.Name = SetFontCB.SelectedIndex switch
            {
                0 => "Arial",
                1 => "Calibri",
                2 => "Times New Roman",
                _ => "Arial"
            };

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
            SetSizeFontTB.Text = "24";

            UnBlockedAll();
        }
        private void SaveFileBT_Click(object sender, EventArgs e)   // Кнопка сохранить
        {
            BlockedAll();
            _doc!.Save();
            MessageBox.Show("Файл успешно сохранен");
            SetupCheckLB("✅", Color.Green);
            UnBlockedAll();
        }
        private void EditWordBT_Click(object sender, EventArgs e) // замена текста
        {
            BlockedAll();
            if (SearchWordTB.Text != null && SearchWordTB.Text.Trim() != "")
            {
                Word.Range range = _doc!.Content;
                if (EditWordTB.Text == null)
                    EditWordTB.Text = "";

                range.Find.Execute(SearchWordTB.Text, ReplaceWith: EditWordTB.Text);
            }
            SearchWordTB.Clear();
            EditWordTB.Clear();
            MessageBox.Show("Тект успешно заменен", "Уведомление");
            UnBlockedAll();
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
            SetAligmentParagraphCB.Enabled = false;
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
            SetAligmentParagraphCB.Enabled = true;
            SearchWordTB.Enabled = true;
            EditWordTB.Enabled = true;
            EditWordBT.Enabled = true;
        }
        private void SetupCheckLB(string symbl, Color color)    // Установки статуса файла
        {
            editCheckLB.Text = symbl;
            editCheckLB.ForeColor = color;
        }
        private void DefaultSetingApp() // Настройки программы по уолчанию при запуске
        {
            BlockedAll();
            SetupCheckLB("❎", Color.Red);
            SetSizeFontTB.Text = "24";
            SetFontCB.SelectedIndex = 0;
            SetColorFontCB.SelectedIndex = 0;
            SetAligmentParagraphCB.SelectedIndex = 0;
        }
        private void SetSizeFontTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) || number == ((char)Keys.Back))
                e.Handled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // Крестик
        {
            _wordApp.Quit();
            Application.Exit();
        }
    }
}