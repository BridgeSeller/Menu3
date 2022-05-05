using System;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

namespace Menu2
{
    public partial class FormT : Form
    {
        bool xTurn = true;
        int turn;

        public FormT()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button senderB = (Button) sender;
            if (xTurn)
            {
                senderB.Text = "X";
            }
            else
            {
                senderB.Text = "O";
            }

            turn++;
            xTurn = !xTurn;
            senderB.Enabled = false;
            Random rng = new Random();
            //if rng.Next(0, 9)

            CheckWin(senderB);
        }

        void CheckWin(Button pressedButton)
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && !button2.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && !button5.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && !button8.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && !button4.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && !button5.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && !button6.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && !button5.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }
            else if (button7.Text == button5.Text && button5.Text == button3.Text && !button5.Enabled)
            {
                MessageBox.Show("Winner is " + pressedButton.Text);
                Application.Restart();

            }

            else
            {
                if (turn == 9)
                {
                    MessageBox.Show("Tie");
                    Application.Restart();
                }
            }


        }
    }
}