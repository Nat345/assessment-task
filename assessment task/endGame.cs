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
    public partial class endGame : Form
    {
        public endGame()
        {
            InitializeComponent();
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            easyLevel f2 = new easyLevel();
            f2.ShowDialog();

            //opens easy level 
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            welcome f8 = new welcome();
            f8.ShowDialog();

            //opens welcome page
        }
    }
}
