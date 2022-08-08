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
        List<int> picNumbers = new List<int> () { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10};
        

        public easyLevel()
        {
            InitializeComponent();
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
    }
}
