namespace Dice_game
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
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.Dice3 = new System.Windows.Forms.PictureBox();
            this.Dice4 = new System.Windows.Forms.PictureBox();
            this.Dice5 = new System.Windows.Forms.PictureBox();
            this.Dice6 = new System.Windows.Forms.PictureBox();
            this.Diceshow1 = new System.Windows.Forms.PictureBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.Diceshow2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diceshow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diceshow2)).BeginInit();
            this.SuspendLayout();
            // 
            // Dice1
            // 
            this.Dice1.Image = ((System.Drawing.Image)(resources.GetObject("Dice1.Image")));
            this.Dice1.Location = new System.Drawing.Point(24, 12);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(100, 88);
            this.Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice1.TabIndex = 0;
            this.Dice1.TabStop = false;
            this.Dice1.Visible = false;
            // 
            // Dice2
            // 
            this.Dice2.Image = ((System.Drawing.Image)(resources.GetObject("Dice2.Image")));
            this.Dice2.Location = new System.Drawing.Point(145, 12);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(100, 88);
            this.Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice2.TabIndex = 1;
            this.Dice2.TabStop = false;
            this.Dice2.Visible = false;
            // 
            // Dice3
            // 
            this.Dice3.Image = ((System.Drawing.Image)(resources.GetObject("Dice3.Image")));
            this.Dice3.Location = new System.Drawing.Point(267, 12);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(100, 88);
            this.Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice3.TabIndex = 2;
            this.Dice3.TabStop = false;
            this.Dice3.Visible = false;
            // 
            // Dice4
            // 
            this.Dice4.Image = ((System.Drawing.Image)(resources.GetObject("Dice4.Image")));
            this.Dice4.Location = new System.Drawing.Point(387, 12);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(100, 88);
            this.Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice4.TabIndex = 3;
            this.Dice4.TabStop = false;
            this.Dice4.Visible = false;
            // 
            // Dice5
            // 
            this.Dice5.Image = ((System.Drawing.Image)(resources.GetObject("Dice5.Image")));
            this.Dice5.Location = new System.Drawing.Point(506, 12);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(100, 88);
            this.Dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice5.TabIndex = 4;
            this.Dice5.TabStop = false;
            this.Dice5.Visible = false;
            // 
            // Dice6
            // 
            this.Dice6.Image = ((System.Drawing.Image)(resources.GetObject("Dice6.Image")));
            this.Dice6.Location = new System.Drawing.Point(625, 12);
            this.Dice6.Name = "Dice6";
            this.Dice6.Size = new System.Drawing.Size(100, 88);
            this.Dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dice6.TabIndex = 5;
            this.Dice6.TabStop = false;
            this.Dice6.Visible = false;
            // 
            // Diceshow1
            // 
            this.Diceshow1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Diceshow1.Location = new System.Drawing.Point(24, 121);
            this.Diceshow1.Name = "Diceshow1";
            this.Diceshow1.Size = new System.Drawing.Size(221, 208);
            this.Diceshow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diceshow1.TabIndex = 6;
            this.Diceshow1.TabStop = false;
            // 
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.ForeColor = System.Drawing.Color.Green;
            this.cmdStart.Location = new System.Drawing.Point(305, 366);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(129, 39);
            this.cmdStart.TabIndex = 9;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Magneto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdExit.Location = new System.Drawing.Point(331, 421);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 32);
            this.cmdExit.TabIndex = 10;
            this.cmdExit.Text = "&Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // Diceshow2
            // 
            this.Diceshow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Diceshow2.Location = new System.Drawing.Point(504, 121);
            this.Diceshow2.Name = "Diceshow2";
            this.Diceshow2.Size = new System.Drawing.Size(221, 208);
            this.Diceshow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Diceshow2.TabIndex = 11;
            this.Diceshow2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(740, 480);
            this.Controls.Add(this.Diceshow2);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.Diceshow1);
            this.Controls.Add(this.Dice6);
            this.Controls.Add(this.Dice5);
            this.Controls.Add(this.Dice4);
            this.Controls.Add(this.Dice3);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diceshow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diceshow2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.PictureBox Dice3;
        private System.Windows.Forms.PictureBox Dice4;
        private System.Windows.Forms.PictureBox Dice5;
        private System.Windows.Forms.PictureBox Dice6;
        private System.Windows.Forms.PictureBox Diceshow1;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.PictureBox Diceshow2;
    }
}

