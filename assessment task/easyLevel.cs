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
        //the numbers that are assigned to the pictures on easy level
        List<PictureBox> picNumbers = new List<PictureBox>();
        bool gameStatus = true;
        string firstChoice = "";
        string secondChoice = "";

        
        public easyLevel()
        {
            InitializeComponent();
            loadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        private void loadPictures()
        {
            //picNumbers.Clear(); (was recommended so idk)
        }


        private void restartGame ()
        {
            if (gameStatus == false)
            {            
                //
                MessageBox.Show("click below to start again");    
                easyLevel f4 = new easyLevel();
                f4.ShowDialog();
            }
            

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
            ResetTime(); 
        }

        private void ResetTime()
        {
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        //here onward is just the pictures in the tiles 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.number1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.number2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.number3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.number4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.number5;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.number6;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.number7;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.number8;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.number9;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.number10;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.star1;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.star2;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.star3;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.star4;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.star5;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Properties.Resources.star6;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Properties.Resources.star7;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Properties.Resources.star8;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.star9;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.star10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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


        private void stopWatch1_Paint(object sender, PaintEventArgs e)
        {

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
