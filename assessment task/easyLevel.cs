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

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.star1,
                    Properties.Resources.star2,
                    Properties.Resources.star3,
                    Properties.Resources.star4,
                    Properties.Resources.star5,
                    Properties.Resources.star6,
                    Properties.Resources.star7,
                    Properties.Resources.star8,
                    Properties.Resources.star9,
                    Properties.Resources.star10,
                    Properties.Resources.number1,
                    Properties.Resources.number2,
                    Properties.Resources.number3,
                    Properties.Resources.number4,
                    Properties.Resources.number5,
                    Properties.Resources.number6,
                    Properties.Resources.number7,
                    Properties.Resources.number8,
                    Properties.Resources.number9,
                    Properties.Resources.number10,

                };
            }
        }

        //trying to get the picture boxes to load when the program starts (doesn't work)
        private void LoadPictures()
        {
            int leftPos = 100;
            int topPos = 100;
            int rows = 0;

            for (int i = 0; i < 20; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 500;
                newPic.Width = 500;
                newPic.BackColor = Color.SlateGray;
                newPic.BorderStyle = BorderStyle.Fixed3D;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += onPic_Click;
                pictures.Add(newPic);

                if (rows < 5)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 100;
                }

                if (rows == 5)
                {
                    leftPos = 100;
                    topPos += 270;
                    rows = 0;
                }
            }

            restartGame();
        }

        private void onPic_Click(object sender, EventArgs e)
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
                    //assigning the pictures to the image resource
                    picA.Image = Image.FromFile("stars/" + (string)picA.Tag + ".png");
                    firstChoice = (string)picA.Tag;
                }
            }
            
            else if(secondChoice == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image == null)
                {
                    picB.Image = Image.FromFile("stars/" + (string)picB.Tag +".png");
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
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
                pictureBox15.Image = null;
                pictureBox16.Image = null;
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                pictureBox19.Image = null;
                pictureBox20.Image = null;

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
            pictureBox1.Image = Properties.Resources.question;
            pictureBox2.Image = Properties.Resources.question;
            pictureBox3.Image = Properties.Resources.question;
            pictureBox4.Image = Properties.Resources.question;
            pictureBox5.Image = Properties.Resources.question;
            pictureBox6.Image = Properties.Resources.question;
            pictureBox7.Image = Properties.Resources.question;
            pictureBox8.Image = Properties.Resources.question;
            pictureBox9.Image = Properties.Resources.question;
            pictureBox10.Image = Properties.Resources.question;
            pictureBox11.Image = Properties.Resources.question;
            pictureBox12.Image = Properties.Resources.question;
            pictureBox13.Image = Properties.Resources.question;
            pictureBox14.Image = Properties.Resources.question;
            pictureBox15.Image = Properties.Resources.question;
            pictureBox16.Image = Properties.Resources.question;
            pictureBox17.Image = Properties.Resources.question;
            pictureBox18.Image = Properties.Resources.question;
            pictureBox19.Image = Properties.Resources.question;
            pictureBox20.Image = Properties.Resources.question;
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
