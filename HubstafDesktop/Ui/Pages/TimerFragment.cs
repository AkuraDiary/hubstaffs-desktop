using HubstafDesktop.Data;
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
        private bool initialSsDone = false;

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

                    screenshootTimeMF = timerCountdownValue/3;

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

                if (!initialSsDone) //only show the message when timer is first started
                {
                    // Display a confirmation message box with Yes and No buttons
                    DialogResult result = MessageBox.Show(
                        @"You're about to start working on this task, the system will automatically screenshoot your works and you won't be able to pause the timer unless the time needed for this task is more than an hour. 

Do you wish to proceed?",
                        "Start Working On Task",
                        MessageBoxButtons.YesNo
                        );

                    // Check the result of the message box
                    if (result == DialogResult.Yes)
                    {
                        onStartTimer();
                        parentContext.takeAndSendScreenshot(); //take initial screenshoot
                        this.initialSsDone = true;
                    }

                    else
                    {
                        // The user clicked No or closed the message box, so cancel the operation
                        // ...
                    }

                }
                else
                {
                    onStartTimer();
                }

                
            }
            else
            {
                MessageBox.Show("You haven't choosen any task");
            }
            
        }

        void onStartTimer()
        {
                startTimerCountdown();
                btnFormMode.PerformClick();
                parentContext.focusMode(true);

                //if (!initialSsDone)
                //{
                //    parentContext.takeAndSendScreenshot(); //take initial screenshoot
                //    this.initialSsDone = true;
                //}
        }

        void startTimerCountdown()
        {
            countdownTimer.Enabled = true;

            if (TimerUtil.getHourOf(timerCountdownValue) >= 1)
            {
                btnPause.Visible = true; //enable pause when time needed is or more than 1 hour
            }

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


                if (timerCountdownValue % this.screenshootTimeMF == 0) // take screenshoot every interval of time
                {
                    parentContext.takeAndSendScreenshot();//takeAndShowScreenshot();
                }

                //update the stopwatch
                bindSecondAndMinute();
            }
            else
            {
                onFinishedTimer();
                
            }
        }


        public void onFinishedTimer()
        {

            countdownTimer.Stop();
            changePlayButtonState(true);

            parentContext.takeAndSendScreenshot(); //finishing screenshoot

            parentContext.focusMode(false);
            //todo update task status
            choosedTask.Status = "Done";

            int timeNeeded = choosedTask.TimeNeeded - timerCountdownValue;
            choosedTask.TimeNeeded = timeNeeded;
           
            parentContext.SelectedTask = choosedTask;

            //UPDATE THE FINISHED STATUS IN DB TASK HERE
            Repository.setTakAsDone(choosedTask.IdTask);

            // sync the status and view
            parentContext.syncSelectedTask(choosedTask); 
            parentContext.fetchProjectData();

            btnFormMode.PerformClick();
            MessageBox.Show("Task Finished");
        }


        #region helper method
        void changePlayButtonState(bool isEnable)
        {
            btnStartTimer.Enabled = isEnable;
            btnFinishNow.Visible = !isEnable;
            if (!isEnable)
            {
                timerPanelContainer.FillColor= Color.FromArgb(70, 120, 255);
            }
            else
            {
                timerPanelContainer.FillColor = Color.FromArgb(30,30,30);
            }
        }

        void bindSecondAndMinute()
        {
            this.lblTimerCountDown.Text = TimerUtil.formatTime(timerCountdownValue);
        }

        internal void clearBinding()
        {
            lblCurrentProjectName.Text = "";
            lblTaskName.Text = "";
        }

        #endregion


        private void btnFormMode_Click(object sender, EventArgs e)
        {
            parentContext.miniMode();
        }



        private void btnPause_Click(object sender, EventArgs e)
        {
            pauseTimer();
        }

        private void btnFinishNow_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box with Yes and No buttons
            DialogResult result = MessageBox.Show("Are You Sure Want to Finish Task Now?", "Finish Task", MessageBoxButtons.YesNo);

            // Check the result of the message box
            if (result == DialogResult.Yes)
            {
                // The user clicked Yes, so perform the operation
                // ...
                onFinishedTimer();
            }
            else
            {
                // The user clicked No or closed the message box, so cancel the delete operation
                // ...
            }
        }
    }
}
