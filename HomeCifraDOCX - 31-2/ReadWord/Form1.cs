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
        }
        private void OpenFileBT_Click(object sender, EventArgs e)
        {
            if (openOFD.ShowDialog() == DialogResult.OK)
            {
                _currentPath = openOFD.FileName;
                filePathTB.Text = _currentPath;
                _doc = _wordApp.Documents?.Open(filePathTB.Text) ?? _wordApp.Documents?.Add();

                ParagraphTB.Enabled = true;
                UnBlockedAll();
                editCheckLB.ForeColor = Color.Green;
            }
        }
        private void AddParagraphBT_Click(object sender, EventArgs e)
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
        }
        public void BlockedAll()
        {
            ParagraphTB.Enabled = false;
            BoldCHB.Enabled = false;
            SetColorFontCB.Enabled = false;
            SetColorFontCB.Enabled = false;
            SetSizeFontTB.Enabled = false;
            AddParagraphBT.Enabled = false;
            SaveFileBT.Enabled = false;
            SetFontCB.Enabled = false;
        }
        public void UnBlockedAll()
        {
            ParagraphTB.Enabled = true;
            BoldCHB.Enabled = true;
            SetColorFontCB.Enabled = true;
            SetColorFontCB.Enabled = true;
            SetSizeFontTB.Enabled = true;
            AddParagraphBT.Enabled = true;
            SaveFileBT.Enabled = true;
            SetFontCB.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _wordApp.Quit();
            Application.Exit();
        }

        private void SaveFileBT_Click(object sender, EventArgs e)
        {
            _doc!.Save();
            MessageBox.Show("Файл успешно сохранен");
        }
    }
}