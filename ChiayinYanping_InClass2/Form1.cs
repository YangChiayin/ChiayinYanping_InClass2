/* 
 * Name of Project: ChiayinYanping_InClass2
 * Purpose: Understaing how to create alarm clock app using C#
 * Revision History: 
 * - Chiayin Yang, May 24th 2024, Create basic design and functions.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiayinYanping_InClass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();

            lblDate.Text = DateTime.Now.ToString("MM:dd:yyyy");
            lblDayOfWeek.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("hh:mm");
            lblSeconds.Text = now.ToString("ss");
            lblAmPm.Text = now.ToString("tt");

            lblDate.Text = now.ToString("MM:dd:yyyy");
            lblDayOfWeek.Text = now.DayOfWeek.ToString();
        }
    }
}
