using System;
using System.Drawing;
using System.Windows.Forms;
using Menu2.MinesweeperGame;

namespace Menu2
{
  public partial class Form2 : Form
  {
    private MinesweeperBoard board;
    private Button[,] allButtons;
    private Button exit;
    private Button reset;
    private int scale;

    private int level;
    
    public Form2(int lvl)
    {
      level = lvl;
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      BackgroundImage = Image.FromFile("Back7.png");
      BackgroundImageLayout = ImageLayout.Stretch;
      SizeChanged += new EventHandler(size_Change);
      
      int[] diff = MinesweeperLevelLayout.GetLevel(level);
      board = new MinesweeperBoard(diff[0],diff[1]);
      board.RandomFillBoard(diff[2]);
      
      scale = (Math.Min(Height - 50, Width - 30)) / Math.Max(board.GetXSide()+4,board.GetYSide()+2);
      if (scale < 10) scale = 10;

      exit = new Button();
      exit.TabIndex = 2000;
      exit.Size = new Size((int) (scale*4),scale*2);
      exit.Location = new Point(10, 10);
      exit.Text = "Назад";
      exit.FlatStyle = FlatStyle.Flat;
      exit.BackColor = Color.FromArgb(255, 240, 226, 204);
      exit.ForeColor = Color.FromArgb(255, 95, 45, 27);
      exit.Font = new Font("Bahnschrift Light", 12, FontStyle.Bold);
      exit.MouseClick += new MouseEventHandler(exit_Click);
      Controls.Add(exit);
      
      reset = new Button();
      reset.TabIndex = 1999;
      reset.Size = new Size((int) (scale*4),scale*2);
      reset.Location = new Point(10, 10+scale*2);
      reset.Text = "Заново";
      reset.FlatStyle = FlatStyle.Flat;
      reset.BackColor = Color.FromArgb(255, 240, 226, 204);
      reset.ForeColor = Color.FromArgb(255, 95, 45, 27);
      reset.Font = new Font("Bahnschrift Light", 12, FontStyle.Bold);
      reset.MouseClick += new MouseEventHandler(reset_Click);
      Controls.Add(reset);

      allButtons = new Button[diff[0], diff[1]];
      int[] offset = {scale * 4, scale*2};
      
      for(int i = 0; i != board.GetXSide(); ++i)
      {
        for (int j = 0; j != board.GetYSide(); ++j)
        {
          Button button = new Button();
          button.Location = new Point(offset[0]+10+scale*j, offset[1]+10+scale*i);
          button.Size = new Size(scale, scale);
          button.Text = board.GetRealBoard()![i,j].ToString();
          button.TabIndex = i * board.GetXSide() + j;
          button.FlatStyle = FlatStyle.Flat;
          allButtons[j, i] = button;
          Controls.Add(button);
          button.MouseDown += new MouseEventHandler(button1_Click);
        }
      }
    }

    private void size_Change(object sender, EventArgs e)
    {
      scale = (Math.Min(Height - 50, Width - 30)) / Math.Max(board.GetXSide()+4,board.GetYSide()+2);
      if (scale < 10) scale = 10;
      int[] offset = {scale * 4, scale*2};
      
      exit.Size = new Size((int) (scale*4),scale*2);
      reset.Size = new Size((int) (scale*4),scale*2);
      reset.Location = new Point(10, 10+scale*2);
      
      for(int i = 0; i != board.GetXSide(); ++i)
      {
        for (int j = 0; j != board.GetYSide(); ++j)
        {
          allButtons[j,i].Location = new Point(offset[0]+10+scale*j, offset[1]+10+scale*i);
          allButtons[j,i].Size = new Size(scale, scale);
        }
      }
    }

    private void reset_Click(object sender, MouseEventArgs e)
    {
      int[] diff = MinesweeperLevelLayout.GetLevel(level);
      board = new MinesweeperBoard(diff[0],diff[1]);
      board.RandomFillBoard(diff[2]);
      
      for (int i = 0; i != board.GetXSide(); ++i)
      {
        for (int j = 0; j != board.GetYSide(); ++j)
        {
          allButtons[i, j].Text = board.GetRealBoard()![i, j].ToString();
        }
      }
    }

    private void exit_Click(object sender, MouseEventArgs e)
    {
      this.Close();
      LevelSelectorTele levelSelector = new LevelSelectorTele('M', 10);
      levelSelector.Show();
    }

    private void button1_Click(object sender, MouseEventArgs e)
    {
      Button senderB = (Button) sender;
      if (e.Button == MouseButtons.Left)
      {
        board.SetCell(senderB.TabIndex, 0);
      }
      if (e.Button == MouseButtons.Right)
      {
        board.SetCell(senderB.TabIndex, 1);
      }

      for (int i = 0; i != board.GetXSide(); ++i)
      {
        for (int j = 0; j != board.GetYSide(); ++j)
        {
          allButtons[i, j].Text = board.GetRealBoard()![i, j].ToString();
        }
      }

      if (e.Button == MouseButtons.Left)
      {
        if (board.GetMine(senderB.TabIndex % board.GetXSide(), senderB.TabIndex / board.GetXSide()))
        {
          MessageBox.Show("You lose!");
        }
      }

      if (e.Button == MouseButtons.Right)
      {
        if (board.CheckBoard())
        {
          MessageBox.Show("You Win!");
        }
      }
    }
  }
}
