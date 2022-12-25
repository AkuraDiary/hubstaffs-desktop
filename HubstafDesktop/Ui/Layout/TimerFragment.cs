using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HubstafDesktop.Ui.Layout
{
    public partial class TimerFragment : UserControl
    {
        private int timerCountdownValue = 0;

        public int TimerCountdownValue { get => timerCountdownValue; set { 
                timerCountdownValue = value; 
                bindSecondAndMinute(); 
            } }
        public TimerFragment()
        {
            InitializeComponent();
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            startTimerCountdown();
        }

        void startTimerCountdown()
        {
            countdownTimer.Enabled = true;
            changePlayButtonState(false);
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if(timerCountdownValue > 0)
            {
                timerCountdownValue--;
                bindSecondAndMinute();
            }
            else
            {
                countdownTimer.Stop();
                changePlayButtonState(true);
                MessageBox.Show("Time's Up");
            }
        }

        void bindSecondAndMinute()
        {
            int minutes = getMinuteOf(timerCountdownValue);
            int second = getSecondOf(timerCountdownValue);

            this.lblTimerCountDown.Text = minutes.ToString() + " : " + second.ToString();
        }

        private void TimerFragment_Load(object sender, EventArgs e)
        {
           
        }


        #region helper method
        void changePlayButtonState(bool isEnable)
        {
            btnStartTimer.Enabled = isEnable;
        }
        int getMinuteOf(int value)
        {
            return value / 60;
        }
        int getSecondOf(int value)
        {
            return value - (getMinuteOf(value) * 60);
        }
        #endregion
    }
}
