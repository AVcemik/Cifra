using System.Runtime.CompilerServices;
using TestProject;

namespace FAQ
{
    public partial class Main : Form
    {
        private int result = 0;
        private int badResult = 0;
        private List<bool> checkApply;
        private List<Question> questions;
        private int countQuestion;
        private int currentQuestion;
        private FileInfo fi;
        public Main()
        {
            InitializeComponent();
            checkApply = new List<bool>();
            questions = new List<Question>();
            btPref.Enabled = false;
            btNext.Enabled = false;
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.ShowDialog();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void çàãðóçèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.dat|*.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        Question question = new Question();
                        checkApply.Add(false);
                        question.question = reader.ReadString();
                        question.countQuestion = reader.ReadInt32();
                        List<Answer> answerList = new List<Answer>();
                        for (int i = 0; i < question.countQuestion; i++)
                        {
                            Answer answer = new Answer();
                            answer.answer = reader.ReadString();
                            answer.yesno = reader.ReadBoolean();
                            answerList.Add(answer);
                        }
                        question.answers = answerList.ToArray();
                        questions.Add(question);
                    }
                    countQuestion = questions.Count;
                    currentQuestion = 0;
                    LoadButton();
                    if (questions.Count > 1) btNext.Enabled = true;
                    if (checkApply[currentQuestion] == true) btApply.Enabled = false;
                    else btApply.Enabled = true;
                }
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            btPref.Enabled = true;
            plQuestion.Controls.Clear();
            LoadButton();
            if (currentQuestion+1 == questions.Count) btNext.Enabled = false;
            if (checkApply[currentQuestion] == true) btApply.Enabled = false;
            else btApply.Enabled = true;
        }

        private void btPref_Click(object sender, EventArgs e)
        {
            currentQuestion--;
            btNext.Enabled = true;
            plQuestion.Controls.Clear();
            LoadButton();
            if (currentQuestion == 0) btPref.Enabled = false;
            if (checkApply[currentQuestion] == true) btApply.Enabled = false;
            else btApply.Enabled = true;
        }
        public void LoadButton()
        {
            GroupBox gb = new GroupBox();
            gb.Text = "Âîïðîñ ¹"+(currentQuestion+1) + " èç " + questions.Count;
            gb.Width = plQuestion.Width;
            int y = 0;
            gb.Top = y;
            y+= 31;
            Label lbQuestion = new Label();
            lbQuestion.Text = questions[currentQuestion].question;
            lbQuestion.Width = plQuestion.Width-50;
            lbQuestion.Top = y;
            lbQuestion.Left = 20;
            gb.Controls.Add(lbQuestion);
            for (int i = 0; i < questions[currentQuestion].answers.Length; i++)
            {
                y+= 25;
                CheckBox cb = new CheckBox();
                int index = gb.Controls.IndexOf(cb);
                cb.Text = questions[currentQuestion].answers[i].answer;
                cb.Size = new System.Drawing.Size(700, 31);
                cb.Top = y;
                cb.Left = 20;
                gb.Controls.Add(cb);
            }
            gb.Height = y+50;
            plQuestion.Controls.Add(gb);
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            checkApply[currentQuestion] = true;
            for(int i = 0;; i++)
            {
                
            }


        }
    }
}