using System.Drawing;
using System.Windows.Forms;

namespace GameFallingObj
{
    public partial class Form1 : Form
    {
        private bool[] checkLocation = new bool[800];
        private static readonly object _lockObject = new object();
        private static string _imagePath = Directory.GetCurrentDirectory() + "\\stone.png";
        Bitmap stoneImage = new Bitmap(_imagePath);
        Random rnd = new Random();
        PictureBox pictureBox_0 = new();
        PictureBox pictureBox_1 = new();
        PictureBox pictureBox_2 = new();
        PictureBox pictureBox_3 = new();
        PictureBox pictureBox_4 = new();
        PictureBox pictureBox_5 = new();
        PictureBox player = new();

        public Form1()
        {
            InitializeComponent();
            InitializayionStone();
        }
        public void InitializayionStone()
        {
            pictureBox_1 = Box();
            pictureBox_2 = Box();
            pictureBox_3 = Box();
            pictureBox_4 = Box();
            pictureBox_5 = Box();


            Controls.Add(pictureBox_1);
            Controls.Add(pictureBox_2);
            Controls.Add(pictureBox_3);
            Controls.Add(pictureBox_4);
            Controls.Add(pictureBox_5);
        }
        public PictureBox Box()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = stoneImage;
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(-50, -50);
            return pictureBox;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            startBT.Hide();

            Thread stone_1 = new Thread(StoneDown_1);
            Thread stone_2 = new Thread(StoneDown_2);
            Thread stone_3 = new Thread(StoneDown_3);
            Thread stone_4 = new Thread(StoneDown_4);
            Thread stone_5 = new Thread(StoneDown_5);


            stone_1.Start();
            stone_2.Start();
            stone_3.Start();
            stone_4.Start();
            stone_5.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void StoneDown_1()
        {
            int positionY = -30;

            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMin = 100;
            int speedMax = 200;
            int speed = rnd.Next(speedMin, speedMax);

            for (int i = 0; i < 100; i++)
            {

                if (positionY >= 500)
                {
                    if (speedMin <= 0)
                    {
                        speedMin += 6;
                    }
                    else
                    {
                        speedMin -= 5;
                    }
                    if (speedMax <= 10)
                    {
                        speedMax += 6;
                    }
                    else
                    {
                        speedMax -= 5;
                    }
                    speed = rnd.Next(speedMin, speedMax);
                    i = 0;
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = -30;
                }
                positionY += 10;
                point.Y = positionY;

                pictureBox_1.Invoke(() =>
                {
                    pictureBox_1.Location = point;
                });
                Thread.Sleep(speed);
            }
        }
        public void StoneDown_2()
        {
            int positionY = -30;
            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMin = 100;
            int speedMax = 200;
            int speed = rnd.Next(speedMin, speedMax);

            for (int i = 0; i < 100; i++)
            {

                if (positionY >= 500)
                {
                    if (speedMin <= 0)
                    {
                        speedMin += 6;
                    }
                    else
                    {
                        speedMin -= 5;
                    }
                    if (speedMax <= 10)
                    {
                        speedMax += 6;
                    }
                    else
                    {
                        speedMax -= 5;
                    }
                    speed = rnd.Next(speedMin, speedMax);
                    i = 0;
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = -30;
                }
                positionY += 10;
                point.Y = positionY;

                pictureBox_2.Invoke(() =>
                {
                    pictureBox_2.Location = point;
                });
                Thread.Sleep(speed);
            }
        }
        public void StoneDown_3()
        {
            int positionY = -30;
            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMin = 100;
            int speedMax = 200;
            int speed = rnd.Next(speedMin, speedMax);

            for (int i = 0; i < 100; i++)
            {

                if (positionY >= 500)
                {
                    if (speedMin <= 0)
                    {
                        speedMin += 6;
                    }
                    else
                    {
                        speedMin -= 5;
                    }
                    if (speedMax <= 10)
                    {
                        speedMax += 6;
                    }
                    else
                    {
                        speedMax -= 5;
                    }
                    speed = rnd.Next(speedMin, speedMax);
                    i = 0;
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = -30;
                }
                positionY += 10;
                point.Y = positionY;

                pictureBox_3.Invoke(() =>
                {
                    pictureBox_3.Location = point;
                });
                Thread.Sleep(speed);
            }
        }
        public void StoneDown_4()
        {
            int positionY = -30;
            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMin = 100;
            int speedMax = 200;
            int speed = rnd.Next(speedMin, speedMax);

            for (int i = 0; i < 100; i++)
            {

                if (positionY >= 500)
                {
                    if (speedMin <= 0)
                    {
                        speedMin += 6;
                    }
                    else
                    {
                        speedMin -= 5;
                    }
                    if (speedMax <= 10)
                    {
                        speedMax += 6;
                    }
                    else
                    {
                        speedMax -= 5;
                    }
                    speed = rnd.Next(speedMin, speedMax);
                    i = 0;
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = -30;
                }
                positionY += 10;
                point.Y = positionY;

                pictureBox_4.Invoke(() =>
                {
                    pictureBox_4.Location = point;
                });
                Thread.Sleep(speed);
            }
        }
        public void StoneDown_5()
        {
            int positionY = -30;
            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMin = 100;
            int speedMax = 200;
            int speed = rnd.Next(speedMin, speedMax);

            for (int i = 0; i < 100; i++)
            {

                if (positionY >= 500)
                {
                    if (speedMin <= 0)
                    {
                        speedMin += 6;
                    }
                    else
                    {
                        speedMin -= 5;
                    }
                    if (speedMax <= 10)
                    {
                        speedMax += 6;
                    }
                    else
                    {
                        speedMax -= 5;
                    }
                    speed = rnd.Next(speedMin, speedMax);
                    i = 0;
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = -30;
                }
                positionY += 10;
                point.Y = positionY;

                pictureBox_5.Invoke(() =>
                {
                    pictureBox_5.Location = point;
                });
                Thread.Sleep(speed);
            }
        }
        public int SetPositionX(int currentPosition)
        {
            if (currentPosition >= 0)
            {
                int count = currentPosition;
                lock (_lockObject)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        checkLocation[count] = false;
                        count++;
                    }
                }
                
            }
            while (true)
            {
                int result = rnd.Next(749);
                if (checkLocation[result] == false)
                {
                    int count = result;
                    lock (_lockObject)
                    {
                        for (int i = 0; i < 50; i++)
                        {
                            checkLocation[count] = true;
                            count++;
                        }
                    }
                    return result;
                }
            }
        }
    }
}