using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LogoProject
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateBlue; //change bacground to Dark Slate Blue
            countdownTimer.Text = "Starting in ...3"; // Starting in...3 appears (countdown)

            Refresh();
            Thread.Sleep(1000); // Pauses for 1000 ms

            countdownTimer.Text = "Starting in ..2"; // Starting in ...3 changes to Starting in ...2

            Refresh();
            Thread.Sleep(1000); // Pauses for 1000 ms

            countdownTimer.Text = "Staring in ...1"; // Starting in ... 2 changes to Starting in 1

            Refresh();
            Thread.Sleep(1000); // Pauses for 1000 ms

            countdownTimer.Text = "GO!"; // Starting in...1 changes to GO!

            this.BackColor = Color.Salmon; // Background colour changes to Salmon

            Refresh();
            Thread.Sleep(1000); // Pauses for 1000ms

            countdownTimer.Text = "";
            this.BackColor = Color.NavajoWhite; // Background colour changes to NavajoWhite

            Graphics formGraphics = this.CreateGraphics(); // set-up to have formGrahics set up as a graphic

            Pen drawPen = new Pen(Color.Red, 10);
           
           formGraphics.DrawArc(drawPen, 20, 20, 50, 50, 30, 300);

            Refresh();
            Thread.Sleep(2000);


        }
    }
}
