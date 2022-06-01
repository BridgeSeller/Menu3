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
        
        private int scale = 35;
        
        public LevelSelectorTele(char game, int numberOfLevels)
        {
            currGame = game;
            n = numberOfLevels;
            allbuttons = new Button[1+n];
            InitializeComponent();
        }


        private void LevelSelectorTele_Load(object sender, EventArgs e)
        {
            Button exit = new Button();
            exit.TabIndex = 0;
            exit.Size = new Size((int) (scale*2),scale);
            exit.Location = new Point(10, 10);
            exit.Text = "Назад";
            allbuttons[0] = exit;
            exit.MouseClick += new MouseEventHandler(ExitSelector);
            Controls.Add(exit);

            for (int i = 0; i != n; ++i)
            {
                Button button = new Button();
                button.TabIndex = i+1;
                button.Size = new Size(scale, scale);
                button.Location = new Point(10+scale*2+(i%5)*scale, 10+scale*2+(i/5)*scale);
                button.Text = (i+1).ToString();
                allbuttons[i + 1] = button;
                button.MouseClick += new MouseEventHandler(button_Click);
                Controls.Add(button);
                
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