using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace StopWatchSample
{
    public partial class Form1 : Form
    {
        private Stopwatch mStopwatch;
        private Timer mStopWatchTimer;
        public Form1()
        {
            InitializeComponent();
            mStopwatch = new Stopwatch();
            mStopWatchTimer = new Timer();
            mStopWatchTimer.Interval = 100;
            mStopWatchTimer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = mStopwatch.Elapsed;
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            mStopwatch.Start();
            mStopWatchTimer.Start();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            mStopwatch.Stop();
            mStopWatchTimer.Stop();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            mStopwatch.Reset();
            label1.Text = "00:00:00.00"; // 초기 상태로 리셋
        }
    }
}
