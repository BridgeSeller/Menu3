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
        private int scale = 40;
        private int level;

        public Chess(int lvl)
        {
            level = lvl;
            InitializeComponent();
        }

        private void Chess_Load(object sender, EventArgs e)
        {
            allButtons = new Button[8,8];
            board = new SingleChessBoard(ChessLevelLayout.GetLevel(level));

            for (int i = 0; i != board.GetXSide(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(10, scale + scale * i + 10);
                label.Size = new Size(scale, scale);
                label.Text = board.GetSquare(i, 0).GetCoordinates()[1].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(label);
            }
            for (int i = 0; i != board.GetXSide(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(scale + scale * i + 10, scale + 10 + scale * 8);
                label.Size = new Size(scale, scale);
                label.Text = board.GetSquare(0, i).GetCoordinates()[0].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(label);
            }
            
            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(10+scale+scale*j, 10+scale+scale*i);
                    button.Size = new Size(scale, scale);
                    button.Text = board.GetSquare(i,j).ToString();
                    button.BackColor = board.GetSquare(i, j).GetColor() == 'B'
                        ? Color.FromArgb(255, 136, 69, 17)
                        : Color.FromArgb(156, 180, 107, 21);
                    button.ForeColor = Color.Bisque;
                    button.TabIndex = i * board.GetXSide() + j + 30;
                    allButtons[i, j] = button;
                    Controls.Add(button);
                    button.MouseDown += new MouseEventHandler(button1_Click);
                    button.KeyPress += new KeyPressEventHandler(back_Click);
                }
            }
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