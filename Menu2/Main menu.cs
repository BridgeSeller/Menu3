﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        private void SwitchMenu(object sender, EventArgs e)
        {
           this.Close(); 
           GenreChoice second = new GenreChoice();
           second.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке участвовали: Потапович Иван;" + '\n'
                           + "Некоторые другие лица " + '\n'+
                            "Поддержите независимый проект на patreon.com/Puzzlerama!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}