using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobusJanseVanVurenAssgt
{
    // Name: Die        Date Created: 16/05/2018
    // Programmers: Francois Janse van Vuren, Jacobus Janse van Vuren
    // Purpose: The Die class was created to store any variables and methods relating to a
    // particular die.

    class Die
    {
        #region Private Attributes

        private int iMyDieNum;      // Holds the number of the die (which of the three dice it is)
        private int iMyDieRoll;     // Holds the number rolled on die
        private bool bMyDieKept;    // Used to check if player is rolling or keeping die

        #endregion

        #region Public Properties

        public int iDieNum     // Holds the number of the die (which of the three dice it is)
        {
            get
            {
                return iMyDieNum;
            }
            set
            {
                iMyDieNum = value;
            }
        }
        public bool bDieKept   // Used to check if player is rolling or keeping die
        {
            get
            {
                return bMyDieKept;
            }
            set
            {
                bMyDieKept = value;
            }
        }
        public int iDieRoll    // Holds the number rolled on die
        {
            get
            {
                return iMyDieRoll;
            }
            set
            {
                iMyDieRoll = value;
            }
        }
        #endregion

        #region Private Methods

        private int roll(Random rand)
        {
            // Function that generates a random number between 1 and 6 and returns an integer

            int randRoll = rand.Next(1, 7);
            return (randRoll);
        }

        private void animate(Graphics graDie, Random rAnimation, Random rAnimationRoll)
        {
            // Method that simulates a die rolling

            bool bDieKept = false;  // Used to set the dot colour to DodgerBlue
            int i;                  // Variable used as a counter
            int iRollRandom;        // Used to randomise a number for the animation

            // Randomise the amount of times the animation loops
            int iRandom = rAnimation.Next(7, 16);

            // Initial wait time between die drawn
            int iWait = 50;

            // Loop a random amount of times
            for (i = 1; i <= iRandom; i++)
            {
                // Get a random number between 1 & 6
                iRollRandom = rAnimationRoll.Next(1, 7);

                // Draw the die and wait
                draw(iRollRandom, graDie, bDieKept);
                System.Threading.Thread.Sleep(iWait);

                // Increase wait time to simulate die slowing down
                iWait = iWait + 10;
            }
        }
        #endregion

        #region Public Methods
        public void rollDie(Graphics graDie, Random rand, Random rAnimationRoll, Random rAnimation)
        {
            // Method called by external class to simulate a die roll.

            bool bDieKept = false;    // Sets the dot colour to DodgerBlue

            // Animate the die rolling
            animate(graDie, rAnimation, rAnimationRoll);
            System.Threading.Thread.Sleep(10);

            // Set iDieRoll to a random number between 1 & 6
            iDieRoll = roll(rand);

            // Draw the die face on the graphics object
            draw(iDieRoll, graDie, bDieKept);
        }

        public void draw(int iRoll, Graphics graDie, bool bKept)
        {
            // This method draws the specified amount of dots on a graphics object
            // to simulate a die face.
            // Draws the dots in either DodgerBlue or Coral colour depending on
            // if the die is kept or not.

            // Clears the die using black colour
            graDie.Clear(Color.Black);

            // Brush used to draw dots
            SolidBrush dotBrush;

            // Sets brush colour depending on bKept
            if (!bKept)
            {
                dotBrush = new SolidBrush(Color.DodgerBlue);
            }
            else
            {
                dotBrush = new SolidBrush(Color.Coral);
            }

            // Draw the specified amount of dots on the graphics object
            // If iRoll is not between 1 - 6, leave the die face blank
            if (iRoll == 1)
            {
                graDie.FillEllipse(dotBrush, 43, 43, 14, 14);
            }
            else if (iRoll == 2)
            {
                graDie.FillEllipse(dotBrush, 18, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 68, 14, 14);
            }
            else if (iRoll == 3)
            {
                graDie.FillEllipse(dotBrush, 18, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 43, 43, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 68, 14, 14);
            }
            else if (iRoll == 4)
            {
                graDie.FillEllipse(dotBrush, 18, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 18, 68, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 68, 14, 14);
            }
            else if (iRoll == 5)
            {
                graDie.FillEllipse(dotBrush, 18, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 18, 68, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 68, 14, 14);
                graDie.FillEllipse(dotBrush, 43, 43, 14, 14);
            }
            else if (iRoll == 6)
            {
                graDie.FillEllipse(dotBrush, 18, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 18, 68, 14, 14);
                graDie.FillEllipse(dotBrush, 18, 43, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 18, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 68, 14, 14);
                graDie.FillEllipse(dotBrush, 68, 43, 14, 14);
            }
        }
        #endregion
    }
}
