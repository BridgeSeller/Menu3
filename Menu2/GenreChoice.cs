using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu2
{
    public partial class GenreChoice : Form
    {
        private Button[] allButtons;
        private int scale = 10;
        public GenreChoice()
        {
            allButtons = new Button[7];
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
            exit.BackColor = Color.Lavender;
            exit.ForeColor = Color.FromArgb(255, 14, 29, 53);
            exit.FlatStyle = FlatStyle.Flat;
            allButtons[exit.TabIndex] = exit;

            sudokuButton.BackColor = Color.FromArgb(255,255, 126, 247);
            sudokuButton.ForeColor = Color.FromArgb(255, 14, 29, 53);
            sudokuButton.Size = new Size(scale * 12, scale * 10);
            sudokuButton.Location = new Point(100, 60+12*scale);
            allButtons[sudokuButton.TabIndex] = sudokuButton;

            rebusLetter.BackColor = Color.FromArgb(255, 138, 255, 94);
            rebusLetter.ForeColor = Color.FromArgb(255, 14, 29, 53);
            rebusLetter.Size = new Size(scale * 12, scale * 10);
            rebusLetter.Location = new Point(100+17*scale, 60);
            allButtons[rebusLetter.TabIndex] = rebusLetter;

            mineButton.BackColor = Color.FromArgb(255, 102, 244, 255);
            mineButton.ForeColor = Color.FromArgb(255, 14, 29, 53);
            mineButton.Size = new Size(scale * 12, scale * 10);
            mineButton.Location = new Point(100, 60);
            allButtons[mineButton.TabIndex] = mineButton;

            chessButton.BackColor = Color.FromArgb(255, 255, 136, 78);
            chessButton.ForeColor = Color.FromArgb(255, 14, 29, 53);
            chessButton.Size = new Size(scale * 12, scale * 10);
            chessButton.Location = new Point(100+17*2*scale, 60);
            allButtons[chessButton.TabIndex] = chessButton;

            JButton.BackColor = Color.FromArgb(255, 255, 195, 77);
            JButton.ForeColor = Color.FromArgb(255, 14, 29, 53);
            JButton.Size = new Size(scale * 12, scale * 10);
            JButton.Location = new Point(100+17*scale, 60+12*scale);
            allButtons[JButton.TabIndex] = JButton;

            cipherButton.BackColor = Color.FromArgb(255, 122, 85, 255);
            cipherButton.ForeColor = Color.FromArgb(255, 14, 29, 53);
            cipherButton.Size = new Size(scale * 12, scale * 10);
            cipherButton.Location = new Point(100+17*2*scale, 60+12*scale);
            allButtons[cipherButton.TabIndex] = cipherButton;

            SizeChanged += new EventHandler(size_Changed);
        }

        private void size_Changed(object sender, EventArgs e)
        {
            scale = (Math.Min((Size.Height - 50) / 40, (Size.Width - 30) / 68));
            
            sudokuButton.Size = new Size(scale * 12, scale * 10);
            sudokuButton.Location = new Point(100, 60+12*scale);
            
            rebusLetter.Size = new Size(scale * 12, scale * 10);
            rebusLetter.Location = new Point(100+17*scale, 60);
            
            mineButton.Size = new Size(scale * 12, scale * 10);
            mineButton.Location = new Point(100, 60);
            
            chessButton.Size = new Size(scale * 12, scale * 10);
            chessButton.Location = new Point(100+17*2*scale, 60);
            
            JButton.Size = new Size(scale * 12, scale * 10);
            JButton.Location = new Point(100+17*scale, 60+12*scale);
            
            cipherButton.Size = new Size(scale * 12, scale * 10);
            cipherButton.Location = new Point(100+17*2*scale, 60+12*scale);
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