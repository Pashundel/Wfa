using System;
using System.Windows.Forms;

namespace Wfa
{
    public partial class LoginForm : Form
    {
        public bool sourseDirectoryChosen = false;
        public bool destinationDirectoryChosen = false;
        public string soursePath;
        public string destinationPath;
        public static int numberOfUsers;

        public LoginForm()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Text = Properties.Settings.Default.sourceDirectory.ToString();
            textBox2.Text = Properties.Settings.Default.destinationDirectory.ToString();

            if (Properties.Settings.Default.sourceDirectory != null && Properties.Settings.Default.destinationDirectory != null)
            {
                sourseDirectoryChosen = true;
                destinationDirectoryChosen = true;
                soursePath = Properties.Settings.Default.sourceDirectory.ToString();
                destinationPath = Properties.Settings.Default.destinationDirectory.ToString();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void transform_button_Click(object sender, EventArgs e)
        {
            if (sourseDirectoryChosen && destinationDirectoryChosen)
            {
                CSVHandler.handler(this.soursePath, this.destinationPath);

                //CSVHandler.test1();
            }
            else
            {
                MessageBox.Show("Будь ласка оберіть директорію");
            }
        }

        private void destinationDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                destinationPath = FBD.SelectedPath;
                destinationDirectoryChosen = true;

                textBox2.Text = destinationPath.ToString();

                this.saveParam();

            }
        }

        private void sourceDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                soursePath = FBD.SelectedPath;
                sourseDirectoryChosen = true;

                textBox1.Text = soursePath.ToString();

                this.saveParam();
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void saveParam()
        {
            Properties.Settings.Default.sourceDirectory = soursePath;
            Properties.Settings.Default.destinationDirectory = destinationPath;
            Properties.Settings.Default.Save();
        }
    }
}
