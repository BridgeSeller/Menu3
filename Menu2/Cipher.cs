using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class FormS : Form
    {
        private Bitmap Image;
        private string ans = "";
        private string text = "Разгадайте, что на картинке";
        private int x = 480;
        private int y = 480;

        private double scale = 1.0;
        private int Level;
        private char tip;

        private Label label;
        private PictureBox pictureBox;
        private TextBox textBox;
        private Button GenreSelector;
        private Button LevelSelector;
        private Button button; 

        public FormS(int lvl)
        {
            Level = lvl;
            InitializeComponent();
        }

        private void FormS_Load(object sender, EventArgs e)
        {
            Size = new Size(x, y);
            BackgroundImage = System.Drawing.Image.FromFile(@"res\Back3.png");
            BackgroundImageLayout = ImageLayout.Tile;
            
            label = new Label();
            label.Location = new Point((x - 400) / 2, 20);
            label.Size = new Size(400, 50);
            label.Text = text;
            label.TextAlign = ContentAlignment.TopCenter;
            label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Controls.Add(label);

            pictureBox = new PictureBox();
            pictureBox.Location = new Point((x - 400) / 2, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(400, 150);

            switch (Level)
            {
                case 1:
                    Image = new Bitmap(@"res\cipher\cipher1.jpg");
                    ans = "каникулы";
                    tip = 'z';
                    break;
                case 2:
                    Image = new Bitmap(@"res\cipher\cipher2.jpg");
                    ans = "сфера";
                    tip = 'z';
                    break;
                case 3:
                    Image = new Bitmap(@"res\cipher\cipher3.jpg");
                    ans = "небо";
                    tip = 'a';
                    break;
                case 4:
                    Image = new Bitmap(@"res\cipher\cipher4.jpg");
                    ans = "программист";
                    tip = 'a';
                    break;
                case 5:
                    Image = new Bitmap(@"res\cipher\cipher5.jpg");
                    ans = "город";
                    tip = 'a';
                    break;
                case 6:
                    Image = new Bitmap(@"res\cipher\cipher6.jpg");
                    ans = "весна";
                    tip = 'a';
                    break;
                case 7:
                    Image = new Bitmap(@"res\cipher\cipher7.jpg");
                    ans = "реакция";
                    tip = 'n';
                    break;
                case 8:
                    Image = new Bitmap(@"res\cipher\cipher8.jpg");
                    ans = "сирень";
                    tip = 'n';
                    break;
                case 9:
                    Image = new Bitmap(@"res\cipher\cipher9.jpg");
                    ans = "чувство";
                    tip = 'a';
                    break;
                case 10:
                    Image = new Bitmap(@"res\cipher\cipher10.jpg");
                    ans = "библиотека";
                    tip = 'a';
                    break;
                default:
                    Image = new Bitmap(@"res\cipher\img3.png");
                    ans = "я";
                    tip = 'n';
                    break;
            }

            pictureBox.Image = (Image) Image;
            Controls.Add(pictureBox);
            
            textBox = new TextBox();
            textBox.Location = new Point((x - 400) / 2, y - 120);
            textBox.Size = new Size(400, 50);
            textBox.KeyPress += new KeyPressEventHandler(TextCheck);
            Controls.Add(textBox);

            button = new Button();
            button.Location = new Point(0, 0);
            button.Size = new Size(30, 30);
            button.Text = "?";
            button.MouseClick += new MouseEventHandler(button_Click1);
            Controls.Add(button);
            
            GenreSelector = new Button();
            GenreSelector.Location = new Point((int) ((x-40-150)*scale),   (int) ((y - 80)*scale));
            GenreSelector.Size = new Size(150, 30);
            GenreSelector.Text = "Выбор жанра";
            GenreSelector.MouseClick += new MouseEventHandler(button_Click2);
            Controls.Add(GenreSelector);
            
            LevelSelector = new Button();
            LevelSelector.Location = new Point((int) (scale*(x-400)/2),   (int) ((y - 80)*scale));
            LevelSelector.Size = new Size(150, 30);
            LevelSelector.Text = "Выбор уровня";
            LevelSelector.MouseClick += new MouseEventHandler(button_Click3);
            Controls.Add(LevelSelector);

            this.SizeChanged += new EventHandler(size_Changed);
        }

        private void size_Changed(object sender, EventArgs e)
        {
            scale = Math.Min((double)Width/x, (double)Height/y);
            
            label.Location = new Point((int) (scale*(x - 400) / 2), (int) (20*scale));
            label.Size = new Size((int) (400*scale), (int) (50*scale));
            label.Font = new Font("Microsoft Sans Serif", (int) (10*scale), FontStyle.Bold);
            
            pictureBox.Location = new Point((int) (scale*(x-400)/2), (int) (50*scale));
            pictureBox.Size = new Size((int) (400*scale), (int) (190*scale));
            
            textBox.Location = new Point((int) (scale*(x-400)/2), (int) (scale*(y-120)));
            textBox.Size = new Size((int) (400*scale), (int) (50*scale));
            
            GenreSelector.Location = new Point((int) ((x-40-150)*scale),   (int) ((y - 80)*scale));
            GenreSelector.Size = new Size((int) (150*scale), (int) (30*scale));
            
            LevelSelector.Location = new Point((int) (scale*(x-400)/2),   (int) ((y - 80)*scale));
            LevelSelector.Size = new Size((int) (150*scale), (int) (scale*30));
               
            button.Size = new Size((int) (30*scale), (int) (30*scale));
        }


        private void TextCheck(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string vvod = ((TextBox) sender).Text.ToLower();
                if (ans.Equals(vvod))
                {
                    MessageBox.Show("Ура! Все верно");
                }
                else
                {
                    MessageBox.Show("Ты ошибся");
                }
            }
        }

        private void button_Click1(object sender, MouseEventArgs e)
        {
            Form4 TipForm = new Form4(tip);
            TipForm.Size = new Size(600, 300);
            TipForm.Show();
        }
        
        private void button_Click2(object sender, MouseEventArgs e)
        {
            this.Close();
            GenreChoice genre = new GenreChoice();
            genre.Show();
        }
        
        private void button_Click3(object sender, MouseEventArgs e)
        {
            this.Close();
            LevelCR genre = new LevelCR('C',10);
            genre.Show();
        }
    }
}