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

        private int halfTheTime = 0;

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
                parentContext.miniMode();
                parentContext.focusMode(true);
            }
            else
            {
                MessageBox.Show("You haven't choosed any task MF");
            }
            
        }

        void startTimerCountdown()
        {
            countdownTimer.Enabled = true;
            halfTheTime = timerCountdownValue / 2;
            changePlayButtonState(false);
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (timerCountdownValue > 0)
            {
                //decrement the value
                timerCountdownValue--;

                if(timerCountdownValue == this.halfTheTime)
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
                parentContext.focusMode(false);
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
    }
}
