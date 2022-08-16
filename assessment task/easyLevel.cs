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
        //the numbers that are assigned to the pictures on easy level
        List<PictureBox> picNumbers = new List<PictureBox>();
        
        public easyLevel()
        {
            InitializeComponent();
            picNumbers.Add(pictureBox1);
            picNumbers.Add(pictureBox2);
            picNumbers.Add(pictureBox3);
            picNumbers.Add(pictureBox4);
            picNumbers.Add(pictureBox5);
            picNumbers.Add(pictureBox6);
            picNumbers.Add(pictureBox7);
            picNumbers.Add(pictureBox8);
            picNumbers.Add(pictureBox9);
            picNumbers.Add(pictureBox10);
            picNumbers.Add(pictureBox11);
            picNumbers.Add(pictureBox12);
            picNumbers.Add(pictureBox13);
            picNumbers.Add(pictureBox14);
            picNumbers.Add(pictureBox15);
            picNumbers.Add(pictureBox16);
            picNumbers.Add(pictureBox17);
            picNumbers.Add(pictureBox18);
            picNumbers.Add(pictureBox19);
            picNumbers.Add(pictureBox20);
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        private void loadPictures ()
        {

        }

        private void checkPictures (PictureBox x, PictureBox y)
        {

        }

        private void restartGame ()
        {

        }

        private void easyLevel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //I'm trying to make a click event where the picture appears when its clicked 
            pictureBox1.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number1.png");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number2.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number3.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number4.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number5.png");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number10.png");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number9.png");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number8.png");
        }

        
    }
}
