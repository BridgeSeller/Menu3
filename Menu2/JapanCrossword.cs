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

        private bool[,] data10_5 =
        {
            {true, false, true, false, false, false, true, false, true, false},
            {true, true, true, true, false, false, true, true, true, true},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false}
        };
        
        public JapanCrossword()
        {
            InitializeComponent();
        }

        private void JapanCrossword_Load(object sender, EventArgs e)
        {
            board = new JapaneseCrosswordBoard(data10_5);
            
            Size = new Size(800, 500);
            scale = (Math.Min(Size.Height - 50, Size.Width - 30)) / Math.Max(board.GetSideX(), board.GetSideY());
            if (scale < 10) scale = 10;
            
            allButtons = new Button[board.GetSideX(), board.GetSideY()];

            for (int i = 0; i != board.GetSideY(); ++i)
            {
                Label label = new Label();
                label.Location = new Point( 10 + scale * (i + 1),10);
                label.Size = new Size(scale, scale);
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
                Controls.Add(label);
            }
            for (int i = 0; i != board.GetSideX(); ++i)
            {
                Label label = new Label();
                label.Location = new Point(10,10 + scale * (i + 1));
                label.Size = new Size(scale, scale);
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
                Controls.Add(label);
            }
            
            for (int i = 0; i != board.GetSideX(); ++i)
            {
                for (int j = 0; j != board.GetSideY(); ++j)
                {
                    Button button = new Button();
                    button.Location = new Point(10 + scale * (j + 1), 10 + scale * (i + 1));
                    button.Size = new Size(scale, scale);
                    

                    button.TabIndex = i + j * board.GetSideX();

                    allButtons[i, j] = button;
                    Controls.Add(button);
                    button.MouseClick += new MouseEventHandler(button_Click);
                }
            }
            //SizeChanged += new EventHandler(SizeChangedForm4);
        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            Button senderB = (Button) sender;
            if (board.GetCell(senderB.TabIndex) == 0)
            {
                senderB.Text = char.ConvertFromUtf32(9632);
                board.SetCell(senderB.TabIndex);
            }
            else
            {
                senderB.Text = "";
                board.SetCell(senderB.TabIndex);
            }

            if (board.CheckBoard())
            {
                MessageBox.Show("You Win!");
            }
        }
        
    }
}