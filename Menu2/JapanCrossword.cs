using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Menu2.JapaneseCrosswordGame;

namespace Menu2
{
    public partial class JapanCrossword : Form
    {
        private int scale;
        private JapaneseCrosswordBoard board;

        private Button[,] allButtons;
        private Label[] XLabels;
        private Label[] YLabels;
        private Button exit;

        private int level;
        
        public JapanCrossword(int lvl)
        {
            level = lvl;
            InitializeComponent();
        }

        private void JapanCrossword_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Back5.png");
            board = new JapaneseCrosswordBoard(CrosswordLevelLayout.GetLevel(level));
            
            Size = new Size(700, 500);
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / Math.Max(board.GetSideX()+1+4, board.GetSideY()+1+2);
            if (scale < 10) scale = 10;

            exit = new Button();
            exit.TabIndex = 500;
            exit.Size = new Size((int) (scale*3),scale*2);
            exit.Location = new Point(10, 10);
            exit.Text = "Назад";
            exit.FlatStyle = FlatStyle.Flat;
            exit.BackColor = Color.FromArgb(255, 154, 190, 255);
            exit.Font = new Font("Bahnschrift Light", 12, FontStyle.Bold);
            exit.MouseClick += new MouseEventHandler(Exit_Click);
            Controls.Add(exit);
            
            allButtons = new Button[board.GetSideX(), board.GetSideY()];
            XLabels = new Label[board.GetSideX()];
            YLabels = new Label[board.GetSideY()];

            int[] offset = {scale * 4, scale*2};

            for (int i = 0; i != board.GetSideY(); ++i)
            {
                Label label = new Label();
                label.Location = new Point( offset[0] +10 + scale * (i+1),offset[1]-scale+10);
                label.Size = new Size(scale, scale*2);
                label.TextAlign = ContentAlignment.TopCenter;

                StringBuilder builder = new StringBuilder();
                int j;
                for (j = 0; j < board.GetColsData()[i].Length-1; j++)
                {
                    builder.Append(board.GetColsData()[i][j]);
                    builder.AppendLine();
                }
                if (board.GetColsData()[i].Length > 0)
                {
                    builder.Append(board.GetColsData()[i][j]);
                }

                label.Text = builder.ToString();
                YLabels[i] = label;
                Controls.Add(label);
            }
            for (int i = 0; i != board.GetSideX(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(offset[0]-scale+10,offset[1]+10 + scale * (i+1));
                label.Size = new Size(scale*2, scale);
                label.TextAlign = ContentAlignment.MiddleLeft;

                StringBuilder builder = new StringBuilder();
                int j;
                for (j = 0; j < board.GetLinesData()[i].Length-1; j++)
                {
                    builder.Append(board.GetLinesData()[i][j]);
                    builder.Append('-');
                }
                if (board.GetLinesData()[i].Length > 0)
                {
                    builder.Append(board.GetLinesData()[i][j]);
                }

                label.Text = builder.ToString();
                XLabels[i] = label;
                Controls.Add(label);
            }
            
            for (int i = 0; i != board.GetSideX(); ++i)
            {
                for (int j = 0; j != board.GetSideY(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(offset[0]+10 + scale * (j + 1), offset[1]+10 + scale * (i + 1));
                    button.Size = new Size(scale, scale);
                    button.FlatStyle = FlatStyle.Flat;

                    button.TabIndex = i + j * board.GetSideX();

                    allButtons[i, j] = button;
                    Controls.Add(button);
                    button.MouseClick += new MouseEventHandler(button_Click);
                }
            }
            SizeChanged += new EventHandler(SizeChangedForm4);
        }

        private void Exit_Click(object sender, MouseEventArgs e)
        {
            this.Close();
            LevelSelectorTele levelSelector = new LevelSelectorTele('J', 15);
            levelSelector.Show();
        }
        
        private void SizeChangedForm4(object sender, EventArgs e)
        {
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / Math.Max(board.GetSideX()+1+4, board.GetSideY()+1+2);
            if (scale < 10) scale = 10;
            int[] offset = {scale * 4, scale*2};
            
            exit.Size = new Size((int) (scale*3),scale*2);

            for (int i = 0; i < board.GetSideY(); i++)
            {
                YLabels[i].Location = new Point( offset[0]+10 + scale * (i + 1),offset[1]-scale+10);
                YLabels[i].Size = new Size(scale, scale*2);
            }
            for (int i = 0; i < board.GetSideX(); i++)
            {
                XLabels[i].Location = new Point(offset[0]-scale + 10,offset[1]+10 + scale * (i + 1));
                XLabels[i].Size = new Size(scale*2, scale);
            }
            for (int i = 0; i != board.GetSideX(); ++i)
            {
                for (int j = 0; j != board.GetSideY(); ++j)
                {
                    allButtons[i,j].Location = new Point(offset[0]+10 + scale * (j + 1), offset[1]+10 + scale * (i + 1));
                    allButtons[i,j].Size = new Size(scale, scale);
                }
            }
        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            Button senderB = (Button) sender;
            if (board.GetCell(senderB.TabIndex) == 0)
            {
                senderB.BackColor = Color.Black;
                board.SetCell(senderB.TabIndex);
            }
            else
            {
                senderB.BackColor = Color.Empty;
                board.SetCell(senderB.TabIndex);
            }

            if (board.CheckBoard())
            {
                MessageBox.Show("You Win!");
            }
        }
        
    }
}