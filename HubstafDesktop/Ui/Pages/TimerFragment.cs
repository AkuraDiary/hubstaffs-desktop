﻿using HubstafDesktop.Data.Images;
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
                startTimerCountdown();
                btnFormMode.PerformClick();
                parentContext.focusMode(true);

                if (!initialSsDone)
                {
                    parentContext.takeAndShowScreenshot(); //take initial screenshoot
                    this.initialSsDone = true;
                }
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
                    parentContext.takeAndShowScreenshot();//takeAndShowScreenshot();
                }

                //update the stopwatch
                bindSecondAndMinute();
            }
            else
            {
                countdownTimer.Stop();
                changePlayButtonState(true);
                onFinishedTimer();

                btnFormMode.PerformClick();
                MessageBox.Show("Time's Up");
            }
        }


        void onFinishedTimer()
        {
            parentContext.takeAndShowScreenshot(); //finishing screenshoot

            parentContext.focusMode(false);
            //todo update task status
            choosedTask.Status = "done";
            var now = DateTime.Now;
            MessageBox.Show("DONE at : " + now);
            choosedTask.FinishedTime = now;
            parentContext.SelectedTask = choosedTask;


            //UPDATE THE FINISHED TASK HERE

            parentContext.syncSelectedTask(choosedTask); // sync the status and view

            //parentContext.; //TODO UPDATE TASK STATUS HERE
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


        internal void clearBinding()
        {
            lblCurrentProjectName.Text = "";
            lblTaskName.Text = "";
        }



        private void btnFormMode_Click(object sender, EventArgs e)
        {
            parentContext.miniMode();
        }



        private void btnPause_Click(object sender, EventArgs e)
        {
            pauseTimer();
        }
    }
}
