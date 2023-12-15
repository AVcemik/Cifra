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

                paragraph.Range.Text = " ";
                paragraph.Alignment = SetAlignmentFont();
                paragraph.Range.Font.Bold = SetBoldFont();
                paragraph.Range.Font.Name = SetNameFont();
                paragraph.Range.Font.Color = SetColorFont();
                paragraph.Range.Font.Size = SetSizeFont();
                paragraph.Range.Text = ParagraphTB.Text + "\n";

                MessageBox.Show("Параграф добавлен", "Уведомление");

                SetupCheckLB("✅", Color.Red);
                SetSizeFontTB.Text = "13";

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
            SetSizeFontTB.Text = "13";
            SetFontCB.SelectedIndex = 0;
            SetColorFontCB.SelectedIndex = 0;
            SetAligmentParagraphCB.SelectedIndex = 0;
        }
        private byte SetBoldFont()  // Проверяет нажатие CheckBox
        {
            if (BoldCHB.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private string SetNameFont()    // Возвращаем strting из списка шрифтов по индексу
        {
           switch(SetFontCB.SelectedIndex)
            {
                case 0: return "Arial";
                case 1: return "Calibri";
                case 2: return "Times New Roman";
                default: return "Arial";
            };
        }
        private Word.WdColor SetColorFont() // Возвращаем WdColor из списка цветов по индексу
        {
            switch (SetColorFontCB.SelectedIndex)
            {
                case 0: return Word.WdColor.wdColorBlack;
                case 1: return Word.WdColor.wdColorBlue;
                case 2: return Word.WdColor.wdColorGreen;
                case 3: return Word.WdColor.wdColorRed;
                default: return Word.WdColor.wdColorBlack;
            };
        }
        private int SetSizeFont()   // Возвращаем размер шрифта
        {
            int result = 13;
            int.TryParse(SetSizeFontTB.Text, out result);

            if (result <= 0)
                return 13;
            else if (result == null)
                return 13;
            else
                return result;
        }
        private Word.WdParagraphAlignment SetAlignmentFont() // Возвращаем WdParagraphAlignment из списка выравнивания по индексу
        {
            switch(SetAligmentParagraphCB.SelectedIndex)
            {
                case 0: return Word.WdParagraphAlignment.wdAlignParagraphLeft;
                case 1: return Word.WdParagraphAlignment.wdAlignParagraphRight;
                case 2: return Word.WdParagraphAlignment.wdAlignParagraphCenter;
                case 3: return Word.WdParagraphAlignment.wdAlignParagraphJustify;
                default: return Word.WdParagraphAlignment.wdAlignParagraphLeft;
            };
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   // Крестик
        {
            _wordApp.Quit();
            Application.Exit();
        }
        private void SetSizeFontTB_KeyPress(object sender, KeyPressEventArgs e) // Событие ограничение ввода значение в размер шрифта
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != ((char)Keys.Back))
                e.Handled = true;
        }
    }
}