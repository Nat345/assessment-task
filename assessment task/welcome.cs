namespace assessment_task
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            if (string.IsNullOrEmpty(x))
            {
                string message = "Enter a Name.";
                string title = "Name";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Exclamation);

            }

            else
            {
                //Properties.Settings.Default.User = textBox1.Text;
                //Properties.Settings.Default.Save();

                //saves name

                easyLevel f2 = new easyLevel();
                f2.ShowDialog();

                //opens easy level 
            }

        }

        private void hardbutton_Click(object sender, EventArgs e)
        {

            string x = textBox1.Text;
            if (string.IsNullOrEmpty(x))
            {
                MessageBox.Show("enter a name >:(");

            }

            //checks character length 

            else
            { 
                //Properties.Settings.Default.User = label1.Text;
                //Properties.Settings.Default.Save();
                //(supposed to) save name 

                hardLevel f3 = new hardLevel();
                f3.ShowDialog();
                //opens hard level
            }

        }
    }
}