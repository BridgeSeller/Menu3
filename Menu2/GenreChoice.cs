using System;
using System.Windows.Forms;

namespace Menu2
{
    public partial class GenreChoice : Form
    {
        public GenreChoice()
        {
            InitializeComponent();
        }


        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Thank you so much for quitting my game");
        }

        private void sudokuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelSelectorTele levels = new LevelSelectorTele('S', 11);
            levels.Show();
        }


        private void mineButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelSelectorTele levels = new LevelSelectorTele('M', 10);
            levels.Show();
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ticTacToeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTic tic = new FormTic();
            tic.Show();
        }

        private void sequenceButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cipherButton_Click(object sender, EventArgs e)
        {
            this.Close();

            FormS cipher = new FormS();
            cipher.Show();
        }

        private void rebusLetter_Click(object sender, EventArgs e)
        {
            this.Close();
            FormR rebus = new FormR();
            rebus.Show();

        }

        private void japanCrossword_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelSelectorTele levels = new LevelSelectorTele('J', 15);
            levels.Show();
        }

        private void GenreChoice_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Menu = new Form1();
            Menu.Show();
        }

        private void soloChess_Click(object sender, EventArgs e)
        {
            this.Close();
            LevelSelectorTele levels = new LevelSelectorTele('C', 10);
            levels.Show();
        }
    }
}