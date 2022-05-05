using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class FormR : Form
    {
        internal string directory = @"C:\Users\qwerty\RiderProjects\Rebus\WindowsForms1\WindowsForms1\";
        private Bitmap Image;
       
        //private string[] ans = {"листок","Листок"};
        private string[] ans = {"Гаара","гаара"};

        private string text = "Разгадайте, что на картинке";
        private int x = 480;
        private int y = 480;

        public FormR()
        {
            InitializeComponent();
        }
        
        private void FormR_Load(object sender, EventArgs e)
        {
            
            Size = new Size(x, y);
            Label label = new Label();
            label.Location = new Point((x - 400) / 2, 20);
            label.Size = new Size(400, 50);
            label.Text = text;
            label.TextAlign = ContentAlignment.TopCenter;
            label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            Controls.Add(label);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point((x-400)/2, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(400, 190);
            Image = new Bitmap(directory + @"Resources\img3.png");
            pictureBox.Image = (Image) Image;
            Controls.Add(pictureBox);

            //ans = "лиса";
            TextBox textBox = new TextBox();
            textBox.Location = new Point((x-400)/2, y-120);
            textBox.Size = new Size(400, 50);
            textBox.KeyPress += new KeyPressEventHandler(TextCheck);
            Controls.Add(textBox);
            
            Button restart = new Button();
            restart.Location = new Point(x - 250,   y - 80);
            restart.Size = new Size(150, 30);
            restart.Text = "Genre select";
            restart.MouseClick += new MouseEventHandler(button_Click2);
            Controls.Add(restart);
            
            Button level = new Button();
            level.Location = new Point(x - 450,   y - 80);
            level.Size = new Size(150, 30);
            level.Text = "Level select";
            level.MouseClick += new MouseEventHandler(button_Click3);
            Controls.Add(level);

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
                    //MessageBox.Show("Ты ошибся");
                    MessageBox.Show("Саске вернись в коноху");
                }
                
            }
        }

        private bool AnsCheck(string vvod)
        {
            for (int i = 0; i < ans.Length; i++)
            {
                if (vvod.Equals(ans[i]))
                {
                    return true;
                }
            }

            return false;
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