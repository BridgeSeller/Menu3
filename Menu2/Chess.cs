using System;
using System.Drawing;
using System.Windows.Forms;
using Menu2.SingleChessGame;

namespace Menu2
{
    public partial class Chess : Form
    {
        private SingleChessBoard board;
        private Button[,] allButtons;
        private Button exitButton;
        private int scale = 40;
        private int level;

        public Chess(int lvl)
        {
            level = lvl;
            InitializeComponent();
        }

        private void Chess_Load(object sender, EventArgs e)
        {
            this.Width = scale * 14 + 20;
            this.Height = scale * 12 + 20;
            
            this.BackColor = Color.FromArgb(40,40,50);
            
            exitButton = new Button();
            exitButton.Location = new Point(10, 10);
            exitButton.Size = new Size(2 * scale, scale);
            exitButton.Text = "Назад";
            exitButton.TabIndex = 0;
            exitButton.BackColor = Color.FromArgb(255, 180, 107, 21);
            exitButton.ForeColor = Color.Bisque;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.MouseClick += new MouseEventHandler(exit_Click);
            Controls.Add(exitButton);

            allButtons = new Button[8,8];
            board = new SingleChessBoard(ChessLevelLayout.GetLevel(level));

            int[] offset = {scale * 2, scale};
            
            for (int i = 0; i != board.GetXSide(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(offset[0]+10, offset[1]+scale + scale * i + 10);
                label.Size = new Size(scale, scale);
                label.Text = board.GetSquare(i, 0).GetCoordinates()[1].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.ForeColor = Color.FromArgb(156, 180, 107, 21);
                Controls.Add(label);
            }
            for (int i = 0; i != board.GetXSide(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(offset[0]+scale + scale * i + 10, offset[1]+scale + 10 + scale * 8);
                label.Size = new Size(scale, scale);
                label.Text = board.GetSquare(0, i).GetCoordinates()[0].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.ForeColor = Color.FromArgb(156, 180, 107, 21);
                Controls.Add(label);
            }
            
            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(offset[0]+10+scale+scale*j, offset[1]+10+scale+scale*i);
                    button.Size = new Size(scale, scale);
                    button.Text = board.GetSquare(i,j).ToString();
                    button.BackColor = board.GetSquare(i, j).GetColor() == 'B'
                        ? Color.SaddleBrown
                        : Color.Peru;
                    button.ForeColor = Color.Bisque;
                    button.FlatStyle = FlatStyle.Flat;
                    button.TabIndex = i * board.GetXSide() + j + 30;
                    allButtons[i, j] = button;
                    Controls.Add(button);
                    button.MouseDown += new MouseEventHandler(button1_Click);
                    button.KeyPress += new KeyPressEventHandler(back_Click);
                }
            }
        }

        private void exit_Click(object sender, MouseEventArgs e)
        {
            this.Close();
            LevelSelectorTele levelSelector = new LevelSelectorTele('C', 10);
            levelSelector.Show();
        }

        private void back_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 8)
            {
                board.HistoryBackward();
                for (int i = 0; i != board.GetXSide(); ++i)
                {
                    for (int j = 0; j != board.GetYSide(); ++j)
                    {
                        allButtons[i, j].Text = board.GetSquare(i, j).ToString();
                        if (board.GetSquare(i,j).IsOccupied())
                        {
                            if (board.GetSquare(i, j).GetPiece()!.GetColor() == 'B')
                            {
                                allButtons[i, j].ForeColor = Color.Black;
                            }
                            else
                            {
                                allButtons[i, j].ForeColor = Color.Bisque;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            Button senderB = (Button) sender;
            if (e.Button == MouseButtons.Right)
            {
                board.MovePiece((senderB.TabIndex - 30) / 8, (senderB.TabIndex - 30) % 8);
                for (int i = 0; i != board.GetXSide(); ++i)
                {
                    for (int j = 0; j != board.GetYSide(); ++j)
                    {
                        allButtons[i, j].Text = board.GetSquare(i, j).ToString();
                        if (board.GetSquare(i,j).IsOccupied())
                        {
                            if (board.GetSquare(i, j).GetPiece()!.GetColor() == 'B')
                            {
                                allButtons[i, j].ForeColor = Color.Black;
                            }
                            else
                            {
                                allButtons[i, j].ForeColor = Color.Bisque;
                            }
                        }
                    }
                }

                if (board.CheckBoard())
                    MessageBox.Show("Win!");
            }
            else if(e.Button == MouseButtons.Left)
            {
                board.SelectSquare((senderB.TabIndex - 30) / 8, (senderB.TabIndex - 30) % 8);
                for (int i = 0; i != board.GetXSide(); ++i)
                {
                    for (int j = 0; j != board.GetYSide(); ++j)
                    {
                        allButtons[i, j].Text = board.GetSquare(i, j).ToString();
                        if (board.GetSquare(i,j).IsOccupied())
                        {
                            if (board.GetSquare(i, j).GetPiece()!.GetColor() == 'B')
                            {
                                allButtons[i, j].ForeColor = Color.Black;
                            }
                            else
                            {
                                allButtons[i, j].ForeColor = Color.Bisque;
                            }
                        }
                    }
                }
            }
        }
    }
}