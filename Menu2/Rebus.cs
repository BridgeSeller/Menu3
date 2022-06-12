using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class FormR : Form
    {
        private Bitmap Image;
        
        private string ans;

        private string text = "Разгадайте, что на картинке";
        private int x = 480;
        private int y = 480;
        private double scale = 1.0;
        private int Level;

        private Label label;
        private PictureBox pictureBox;
        private TextBox textBox;
        private Button GenreSelector;
        private Button LevelSelector;
        
        public FormR(int lvl)
        {
            Level = lvl;
            InitializeComponent();
        }
        
        private void FormR_Load(object sender, EventArgs e)
        {
            Size = new Size(x, y);
            BackgroundImage = System.Drawing.Image.FromFile(@"res\Back5.png");
            BackgroundImageLayout = ImageLayout.Tile;

            label = new Label();
            label.Location = new Point((x - 400) / 2, 20);
            label.Size = new Size(400, 50);
            label.Text = text;
            label.TextAlign = ContentAlignment.TopCenter;
            label.Font = new Font("Microsoft Sans Serif", (int) (10*scale), FontStyle.Bold);
            Controls.Add(label);

            pictureBox = new PictureBox();
            pictureBox.Location = new Point((x-400)/2, 50);
            pictureBox.Size = new Size(400, 190);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (Level)
            {
                case 1:
                    Image = new Bitmap(@"res\rebus\скрипка.png");
                    ans = "скрипка";
                    break;
                case 2:
                    Image = new Bitmap(@"res\rebus\небеса.png");
                    ans = "небеса";
                    break;
                case 3:
                    Image = new Bitmap(@"res\rebus\южанин.png");
                    ans = "южанин";
                    break;
                case 4:
                    Image = new Bitmap(@"res\rebus\микрофон.png");
                    ans = "микрофон";
                    break;
                case 5:
                    Image = new Bitmap(@"res\rebus\кислота.png");
                    ans = "кислота";
                    break;
                case 6:
                    Image = new Bitmap(@"res\rebus\чудище.png");
                    ans = "чудище";
                    break;
                case 7:
                    Image = new Bitmap(@"res\rebus\скука.png");
                    ans = "скука";
                    break;
                case 8:
                    Image = new Bitmap(@"res\rebus\графика.png");
                    ans = "графика";
                    break;
                case 9:
                    Image = new Bitmap(@"res\rebus\динамика.png");
                    ans = "динамика";
                    break;
                case 10:
                    Image = new Bitmap(@"res\rebus\бурундук.png");
                    ans = "бурундук";
                    break;
                case 11:
                    Image = new Bitmap(@"res\rebus\секрет.png");
                    ans = "секрет";
                    break;
                case 12:
                    Image = new Bitmap(@"res\rebus\легенда.png");
                    ans = "легенда";
                    break;
                case 13:
                    Image = new Bitmap(@"res\rebus\канарейка.png");
                    ans = "канарейка";
                    break;
                case 14:
                    Image = new Bitmap(@"res\rebus\полночь.png");
                    ans = "полночь";
                    break;
                case 15:
                    Image = new Bitmap(@"res\rebus\пример.png");
                    ans = "пример";
                    break;
                case 16:
                    Image = new Bitmap(@"res\rebus\муравей.png");
                    ans = "муравей";
                    break;
                case 17:
                    Image = new Bitmap(@"res\rebus\апокалипсис.png");
                    ans = "апокалипсис";
                    break;
                case 18:
                    Image = new Bitmap(@"res\rebus\пельмешки.png");
                    ans = "пельмешки";
                    break;
                case 19:
                    Image = new Bitmap(@"res\rebus\шоколад.png");
                    ans = "шоколад";
                    break;
                case 20:
                    Image = new Bitmap(@"res\rebus\понедельник.png");
                    ans = "понедельник";
                    break;
                default:
                    Image = new Bitmap(@"res\rebus\здоровый сон.png");
                    ans = "здоровый сон";
                    break;
            }
            pictureBox.Image = (Image) Image;
            Controls.Add(pictureBox);

            textBox = new TextBox();
            textBox.Location = new Point((x-400)/2, y-120);
            textBox.Size = new Size(400, 50);
            textBox.KeyPress += new KeyPressEventHandler(TextCheck);
            Controls.Add(textBox);

            GenreSelector = new Button();
            GenreSelector.FlatStyle = FlatStyle.Flat;
            GenreSelector.Location = new Point(x-40-150,   y - 80);
            GenreSelector.Size = new Size(150, 30);
            GenreSelector.Text = "Выбор жанра";
            GenreSelector.MouseClick += new MouseEventHandler(button_Click2);
            Controls.Add(GenreSelector);

            LevelSelector = new Button();
            LevelSelector.FlatStyle = FlatStyle.Flat;
            LevelSelector.Location = new Point((x-400)/2,   y - 80);
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
        }

        private void TextCheck(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string vvod = ((TextBox) sender).Text;

                if (AnsCheck(vvod))
                {
                    MessageBox.Show("Ура! Все верно");
                }
                else
                {
                    MessageBox.Show("Ты ошибся");
                }
                
            }
        }

        private bool AnsCheck(string vvod)
        {
            if (vvod.ToLower().Equals(ans))
            {
                return true;
            }
            return false;
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
            LevelCR lvl = new LevelCR('R',20);
            lvl.Show();
        }
    }
}