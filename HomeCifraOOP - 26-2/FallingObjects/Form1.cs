using System.Windows.Forms;

namespace GameFallingObj
{
    public partial class Form1 : Form
    {
        private static readonly object _lockJbject = new object();
        private static string _imagePath = Directory.GetCurrentDirectory() + "\\stone.png";
        Bitmap stoneImage = new Bitmap(_imagePath);
        Random rnd = new Random();
        PictureBox pictureBox = new();
        //Form1 form1 = new();

        public Form1()
        {
            InitializeComponent();
            int positionX = 50;
            int positionY = 50;
            Point point = new();
            point.X = positionX;
            point.Y = positionY;
            pictureBox.Image = stoneImage;
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = point;
            Controls.Add(pictureBox);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(down);
            th.Start();
        }
        public void down()
        {
            int positionY = -30;
            int positionX = rnd.Next(700);
            Point point = new(positionX, positionY);
            //pictureBox.Location = point;

            for (int i = 0; i < 100; i++)
            {
                if (positionY >= 500)
                {
                    i = 0;
                    positionX = rnd.Next(700);
                    point.X = positionX;
                    positionY = -30;
                }
                positionY += 10;
                point.Y = positionY;

                pictureBox.Invoke(() =>
                {
                    pictureBox.Location = point;
                });
                Thread.Sleep(20);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}