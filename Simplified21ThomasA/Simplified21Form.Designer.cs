namespace Simplified21ThomasA
{
    partial class frmSimplified21
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picPlayerCardOne = new System.Windows.Forms.PictureBox();
            this.picPlayerCardTwo = new System.Windows.Forms.PictureBox();
            this.picPlayerCardThree = new System.Windows.Forms.PictureBox();
            this.picComputerCardOne = new System.Windows.Forms.PictureBox();
            this.picComputerCardTwo = new System.Windows.Forms.PictureBox();
            this.picComputerCardThree = new System.Windows.Forms.PictureBox();
            this.lblComputerSum = new System.Windows.Forms.Label();
            this.lblPlayerSum = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.picStay = new System.Windows.Forms.PictureBox();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStay)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1327, 24);
            this.mnuMainMenu.TabIndex = 0;
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mniFile.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniNewGame
            // 
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(132, 22);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.mniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(132, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGreeting.Location = new System.Drawing.Point(538, 45);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(344, 44);
            this.lblGreeting.TabIndex = 1;
            this.lblGreeting.Text = "Welcome to Black Jack!";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(665, 307);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picPlayerCardOne
            // 
            this.picPlayerCardOne.Location = new System.Drawing.Point(467, 420);
            this.picPlayerCardOne.Name = "picPlayerCardOne";
            this.picPlayerCardOne.Size = new System.Drawing.Size(97, 162);
            this.picPlayerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCardOne.TabIndex = 3;
            this.picPlayerCardOne.TabStop = false;
            // 
            // picPlayerCardTwo
            // 
            this.picPlayerCardTwo.Location = new System.Drawing.Point(670, 420);
            this.picPlayerCardTwo.Name = "picPlayerCardTwo";
            this.picPlayerCardTwo.Size = new System.Drawing.Size(97, 162);
            this.picPlayerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCardTwo.TabIndex = 4;
            this.picPlayerCardTwo.TabStop = false;
            // 
            // picPlayerCardThree
            // 
            this.picPlayerCardThree.Location = new System.Drawing.Point(877, 420);
            this.picPlayerCardThree.Name = "picPlayerCardThree";
            this.picPlayerCardThree.Size = new System.Drawing.Size(97, 162);
            this.picPlayerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCardThree.TabIndex = 5;
            this.picPlayerCardThree.TabStop = false;
            this.picPlayerCardThree.Click += new System.EventHandler(this.picPlayerCardThree_Click);
            // 
            // picComputerCardOne
            // 
            this.picComputerCardOne.Location = new System.Drawing.Point(467, 27);
            this.picComputerCardOne.Name = "picComputerCardOne";
            this.picComputerCardOne.Size = new System.Drawing.Size(97, 162);
            this.picComputerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputerCardOne.TabIndex = 6;
            this.picComputerCardOne.TabStop = false;
            // 
            // picComputerCardTwo
            // 
            this.picComputerCardTwo.Location = new System.Drawing.Point(670, 27);
            this.picComputerCardTwo.Name = "picComputerCardTwo";
            this.picComputerCardTwo.Size = new System.Drawing.Size(97, 162);
            this.picComputerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputerCardTwo.TabIndex = 7;
            this.picComputerCardTwo.TabStop = false;
            // 
            // picComputerCardThree
            // 
            this.picComputerCardThree.Location = new System.Drawing.Point(877, 27);
            this.picComputerCardThree.Name = "picComputerCardThree";
            this.picComputerCardThree.Size = new System.Drawing.Size(97, 162);
            this.picComputerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputerCardThree.TabIndex = 8;
            this.picComputerCardThree.TabStop = false;
            // 
            // lblComputerSum
            // 
            this.lblComputerSum.AutoSize = true;
            this.lblComputerSum.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerSum.Location = new System.Drawing.Point(1006, 95);
            this.lblComputerSum.Name = "lblComputerSum";
            this.lblComputerSum.Size = new System.Drawing.Size(166, 26);
            this.lblComputerSum.TabIndex = 10;
            this.lblComputerSum.Text = "Computer\'s Score: ";
            // 
            // lblPlayerSum
            // 
            this.lblPlayerSum.AutoSize = true;
            this.lblPlayerSum.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerSum.Location = new System.Drawing.Point(1006, 479);
            this.lblPlayerSum.Name = "lblPlayerSum";
            this.lblPlayerSum.Size = new System.Drawing.Size(135, 26);
            this.lblPlayerSum.TabIndex = 11;
            this.lblPlayerSum.Text = "Player\'s Score: ";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(126, 301);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(233, 44);
            this.lblResults.TabIndex = 12;
            this.lblResults.Text = "The Winner is: ";
            // 
            // picStay
            // 
            this.picStay.Image = global::Simplified21ThomasA.Properties.Resources.Stay;
            this.picStay.Location = new System.Drawing.Point(892, 353);
            this.picStay.Name = "picStay";
            this.picStay.Size = new System.Drawing.Size(71, 29);
            this.picStay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStay.TabIndex = 13;
            this.picStay.TabStop = false;
            this.picStay.Click += new System.EventHandler(this.picStay_Click);
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.AutoSize = true;
            this.lblComputerWins.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.Location = new System.Drawing.Point(12, 123);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(134, 22);
            this.lblComputerWins.TabIndex = 14;
            this.lblComputerWins.Text = "Computer Wins: 0";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(12, 167);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(108, 22);
            this.lblPlayerWins.TabIndex = 15;
            this.lblPlayerWins.Text = "Player Wins: 0";
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simplified21ThomasA.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1327, 620);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.picStay);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblPlayerSum);
            this.Controls.Add(this.lblComputerSum);
            this.Controls.Add(this.picComputerCardThree);
            this.Controls.Add(this.picComputerCardTwo);
            this.Controls.Add(this.picComputerCardOne);
            this.Controls.Add(this.picPlayerCardThree);
            this.Controls.Add(this.picPlayerCardTwo);
            this.Controls.Add(this.picPlayerCardOne);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 By Thomas Aubin";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputerCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picPlayerCardOne;
        private System.Windows.Forms.PictureBox picPlayerCardTwo;
        private System.Windows.Forms.PictureBox picPlayerCardThree;
        private System.Windows.Forms.PictureBox picComputerCardOne;
        private System.Windows.Forms.PictureBox picComputerCardTwo;
        private System.Windows.Forms.PictureBox picComputerCardThree;
        private System.Windows.Forms.Label lblComputerSum;
        private System.Windows.Forms.Label lblPlayerSum;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.PictureBox picStay;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label lblPlayerWins;
    }
}

