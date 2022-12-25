using HubstafDesktop.Data.Model;
using HubstafDesktop.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace HubstafDesktop.Ui.Pages
{
    public partial class TimerFragment : UserControl
    {
        MainForm parentContext;

        private int timerCountdownValue = 0;
        private UserTask choosedTask;
        private string projectName = "";

        //        private UserTask choosedTask;

        public int TimerCountdownValue
        {
            get => timerCountdownValue; set
            {
                timerCountdownValue = value;
                bindSecondAndMinute();
            }
        }

        public UserTask ChoosedTask { get => choosedTask; set { 
                choosedTask = value;
                if (choosedTask != null)
                {
                    lblTaskName.Text = choosedTask.TaskName;
                }
                
            } }

        public string ProjectName { get => projectName; set { 
                projectName = value;
                
                lblCurrentProjectName.Text = value;
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
            if (timerCountdownValue > 0)
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
            this.lblTimerCountDown.Text = TimerUtil.formatTime(timerCountdownValue);
        }

        private void TimerFragment_Load(object sender, EventArgs e)
        {

        }


        #region helper method
        void changePlayButtonState(bool isEnable)
        {
            btnStartTimer.Enabled = isEnable;
        }
       
        #endregion
    }
}
