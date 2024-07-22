namespace Project
{
    partial class mainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameStart = new System.Windows.Forms.Button();
            this.controls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.bd33f119b3d068eb322012e5bc0c109c;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gameStart
            // 
            this.gameStart.Location = new System.Drawing.Point(110, 60);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(130, 42);
            this.gameStart.TabIndex = 1;
            this.gameStart.Text = "START";
            this.gameStart.UseVisualStyleBackColor = true;
            this.gameStart.Click += new System.EventHandler(this.loadGame);
            // 
            // controls
            // 
            this.controls.Location = new System.Drawing.Point(110, 136);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(130, 40);
            this.controls.TabIndex = 2;
            this.controls.Text = "HOW TO PLAY";
            this.controls.UseVisualStyleBackColor = true;
            this.controls.Click += new System.EventHandler(this.howTo);
            // 
            // mainMenu
            // 
            this.ClientSize = new System.Drawing.Size(354, 325);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private PictureBox pictureBox1;
        private Button gameStart;
        private Button controls;
    }
}