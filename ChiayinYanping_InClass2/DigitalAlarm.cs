/* 
 * Name of Project: ChiayinYanping_InClass2
 * Purpose: Understaing how to create alarm clock app using C#
 * Revision History: 
 * - Chiayin Yang and Yanping Guo, May 24th 2024, Create basic design and functions.
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
    public partial class DigitalAlarm : Form
    {
        public DigitalAlarm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get system current clock time
            timerClock.Interval = 1000;
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();

            //set date
            lblDate.Text = DateTime.Now.ToString("MM:dd:yyyy");
            lblDayOfWeek.Text = DateTime.Now.DayOfWeek.ToString();

            //set timerAlarm and if timerclock is equals timerAlarm show picture
            timerAlarm.Interval = 1000;
            timerAlarm.Tick += btnAlarmOn_Click;
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

        private void btnAlarmOn_Click(object sender, EventArgs e)
        {
            timerAlarm.Start();
            DateTime alarmTime = DateTime.Parse(dateTimePicker.Text);
            if ((DateTime.Now.ToString()).Equals(alarmTime.ToString()))
            {
                picAlarm.Visible = true;
            } 
        }

        private void btnAlarmOff_Click(object sender, EventArgs e)
        {
            timerAlarm.Stop();
            picAlarm.Visible = false;
        }
    }
}
