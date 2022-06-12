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

        private int level;

        private Button[,]? allButtons;
        private Button exit;

        public Form3(int lvl)
        {
            level = lvl;
            InitializeComponentt();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"res\Back6.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            int[] diff = SudokuLevelLayout.GetLevel(level);
            board = new SudokuBoard(diff[0]);
            board.RandomFillBoard(diff[1]);
            
            
            Size = new Size(360, 500);
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / (board.GetSize()+3);
            if (scale < 10) scale = 10;
            
            exit = new Button();
            exit.TabIndex = 500;
            exit.Size = new Size((int) (scale*2),scale);
            exit.Location = new Point(10, 10);
            exit.Text = "Назад";
            exit.FlatStyle = FlatStyle.Flat;
            exit.BackColor = Color.FromArgb(255, 200, 218, 110);
            exit.ForeColor = Color.FromArgb(255, 51, 76, 8);
            exit.Font = new Font("Bahnschrift Light", 12, FontStyle.Bold);
            exit.MouseClick += new MouseEventHandler(exit_Click);
            Controls.Add(exit);

            int[] offset = {(int) (scale * 2.5), scale};

            allButtons = new Button[board.GetXSide(), board.GetYSide()];

            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(offset[0]+10 + scale * j, offset[1]+10 + scale * i);
                    button.Size = new Size(scale, scale);
                    button.FlatStyle = FlatStyle.Flat;
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

                    button.TabIndex = i + j * board.GetSize();

                    allButtons[j, i] = button;
                    Controls.Add(button);
                    button.KeyPress += new KeyPressEventHandler(TextEdited);
                }
            }

            SizeChanged += new EventHandler(SizeChangedForm3);
            
        }

        private void exit_Click(object sender, MouseEventArgs e)
        {
            this.Close();
            LevelSelectorTele levelSelector = new LevelSelectorTele('S', 11);
            levelSelector.Show();
        }

        private void TextEdited(object sender, KeyPressEventArgs e)
        {
            Button senderB = (Button) sender;
            if ((string) senderB.Tag == "Locked") return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (senderB.Text == "" && e.KeyChar == '0') return;
                if ((board.GetCell(senderB.TabIndex) * 10 + e.KeyChar - 48) > board.GetSize()) return;
                
                senderB.Text += e.KeyChar.ToString();
                board.SetCell(senderB.TabIndex, board.GetCell(senderB.TabIndex) * 10 + e.KeyChar - 48);
            }
            else if (e.KeyChar == (char) 8)
            {
                switch (senderB.Text.Length)
                {
                    case 2:
                        senderB.Text = senderB.Text[0].ToString();
                        board.SetCell(senderB.TabIndex, board.GetCell(senderB.TabIndex) / 10);
                        break;
                    case 1:
                        senderB.Text = "";
                        board.SetCell(senderB.TabIndex, 0);
                        break;
                    case 0:
                        break;
                }
            }

            if (board.CheckBoard())
            {
                MessageBox.Show("You Win");
            }
        }

        private void SizeChangedForm3(object sender, EventArgs e)
        {
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / (board.GetSize()+3);
            if (scale < 10) scale = 10;

            exit.Size = new Size(scale * 2, scale);
            
            int[] offset = {(int) (scale * 2.5), scale};

            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    allButtons[i, j].Location = new Point(offset[0] + 10 + scale * j, offset[1] + 10 + scale * i);
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
            this.SuspendLayout();
            // 
            // Form3
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(348, 288);
            this.Name = "Form3";
            this.ResumeLayout(false);
        }
    }
}