using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class Form4 : Form
    {
        private PictureBox picture;
        private Bitmap Image;
        private int scale = 600;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4( FormS f)
        {
            InitializeComponent();
        }

        private void Form4_load(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(scale, scale/2);
            Image = new Bitmap(FormS.directory + @"Resources\azb.png");
            pictureBox.Image = (Image) Image;
            picture = pictureBox;
            Controls.Add(pictureBox);
            
            SizeChanged += new EventHandler(SizeChangedForm4);
        }

        private void SizeChangedForm4(object sender, EventArgs e)
        {
            scale = Math.Min(Size.Height*2-50, Size.Width);
            if (scale < 10) scale = 10;
            picture.Size = new Size(scale, scale/2);
        }
    }
}