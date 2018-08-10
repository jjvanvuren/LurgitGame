using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobusJanseVanVurenAssgt
{
    // Name: CompPlayer     Date Created: 19/05/2018
    // Programmers: Francois Janse van Vuren, Jacobus Janse van Vuren
    // Purpose: Class that contains all methods that allow the program to act as player 2

    class CompPlayer
    {

        #region Public Methods

        public void playRound(Button btnRoll, Button btnP2EndRound, Button btnKeepDie1, Button btnKeepDie2,
            Button btnKeepDie3, Die dDie1, Die dDie2, Die dDie3, int iRound, Random rComp, ProgressBar pRoundProgress,
            Label lblComputerProgress, GroupBox gbxGameOptions)
        {
            // The main method that plays a round for the program.
            // Uses a strategy that Jacobus and Francois created to play Lurgit with the highest chance of winning.
            // The program aims to roll as many sequence bonuses as possible in rounds 1 - 4.
            // In rounds 5 & 6 the program simply aims to roll the scoring number on all 3 dice.

            int iWait;                  // Used to specify how long the program should wait between turns
            bool bEndRound = false;     // Used to determine when to end the round for the program

            gbxGameOptions.Enabled = false;
            lblComputerProgress.Visible = true;
            pRoundProgress.Visible = true;
            lblComputerProgress.Text = "Computer Round Progress: Taking turn 1";
            pRoundProgress.Value = 1;

            Application.DoEvents();

            System.Threading.Thread.Sleep(500);

            // On the first roll simply press the roll button to roll all 3 dice
            btnRoll.PerformClick();

            // Before the second turn determine dice to keep
            if (iRound <= 4) // If the round is 1 - 4 try for a sequence bonus
            {
                bEndRound = rollForSequence(dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3, btnRoll, iRound);
            }
            else    // If the round is 5 or 6 try for scoring number
            {
                bEndRound = rollForScore(dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3, btnRoll, iRound);
            }

            lblComputerProgress.Text = "Computer Round Progress: Taking turn 2";
            pRoundProgress.Value = 2;

            Application.DoEvents();

            // If the program decides to roll again, roll the dice for turn 2
            if (bEndRound)
            {
                endRound(lblComputerProgress, pRoundProgress, btnP2EndRound, gbxGameOptions);
            }
            else
            {
                iWait = rComp.Next(1500, 2000);
                System.Threading.Thread.Sleep(iWait);
                btnRoll.PerformClick();
            }

            // Before the third turn determine dice to keep
            if (iRound <= 4)
            {
                bEndRound = rollForSequence(dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3, btnRoll, iRound);
            }
            else
            {
                bEndRound = rollForScore(dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3, btnRoll, iRound);
            }

            lblComputerProgress.Text = "Computer Round Progress: Taking turn 3";
            pRoundProgress.Value = 3;

            Application.DoEvents();

            // If the program decides to roll again, roll the dice for turn 3
            if (bEndRound)
            {
                endRound(lblComputerProgress, pRoundProgress, btnP2EndRound, gbxGameOptions);
            }
            else
            {
                iWait = rComp.Next(1500, 2000);
                System.Threading.Thread.Sleep(iWait);
                btnRoll.PerformClick();
            }

            // End the program's round after all turns have been taken
            endRound(lblComputerProgress, pRoundProgress, btnP2EndRound, gbxGameOptions);
        }
        #endregion

        #region Private Methods

        private bool rollForSequence(Die dDie1, Die dDie2, Die dDie3, Button btnKeepDie1, Button btnKeepDie2,
            Button btnKeepDie3, Button btnRoll, int iRound)
        {
            // Function that decides which dice to keep/roll in a turn if the program is rolling for a sequence bonus

            int[] iDieRollArray = new int[3];   // Holds the numbers rolled on the dice
            int[] iDieNumArray = new int[3];    // Holds the die number
            bool bEndRound;                     // Used to determine when to end the round

            //Stores the values rolled
            iDieRollArray[0] = dDie1.iDieRoll;
            iDieRollArray[1] = dDie2.iDieRoll;
            iDieRollArray[2] = dDie3.iDieRoll;

            //Stores the die's number
            iDieNumArray[0] = dDie1.iDieNum;
            iDieNumArray[1] = dDie2.iDieNum;
            iDieNumArray[2] = dDie3.iDieNum;

            //Sorts both arrays on values of iDieRollArray
            Array.Sort(iDieRollArray, iDieNumArray);

            //Check if all dice are in sequence and keeps the dice that are not 1 or 6
            //Increases odds of rolling another sequence
            if (iDieRollArray[1] == iDieRollArray[0] + 1 && iDieRollArray[1] == iDieRollArray[2] - 1) 
            {
                //Checks if the die with the lowest number is a 1
                if (iDieRollArray[0] == 1)
                {
                    selectToRoll3(1, dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3);
                }
                //Checks if the die with the highest number is a 6
                else if (iDieRollArray[2] == 6)
                {
                    selectToRoll3(6, dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3);
                }
                else //Simply keeps the first two die in sorted array and rolls the other
                {
                    selectToRoll2(2, iDieRollArray, iDieNumArray, dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3);
                }
            }
            else if (iDieRollArray[1] == iDieRollArray[0] + 1) //Check if first two dice are in sequence
            {
                selectToRoll2(2, iDieRollArray, iDieNumArray, dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3);
            }
            else if (iDieRollArray[1] == iDieRollArray[2] - 1) //Check if last two dice are in sequence
            {
                selectToRoll2(0, iDieRollArray, iDieNumArray, dDie1, dDie2, dDie3, btnKeepDie1, btnKeepDie2, btnKeepDie3);
            }

            // If a lurgit is rolled end the round
            return (bEndRound = detectLurgit(iRound, dDie1, dDie2, dDie3));
        }

        
        private void selectToRoll3(int iToRoll, Die dDie1, Die dDie2, Die dDie3, Button btnKeepDie1, Button btnKeepDie2, Button btnKeepDie3)
        {
            //If all three dice are in sequence this method selects the die to roll and dice to keep

            int i;

            //Sets the die with value 1 to "roll"
            if (dDie1.bDieKept && dDie1.iDieRoll == iToRoll)
            {
                btnKeepDie1.PerformClick();
            }
            else if (dDie2.bDieKept && dDie2.iDieRoll == iToRoll)
            {
                btnKeepDie2.PerformClick();
            }
            else if (dDie3.bDieKept && dDie3.iDieRoll == iToRoll)
            {
                btnKeepDie3.PerformClick();
            }

            //Loop for remaining 2 dice
            for (i = 1; i <= 2; i++)
            {
                //Sets the die to "Keep"
                if (!dDie1.bDieKept && dDie1.iDieRoll != iToRoll)
                {
                    btnKeepDie1.PerformClick();
                }
                else if (!dDie2.bDieKept && dDie2.iDieRoll != iToRoll)
                {
                    btnKeepDie2.PerformClick();
                }
                else if (!dDie3.bDieKept && dDie3.iDieRoll != iToRoll)
                {
                    btnKeepDie3.PerformClick();
                }
            }
        }

        private void selectToRoll2(int iToRoll, int[] iDieRollArray, int[] iDieNumArray, Die dDie1, Die dDie2, Die dDie3, Button btnKeepDie1, Button btnKeepDie2, Button btnKeepDie3)
        {
            //If 2 dice are in sequence this method selects the die to roll and dice to keep

            int i;          // Used as a counter
            int iStart;     // Where to start looping from in the array
            int iStop;      // Where to stop looping in the array

            // Determine where to start/stop looping in the array depending on iToRoll value
            if (iToRoll == 2)
            {
                iStart = 0;
                iStop = 1;
            }
            else
            {
                iStart = 1;
                iStop = 2;
            }

            //Select the die to keep
            for (i = iStart; i <= iStop; i++)
            {
                if (iDieNumArray[i] == 1 && !dDie1.bDieKept)
                {
                    btnKeepDie1.PerformClick();
                }
                else if (iDieNumArray[i] == 2 && !dDie2.bDieKept)
                {
                    btnKeepDie2.PerformClick();
                }
                else if (iDieNumArray[i] == 3 && !dDie3.bDieKept)
                {
                    btnKeepDie3.PerformClick();
                }
            }

            //Select the die to roll
            if (iDieNumArray[iToRoll] == 1 && dDie1.bDieKept)
            {
                btnKeepDie1.PerformClick();
            }
            else if (iDieNumArray[iToRoll] == 2 && dDie2.bDieKept)
            {
                btnKeepDie2.PerformClick();
            }
            else if (iDieNumArray[iToRoll] == 3 && dDie3.bDieKept)
            {
                btnKeepDie3.PerformClick();
            }
        }

        private bool rollForScore(Die dDie1, Die dDie2, Die dDie3, Button btnKeepDie1, Button btnKeepDie2,
            Button btnKeepDie3, Button btnRoll, int iRound)
        {
            // Used to keep the die/dice showing the scoring number and roll the others

            int[] iDieRollArray = new int[3];   // Stores numbers rolled on dice
            int i;                              // Used as a counter
            bool bEndRound;                     // Used to determine when the round should be ended

            // Store numbers rolled on dice
            iDieRollArray[0] = dDie1.iDieRoll;
            iDieRollArray[1] = dDie2.iDieRoll;
            iDieRollArray[2] = dDie3.iDieRoll;

            //Select Die to Keep
            for (i = 0; i < 3; i++)
            {
                if (iDieRollArray[i] == iRound && i == 0)
                {
                    if (!dDie1.bDieKept)
                    {
                        btnKeepDie1.PerformClick();
                    }
                }
                else if (iDieRollArray[i] == iRound && i == 1)
                {
                    if (!dDie2.bDieKept)
                    {
                        btnKeepDie2.PerformClick();
                    }
                }
                else if (iDieRollArray[i] == iRound && i == 2)
                {
                    if (!dDie3.bDieKept)
                    {
                        btnKeepDie3.PerformClick();
                    }
                }
            }

            // If the scoring number is shown on all three dice end the round
            return (bEndRound = dDie1.iDieRoll == iRound && dDie2.iDieRoll == iRound && dDie3.iDieRoll == iRound);
        }

        private bool detectLurgit(int iRound, Die dDie1, Die dDie2, Die dDie3)
        {
            // Function used to detect when the program has rolled a lurgit bonus

            bool bLurgit = dDie1.iDieRoll == iRound && dDie2.iDieRoll == iRound && dDie3.iDieRoll == iRound
                && !dDie1.bDieKept && !dDie2.bDieKept && !dDie3.bDieKept;

            return (bLurgit);
        }

        private void endRound(Label lblComputerProgress, ProgressBar pRoundProgress, Button btnP2EndRound, GroupBox gbxGameOptions)
        {
            // Method that ends the round for the program

            // Update the progress bar label and set the bar progress to full
            lblComputerProgress.Text = "Computer Round Progress: Ending Round";
            pRoundProgress.Value = 4;

            // Click the program's end round button
            System.Threading.Thread.Sleep(1500);
            btnP2EndRound.PerformClick();

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            // Enable the game options for the player
            gbxGameOptions.Enabled = true;

            // Make the progress bar and label invisible for player's round
            lblComputerProgress.Visible = false;
            pRoundProgress.Visible = false;
        }
    }
    #endregion
}