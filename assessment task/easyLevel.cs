using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_task
{
    public partial class easyLevel : Form
    {
        //the variables used for the timer2 - the stopwatch in the rocket on the right side
        int timeCs, timeSec, timeMin;
        //for the start button of the stopwatch
        bool isActive;
        //applied to the drop down menu of 'How to Win?'
        private bool isCollapsed;
        List<int> numbers = new List<int> {1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10};
        //variables to see if the things match 
        string firstChoice;
        string secondChoice;
        //keep track of how many mismatches (for calculation of score at the end)
        int mismatchCounter;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        //variable to see if game is over 
        bool gameOver = false;



        public easyLevel()
        {
            InitializeComponent();            
        }

        private void onPicClick(object sender, EventArgs e)
        {
            if (gameOver  == true)
            {
                //don't register any new attempts to click stuff 
                return;
            }

            if (firstChoice == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    //assigning the pictures to the iamge resource
                    picA.Image = Image.FromFile("stars/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            
            else if(secondChoice == null)
            {
                picB = sender as PictureBox;

                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("stars/" + (string)picB.Tag + ".png");
                    secondChoice = (string)picB.Tag;
                }
            }
            else
            {
                checkMatch(picA, picB);
            }
        }

        private void restartGame()
        {
            //randomising the list of numbers that are assigned to the pictures
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            //assigning the random list to the numbers
            numbers = randomList;

            for (int i = 0; i< pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();
            }

            mismatchCounter = 0; 
            MismatchedTimes.Text = "Mismatched: " + mismatchCounter;
            gameOver = false;
        }

        private void checkMatch(PictureBox A, PictureBox B)
        {
            if (firstChoice == secondChoice)
            {
                //continue game 
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                //make them go back to blue colour 
                //and 
                mismatchCounter++;
                MismatchedTimes.Text = "Mismatched: " + mismatchCounter;

            }

            //resetting the assigned choices when it is matched or not matched
            firstChoice = null;
            secondChoice = null;

            //more resetting
            //the variable, then item, in the collection
            foreach (PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            //checking that the items have been solved
            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver("Good Job! You win!");
            }
        }


        private void GameOver(string msg)
        {
            isActive = false;
            gameOver = true;
            endGame f4 = new endGame();
            f4.ShowDialog();
        }

        private void easyLevel_Load(object sender, EventArgs e)
        {  
            //timer is set to zero (not functioning) when the form is loaded
            ResetTime();
            isActive = false;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            isActive = false;
            string message = "Are you sure you want to restart?";
            string title = "Restart game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                isActive = false;
                ResetTime();
                gameOver = true;
                restartGame();
            }
            else
            {
                isActive = true;
            }
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }        
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            isActive = false;
            string message = "Are you sure you want to quit?";
            string title = "Quit game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                isActive = true;
            }
        }
        private void buttonDropDown_Click(object sender, EventArgs e)
        {
            //drop down menu
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //dropdown menu
            if (isCollapsed)
            {
                //how long it takes for the drop down menu to drop down and come back up
                panelDropDown.Height += 30;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 30;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            //when the stopwatch is counting and shows the calculations of which label to alter
            if (isActive)
            {
                timeCs++;

                if(timeCs  >= 100)
                {
                    timeSec++;
                    timeCs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }
            //add this in to the screen element of the easy level design
            DrawTime();
        }

        private void DrawTime()
        {
            labelMilSec.Text = String.Format("{0:00}", timeCs);
            labelSec.Text = String.Format ("{0:00}", timeSec);  
            labelMin.Text = String.Format("{0:00}", timeMin);
        }
        
    }
}
