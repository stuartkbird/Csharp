using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game_Program
{
    /*
     * Simple Game
     * This program will allow the player to return a ball and continue to earn points
     * If the ball passes the paddle the player losees a point up to three times
     */

    public partial class frmSimpleGame : Form
    {
        int x;      // x is the positon on the x axis from the upper left corner
        int y;      // y is the positon on the y axis from the upper left corner
        int dx;     // speed is the change of x
        int dy;     // speed is the change of y
        int ptx;    // x coordinate of the paddle
        int pty;    // y coordinate of the paddle
        int score;  // how many times the ball hits the paddle
        int life;   // number of lives starting at 3


        public frmSimpleGame()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(frmSimpleGame_KeyDown);
        }

        private void frmSimpleGame_KeyDown(object sender, KeyEventArgs e)
        {
            int px = imgPaddle.Location.X;
            int py = imgPaddle.Location.Y;

            if (e.KeyCode == Keys.Right) px += 5;
            else if (e.KeyCode == Keys.Left) px -= 5;

            if (px < 0)
            {
                px = 0;
            }
            if (px > this.ClientSize.Width - 50)
            {
                px = this.ClientSize.Width - 50;
            }
            imgPaddle.Location = new Point(px, py);
        }


        private void frmSimpleGame_Load(object sender, EventArgs e)
        {
            // Loads the ball on the screen at the upper left corner of the window
            x = 1;      // x coordinate of the ball starting point
            y = 1;      // y coordinate of the ball starting point
            dx = 1;     // Speed of the ball in the x direction is 1
            dy = 1;     // Speed of the ball in the y direction is 1
            score = 0;  // The initial score is 0
            life = 3;   // The initial life is 3
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imgBall.Location = new Point(x, y);
            x = x + dx;
            if (x < 0)
            {
                dx = -dx; // if y is less than 0 then we change direction
            }
            else if (x + 10 > this.ClientSize.Width)
            {
                dx = -dx; // if y + 10, the radius of the circle is greater than the form height then we change direction
            }

            y = y + dy;
            if (y < 0)
            {
                dy = -dy; // if y is less than 0 then we change direction
            }

            // checks if the ball hits the paddle
            Point point1 = this.imgPaddle.Location;
            ptx = (point1.X);
            pty = (point1.Y);
            if (x >= ptx)
            {
                if (x <= (ptx + 50))
                {
                    if ((y + 10) > pty)
                    {
                        dy = -dy;
                        score = score + 1;
                        lblScore.Text = Convert.ToString(score);
                    }
                    //trying to increment ball speed after hitting paddle   if (x = x + dx == dx, dy - 1)
                    //{
                    //    dx = dx + 10;
                    //    dy = dy + 10;
                    //}
                }
            }

            // checks if the ball goes by the paddle imaginary line
            if ((y + 9) > pty)
            {
                life = life - 1;
                lblLife.Text = Convert.ToString(life);
                dx = 1;
                dy = 1;
                x = 1;
                y = 1;
            }

            // checks if the game is over
            if (life == 0)
            {
                lblGameOver.Text = "Game Over";
                x = -10;
                y = -10;

            }

            // refresh the window
            this.Invalidate();
        }

        private void imgBall_Click(object sender, EventArgs e)
        {

        }
    }
}
