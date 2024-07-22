namespace Project
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.whitebox = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.GroupBox();
            this.lblretry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.whitebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // whitebox
            // 
            this.whitebox.Image = global::Project.Properties.Resources.whitebox;
            this.whitebox.Location = new System.Drawing.Point(32, 141);
            this.whitebox.Name = "whitebox";
            this.whitebox.Size = new System.Drawing.Size(45, 45);
            this.whitebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.whitebox.TabIndex = 0;
            this.whitebox.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::Project.Properties.Resources.rainbow;
            this.enemy1.Location = new System.Drawing.Point(415, 38);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(89, 78);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::Project.Properties.Resources.rainbow;
            this.enemy3.Location = new System.Drawing.Point(290, 305);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(91, 74);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 2;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::Project.Properties.Resources.rainbow;
            this.enemy2.Location = new System.Drawing.Point(515, 159);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(81, 76);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scoreText.Location = new System.Drawing.Point(179, 414);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 30);
            this.scoreText.TabIndex = 5;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ground.Location = new System.Drawing.Point(0, 414);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(654, 68);
            this.ground.TabIndex = 6;
            this.ground.TabStop = false;
            this.ground.Visible = false;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainMenu.ForeColor = System.Drawing.Color.Gray;
            this.mainMenu.Location = new System.Drawing.Point(69, 22);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(154, 96);
            this.mainMenu.TabIndex = 9;
            this.mainMenu.Text = "Return to main menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Visible = false;
            this.mainMenu.Click += new System.EventHandler(this.back1);
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.highscore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highscore.Location = new System.Drawing.Point(532, 414);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(0, 30);
            this.highscore.TabIndex = 10;
            this.highscore.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.bd33f119b3d068eb322012e5bc0c109c;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menu.Controls.Add(this.lblretry);
            this.menu.Controls.Add(this.mainMenu);
            this.menu.Location = new System.Drawing.Point(209, 86);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(295, 235);
            this.menu.TabIndex = 15;
            this.menu.TabStop = false;
            this.menu.Text = "MENU";
            this.menu.Visible = false;
            // 
            // lblretry
            // 
            this.lblretry.AutoSize = true;
            this.lblretry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblretry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblretry.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblretry.ForeColor = System.Drawing.Color.Gray;
            this.lblretry.Location = new System.Drawing.Point(81, 148);
            this.lblretry.Name = "lblretry";
            this.lblretry.Size = new System.Drawing.Size(136, 52);
            this.lblretry.TabIndex = 10;
            this.lblretry.Text = "RETRY";
            this.lblretry.Visible = false;
            this.lblretry.Click += new System.EventHandler(this.retry);
            // 
            // GameScreen
            // 
            this.ClientSize = new System.Drawing.Size(707, 442);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.whitebox);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ground);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sd";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.whitebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private PictureBox whitebox;
        private PictureBox enemy1;
        private PictureBox enemy3;
        private PictureBox enemy2;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
        private PictureBox ground;
        private Button mainMenu;
        private Label highscore;
        private PictureBox pictureBox1;
        private GroupBox menu;
        private Label lblretry;
    }
}