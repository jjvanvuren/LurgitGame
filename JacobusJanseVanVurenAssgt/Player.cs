using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacobusJanseVanVurenAssgt
{
    // Name: Player     Date Created: 16/05/2018
    // Programmers: Francois Janse van Vuren, Jacobus Janse van Vuren
    // Purpose: The player class was created to store any variables and methods relating to a
    // particular player.

    class Player
    {
        #region Private Attributes

        private string sMyName;         //Player's name as a string
        private int iMyGameScore;       //Player's Game score.
        private int iMyRoundScore;      //Player's Round Score.
        private int iMyBonusScore;      //Player's Bonus score.
        private int iMyGamesWon;        //Number of games player has won in session.
        private int iMySessionScore;    //Player's total session score.
        private int iMyGamesPlayed;     //Amount of games the player has played.

        #endregion

        #region Public Properties
        public string sName        //Player's name as a string
        {
            get
            {
                return sMyName;
            }
            set
            {
                sMyName = value;
            }
        }

        public int iGameScore      //Player's Game score.
        {
            get
            {
                return iMyGameScore;
            }
            set
            {
                iMyGameScore = value;
            }
        }

        public int iRoundScore     //Player's Round Score.
        {
            get
            {
                return iMyRoundScore;
            }
            set
            {
                iMyRoundScore = value;
            }
        }

        public int iBonusScore //Player's Bonus score.
        {
            get
            {
                return iMyBonusScore;
            }
            set
            {
                iMyBonusScore = value;
            }
        }

        public int iGamesWon       //Number of games player has won in session.
        {
            get
            {
                return iMyGamesWon;
            }
            set
            {
                iMyGamesWon = value;
            }
        }

        public int iSessionScore   //Player's total session score.
        {
            get
            {
                return iMySessionScore;
            }
            set
            {
                iMySessionScore = value;
            }
        }

        public int iGamesPlayed    //Amount of games the player has played.
        {
            get
            {
                return iMyGamesPlayed;
            }
            set
            {
                iMyGamesPlayed = value;
            }
        }
        #endregion

        #region Public Methods
        
        public void getName(string sPlayer, Player pPlayer, ref bool bOKClicked, Player pOtherPlayer)
        {
            //Method that asks for player names using an input box

            // Instantiate inputbox
            InputBox frmCollector = new InputBox();

            // Check if player exists
            if (string.IsNullOrWhiteSpace(pPlayer.sName) || pPlayer.sName == "Computer")
            {

                frmCollector = new InputBox("Player " + sPlayer + " please enter your name (10 character limit)", "Player " + sPlayer + " Name");

                // If cancel button is pressed close the inputbox and return to the game mode selection
                if (frmCollector.ShowDialog() == DialogResult.Cancel)
                {
                    bOKClicked = false;
                }
                // Store the player name and continue with the game
                else
                {
                    pPlayer.sName = frmCollector.sInputValue;
                    bOKClicked = true;
                }

                if (bOKClicked)
                {
                    // Check that the name entered by the user is not blank or whitespace characters
                    while ((string.IsNullOrWhiteSpace(pPlayer.sName) || pPlayer.sName.Length > 10) && bOKClicked || pPlayer.sName == "Computer" && bOKClicked || pOtherPlayer.sName == frmCollector.sInputValue && bOKClicked)
                    {
                        frmCollector = new InputBox("Error: Please enter a valid name", "Player " + sPlayer + " Name");

                        if (frmCollector.ShowDialog() == DialogResult.Cancel)
                        {
                            bOKClicked = false;
                        }
                        else
                        {
                            pPlayer.sName = frmCollector.sInputValue;
                        }
                    }
                }
            }
            else // if the player already exists do not ask for name again
            {
                bOKClicked = true;
            }
        }
        #endregion
    }
}
