using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class Form4 : Form
    {
        private Bitmap Image;
        private char Tip;
        
        public Form4(char tip)
        {
            Tip = tip;
            InitializeComponent();
        }

        private void Form4_load(object sender, EventArgs e)
        {
            Size = new Size(350, 350);
            
            switch (Tip)
            {
                case 'a':
                    Image = new Bitmap(@"res\cipher\alph.jpg");
                    break;
                case 'z':
                    Image = new Bitmap(@"res\cipher\azb.png");
                    break;
                default:
                    Image = new Bitmap(@"res\cipher\img3.png");
                    break;
            }
            BackgroundImage = Image;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}