using System.Drawing;
using System.Windows.Forms;

namespace GameFallingObj
{
    public partial class Form1 : Form
    {
        private readonly object _lock = new ();
        private readonly Semaphore _semaphore = new (1,4);
        public bool[] checkLocation = new bool[800];
        private readonly static string _imagePath = Directory.GetCurrentDirectory() + "\\stone.png";
        private readonly static string _imagePathPlayer = Directory.GetCurrentDirectory() + "\\player.png";
        private readonly Bitmap _stoneImage = new (_imagePath);
        public Random rnd = new ();
        public PictureBox pictureBox_1 = new();
        public PictureBox pictureBox_2 = new();
        public PictureBox pictureBox_3 = new();
        public PictureBox pictureBox_4 = new();
        public PictureBox pictureBox_5 = new();
        public PictureBox player = new();
        private readonly int _startPositionY = -30;
        private readonly int _startSpeedMax = 1;
        private readonly int _startSpeedMin = 10;
        private readonly int _downSpeed = 1;
        private readonly int _stepDownSpeed = 4;
        private bool moveLeft = false;
        private bool moveRight = false;

        public Form1()
        {
            InitializeComponent();
            InitializayionStone();
            InitializayionPlayer();

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            this.KeyPreview = true;

        }
        public void InitializayionPlayer()
        {
            Bitmap playerImage = new(_imagePathPlayer);
            player = new()
            {
                Image = playerImage,
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(375, 410)
            };


            Controls.Add(player);
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
            PictureBox pictureBox = new()
            {
                Image = _stoneImage,
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(-50, -50)
            };
            return pictureBox;
        }
        public void PlayerMove()
        {
            int step = 10;
            while (true)
            {
                if (moveRight)
                {
                    if (player.Left > 0)
                        player.Invoke(() =>
                        {
                            player.Left -= step; 
                        });
                }

                if (moveLeft)
                {
                    if (player.Right < 800)
                        player.Invoke(() =>
                        {
                            player.Left += step; 
                        });
                }

                Thread.Sleep(10);
            }
        }
        private void StartBTN_Click(object sender, EventArgs e)
        {
            startBT.Hide();

            Thread player = new(PlayerMove);
            Thread stone_1 = new (StoneDown_1);
            Thread stone_2 = new (StoneDown_2);
            Thread stone_3 = new (StoneDown_3);
            Thread stone_4 = new (StoneDown_4);
            Thread stone_5 = new (StoneDown_5);

            player.Start();
            stone_1.Start();
            stone_2.Start();
            stone_3.Start();
            stone_4.Start();
            stone_5.Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveRight = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveRight = false;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public int SetPositionX(int currentPosition)
        {
            _semaphore.WaitOne();
            if (currentPosition >= 0)
            {
                int count = currentPosition;                
                for (int i = 0; i <= 50; i++)
                {
                    checkLocation[count] = false;
                    count++;
                }
            }
            while (true)
            {
                int result = rnd.Next(749);
                if (checkLocation[result] == false)
                {
                    int count = result;
                    {
                        for (int i = 0; i <= 50; i++)
                        {
                            checkLocation[count] = true;
                            count++;
                        }
                    }
                    _semaphore.Release();
                    lock (_lock)
                    {
                        return result;
                    }
                }
            }
        }
        public void StoneDown_1()
        {
            int count_1 = 0;
            int stepUp = _stepDownSpeed;
            int positionY = _startPositionY;

            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMax = _startSpeedMax;
            int speedMin = _startSpeedMin;
            int speed = rnd.Next(speedMax, speedMin);

            while (true)
            {
                if (positionY >= 500)
                {
                    if (count_1 > 5) { stepUp += 1; count_1 = 0; }
                    if (speedMax > 1) speedMax -= _downSpeed;
                    if (speedMin > 2) speedMin -= _downSpeed;

                    speed = rnd.Next(speedMax, speedMin);
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = _startPositionY;
                    count_1++;
                }
                positionY += stepUp;
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
            int count = 0;
            int stepUp = _stepDownSpeed;
            int positionY = _startPositionY;

            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMax = _startSpeedMax;
            int speedMin = _startSpeedMin;
            int speed = rnd.Next(speedMax, speedMin);

            while (true)
            {
                if (positionY >= 500)
                {
                    if (count >= 5) { stepUp++; count = 0; }
                    if (speedMax > 1) speedMax -= _downSpeed;
                    if (speedMin > 2) speedMin -= _downSpeed;

                    speed = rnd.Next(speedMax, speedMin);
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = _startPositionY;
                    count++;
                }
                positionY += stepUp;
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
            int count = 0;
            int stepUp = _stepDownSpeed;
            int positionY = _startPositionY;

            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMax = _startSpeedMax;
            int speedMin = _startSpeedMin;
            int speed = rnd.Next(speedMax, speedMin);

            while (true)
            {
                if (positionY >= 500)
                {
                    if (count >= 5) { stepUp++; count = 0; }
                    if (speedMax > 1) speedMax -= _downSpeed;
                    if (speedMin > 2) speedMin -= _downSpeed;

                    speed = rnd.Next(speedMax, speedMin);
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = _startPositionY;
                    count++;
                }
                positionY += stepUp;
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
            int count = 0;
            int stepUp = _stepDownSpeed;
            int positionY = _startPositionY;

            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMax = _startSpeedMax;
            int speedMin = _startSpeedMin;
            int speed = rnd.Next(speedMax, speedMin);

            while (true)
            {
                if (positionY >= 500)
                {
                    if (count >= 5) { stepUp++; count = 0; }
                    if (speedMax > 1) speedMax -= _downSpeed;
                    if (speedMin > 2) speedMin -= _downSpeed;

                    speed = rnd.Next(speedMax, speedMin);
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = _startPositionY;
                    count++;
                }
                positionY += stepUp;
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
            int count = 0;
            int stepUp = _stepDownSpeed;
            int positionY = _startPositionY;

            int positionX = SetPositionX(-1);
            Point point = new(positionX, positionY);
            int speedMax = _startSpeedMax;
            int speedMin = _startSpeedMin;
            int speed = rnd.Next(speedMax, speedMin);

            while (true)
            {
                if (positionY >= 500)
                {
                    if (count >= 5) { stepUp++; count = 0; }
                    if (speedMax > 1) speedMax -= _downSpeed;
                    if (speedMin > 2) speedMin -= _downSpeed;

                    speed = rnd.Next(speedMax, speedMin);
                    positionX = SetPositionX(positionX);
                    point.X = positionX;
                    positionY = _startPositionY;
                    count++;
                }
                positionY += stepUp;
                point.Y = positionY;

                pictureBox_5.Invoke(() =>
                {
                    pictureBox_5.Location = point;
                });
                Thread.Sleep(speed);
            }
        }
    }
}