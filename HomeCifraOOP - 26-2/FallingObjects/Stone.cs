using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjects
{
    public class Stone
    {
        public PictureBox PictureBox {  get; set; } = new PictureBox();
        private string _imagePath = Directory.GetCurrentDirectory() + "\\stone.png";
        public Point Position { get; set; } = new Point(0, 0);
        public int Speed { get; set; }

        public void Getposition(int x, int y)
        {
            Position = new Point(x, y);
        }
        public void DisplayStone()
        {

            Bitmap image = new Bitmap(_imagePath);
            PictureBox.Location = Position;
            PictureBox.Size = new Size(250, 250);
            PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBox.Image = image;   
        }
    }
}
