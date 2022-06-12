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
            this.cipherButton = new System.Windows.Forms.Button();
            this.mineButton = new System.Windows.Forms.Button();
            this.chessButton = new System.Windows.Forms.Button();
            this.JButton = new System.Windows.Forms.Button();
            this.sequenceButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sudokuButton
            // 
            this.sudokuButton.AutoSize = true;
            this.sudokuButton.BackColor = System.Drawing.Color.SlateBlue;
            this.sudokuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sudokuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sudokuButton.Location = new System.Drawing.Point(100, 180);
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.Size = new System.Drawing.Size(120, 100);
            this.sudokuButton.TabIndex = 4;
            this.sudokuButton.Text = "Судоку";
            this.sudokuButton.UseVisualStyleBackColor = false;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            // 
            // rebusLetter
            // 
            this.rebusLetter.AutoSize = true;
            this.rebusLetter.BackColor = System.Drawing.Color.IndianRed;
            this.rebusLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebusLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.rebusLetter.Location = new System.Drawing.Point(270, 60);
            this.rebusLetter.Name = "rebusLetter";
            this.rebusLetter.Size = new System.Drawing.Size(120, 100);
            this.rebusLetter.TabIndex = 2;
            this.rebusLetter.Text = "Ребусы";
            this.rebusLetter.UseVisualStyleBackColor = false;
            this.rebusLetter.Click += new System.EventHandler(this.rebusLetter_Click);
            // 
            // cipherButton
            // 
            this.cipherButton.AutoSize = true;
            this.cipherButton.BackColor = System.Drawing.Color.Magenta;
            this.cipherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cipherButton.Location = new System.Drawing.Point(440, 180);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(120, 100);
            this.cipherButton.TabIndex = 6;
            this.cipherButton.Text = "Шифр";
            this.cipherButton.UseVisualStyleBackColor = false;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // mineButton
            // 
            this.mineButton.AutoSize = true;
            this.mineButton.BackColor = System.Drawing.Color.Cyan;
            this.mineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mineButton.Location = new System.Drawing.Point(100, 60);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(120, 100);
            this.mineButton.TabIndex = 1;
            this.mineButton.Text = "Сапер";
            this.mineButton.UseVisualStyleBackColor = false;
            this.mineButton.Click += new System.EventHandler(this.mineButton_Click);
            // 
            // chessButton
            // 
            this.chessButton.BackColor = System.Drawing.Color.CadetBlue;
            this.chessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.chessButton.Location = new System.Drawing.Point(440, 60);
            this.chessButton.Name = "chessButton";
            this.chessButton.Size = new System.Drawing.Size(120, 100);
            this.chessButton.TabIndex = 3;
            this.chessButton.Text = "Одиночные шахматы";
            this.chessButton.UseVisualStyleBackColor = false;
            this.chessButton.Click += new System.EventHandler(this.soloChess_Click);
            // 
            // JButton
            // 
            this.JButton.BackColor = System.Drawing.Color.Gold;
            this.JButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.JButton.Location = new System.Drawing.Point(270, 180);
            this.JButton.Name = "JButton";
            this.JButton.Size = new System.Drawing.Size(120, 100);
            this.JButton.TabIndex = 5;
            this.JButton.Text = "Японский кроссворд";
            this.JButton.UseVisualStyleBackColor = false;
            this.JButton.Click += new System.EventHandler(this.japanCrossword_Click);
            // 
            // sequenceButton
            // 
            this.sequenceButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sequenceButton.BackColor = System.Drawing.Color.Sienna;
            this.sequenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sequenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sequenceButton.Location = new System.Drawing.Point(553, 356);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(84, 43);
            this.sequenceButton.TabIndex = 6;
            this.sequenceButton.Text = "Выход";
            this.sequenceButton.UseVisualStyleBackColor = false;
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            this.sequenceButton.MouseEnter += new System.EventHandler(this.sequenceButton_MouseEnter);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(655, 356);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 43);
            this.exit.TabIndex = 0;
            this.exit.Text = "Главное меню";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // GenreChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 415);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.JButton);
            this.Controls.Add(this.chessButton);
            this.Controls.Add(this.mineButton);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.sequenceButton);
            this.Controls.Add(this.rebusLetter);
            this.Controls.Add(this.sudokuButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "GenreChoice";
            this.Load += new System.EventHandler(this.GenreChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button exit;
        
        private System.Windows.Forms.Button chessButton;
        private System.Windows.Forms.Button JButton;

        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.Button rebusLetter;
        private System.Windows.Forms.Button sequenceButton;
        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.Button mineButton;

        #endregion
    }
}