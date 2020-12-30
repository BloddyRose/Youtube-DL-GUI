using System;
using System.IO;
using System.Windows.Forms;

namespace Youtube_DL_GUI.Forms
{
    public partial class Settings : Form
    {
        private static string url = string.Empty;

        public Settings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = false;
                using (StreamReader sr = new StreamReader("version"))
                {
                    url = sr.ReadLine();
                    sr.Close();
                }
            }
            else
            {
                url = textBox1.Text;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("version"))
            {
                sw.WriteLine(url);
                sw.Close();
            }
            Hide();
        }
    }
}