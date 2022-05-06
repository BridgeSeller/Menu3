using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Menu2.SudokuGame;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Menu2
{
    public partial class Form3 : Form
    {
        private int scale;
        private SudokuBoard? board;

        private Button[,]? allButtons;

        public Form3()
        {
            InitializeComponentt();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            
            board = new SudokuBoard(9);
            board.RandomFillBoard();

            Size = new Size(360, 500);
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / board.GetSize();
            if (scale < 10) scale = 10;

            allButtons = new Button[board.GetXSide(), board.GetYSide()];

            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(10 + scale * j, 10 + scale * i);
                    button.Size = new Size(scale, scale);
                    if (board.GetCell(i,j)==0)
                    {
                        button.Text = "";
                    }
                    else
                    {
                        button.Text = board.GetCell(i, j).ToString();
                        button.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                        button.Tag = "Locked";
                    }

                    allButtons[j, i] = button;
                    Controls.Add(button);
                    button.KeyPress += new KeyPressEventHandler(TextEdited);
                }
            }

            SizeChanged += new EventHandler(SizeChangedForm3);

            Button resetButton = new Button();
            resetButton.Location = new Point(10 + scale * 2, 30 + scale * 10);
            resetButton.Size = new Size(scale * 2, scale);
            resetButton.Text = "Reset";
            Controls.Add(resetButton);
            resetButton.Click += new EventHandler(ResetButton_Click);

            Button genre = new Button();
            genre.Location = new Point(10 + scale * 4, 30 + scale * 10);
            genre.Size = new Size(scale * 2, scale);
            genre.Text = "Genre choice";
            Controls.Add(genre);
            genre.Click += new EventHandler(ReturnToLevels_Click);
        }

        private void TextEdited(object sender, KeyPressEventArgs e)
        {
            Button senderB = (Button) sender;
            if ((string) senderB.Tag == "Locked") return;
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                senderB.Text = e.KeyChar.ToString();
                board.SetCell(senderB.TabIndex, e.KeyChar - 48);
            }

            if (board.CheckBoard())
            {
                MessageBox.Show("You Win");
            }
        }

        private void SizeChangedForm3(object sender, EventArgs e)
        {
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / board.GetSize();
            if (scale < 10) scale = 10;

            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    allButtons[i, j].Location = new Point(10 + scale * j, 10 + scale * i);
                    allButtons[i, j].Size = new Size(scale, scale);
                }
            }
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.SuspendLayout();
            // 
            // Form3
            // 
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 288);
            this.Name = "Form3";
            this.ResumeLayout(false);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 second = new Form3();
            second.Show();
        }

        private void ReturnToLevels_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenreChoice second = new GenreChoice();
            second.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenreChoice genre = new GenreChoice();
            genre.Show();
        }
    }
}