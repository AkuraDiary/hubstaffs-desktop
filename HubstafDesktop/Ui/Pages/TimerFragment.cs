using HubstafDesktop.Data.Images;
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MainForm parentContext;

        private int timerCountdownValue = 0;
        private UserTask choosedTask;
        private string projectName = "";

        private int screenshootTimeMF = 0;

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
                    timerCountdownValue = choosedTask.TimeNeeded;
                    screenshootTimeMF = timerCountdownValue/2;
                    bindSecondAndMinute();
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
            if(choosedTask != null)
            {
                startTimerCountdown();
                btnFormMode.PerformClick();
                parentContext.focusMode(true);
                //parentContext.miniMode();
            }
            else
            {
                MessageBox.Show("You haven't choosed any task MF");
            }
            
        }

        void startTimerCountdown()
        {
            countdownTimer.Enabled = true;

            if (TimerUtil.getHourOf(timerCountdownValue) >= 1)
            {
                btnPause.Visible = true; //enable pause when time needed is or more than 1 hour
            }

            //halfTheTime = timerCountdownValue / 2;
            changePlayButtonState(false);
        }

        void pauseTimer()
        {
            countdownTimer.Enabled = false;
            changePlayButtonState(true);
            btnPause.Visible = false;
            btnFormMode.PerformClick();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (timerCountdownValue > 0)
            {
                //decrement the value
                timerCountdownValue--;

                if(timerCountdownValue == this.screenshootTimeMF)
                {
                    parentContext.takeAndShowScreenshot();//takeAndShowScreenshot();
                }

                //update the stopwatch
                bindSecondAndMinute();
            }
            else
            {
                countdownTimer.Stop();
                changePlayButtonState(true);
                btnFormMode.PerformClick();
                //parentContext.focusMode(false);
                onFinishedTimer();
                //MessageBox.Show("Time's Up");
            }
        }

        //void takeAndShowScreenshot()
        //{
        //    var ss = ImagesUtil.takeScreenshoot();
        //    ImagesUtil.ShowSsResult(ss);
        //}

        void onFinishedTimer()
        {
            //todo update task status
            choosedTask.Status = "done";
            var now = DateTime.Now;
            MessageBox.Show("DONE at : " + now);
            choosedTask.FinishedTime = now;
            parentContext.SelectedTask = choosedTask;
            parentContext.syncSelectedTask(choosedTask); // sync


            //parentContext.; //TODO UPDATE TASK STATUS HERE
        }

       

        private void TimerFragment_Load(object sender, EventArgs e)
        {
            
        }


        #region helper method
        void changePlayButtonState(bool isEnable)
        {
            btnStartTimer.Enabled = isEnable;
        }

        void bindSecondAndMinute()
        {
            this.lblTimerCountDown.Text = TimerUtil.formatTime(timerCountdownValue);
        }

        #endregion

        private void timerPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        internal void clearBinding()
        {
            lblCurrentProjectName.Text = "";
            lblTaskName.Text = "";
        }

        private void lblTimerCountDown_Click(object sender, EventArgs e)
        {

        }

        private void lblTaskName_Click(object sender, EventArgs e)
        {

        }

        private void btnFormMode_Click(object sender, EventArgs e)
        {
            parentContext.miniMode();
        }

        private void lblCurrentProjectName_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pauseTimer();
        }
    }
}
