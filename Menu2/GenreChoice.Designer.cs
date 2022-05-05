using System.ComponentModel;

namespace Menu2
{
    partial class GenreChoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenreChoice));
            this.sudokuButton = new System.Windows.Forms.Button();
            this.rebusLetter = new System.Windows.Forms.Button();
            this.wordleButton = new System.Windows.Forms.Button();
            this.sequenceButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.cipherButton = new System.Windows.Forms.Button();
            this.crosswordButton = new System.Windows.Forms.Button();
            this.mineButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ticTacToeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sudokuButton
            // 
            this.sudokuButton.BackColor = System.Drawing.Color.SlateBlue;
            this.sudokuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sudokuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sudokuButton.Location = new System.Drawing.Point(176, 12);
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.Size = new System.Drawing.Size(120, 93);
            this.sudokuButton.TabIndex = 3;
            this.sudokuButton.Text = "Sudoku";
            this.sudokuButton.UseVisualStyleBackColor = false;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            // 
            // rebusLetter
            // 
            this.rebusLetter.BackColor = System.Drawing.Color.IndianRed;
            this.rebusLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebusLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.rebusLetter.Location = new System.Drawing.Point(176, 290);
            this.rebusLetter.Name = "rebusLetter";
            this.rebusLetter.Size = new System.Drawing.Size(120, 93);
            this.rebusLetter.TabIndex = 4;
            this.rebusLetter.Text = "Rebus";
            this.rebusLetter.UseVisualStyleBackColor = false;
            this.rebusLetter.Click += new System.EventHandler(this.rebusLetter_Click);
            // 
            // wordleButton
            // 
            this.wordleButton.BackColor = System.Drawing.Color.Aquamarine;
            this.wordleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.wordleButton.Location = new System.Drawing.Point(351, 12);
            this.wordleButton.Name = "wordleButton";
            this.wordleButton.Size = new System.Drawing.Size(120, 93);
            this.wordleButton.TabIndex = 5;
            this.wordleButton.Text = "Wordle";
            this.wordleButton.UseVisualStyleBackColor = false;
            this.wordleButton.Click += new System.EventHandler(this.wordleButton_Click);
            // 
            // sequenceButton
            // 
            this.sequenceButton.BackColor = System.Drawing.Color.Sienna;
            this.sequenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sequenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sequenceButton.Location = new System.Drawing.Point(176, 151);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(120, 93);
            this.sequenceButton.TabIndex = 6;
            this.sequenceButton.Text = "Quit";
            this.sequenceButton.UseVisualStyleBackColor = false;
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockButton.Location = new System.Drawing.Point(12, 290);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(120, 93);
            this.lockButton.TabIndex = 7;
            this.lockButton.Text = "*please don\'t click, it breaks the app*\r\n\r\n";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // cipherButton
            // 
            this.cipherButton.BackColor = System.Drawing.Color.Magenta;
            this.cipherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cipherButton.Location = new System.Drawing.Point(351, 151);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(120, 93);
            this.cipherButton.TabIndex = 8;
            this.cipherButton.Text = "Cipher";
            this.cipherButton.UseVisualStyleBackColor = false;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // crosswordButton
            // 
            this.crosswordButton.BackColor = System.Drawing.Color.YellowGreen;
            this.crosswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crosswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.crosswordButton.Location = new System.Drawing.Point(531, 12);
            this.crosswordButton.Name = "crosswordButton";
            this.crosswordButton.Size = new System.Drawing.Size(120, 93);
            this.crosswordButton.TabIndex = 9;
            this.crosswordButton.Text = "Placeholder";
            this.crosswordButton.UseVisualStyleBackColor = false;
            this.crosswordButton.Click += new System.EventHandler(this.crosswordButton_Click);
            // 
            // mineButton
            // 
            this.mineButton.BackColor = System.Drawing.Color.DarkCyan;
            this.mineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mineButton.Location = new System.Drawing.Point(12, 151);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(120, 93);
            this.mineButton.TabIndex = 10;
            this.mineButton.Text = "Minesweeper";
            this.mineButton.UseVisualStyleBackColor = false;
            this.mineButton.Click += new System.EventHandler(this.mineButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button2.Location = new System.Drawing.Point(531, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 93);
            this.button2.TabIndex = 12;
            this.button2.Text = "Beholder";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.Location = new System.Drawing.Point(531, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 93);
            this.button3.TabIndex = 13;
            this.button3.Text = "Solo Chess";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button4.Location = new System.Drawing.Point(351, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 93);
            this.button4.TabIndex = 14;
            this.button4.Text = "Chinese Crossword\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ticTacToeButton
            // 
            this.ticTacToeButton.BackColor = System.Drawing.Color.Crimson;
            this.ticTacToeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticTacToeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ticTacToeButton.Location = new System.Drawing.Point(12, 12);
            this.ticTacToeButton.Name = "ticTacToeButton";
            this.ticTacToeButton.Size = new System.Drawing.Size(120, 93);
            this.ticTacToeButton.TabIndex = 15;
            this.ticTacToeButton.Text = "Tic-Tac-Toe\r\n";
            this.ticTacToeButton.UseVisualStyleBackColor = false;
            this.ticTacToeButton.Click += new System.EventHandler(this.ticTacToeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Main menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenreChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ticTacToeButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mineButton);
            this.Controls.Add(this.crosswordButton);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.lockButton);
            this.Controls.Add(this.sequenceButton);
            this.Controls.Add(this.wordleButton);
            this.Controls.Add(this.rebusLetter);
            this.Controls.Add(this.sudokuButton);
            this.Name = "GenreChoice";
            this.Text = "GenreChoice";
            this.Load += new System.EventHandler(this.GenreChoice_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ticTacToeButton;

        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.Button rebusLetter;
        private System.Windows.Forms.Button wordleButton;
        private System.Windows.Forms.Button sequenceButton;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.Button crosswordButton;
        private System.Windows.Forms.Button mineButton;

        #endregion
    }
}