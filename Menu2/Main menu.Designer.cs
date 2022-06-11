namespace Menu2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton1 = new Menu2.RoundButton();
            this.roundButton2 = new Menu2.RoundButton();
            this.roundButton4 = new Menu2.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.label1.Image = ((System.Drawing.Image) (resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 141);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.roundButton1.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("roundButton1.BackgroundImage")));
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roundButton1.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonHighlightColor = System.Drawing.SystemColors.HotTrack;
            this.roundButton1.ButtonHighlightColor2 = System.Drawing.Color.SkyBlue;
            this.roundButton1.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton1.ButtonPressedColor = System.Drawing.Color.Navy;
            this.roundButton1.ButtonPressedColor2 = System.Drawing.Color.Navy;
            this.roundButton1.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton1.ButtonRoundRadius = 60;
            this.roundButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.roundButton1.ForeColor = System.Drawing.Color.Black;
            this.roundButton1.Location = new System.Drawing.Point(231, 180);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(212, 125);
            this.roundButton1.TabIndex = 7;
            this.roundButton1.Text = "Играть!";
            this.roundButton1.Click += new System.EventHandler(this.SwitchMenu);
            // 
            // roundButton2
            // 
            this.roundButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton2.BackColor = System.Drawing.Color.YellowGreen;
            this.roundButton2.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton2.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonHighlightColor = System.Drawing.Color.YellowGreen;
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.Color.YellowGreen;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.DarkGreen;
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.DarkGreen;
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonRoundRadius = 30;
            this.roundButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.roundButton2.Location = new System.Drawing.Point(231, 330);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(115, 50);
            this.roundButton2.TabIndex = 8;
            this.roundButton2.Text = "Авторы";
            this.roundButton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roundButton4.BackColor = System.Drawing.Color.Gainsboro;
            this.roundButton4.BackColor2 = System.Drawing.Color.Silver;
            this.roundButton4.ButtonBorderColor = System.Drawing.Color.Black;
            this.roundButton4.ButtonHighlightColor = System.Drawing.Color.Empty;
            this.roundButton4.ButtonHighlightColor2 = System.Drawing.Color.Empty;
            this.roundButton4.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton4.ButtonPressedColor = System.Drawing.Color.Empty;
            this.roundButton4.ButtonPressedColor2 = System.Drawing.Color.Empty;
            this.roundButton4.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton4.ButtonRoundRadius = 30;
            this.roundButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.roundButton4.Location = new System.Drawing.Point(352, 330);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(91, 50);
            this.roundButton4.TabIndex = 10;
            this.roundButton4.Text = "Выход";
            this.roundButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private Menu2.RoundButton roundButton4;

        private Menu2.RoundButton roundButton2;

        private Menu2.RoundButton roundButton1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}