using System.Windows.Forms;

namespace FallingObjects
{
    public partial class Form1 : Form
    {
        private static readonly object _lockJbject = new object();
        //private string _imagePath = Directory.GetCurrentDirectory() + "\\stone.png";
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(label2);
        }

        private void DownStone()
        {
            
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    int y = i;
                    y += 10;
                    lock (_lockJbject)
                    {
                        label2.Location = new Point(50, y);
                    }
                    Thread.Sleep(200);
                }
            });
            th.Start();
        }
    }
}