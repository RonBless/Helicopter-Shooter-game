using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helicopter_game
{
    public partial class Form1 : Form
    {
        bool goUp; // this is a boolean to allow player to go up
        bool goDown; // this is a boolean to allow player to go down
        bool goRight; // this is a boolean to allow player to go right
        bool goLeft; // this is a boolean to allow player to go left
        bool shot = false; // this will check if the player has shot any bullets
        bool gameOver = false; //condition for restarting

        int score = 0; // this is a integer for player to keep score

        int pillarSpeed = 8; // this is the speed of obstacles 
        int ufoSpeed = 10;

        Random rand = new Random(); // this is the random class to generate a random number

        int playerSpeed = 9; // this interger will control how fast the player moves

        public Form1()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(gameOver == false)
            {
                if (e.KeyCode == Keys.Down)
                {
                    goDown = true;
                }
               else if (e.KeyCode == Keys.Up)
                {
                    goUp = true;
                }
                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                }
               else if (e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                }

                if (e.KeyCode == Keys.Space && shot == false)
                {
                    MakeBullet();
                    shot = true;
                }
            }
            else if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }   
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if the player has left the up key
                // change go up to false
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                // if the player has left the down key
                // change go down to false
                goDown = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                // if the player has left the Right key
                // change go down to false
                goRight = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                // if the player has left the Left key
                // change go down to false
                goLeft = false;
            }

            if (shot == true)
            {
                //if shot variable is true 
                // we change it false so the player will have to shoot again
                // for more bullet. 
                shot = false;
            }
        }

        private void GameTick(object sender, EventArgs e)
        {
            pillar1.Left -= pillarSpeed;
            pillar2.Left -= pillarSpeed;
            ufo.Left -= ufoSpeed;
            scoreTxt.Text = "Score: " + score;

            if (goUp && player.Top >= playerSpeed) //up + making sure we won't cross screen boundries 
            {
                // if go up is true then move the player up the screen
                // it will deduct from the top location
                player.Top -= playerSpeed;
            }
            else if (goDown && player.Top + player.Height < this.ClientSize.Height)//down + making sure we won't cross screen boundries 
            {
                player.Top += playerSpeed;
            }
            else if (goRight && player.Left + player.Width < this.ClientSize.Width)//right + making sure we won't cross screen boundries 
            {
                player.Left += playerSpeed;
             }
            else if (goLeft && player.Left >= playerSpeed)//left + making sure we won't cross screen boundries 
            {
                player.Left -= playerSpeed;
            }


            if (pillar1.Left < -150)
            {
                // pillar 1 continuous motion from right to left
                pillar1.Left = 900;
            }

            if (pillar2.Left < -150)
            {
                // pillar 2 continuous motion from right to left
                pillar2.Left = 1000;
            }

            //losing conditions check
            if (ufo.Left < -150
                || player.Bounds.IntersectsWith(ufo.Bounds)
                || player.Bounds.IntersectsWith(pillar1.Bounds)
                || player.Bounds.IntersectsWith(pillar2.Bounds))
            {
                GameOver();
            }

            // below is a for loop thats checking the components in this form
            // first we created a valiable called X in this form
            // x will be linked to the bullet object 
            // it will find out if the bullet object exist

            foreach (Control X in this.Controls)
            {

                // if X is a picture box object AND it has a tag of bullet
                // then we will follow the instructions within

                if (X is PictureBox && (string)X.Tag == "bullet")
                {
                    // move x towards the right of the screen
                    X.Left += 15;

                    // if x has left the screen towards the right
                    // x's location is greater than 900 pixels from the screen
                    if (X.Left > 900)
                    {
                        RemoveBullet((PictureBox)X);
                    }

                    // below we will check if X collides with the UFO object
                    if (X.Bounds.IntersectsWith(ufo.Bounds))
                    {
                        // is X collides with the UFO object

                        // add 1 to the score
                        score += 1;

                        RemoveBullet((PictureBox)X);


                        

                        // move the UFO object 1000 pixels off the screen
                        ufo.Left = 1000;

                        // generate a random vertical location for the UFO
                        ufo.Top = rand.Next(70, 551) - ufo.Height;
                        // run the change UFO function it appears like a different UFO
                        ChangeUfo();
                    }
                }
            }
        }


        private void ChangeUfo() //we will change the ufo image randomly
        {
            int index = rand.Next(1, 4);
            switch (index)
            {
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
            }
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            // create a new picture box class to the form

            bullet.BackColor = System.Drawing.Color.DarkOrange;
            // set the colour of the bullet to dark organge

            bullet.Height = 5;
            // set bullet height to 5 pixels

            bullet.Width = 10;
            // set bullet width to 10 pixels

            bullet.Left = player.Left + player.Width;
            // bullet will place in front of player object

            bullet.Top = player.Top + player.Height / 2;
            // bullet will be middle of player object

            bullet.Tag = "bullet";
            // set the tag for the object to bullet

            this.Controls.Add(bullet);
            // finally adding the picture box bullet to the scene
        }

        private void RemoveBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }

        private void GameOver()
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "bullet")
                {
                    RemoveBullet((PictureBox)X);

                }
            }
            scoreTxt.Text = "Your score: " + score + "\nPress Enter to start over";
            gameOver = true;
            gameTimer.Stop();
        }

        private void RestartGame()
        {

            // we will Reset all the values to thier starting point
            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
            shot = false;
            gameOver = false;
            score = 0;
            player.Top = 300;
            ufo.Left = 800;
            ufo.Top = 300;
            pillar1.Left = 450;
            pillar2.Left = 550;


            gameTimer.Start();

        }

    }
}

  

