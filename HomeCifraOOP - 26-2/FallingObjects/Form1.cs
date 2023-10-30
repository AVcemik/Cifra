using System.Windows.Forms;

namespace FallingObjects
{
    public partial class Form1 : Form
    {
        private List<Stone> stone = new List<Stone>();
        private Random random = new Random();

        PictureBox pictureBox1 = new();
        PictureBox pictureBox2 = new();
        PictureBox pictureBox3 = new();
        private string _imagePath = Directory.GetCurrentDirectory() + "\\stone.png";
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1000, 600);
            pictureBox1 = SetSettingsStone();
            pictureBox2 = SetSettingsStone();
            pictureBox3 = SetSettingsStone();
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);



            Thread thread_1 = new Thread(() =>
            {
                pictureBox1 = SetSettingsStone();
                DownStone();
            });

            thread_1.Start();

        }
        private void DownStone()
        {
            for (int i = 0; i < 600; i++)
            {
                pictureBox1.Top += i;
            }
        }
        private PictureBox SetSettingsStone()
        {
            Bitmap image = new Bitmap(_imagePath);
            PictureBox pictureBox = new();
            int x = random.Next(970);
            pictureBox.Location = new Point(x, 0);
            pictureBox.Size = new Size(30, 30);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
            return pictureBox;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}