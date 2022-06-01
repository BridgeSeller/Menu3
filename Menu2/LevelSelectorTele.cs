using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class LevelSelectorTele : Form
    {
        private int n;
        private char currGame;

        private Button[] allbuttons;
        
        private int scale = 50;
        
        public LevelSelectorTele(char game, int numberOfLevels)
        {
            currGame = game;
            n = numberOfLevels;
            allbuttons = new Button[1+n];
            InitializeComponent();
        }


        private void LevelSelectorTele_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("Back4.png");
            this.SizeChanged += new EventHandler(size_Changed);
            
            Button exit = new Button();
            exit.TabIndex = 0;
            exit.Size = new Size((int) (scale*2),scale);
            exit.Location = new Point(10, 10);
            exit.Text = "Назад";
            exit.BackColor = Color.FromArgb(130, 41, 180, 124);
            exit.ForeColor = Color.Teal;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Bahnschrift Light", 14, FontStyle.Bold);
            allbuttons[0] = exit;
            exit.MouseClick += new MouseEventHandler(ExitSelector);
            Controls.Add(exit);

            for (int i = 0; i != n; ++i)
            {
                Button button = new Button();
                button.TabIndex = i+1;
                button.Size = new Size(scale, scale);
                button.Location = new Point((int) (10+scale*2+(i%5)*scale*(1.5)), (int) (10+scale*2+(i/5)*scale*(1.5)));
                button.Text = (i+1).ToString();
                button.BackColor = Color.FromArgb(130, 41, 180, 124);
                button.ForeColor = Color.Teal;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = new Font("Bahnschrift Light", 14, FontStyle.Bold);
                allbuttons[i + 1] = button;
                button.MouseClick += new MouseEventHandler(button_Click);
                Controls.Add(button);
            }
        }

        private void size_Changed(object sender, EventArgs e)
        {
            scale = (int) Math.Min((Width - 20) / 11, (Height - 20) / 7.5);
            if (scale < 10) scale = 10;
            allbuttons[0].Size = new Size((scale*2),scale);

            for (int i = 0; i < n; i++)
            {
                allbuttons[1+i].Size = new Size(scale, scale);
                allbuttons[1+i].Location = new Point((int) (10+scale*2+(i%5)*scale*(1.5)), (int) (10+scale*2+(i/5)*scale*(1.5)));
            }
        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            switch (currGame)
            {
                case 'S':
                    this.Close();
                    Form3 third = new Form3(((Button) sender).TabIndex);
                    third.Show();
                    break;
                case 'M':
                    this.Close();
                    Form2 seco = new Form2(((Button) sender).TabIndex);
                    seco.Show();
                    break;
                case 'C':
                    this.Hide();
                    Chess chess = new Chess(((Button) sender).TabIndex);
                    chess.Show();
                    break;
                case 'J':
                    this.Hide();
                    JapanCrossword japan = new JapanCrossword(((Button) sender).TabIndex);
                    japan.Show();
                    break;
            }
        }

        private void ExitSelector(object sender, MouseEventArgs e)
        {
            this.Close();
            GenreChoice genreChoice = new GenreChoice();
            genreChoice.Show();
        }
    }
}