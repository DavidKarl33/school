using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
        }
        
        int enemySpeed = 8;
        int score = 0;
        int whiteboxspeed = 7;
        int highScore;
        bool goLeft, goRight, goDown, goUp; // controls
        Random numGen = new Random(); // random generator
        private void gameTimerEvent(object sender, EventArgs e)
        {
           
            scoreText.Text = "Score: " + score;  //display score

            if (goLeft) 
            {
                whitebox.Left -= whiteboxspeed; // speed to left -=
            }
            if (goRight)
            {
                whitebox.Left += whiteboxspeed; // speed to right +=
            }
            if (goUp)
            {
                whitebox.Top -= whiteboxspeed; // speed to top -=
            }
            if (goDown)
            {
                whitebox.Top += whiteboxspeed; // speed to bot +=
            }

            // yung bilis ng enemy pag punta sa LEFT
            enemy1.Left -= enemySpeed;
            enemy2.Left -= enemySpeed;
            enemy3.Left -= enemySpeed;
            

            if (enemy1.Left < -50) // pag lumampas ng -50 Left ng form 
            {
                enemy1.Left = 700; // mag rerespawn ulit sa 700 ng left 
                score++;
            }
            if (enemy2.Left < -190) 
            {
                enemy2.Left = 900;
                score++;
            }
            if (enemy3.Left < -400)
            {
                enemy3.Left = 1100;
                score++;
            }
            if (score > 5) // pag mas mtaas sa 5 yung score 
            {
                enemySpeed = 15; // bibilis yung enemy
                whiteboxspeed = 15; // bibilis whitebox

            }
            if (score > 30) //same
            {
                enemySpeed = 30;//same
                whiteboxspeed = 30;//same
            }
            

            if (whitebox.Bounds.IntersectsWith(enemy1.Bounds) || whitebox.Bounds.IntersectsWith(enemy2.Bounds) ||
               whitebox.Bounds.IntersectsWith(enemy3.Bounds) || whitebox.Top < -25 || whitebox.Bounds.IntersectsWith(ground.Bounds) 
               || whitebox.Left < -25 || whitebox.Right < 10) // pag tumama sa enemy 1 2 3 = .Bounds.IntersecsWith 
             {
                GameOver(); // mag ge GameOver
            }



        }

        private void keyDown(object sender, KeyEventArgs e) // Controls pag pinindot yung A D W S mag momove yung whitebox 
                                                            // depends sa value ng whiteboxspeed sa gameTimerEvent
        {                                                   

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = true;
            }

        }
        private void keyUp(object sender, KeyEventArgs e) // pag nirelease sa pag kakapindot A D W S titigil yung whitebox
        {                                                   

            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }
        }

        private void retry(object sender, EventArgs e) // pag click ng label retry mapapaltan ang value 
        {
            whitebox.Left = 15; // respawn yung whitebox/player sa Left 15 ng form
            whitebox.Top = numGen.Next(50, 100);// respawn yung whitebox sa Top 50 to 100 ng form
            whiteboxspeed = 8; // binalik yung speed sa 8 by default speed
            score = 0; // balik 0 score
            enemySpeed = 8;// balik sa default speed
            enemy1.Left = numGen.Next(300, 500); // enemy spawn 300 to 500 sa form
            enemy2.Left = numGen.Next(750, 1000); // enemy spawn 750 to 1000 sa form
            enemy3.Left = numGen.Next(1100, 1300); // enemy spawn 1100 to 1300 sa form
            gameTimer.Start(); // mag start yung game
            mainMenu.Visible = false; // hide main menu
            lblretry.Visible = false; // hide retry 
            menu.Visible = false; // hide menu
        }

        

        public void back1(object sender, EventArgs e)
        {
            mainMenu mainmenu = new mainMenu(); 
            mainmenu.Show(); 
            this.Hide(); 
        }

        

        private void GameOver()
        {

            gameTimer.Stop(); // end game
            scoreText.Text = "Game Over! Your Final Score: " + score;
            mainMenu.Visible= true;
            highscore.Visible = true;
            lblretry.Visible = true;
            menu.Visible = true;
            if (score > highScore) // pag mas mataas yung score sa highscore 
            {
                highScore = score; // magiging highscore yung score
                highscore.Text = "High Score: " + highScore;
            }
        }
        
        

      
    }
}
