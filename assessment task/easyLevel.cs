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
            //loadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        //private void loadPictures()


        private void restartGame ()
        {

        }

        private void easyLevel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number7.png");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\number6.png");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star5.png");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star4.png");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star3.png");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star2.png");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star1.png");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star10.png");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star9.png");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star8.png");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star7.png");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(@"C:\Users\Natalie\source\repos\New folder\assessment task\star6.png");
        }

    }
}
