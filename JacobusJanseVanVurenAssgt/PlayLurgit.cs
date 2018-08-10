using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace JacobusJanseVanVurenAssgt
{
    // Name: PlayLurgit     Date Created: 02/05/2018
    // Programmers: Francois Janse van Vuren, Jacobus Janse van Vuren
    // Purpose: A program that can play the Lurgit dice game. The game can be played as single player,
    // against another person or against the program itself.
    // Scores and statistics are shown at the end of every game and once the session is ended.

    public partial class PlayLurgit : Form
    {
        #region Instantiate Objects and Variables

        // Instantiate graphics objects
        private Graphics graDie;
        private Graphics graDie1;
        private Graphics graDie2;
        private Graphics graDie3;

        // Instantiate player objects
        private Player pPlayer1 = new Player();
        private Player pPlayer2 = new Player();

        // Instantiate computer player object
        private CompPlayer cComputer = new CompPlayer();

        // Instantiate die objects
        private Die dDie1 = new Die();
        private Die dDie2 = new Die();
        private Die dDie3 = new Die();

        // Instantiate the arraylist objects
        private ArrayList playerList = new ArrayList();
        private ArrayList dieList = new ArrayList();

        // Instantiate the random objects
        private Random rAnimation = new Random();       // Used to randomise animation length
        private Random rAnimationRoll = new Random();   // Used to randomise die roll animation
        private Random rand = new Random();             // Used to randomise die rolls
        private Random rComp = new Random();            // Used to randomise computers wait time between turns

        // Create variables
        private int iPlayerTurn;        // Keep track of player turns
        private int iRound;             // Keep track of current round number
        private int iRunningScore;      // Keep score between rounds for bonuses
        private int iPlayerCount;       // Amount of players playing game
        private bool bIsSinglePlayer;   // Check if game is single player or not
        private bool bPlayComputer;     // Check if the second player is the program/computer
        private int iCurrentPlayer;     // Keep track of who's turn it is

        #endregion

        public PlayLurgit()
        {
            InitializeComponent();

            #region Initialize Objects and variables
            // Create the three die graphics
            graDie1 = picbxDice1.CreateGraphics();
            graDie2 = picbxDice2.CreateGraphics();
            graDie3 = picbxDice3.CreateGraphics();

            // Add the two players to the playerList array list
            playerList.Add(pPlayer1);
            playerList.Add(pPlayer2);

            // Add the three dice to the dieList array list
            dieList.Add(dDie1);
            dieList.Add(dDie2);
            dieList.Add(dDie3);

            // Set default value for playerTurn, round number and player count variables
            iPlayerTurn = 1;
            iRound = 1;
            iPlayerCount = 1;

            // Set the die number for each die object
            dDie1.iDieNum = 1;
            dDie2.iDieNum = 2;
            dDie3.iDieNum = 3;
            #endregion
        }

        #region Private Methods

        private void setupNextRound(ref Player pCurrentPlayer, int iRunningScore)
        {
            // Used to setup the next round while the game is not over

            int iScoringNumber = iRound;    // Sets the current number to add to score
            int i;                          // Used as a counter
            bool bKept = false;             // Used to blank die faces

            // Add the bonus score to the players bonus score variable
            pCurrentPlayer.iBonusScore = pCurrentPlayer.iBonusScore + iRunningScore;

            // Loops for for every die in ArrayList
            foreach (Die d in dieList)
            {
                if (d.iDieRoll == iScoringNumber)
                {
                    iRunningScore = iRunningScore + iScoringNumber;
                    pCurrentPlayer.iRoundScore = pCurrentPlayer.iRoundScore + iScoringNumber;
                }
            }

            // Adds the current round score to the players game score total
            pCurrentPlayer.iGameScore = pCurrentPlayer.iGameScore + iRunningScore;

            // Resets the turn number for next round
            iPlayerTurn = 1;

            i = 1;
            // Loops for for every die in ArrayList
            foreach (Die d in dieList)
            {
                // Reset DiceKept values to default
                d.bDieKept = false;

                if (d.iDieNum == 1)
                {
                    graDie = graDie1;
                }
                else if (d.iDieNum == 2)
                {
                    graDie = graDie2;
                }
                else
                {
                    graDie = graDie3;
                }

                // Blanks out all die faces for next round
                d.draw(0, graDie, bKept);

                i++;
            }

            // Reset Die status labels to "Rolling"
            lblDieStatus1.Text = "Rolling";
            lblDieStatus2.Text = "Rolling";
            lblDieStatus3.Text = "Rolling";

            // Reset Keep buttons to "Keep"
            btnKeepDie1.Text = "Keep";
            btnKeepDie2.Text = "Keep";
            btnKeepDie3.Text = "Keep";

            // Zero the die for the next player/round
            dDie1.iDieRoll = 0;
            dDie2.iDieRoll = 0;
            dDie3.iDieRoll = 0;
        }

        private bool detectLurgit(int iRound)
        {
            // Used to check if player rolled a Lurgit Bonus

            // If all die are rolled and all the values match the round number the value is true
            bool bLurgit = dDie1.iDieRoll == iRound && dDie2.iDieRoll == iRound && dDie3.iDieRoll == iRound && !dDie1.bDieKept && !dDie2.bDieKept && !dDie3.bDieKept;

            return (bLurgit);
        }

        
        private bool detectSequence()
        {
            // Used to detect whether a sequence bonus has been rolled

            // If one die is not kept and all the die are in a consecutive sequence return true
            // Create an array of the dice values
            int[] iDieArray = new int[3] { dDie1.iDieRoll, dDie2.iDieRoll, dDie3.iDieRoll };

            // Sorts the array
            Array.Sort(iDieArray);

            // Check if they are in a consecutive sequence
            bool bSequence = iDieArray[1] == iDieArray[0] + 1 && iDieArray[1] == iDieArray[2] - 1 
                && (!dDie1.bDieKept || !dDie2.bDieKept || !dDie3.bDieKept);

            return (bSequence);

        }

        private void listSessionStats()
        {
            // Adds the players session stats to txbxDisplayMessage

            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer1.sName + "'s score: " + Convert.ToString(pPlayer1.iGameScore) + " points");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer2.sName + "'s score: " + Convert.ToString(pPlayer2.iGameScore) + " points");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer1.sName + "'s session score: " + Convert.ToString(pPlayer1.iSessionScore) + " points");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer2.sName + "'s session score: " + Convert.ToString(pPlayer2.iSessionScore) + " points");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer1.sName + " has played " + Convert.ToString(pPlayer1.iGamesPlayed) + " game/s.");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer2.sName + " has played " + Convert.ToString(pPlayer2.iGamesPlayed) + " game/s.");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer1.sName + " has won " + Convert.ToString(pPlayer1.iGamesWon) + " game/s.");
            txbxDisplayMessage.AppendText(Environment.NewLine);
            txbxDisplayMessage.AppendText(pPlayer2.sName + " has won " + Convert.ToString(pPlayer2.iGamesWon) + " game/s.");
        }

        private void endRound()
        {
            // Ends the round and sets up the next round depending on if the game is over or not

            iRound++;

            // Check if the game has ended and reset game scores
            if (iRound == 7)
            {
                if (bIsSinglePlayer)    // If it is a single player game
                {
                    //Add player's game score to player's session score
                    pPlayer1.iSessionScore = pPlayer1.iSessionScore + pPlayer1.iGameScore;

                    // Reset Players' bonus score and round score
                    pPlayer1.iBonusScore = 0;
                    pPlayer1.iRoundScore = 0;

                    //Add a game played for player
                    pPlayer1.iGamesPlayed++;
                    // Add a game won for the player
                    pPlayer1.iGamesWon++;

                    //Display message to the player
                    txbxDisplayMessage.Text = "Game Over!";
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("You Win! You will always win if you're the only player.");
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("Your final score was " + Convert.ToString(pPlayer1.iGameScore) + " points.");
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("Your Session score is: " + Convert.ToString(pPlayer1.iSessionScore) + " points.");
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("You have played " + Convert.ToString(pPlayer1.iGamesPlayed) + " game/s.");
                }
                else    // If it is a two player game
                {
                    //Add both players game scores to their session score
                    pPlayer1.iSessionScore = pPlayer1.iSessionScore + pPlayer1.iGameScore;
                    pPlayer2.iSessionScore = pPlayer2.iSessionScore + pPlayer2.iGameScore;

                    // Reset Players' bonus score and round score
                    pPlayer1.iBonusScore = 0;
                    pPlayer1.iRoundScore = 0;
                    pPlayer2.iBonusScore = 0;
                    pPlayer2.iRoundScore = 0;

                    //Add a game played to both players
                    pPlayer1.iGamesPlayed++;
                    pPlayer2.iGamesPlayed++;

                    if (pPlayer1.iGameScore > pPlayer2.iGameScore)  //If player 1 wins
                    {
                        //Add a game won to player 1
                        pPlayer1.iGamesWon++;

                        //Display message to the players
                        txbxDisplayMessage.Text = "Game Over!";
                        txbxDisplayMessage.AppendText(Environment.NewLine);
                        txbxDisplayMessage.AppendText(pPlayer1.sName + " wins.");
                        listSessionStats();
                    }
                    else if (pPlayer1.iGameScore == pPlayer2.iGameScore)    // If the game is a tie
                    {
                        //Add a game won to both players
                        pPlayer1.iGamesWon++;
                        pPlayer2.iGamesWon++;

                        //Display message to the players
                        txbxDisplayMessage.Text = "Game Over!";
                        txbxDisplayMessage.AppendText(Environment.NewLine);
                        txbxDisplayMessage.AppendText("The game was a tie.");
                        listSessionStats();
                    }
                    else    // If player 2 wins
                    {
                        //Add a game won to player 2
                        pPlayer2.iGamesWon++;

                        //Display message to the players
                        txbxDisplayMessage.Text = "Game Over!";
                        txbxDisplayMessage.AppendText(Environment.NewLine);
                        txbxDisplayMessage.AppendText(pPlayer2.sName + " wins.");
                        listSessionStats();
                    }
                }

                //Disable game buttons
                btnP1EndRound.Enabled = false;
                btnP2EndRound.Enabled = false;
                btnRoll.Enabled = false;
                btnKeepDie1.Enabled = false;
                btnKeepDie2.Enabled = false;
                btnKeepDie3.Enabled = false;

                //Enable the play again button
                btnPlayAgain.Enabled = true;
                btnPlayAgain.Visible = true;

                //Make the end session button visible
                btnEndSession.Visible = true;

                //Reset the round number
                iRound = 1;
                lblCurrentRound.Text = "Round: 1";

                //Reset the player scores
                pPlayer1.iGameScore = 0;
                pPlayer2.iGameScore = 0;

                // Blank out the score text boxes
                txbxPlayer1GameScore.Clear();
                txbxPlayer2GameScore.Clear();
                txbxBonusScoreP1.Clear();
                txbxBonusScoreP2.Clear();

                //Make the play again button visible
                btnPlayAgain.Visible = true;

                //Make the Current player round and turn labels invisible
                lblCurrentPlayer.Visible = false;
                lblCurrentRound.Visible = false;
                lblCurrentTurn.Visible = false;

                ActiveControl = btnPlayAgain;
            }
            else
            {
                txbxDisplayMessage.Text = "Player 1 It's your turn again!";

                // Enable Roll button
                btnRoll.Enabled = true;

                // Enable the keep buttons
                btnKeepDie1.Enabled = true;
                btnKeepDie2.Enabled = true;
                btnKeepDie3.Enabled = true;

                btnP1EndRound.Enabled = true;

                //Update the current round label
                string sCurrentRound = Convert.ToString(iRound);
                lblCurrentRound.Text = "Round: " + sCurrentRound;
            }

            // Reset the current turn lable text to 1
            lblCurrentTurn.Text = "Turn: 1";
        }

        private void rollDie(Die dDie)
        {
            // Sets the correct picture box for the die and calls the die's rollDie method
            // Only calls the die's rollDie method if die is not kept

            if (!dDie.bDieKept)
            {
                if (dDie.iDieNum == 1)
                {
                    graDie = graDie1;
                }
                else if (dDie.iDieNum == 2)
                {
                    graDie = graDie2;
                }
                else
                {
                    graDie = graDie3;
                }

                dDie.rollDie(graDie, rand, rAnimationRoll, rAnimation);
            }
        }
        #endregion

        #region Button Click Event Handlers

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Rolls selected die and accumulates score for the turn.

            bool bLurgit = false;
            bool bSequence = false;

            // Remove text from the bonus message label
            lblBonusMessage.Text = "";

            // Disable "Keep" buttons so that user cannot press during roll animation
            btnKeepDie1.Enabled = false;
            btnKeepDie2.Enabled = false;
            btnKeepDie3.Enabled = false;

            // Disable "Roll" button while a roll is taking place
            btnRoll.Enabled = false;

            //Clear the displayed message
            txbxDisplayMessage.Clear();

            if (iPlayerTurn <= 3)   // Checks if player still has a turn in the round
            {   
                // Execute the rollDie method for all dice as parallel operations
                Parallel.Invoke (() =>
                {
                    rollDie(dDie1);
                },
                () =>
                {
                    rollDie(dDie2);
                },
                () =>
                {
                    rollDie(dDie3);
                });

                // Detect Lurgit Bonus
                bLurgit = detectLurgit(iRound);
                if (bLurgit)
                {
                    iPlayerTurn = 4;
                    iRunningScore = iRunningScore + 20;
                    btnRoll.Enabled = false;
                    txbxDisplayMessage.Text = "Congratulations!!";
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("You've Rolled a Lurgit!!");
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("You must now end your turn.");
                    lblBonusMessage.Text = "Lurgit Bonus!!";
                    lblBonusMessage.ForeColor = Color.Green;
                }

                //Detect Sequence Bonus
                bSequence = detectSequence();
                if (bSequence)
                {
                    iRunningScore = iRunningScore + 10;
                    txbxDisplayMessage.Text = "Congratulations!!";
                    txbxDisplayMessage.AppendText(Environment.NewLine);
                    txbxDisplayMessage.AppendText("You've Rolled a Sequence Bonus!!");
                    lblBonusMessage.Text = "Sequence Bonus!!";
                    lblBonusMessage.ForeColor = Color.DodgerBlue;


                }

                // Increment the player turn
                iPlayerTurn++;

                //Update the current turn label
                lblCurrentTurn.Text = "Turn: " + Convert.ToString(iPlayerTurn);
            }

            //Disables Roll Die Button after 3 rolls
            if (iPlayerTurn == 4)
            {
                btnRoll.Enabled = false;
                lblCurrentTurn.Text = "";
                txbxDisplayMessage.AppendText("You are out of turns. Please end your round.");

                // Set the active control to the end round button of the current player
                if (iCurrentPlayer == 1)
                {
                    ActiveControl = btnP1EndRound;
                }
                else
                {
                    ActiveControl = btnP2EndRound;
                }
            }
            else
            {
                // Enable "Keep" buttons for the next turn
                btnKeepDie1.Enabled = true;
                btnKeepDie2.Enabled = true;
                btnKeepDie3.Enabled = true;

                if (!bLurgit)
                {
                    // Enable "Roll" button after roll has ended
                    btnRoll.Enabled = true;
                }

                //Set the active control to the roll dice button
                ActiveControl = btnRoll;
            }
        }

        private void btnKeepDie1_Click(object sender, EventArgs e)
        {
            // Sets the die to keep or roll depending on the die's bDieKept value
            // Draws the die dots in either "keep" or "roll" colour

            if (!dDie1.bDieKept)    // Set the die to "keep"
            {
                lblDieStatus1.Text = "Keeping";
                btnKeepDie1.Text = "Roll";
                dDie1.bDieKept = true;
                ActiveControl = btnRoll;
            }
            else    // Set the die to "roll"
            {
                lblDieStatus1.Text = "Rolling";
                btnKeepDie1.Text = "Keep";
                dDie1.bDieKept = false;
                ActiveControl = btnRoll;
            }

            // Draw die in keep/roll colour
            dDie1.draw(dDie1.iDieRoll, graDie1, dDie1.bDieKept);
        }

        private void btnKeepDie2_Click(object sender, EventArgs e)
        {
            // Sets the die to keep or roll depending on the die's bDieKept value
            // Draws the die dots in either "keep" or "roll" colour

            if (!dDie2.bDieKept)    // Set the die to "keep"
            {
                lblDieStatus2.Text = "Keeping";
                btnKeepDie2.Text = "Roll";
                dDie2.bDieKept = true;
                ActiveControl = btnRoll;
            }
            else    // Set the die to "roll"
            {
                lblDieStatus2.Text = "Rolling";
                btnKeepDie2.Text = "Keep";
                dDie2.bDieKept = false;
                ActiveControl = btnRoll;
            }

            // Draw die in keep/roll colour
            dDie2.draw(dDie2.iDieRoll, graDie2, dDie2.bDieKept);
        }

        private void btnKeepDice3_Click(object sender, EventArgs e)
        {
            // Sets the die to keep or roll depending on the die's bDieKept value
            // Draws the die dots in either "keep" or "roll" colour

            if (!dDie3.bDieKept)    // Set the die to "keep"
            {
                lblDieStatus3.Text = "Keeping";
                btnKeepDie3.Text = "Roll";
                dDie3.bDieKept = true;
                ActiveControl = btnRoll;
            }
            else    // Set the die to "roll"
            {
                lblDieStatus3.Text = "Rolling";
                btnKeepDie3.Text = "Keep";
                dDie3.bDieKept = false;
                ActiveControl = btnRoll;
            }

            // Draw die in keep/roll colour
            dDie3.draw(dDie3.iDieRoll, graDie3, dDie3.bDieKept);
        }
        
        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            // Sets up the game for one player

            bool bOKClicked = false;  // Used to check if player clicked OK or cancel

            // Ask for player 1's name
            pPlayer1.getName("1", pPlayer1, ref bOKClicked, pPlayer2);

            // If player 1 entered name, set up 1 player game.
            if (bOKClicked)
            {
                // Add the players chosen name to the player 1 label
                lblPlayer1Name.Text = "Player 1: " + pPlayer1.sName;

                //Set Current Player name
                lblCurrentPlayer.Text = "Current Player: " + pPlayer1.sName;

                //Enable the player 1 end turn button
                btnP1EndRound.Enabled = true;

                // Disable and make the player 2 controls invisible
                grpbxPlayer2.Visible = false;
                grpbxPlayer2.Enabled = false;

                // Enable and make visible the game controls and graphics
                grpbxLurgit.Visible = true;
                grpbxLurgit.Enabled = true;

                //Enable roll die button
                btnRoll.Enabled = true;

                //Disable and make invisible play again button
                btnPlayAgain.Enabled = false;
                btnPlayAgain.Visible = false;

                // Make the game mode controls invisible and disable them
                grpbxGameMode.Visible = false;
                grpbxGameMode.Enabled = false;

                // Change the value of bIsSinglePlayer to true this is later used in other methods
                // to determine if the game is single player
                bIsSinglePlayer = true;

                // Change the value of bPlayComputer to false this is later used in other methods
                // to determine if the game is being played against the computer
                bPlayComputer = false;

                // Hide the Current Player label
                lblCurrentPlayer.Visible = false;

                // Hide End Session button
                btnEndSession.Visible = false;

                // Change the current player to player 1 and make the active control the roll button
                iCurrentPlayer = 1;
                ActiveControl = btnRoll;
            }
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            // Sets up the game for two players

            bool bOKClicked = false;  // Used to check if player clicked OK or cancel

            // If the second player was the program in the previous game clear the session stats for player 2.
            if (pPlayer2.sName == "Computer")
            {
                pPlayer2.iSessionScore = 0;
                pPlayer2.iGamesPlayed = 0;
                pPlayer2.iGamesWon = 0;
            }

            // Ask for player 1's name
            pPlayer1.getName("1", pPlayer1, ref bOKClicked, pPlayer2);

            // If player 1 name is entered, ask for player 2's name.
            if (bOKClicked)
            {
                pPlayer2.getName("2", pPlayer2, ref bOKClicked, pPlayer1);
            }

            // If both players have names, set up the 2 player game
            if (bOKClicked)
            {
                lblPlayer1Name.Text = "Player 1: " + pPlayer1.sName;
                lblPlayer2Name.Text = "Player 2: " + pPlayer2.sName;


                iPlayerCount = 2;

                //Set Current Player name
                lblCurrentPlayer.Text = "Current Player: " + pPlayer1.sName;

                //Enable the player 1 end turn button
                btnP1EndRound.Enabled = true;

                // Enable and make visible the game controls and graphics
                grpbxLurgit.Visible = true;
                grpbxLurgit.Enabled = true;

                //Disable and make invisible play again button
                btnPlayAgain.Enabled = false;
                btnPlayAgain.Visible = false;

                //Enable roll die button
                btnRoll.Enabled = true;

                // Make the game mode controls invisible and disable them
                grpbxGameMode.Visible = false;
                grpbxGameMode.Enabled = false;

                // Make Second players controls visible and enable them
                grpbxPlayer2.Visible = true;
                grpbxPlayer2.Enabled = true;

                // Change the values of bIsSinglePlayer and bPlayComputer to false
                bIsSinglePlayer = false;
                bPlayComputer = false;

                // Hide End Session button
                btnEndSession.Visible = false;

                // Make the current player label visible and change the current player to player 1
                // Make the active control the roll button
                lblCurrentPlayer.Visible = true;
                iCurrentPlayer = 1;
                ActiveControl = btnRoll;
            }
        }

        private void btnPlayComputer_Click(object sender, EventArgs e)
        {
            // Sets up the game for 1 player vs the program

            bPlayComputer = true;

            bool bOKClicked = false;  // Used to check if player clicked OK or cancel

            // Ask for player 1's name
            pPlayer1.getName("1", pPlayer1, ref bOKClicked, pPlayer2);

            // If player 1 name is entered, ask for player 2's name.
            if (bOKClicked)
            {
                pPlayer2.sName = "Computer";
            }

            // If both players have names, set up the 2 player game
            if (bOKClicked)
            {
                lblPlayer1Name.Text = "Player 1: " + pPlayer1.sName;
                lblPlayer2Name.Text = "Player 2: " + pPlayer2.sName;


                iPlayerCount = 2;

                //Set Current Player name
                lblCurrentPlayer.Text = "Current Player: " + pPlayer1.sName;

                //Enable the player 1 end turn button
                btnP1EndRound.Enabled = true;

                // Enable and make visible the game controls and graphics
                grpbxLurgit.Visible = true;
                grpbxLurgit.Enabled = true;

                //Disable and make invisible play again button
                btnPlayAgain.Enabled = false;
                btnPlayAgain.Visible = false;

                //Enable roll die button
                btnRoll.Enabled = true;

                // Make the game mode controls invisible and disable them
                grpbxGameMode.Visible = false;
                grpbxGameMode.Enabled = false;

                // Make Second players controls visible and enable them
                grpbxPlayer2.Visible = true;
                grpbxPlayer2.Enabled = true;

                bIsSinglePlayer = false;
                bPlayComputer = true;

                // Hide End Session button
                btnEndSession.Visible = false;

                lblCurrentPlayer.Visible = true;

                iCurrentPlayer = 1;
                ActiveControl = btnRoll;
            }
        }

        private void btnP1EndRound_Click(object sender, EventArgs e)
        {
            // Ends the round for player 1

            string sPlayerRoundScore;

            //Enables Roll Die Button
            btnRoll.Enabled = true;

            // Remove text from the bonus message label
            lblBonusMessage.Text = "";

            // Call the setupNextRound function and display the player scores
            setupNextRound(ref pPlayer1, iRunningScore);
            sPlayerRoundScore = Convert.ToString(pPlayer1.iRoundScore);
            txbxPlayer1GameScore.Text = sPlayerRoundScore;
            txbxBonusScoreP1.Text = Convert.ToString(pPlayer1.iBonusScore);

            // Reset current running score for next round
            iRunningScore = 0;

            btnP1EndRound.Enabled = false;
            if (iPlayerCount == 1)
            {
                lblCurrentPlayer.Text = "Current Player: " + pPlayer1.sName;
            }
            else
            {
                btnP2EndRound.Enabled = true;
                txbxDisplayMessage.Text = "Player 2 It's your turn!";

                lblCurrentPlayer.Text = "Current Player: " + pPlayer2.sName;
            }

            Application.DoEvents();

            // If it is a single player game end round
            if (bIsSinglePlayer)
            {
                endRound();
                iCurrentPlayer = 1;
            }
            else
            {
                iCurrentPlayer = 2;
            }

            // If the game mode is player vs program, play the program's round
            if (bPlayComputer)
            {
                cComputer.playRound(btnRoll, btnP2EndRound, btnKeepDie1, btnKeepDie2, btnKeepDie3, dDie1, dDie2, dDie3, iRound, rComp, pbrComputerRound, lblComputerProgress, grpbxGameOptions);
            }

            // Set the active control to roll dice button
            ActiveControl = btnRoll;
        }

        private void btnP2EndRound_Click(object sender, EventArgs e)
        {
            // // Ends the round for player 2
            string sPlayerRoundScore;

            //Enables Roll Die Button
            btnRoll.Enabled = true;

            // Remove text from the bonus message label
            lblBonusMessage.Text = "";

            // Call the setupNextRound function and display the player scores
            setupNextRound(ref pPlayer2, iRunningScore);
            sPlayerRoundScore = Convert.ToString(pPlayer2.iRoundScore);
            txbxPlayer2GameScore.Text = sPlayerRoundScore;
            txbxBonusScoreP2.Text = Convert.ToString(pPlayer2.iBonusScore);

            // Reset current round score for next round
            iRunningScore = 0;
            btnP2EndRound.Enabled = false;

            // Disable Roll button
            btnRoll.Enabled = false;

            // Display end round message
            txbxDisplayMessage.Text = "The round has ended. Click the end round button to continue.";

            lblCurrentPlayer.Text = "Current Player: " + pPlayer1.sName;

            iCurrentPlayer = 1;
            endRound();

            ActiveControl = btnRoll;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Set up the session for another game

            // Enable the game mode controls and make them visible
            grpbxGameMode.Visible = true;
            grpbxGameMode.Enabled = true;

            //Make the Lurgit game controls invisible and disable them
            grpbxLurgit.Visible = false;
            grpbxLurgit.Enabled = false;

            //Reset the round number
            iRound = 1;
            lblCurrentRound.Text = "Round: 1";

            // Reset the turn number
            iPlayerTurn = 1;
            lblCurrentTurn.Text = "Turn: 1";

            // Reset the player scores
            pPlayer1.iGameScore = 0;
            pPlayer2.iGameScore = 0;

            // Clear the score text boxes
            txbxPlayer1GameScore.Clear();
            txbxPlayer2GameScore.Clear();
            txbxBonusScoreP1.Clear();
            txbxBonusScoreP2.Clear();

            //Clear the message box
            txbxDisplayMessage.Clear();

            //Make the play again button invisible
            btnPlayAgain.Visible = false;

            //Make the Current player round and turn labels visible
            lblCurrentPlayer.Visible = true;
            lblCurrentRound.Visible = true;
            lblCurrentTurn.Visible = true;
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the game

            Application.Exit();
        }

        private void btnGameRules_Click(object sender, EventArgs e)
        {
            //Displays the Lurgit game rules

            // The first two paragraphs for the game rules was copied from the assignment description.
            MessageBox.Show("Lurgit is played with three dice. Each game consists of six rounds, and the aim is to get the best possible score over those six rounds." +
                "\n\n\rIn each round there is a required number, which is the same as the round number. " +
                "Each player in a round has up to three rolls of the dice, the main goal being to roll as many as possible of the " +
                "required number. So in round 1 the goal is to roll three 1s, in round 2 the goal is to roll three 2s, and so on. You can choose to end the round at any time" +
                "\n\n\r A Lurgit bonus of 20 points is added to your score if all of your dice are rolled and all of the die match the round number. " +
                "When this happens you will no longer be able to roll and must end your round.\n\n\rA Sequence bonus of 10 points is added to your " +
                "score whenever all the dice show consecutive numbers. This can be applied multiple times in a round and you do not need to end " +
                "your round after rolling a sequence bonus. A sequence bonus will NOT be applied if all die are kept in a turn. At least one die " +
                "must be rolled for a sequence bonus to be applied.", "Game Rules");
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            //Ends the current session and shows the session statistics in a message box

            if (bIsSinglePlayer && pPlayer2.iGamesPlayed == 0)
            {
                MessageBox.Show(pPlayer1.sName + " wins the session.\n\n\r"
                    + "Session score: " + Convert.ToString(pPlayer1.iSessionScore) + "\n\n\r"
                    + "Games won: " + Convert.ToString(pPlayer1.iGamesWon) + "\n\n\r"
                    + "Games played: " + Convert.ToString(pPlayer1.iGamesPlayed), "Session Over");
            }
            else if (pPlayer1.iSessionScore > pPlayer2.iSessionScore)  //If player 1 wins
            {
                //Display message to the players
                MessageBox.Show(pPlayer1.sName + " wins the session.\n\n\r"
                    + pPlayer1.sName + " session score: " + Convert.ToString(pPlayer1.iSessionScore) + "\n\r"
                    + pPlayer2.sName + " session score: " + Convert.ToString(pPlayer2.iSessionScore) + "\n\n\r"
                    + pPlayer1.sName + " games won: " + Convert.ToString(pPlayer1.iGamesWon) + "\n\r"
                    + pPlayer2.sName + " games won: " + Convert.ToString(pPlayer2.iGamesWon) + "\n\n\r"
                    + pPlayer1.sName + " games played: " + Convert.ToString(pPlayer1.iGamesPlayed) + "\n\r"
                    + pPlayer2.sName + " games played: " + Convert.ToString(pPlayer2.iGamesPlayed), "Session Over");
            }
            else if (pPlayer1.iSessionScore == pPlayer2.iSessionScore)    // If the session is a tie
            {
                //Display message to the players
                MessageBox.Show("Player scores were tied.\n\n\r"
                    + "Session score: " + Convert.ToString(pPlayer1.iSessionScore) + "\n\n\r"
                    + pPlayer1.sName + " games won: " + Convert.ToString(pPlayer1.iGamesWon) + "\n\r"
                    + pPlayer2.sName + " games won: " + Convert.ToString(pPlayer2.iGamesWon) + "\n\n\r"
                    + pPlayer1.sName + " games played: " + Convert.ToString(pPlayer1.iGamesPlayed) + "\n\r"
                    + pPlayer2.sName + " games played: " + Convert.ToString(pPlayer2.iGamesPlayed), "Session Over");
            }
            else    // If player 2 wins
            {
                //Display message to the players
                MessageBox.Show(pPlayer2.sName + " wins the session.\n\n\r"
                    + pPlayer1.sName + " session score: " + Convert.ToString(pPlayer1.iSessionScore) + "\n\r"
                    + pPlayer2.sName + " session score: " + Convert.ToString(pPlayer2.iSessionScore) + "\n\n\r"
                    + pPlayer1.sName + " games won: " + Convert.ToString(pPlayer1.iGamesWon) + "\n\r"
                    + pPlayer2.sName + " games won: " + Convert.ToString(pPlayer2.iGamesWon) + "\n\n\r"
                    + pPlayer1.sName + " games played: " + Convert.ToString(pPlayer1.iGamesPlayed) + "\n\r"
                    + pPlayer2.sName + " games played: " + Convert.ToString(pPlayer2.iGamesPlayed), "Session Over");
            }

            // Clear session stats and names for both players
            pPlayer1.iSessionScore = 0;
            pPlayer2.iSessionScore = 0;
            pPlayer1.iGamesWon = 0;
            pPlayer2.iGamesWon = 0;
            pPlayer1.iGamesPlayed = 0;
            pPlayer2.iGamesPlayed = 0;
            pPlayer1.sName = "";
            pPlayer2.sName = "";

            //Run Play again code to return to game mode selection
            btnPlayAgain.PerformClick();

            //Make End Session and Play Again Buttons invisible
            btnEndSession.Visible = false;
            btnPlayAgain.Visible = false;
        }
    }
    #endregion
}