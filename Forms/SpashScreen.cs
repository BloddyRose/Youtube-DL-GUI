using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Youtube_DL_GUI
{
    public partial class SpashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public SpashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            label1.Text = progressBar1.Value.ToString() + " %";
            if (progressBar1.Value == 100)
            {
                label1.Text = "Done... ";
                timer1.Stop();
                Thread.Sleep(3000);
                Hide();
                Thread.Sleep(3000);
                MainForm main = new MainForm();
                main.Show();
            }
            else if (progressBar1.Value == 20)
            {
                label4.Show();
            }
            else if (progressBar1.Value == 99)
            {
                label3.Text = "Almost Done...";
            }
        }

        private void SpashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Hide();
        }
    }
}