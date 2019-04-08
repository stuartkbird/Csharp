using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_s_and_X_s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Player turn;
        private bool resolved;

        public enum Player
        {
            X,O
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            //New Game
            resolved = false;
            //For simplicity X always starts first
            turn = Player.X;
            //Update the board
            labelTurn.Text = "Turn = X";

            //Add some colour coding to the form
            //winner is green, loser is red, draw is blue
            if (Convert.ToInt32(labelXScore.Text) < Convert.ToInt32(labelOScore.Text))
            {
                labelXScore.ForeColor = Color.Red;
                labelOScore.ForeColor = Color.Green;
            }

            else if (Convert.ToInt32(labelXScore.Text) > Convert.ToInt32(labelOScore.Text))
            {
                labelXScore.ForeColor = Color.Green;
                labelOScore.ForeColor = Color.Red;
            }

            else if (labelXScore.Text == labelOScore.Text)
            {
                labelXScore.ForeColor = Color.Blue;
                labelOScore.ForeColor = Color.Blue;
            }

            //Clear the board
            TopLeft.Text = "";
            TopCenter.Text = "";
            TopRight.Text = "";
            CenterLeft.Text = "";
            CenterCenter.Text = "";
            CenterRight.Text = "";
            BottomLeft.Text = "";
            BottomCenter.Text = "";
            BottomRight.Text = "";
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void XOButtonClicked(System.Object sender, System.EventArgs e)
        {
            /*This function should be called by each of the XO buttons
             * To do so, open the form in design mode and select a button
             * Then look in the properties window and switch from properties to events (button looks like a bolt of lightning)
             * Find the Click event and set it to this function (you will see a list of functions with a compatible signature)
             * or double click it to generate a new function with the correct signature
             * All we are doing here is checking whether the button has already been clicked, and if not it updates it with a "X" or "O"
             */
            if (!resolved)
            {
                if (String.IsNullOrEmpty(((Button)sender).Text))
                {
                    string newText = String.Empty;
                    string nextTurn = String.Empty;
                    /*A switch will allow alternate code blocks to be run depending on the result of an expression
                     * The expression to be evaluated here is the turn variable
                     * Therefore, different blocks of code will be executed depending on whose turn it is
                     * Switches can be better than nested IF ELSE IF logic, but be careful not to duplicate code
                     * In this example I declare the strings above, use the switch to populate them and then do something 
                     * with the values after the switch
                     */
                    switch (turn)
                    {
                        case Player.X:
                            newText = "X";
                            turn = Player.O;
                            nextTurn = "Turn = O";
                            break;
                        case Player.O:
                            newText = "O";
                            turn = Player.X;
                            nextTurn = "Turn = X";
                            break;
                        default:
                            break;
                    }
                    /*When this function is executed, a reference to the sender is passed as an argument
                     * We already know that the sender is a Button, so (Button) sender will expose exactly which button was pressed
                     * The line below demonstrates this
                     */
                            ((Button)sender).Text = newText;
                            labelTurn.Text = nextTurn;
                            //Did the player just win the game?
                            Check();
                    

                    
                }
            }
        }
        private void Check()
        {
            //Check HORIZONTAL lines for winner
            if (TopLeft.Text == "X" & TopCenter.Text == "X" & TopRight.Text == "X") XWins();
            if (CenterLeft.Text == "X" & CenterCenter.Text == "X" & CenterRight.Text == "X") XWins();
            if (BottomLeft.Text == "X" & BottomCenter.Text == "X" & BottomRight.Text == "X") XWins();
            if (TopLeft.Text == "O" & TopCenter.Text == "O" & TopRight.Text == "O") OWins();
            if (CenterLeft.Text == "O" & CenterCenter.Text == "O" & CenterRight.Text == "O") OWins();
            if (BottomLeft.Text == "O" & BottomCenter.Text == "O" & BottomRight.Text == "O") OWins();

            //Check VERTICAL lines for winner
            if (TopLeft.Text == "X" & CenterLeft.Text == "X" & BottomLeft.Text == "X") XWins();
            if (TopCenter.Text == "X" & CenterCenter.Text == "X" & BottomCenter.Text == "X") XWins();
            if (TopRight.Text == "X" & CenterRight.Text == "X" & BottomRight.Text == "X") XWins();
            if (TopLeft.Text == "O" & CenterLeft.Text == "O" & BottomLeft.Text == "O") OWins();
            if (TopCenter.Text == "O" & CenterCenter.Text == "O" & BottomCenter.Text == "O") OWins();
            if (TopRight.Text == "O" & CenterRight.Text == "O" & BottomRight.Text == "O") OWins();

            //Check DIAGONAL lines for winner
            if (TopLeft.Text == "X" & CenterCenter.Text == "X" & BottomRight.Text == "X") XWins();
            if (TopRight.Text == "X" & CenterCenter.Text == "X" & BottomLeft.Text == "X") XWins();
            if (TopLeft.Text == "O" & CenterCenter.Text == "O" & BottomRight.Text == "O") OWins();
            if (TopRight.Text == "O" & CenterCenter.Text == "O" & BottomLeft.Text == "O") OWins();
        }

        private void XWins()
        {
            /*This is what happens when X wins the game
             * Adds 1 to the scoreboard and updates the board
             * Depending on how much the player is winning by, you get a different message
             */
            var score = Convert.ToInt32(labelXScore.Text);
            score++; //increment the score by 1

            labelXScore.Text = score.ToString();
            resolved = true;

            if (Convert.ToInt32(labelXScore.Text) - Convert.ToInt32(labelOScore.Text) > 3)
                labelTurn.Text = "O Sucks!";
            else
                labelTurn.Text = "X Wins!";
        }

        private void OWins()
        {
            //If O wins
            var score = Convert.ToInt32(labelOScore.Text);
            score++; //increment the score by 1

            labelOScore.Text = score.ToString();
            resolved = true;

            if (Convert.ToInt32(labelOScore.Text) - Convert.ToInt32(labelXScore.Text) > 3)
                labelTurn.Text = "X Sucks!";
            else
                labelTurn.Text = "O Wins!";
        }
    }
}
