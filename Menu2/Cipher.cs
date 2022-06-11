using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class FormS : Form
    {
        internal static string directory = @"C:\Users\qwerty\RiderProjects\Rebus\WindowsForms1\WindowsForms1\";
        private Bitmap Image;
        private string ans = "";
        private string text = "Разгадайте, что на картинке";
        private int x = 480;
        private int y = 480;

        public int Level;

        public FormS()
        {
            InitializeComponent();
        }

        private void FormS_Load(object sender, EventArgs e)
        {   Random rnd = new Random();
            Level = rnd.Next(1, 10);

            Size = new Size(x, y);
            Label label = new Label();
            label.Location = new Point((x - 400) / 2, 20);
            label.Size = new Size(400, 50);
            label.Text = text;
            label.TextAlign = ContentAlignment.TopCenter;
            label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Controls.Add(label);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point((x - 400) / 2, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(400, 150);

            switch (Level)
            {
                case 1:
                    Image = new Bitmap(directory + @"Resources\cipher1.jpg");
                    ans = "каникулы";
                    break;
                case 2:
                    Image = new Bitmap(directory + @"Resources\cipher2.jpg");
                    ans = "сфера";
                    break;
                case 3:
                    Image = new Bitmap(directory + @"Resources\cipher3.jpg");
                    ans = "небо";
                    break;
                case 4:
                    Image = new Bitmap(directory + @"Resources\cipher4.jpg");
                    ans = "я";
                    break;
                case 5:
                    Image = new Bitmap(directory + @"Resources\cipher5.jpg");
                    ans = "город";
                    break;
                case 6:
                    Image = new Bitmap(directory + @"Resources\cipher6.jpg");
                    ans = "весна";
                    break;
                case 7:
                    Image = new Bitmap(directory + @"Resources\cipher7.jpg");
                    ans = "реакция";
                    break;
                case 8:
                    Image = new Bitmap(directory + @"Resources\cipher8.jpg");
                    ans = "сирень";
                    break;
                case 9:
                    Image = new Bitmap(directory + @"Resources\cipher9.jpg");
                    ans = "чувство";
                    break;
                case 10:
                    Image = new Bitmap(directory + @"Resources\cipher10.jpg");
                    
                    ans = "библиотека";
                    break;
            }

            pictureBox.Image = (Image) Image;
            Controls.Add(pictureBox);

            //ans = "сложныйкод";
            TextBox textBox = new TextBox();
            textBox.Location = new Point((x - 400) / 2, y - 120);
            textBox.Size = new Size(400, 50);
            textBox.KeyPress += new KeyPressEventHandler(TextCheck);
            Controls.Add(textBox);

            Button button = new Button();
            button.Location = new Point(0, 0);
            button.Size = new Size(30, 30);
            button.Text = "?";
            button.MouseClick += new MouseEventHandler(button_Click1);
            Controls.Add(button);
            
            Button restart = new Button();
            restart.Location = new Point(x - 250,   y - 80);
            restart.Size = new Size(150, 30);
            restart.Text = "Выбор жанра";
            restart.MouseClick += new MouseEventHandler(button_Click2);
            Controls.Add(restart);
            
            Button level = new Button();
            level.Location = new Point(x - 450,   y - 80);
            level.Size = new Size(150, 30);
            level.Text = "Выбор уровня";
            level.MouseClick += new MouseEventHandler(button_Click3);
            Controls.Add(level);
        }

        private void TextCheck(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                string vvod = ((TextBox) sender).Text;
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
            Form4 newForm2 = new Form4(this);
            newForm2.Size = new Size(600, 300);

            newForm2.Show();
        }
        
        private void button_Click2(object sender, MouseEventArgs e)
        {
            this.Hide();
            GenreChoice genre = new GenreChoice();
            genre.Show();
        }
        
        private void button_Click3(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Coming soon");
            //this.Hide();
            //FormS genre = new FormS();
            //genre.Show();
        }



    }
}