using System;
using System.Drawing;
using System.Windows.Forms;
using Menu2.MinesweeperGame;

namespace Menu2
{
  public partial class Form2 : Form
  {
    private MinesweeperBoard board;
    private Button[,] allButtons = new Button[8,8];
    private int scale = 35;
    
    public Form2()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      board = new MinesweeperBoard(8,8);
      board.RandomFillBoard(85);
      for (int i = 0; i != board.GetXSide(); ++i)
      {
        for (int j = 0; j != board.GetYSide(); ++j)
        {
          Button button = new Button();
          button.Location = new Point(10+scale*j, 10+scale*i);
          button.Size = new Size(scale, scale);
          button.Text = board.GetRealBoard()![i,j].ToString();
          allButtons[j, i] = button;
          Controls.Add(button);
          button.MouseDown += new MouseEventHandler(button1_Click);
        }
      }

      Button resetButton = new Button();
      resetButton.Location = new Point(10+scale * 2, 30 + scale * 8);
      resetButton.Size = new Size(scale*2, scale);
      resetButton.Text = "Reset";
      Controls.Add(resetButton);
      resetButton.Click += new EventHandler(button2_Click);
        
      Button genre = new Button();
      genre.Location = new Point(10+scale * 4, 30 + scale * 8);
      genre.Size = new Size(scale*2, scale);
      genre.Text = "Genre choice";
      Controls.Add(genre);
      genre.Click += new EventHandler(button3_Click);
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

    private void button2_Click(object sender, EventArgs e)
    {
      Button senderB = (Button) sender;
      board.RecreateBoard(8);
      board.RandomFillBoard();
      for (int i = 0; i != board.GetXSide(); ++i)
      {
        for (int j = 0; j != board.GetYSide(); ++j)
        {
          allButtons[i, j].Text = board.GetRealBoard()![i, j].ToString();
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      GenreChoice genre = new GenreChoice();
      genre.Show();

    }
    //private void ReturnToLevels(object sender, EventArgs e)
    //{
   //   this.Hide(); 
    //  GenreChoice second = new GenreChoice();
   //   second.Show();
  //  }
  }
}
