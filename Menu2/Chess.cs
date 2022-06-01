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
        private Label[] allLabels;
        private Button exitButton;
        private int scale = 60;
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
            this.SizeChanged += new EventHandler(Size_Change);
            
            exitButton = new Button();
            exitButton.Location = new Point(10, 10);
            exitButton.Size = new Size(2 * scale, scale);
            exitButton.Text = "Назад";
            exitButton.TabIndex = 0;
            exitButton.BackColor = Color.FromArgb(255, 180, 107, 21);
            exitButton.ForeColor = Color.Bisque;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Bahnschrift Light", 14, FontStyle.Bold);
            exitButton.MouseClick += new MouseEventHandler(exit_Click);
            Controls.Add(exitButton);

            allButtons = new Button[8,8];
            allLabels = new Label[8 + 8];
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
                label.Font = new Font("Bahnschrift Light", 14, FontStyle.Bold);
                allLabels[i] = label;
                Controls.Add(label);
            }
            for (int i = 0; i != board.GetYSide(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(offset[0]+scale + scale * i + 10, offset[1]+scale + 10 + scale * 8);
                label.Size = new Size(scale, scale);
                label.Text = board.GetSquare(0, i).GetCoordinates()[0].ToString();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.ForeColor = Color.FromArgb(156, 180, 107, 21);
                label.Font = new Font("Bahnschrift Light", 14, FontStyle.Bold);
                allLabels[board.GetXSide()+i] = label;
                Controls.Add(label);
            }
            
            for (int i = 0; i != board.GetXSide(); ++i)
            {
                for (int j = 0; j != board.GetYSide(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(offset[0]+10+scale+scale*j, offset[1]+10+scale+scale*i);
                    button.Size = new Size(scale, scale);
                    button.Font = new Font("Bahnschrift Light", 20, FontStyle.Bold);
                    switch (board.GetSquare(i, j).ToString())
                    {
                        case "B":
                            button.Image = Image.FromFile("Chess\\Chess_blt60.png");
                            break;
                        case "Q":
                            button.Image = Image.FromFile("Chess\\Chess_qlt60.png");
                            break;
                        case "K":
                            button.Image = Image.FromFile("Chess\\Chess_klt60.png");
                            break;
                        case "N":
                            button.Image = Image.FromFile("Chess\\Chess_nlt60.png");
                            break;
                        case "R":
                            button.Image = Image.FromFile("Chess\\Chess_rlt60.png");
                            break;
                    }
                    
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

        private void Size_Change(object sender, EventArgs e)
        {
            scale = Math.Min((Width - 20) / 14, (Height - 20) / 12);
            if (scale < 10) scale = 10;
            int[] offset = {scale * 2, scale};
            for (int i = 0; i < board.GetXSide(); i++)
            {
                for (int j = 0; j < board.GetYSide(); j++)
                {
                    allButtons[i, j].Size = new Size(scale, scale);
                    allButtons[i, j].Location = new Point(offset[0]+10+scale+scale*j, offset[1]+10+scale+scale*i);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                allLabels[i].Location = new Point(offset[0]+10, offset[1]+scale + scale * i + 10);
                allLabels[i].Size = new Size(scale, scale);
            }

            for (int i = 8; i < 16; i++)
            {
                allLabels[i].Location = new Point(offset[0]+scale + scale * (i-8) + 10, offset[1]+scale + 10 + scale * 8);
                allLabels[i].Size = new Size(scale, scale);
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
                        if (board.GetSquare(i,j).IsOccupied())
                        {
                            allButtons[i, j].Text = " ";
                            if (board.GetSquare(i, j).GetPiece()!.GetColor() == 'B')
                            {
                                switch (board.GetSquare(i, j).ToString())
                                {
                                    case "B":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_bdt60.png");
                                        break;
                                    case "Q":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_qdt60.png");
                                        break;
                                    case "K":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_kdt60.png");
                                        break;
                                    case "N":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_ndt60.png");
                                        break;
                                    case "R":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_rdt60.png");
                                        break;
                                    default:
                                        allButtons[i, j].Image = null;
                                        break;
                                }
                            }
                            else
                            {
                                switch (board.GetSquare(i, j).ToString())
                                {
                                    case "B":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_blt60.png");
                                        break;
                                    case "Q":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_qlt60.png");
                                        break;
                                    case "K":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_klt60.png");
                                        break;
                                    case "N":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_nlt60.png");
                                        break;
                                    case "R":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_rlt60.png");
                                        break;
                                    default:
                                        allButtons[i, j].Image = null;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            allButtons[i, j].Image = null;
                            allButtons[i, j].Text = board.GetSquare(i, j).ToString();
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
                        if (board.GetSquare(i,j).IsOccupied())
                        {
                            allButtons[i, j].Text = " ";
                            if (board.GetSquare(i, j).GetPiece()!.GetColor() == 'B')
                            {
                                switch (board.GetSquare(i, j).ToString())
                                {
                                    case "B":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_bdt60.png");
                                        break;
                                    case "Q":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_qdt60.png");
                                        break;
                                    case "K":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_kdt60.png");
                                        break;
                                    case "N":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_ndt60.png");
                                        break;
                                    case "R":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_rdt60.png");
                                        break;
                                    default:
                                        allButtons[i, j].Image = null;
                                        break;
                                }
                            }
                            else
                            {
                                switch (board.GetSquare(i, j).ToString())
                                {
                                    case "B":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_blt60.png");
                                        break;
                                    case "Q":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_qlt60.png");
                                        break;
                                    case "K":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_klt60.png");
                                        break;
                                    case "N":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_nlt60.png");
                                        break;
                                    case "R":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_rlt60.png");
                                        break;
                                    default:
                                        allButtons[i, j].Image = null;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            allButtons[i, j].Image = null;
                            allButtons[i, j].Text = board.GetSquare(i, j).ToString();
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
                        if (board.GetSquare(i,j).IsOccupied())
                        {
                            allButtons[i, j].Text = " ";
                            if (board.GetSquare(i, j).GetPiece()!.GetColor() == 'B')
                            {
                                switch (board.GetSquare(i, j).ToString())
                                {
                                    case "B":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_bdt60.png");
                                        break;
                                    case "Q":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_qdt60.png");
                                        break;
                                    case "K":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_kdt60.png");
                                        break;
                                    case "N":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_ndt60.png");
                                        break;
                                    case "R":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_rdt60.png");
                                        break;
                                    default:
                                        allButtons[i, j].Image = null;
                                        break;
                                }
                            }
                            else
                            {
                                switch (board.GetSquare(i, j).ToString())
                                {
                                    case "B":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_blt60.png");
                                        break;
                                    case "Q":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_qlt60.png");
                                        break;
                                    case "K":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_klt60.png");
                                        break;
                                    case "N":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_nlt60.png");
                                        break;
                                    case "R":
                                        allButtons[i, j].Image = Image.FromFile("Chess\\Chess_rlt60.png");
                                        break;
                                    default:
                                        allButtons[i, j].Image = null;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            allButtons[i, j].Image = null;
                            allButtons[i, j].Text = board.GetSquare(i, j).ToString();
                        }
                    }
                }
            }
        }
    }
}