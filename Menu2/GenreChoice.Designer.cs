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
            this.sequenceButton = new System.Windows.Forms.Button();
            this.cipherButton = new System.Windows.Forms.Button();
            this.mineButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sudokuButton
            // 
            this.sudokuButton.BackColor = System.Drawing.Color.Chocolate;
            this.sudokuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sudokuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sudokuButton.Location = new System.Drawing.Point(280, 61);
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.Size = new System.Drawing.Size(160, 120);
            this.sudokuButton.TabIndex = 3;
            this.sudokuButton.Text = "Судоку";
            this.sudokuButton.UseVisualStyleBackColor = false;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            // 
            // rebusLetter
            // 
            this.rebusLetter.BackColor = System.Drawing.Color.IndianRed;
            this.rebusLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rebusLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.rebusLetter.Location = new System.Drawing.Point(280, 218);
            this.rebusLetter.Name = "rebusLetter";
            this.rebusLetter.Size = new System.Drawing.Size(160, 120);
            this.rebusLetter.TabIndex = 4;
            this.rebusLetter.Text = "Ребус";
            this.rebusLetter.UseVisualStyleBackColor = false;
            this.rebusLetter.Click += new System.EventHandler(this.rebusLetter_Click);
            // 
            // sequenceButton
            // 
            this.sequenceButton.BackColor = System.Drawing.Color.Sienna;
            this.sequenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sequenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.sequenceButton.Location = new System.Drawing.Point(600, 370);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(72, 46);
            this.sequenceButton.TabIndex = 6;
            this.sequenceButton.Text = "Выход";
            this.sequenceButton.UseVisualStyleBackColor = false;
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            this.sequenceButton.MouseEnter += new System.EventHandler(this.sequenceButton_MouseEnter);
            // 
            // cipherButton
            // 
            this.cipherButton.BackColor = System.Drawing.Color.SlateBlue;
            this.cipherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cipherButton.Location = new System.Drawing.Point(81, 218);
            this.cipherButton.Name = "cipherButton";
            this.cipherButton.Size = new System.Drawing.Size(160, 120);
            this.cipherButton.TabIndex = 8;
            this.cipherButton.Text = "Шифр";
            this.cipherButton.UseVisualStyleBackColor = false;
            this.cipherButton.Click += new System.EventHandler(this.cipherButton_Click);
            // 
            // mineButton
            // 
            this.mineButton.BackColor = System.Drawing.Color.LimeGreen;
            this.mineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mineButton.Location = new System.Drawing.Point(81, 61);
            this.mineButton.Name = "mineButton";
            this.mineButton.Size = new System.Drawing.Size(160, 120);
            this.mineButton.TabIndex = 10;
            this.mineButton.Text = "Сапёр";
            this.mineButton.UseVisualStyleBackColor = false;
            this.mineButton.Click += new System.EventHandler(this.mineButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button3.Location = new System.Drawing.Point(475, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 120);
            this.button3.TabIndex = 13;
            this.button3.Text = "Соло Шахматы";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.soloChess_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button4.Location = new System.Drawing.Point(475, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 120);
            this.button4.TabIndex = 14;
            this.button4.Text = "Японский кроссворд";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.japanCrossword_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.Location = new System.Drawing.Point(695, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Меню";
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mineButton);
            this.Controls.Add(this.cipherButton);
            this.Controls.Add(this.sequenceButton);
            this.Controls.Add(this.rebusLetter);
            this.Controls.Add(this.sudokuButton);
            this.Name = "GenreChoice";
            this.Text = "GenreChoice";
            this.Load += new System.EventHandler(this.GenreChoice_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.Button rebusLetter;
        private System.Windows.Forms.Button sequenceButton;
        private System.Windows.Forms.Button cipherButton;
        private System.Windows.Forms.Button mineButton;

        #endregion
    }
}