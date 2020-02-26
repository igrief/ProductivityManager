/*
 * Copyright 2020, Isaiah Grief, All rights reserved.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProductivityManager
{
    public partial class Manager : Form
    {
        Timer timerT = new Timer();
        Stopwatch stopwatchT = new Stopwatch();

        public Manager()
        {
            InitializeComponent();
            todoTextBox.KeyDown += todoTextBox_OnKeyDown; //attaches event
            habitsTextBox.KeyDown += habitsTextBox_OnKeyDown;
            habitsBox.ItemCheck += habitsBox_ItemCheck;
            //calculate the time until first day is over 
            Int32 timeInterval = 86400000 - ((DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second) * 1000);
            if(timeInterval < 0)
            {
                throw new Exception("Time interval invalid");
            }
            dayTimer.Interval = timeInterval;
            reminderDatePicker.MinDate = DateTime.Now;
            reminderNotifyIcon.Visible = true;
            reminderNotifyIcon.Icon = SystemIcons.Application; //can replace with an appropriate .ico file
            reminderNotifyIcon.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
            notifyIcon2.Visible = true;
            notifyIcon2.Icon = SystemIcons.Application;
            notifyIcon2.BalloonTipIcon = ToolTipIcon.None;
        }

        //This method unchecks all habits at the beginning of a new day 
        private void resetHabits()
        {
            //update the timer tick interval to be length of a day
            dayTimer.Interval = 86400000;
            //uncheck all boxes 
            for(int i = 0; i < habitsBox.Items.Count; i++)
            {
                if (((Habit)habitsBox.Items[i]).doneToday)
                {
                    ((Habit)habitsBox.Items[i]).doneToday = false;
                    habitsBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        //This method removes an item from the todo list when it is selected
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            todoBox.Items.Remove(todoBox.SelectedItem);
        }

        //This method updates the timer's timer
        private void timerTimer_Tick(object sender, EventArgs e)
        {
            if (!timerT.TimerTick())
            {
                timerTimer.Stop();
                //todo: generate a notification 
            }
            timerValue.Text = timerT.ReadTime();
        }

        //This method updates the stopwatch's timer
        private void stopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchT.StopwatchTick();
            stopwatchValue.Text = stopwatchT.ReadTime();
        }

        //This method begins the timer when the start button is clicked 
        private void timerStartButton_Click(object sender, EventArgs e)
        {
            timerTimer.Start();
        }

        //This method pauses the timer when the stop button is clicked 
        private void timerStopButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
        }

        //This method resets the timer to 00:00:00 when the reset button is clicked
        private void timerResetButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
            timerT.ResetTime();
            timerValue.Text = timerT.ReadTime();
        }

        //This method sets the timer's value when the set button is clicked
        private void timerSetButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
            timerT.SetTime(Decimal.ToInt32(hoursInput.Value), Decimal.ToInt32(minutesInput.Value), Decimal.ToInt32(secondsInput.Value));
            timerValue.Text = timerT.ReadTime();
        }

        //This method starts the stopwatch when the start button is clicked
        private void stopwatchStartButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Start();
        }

        //This method pauses the stopwatch when the stop button is clicked
        private void stopwatchStopButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
        }

        //This method resets the stopwatch to the last set value when the reset button is clicked
        private void stopwatchResetButton_Click(object sender, EventArgs e)
        {
            stopwatchT.ResetStopwatch();
            stopwatchTimer.Stop();
            stopwatchValue.Text = stopwatchT.ReadTime();
        }

        //This method adds an item to the todo list when the add button is clicked
        private void todoButton_Click(object sender, EventArgs e)
        {
            todoBox.Items.Add(new Todo(todoTextBox.Text));
            todoTextBox.Text = "";
        }

        //This method clears the text box when the user presses enter 
        private void todoTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                todoButton_Click(sender, e);
            }
        }

        //This method clears the text box when the user presses enter
        private void habitsTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                habitsAddButton_Click(sender, e);
            }
        }

        //This method removes the selected habit when the remove button is clicked
        private void habitsRemoveButton_Click(object sender, EventArgs e)
        {
            habitsBox.Items.Remove(habitsComboBox.SelectedItem);
            habitsComboBox.Items.Remove(habitsComboBox.SelectedItem);
            habitsComboBox.Text = "";
        }

        //This method adds a habit to the list when the add button is clicked
        private void habitsAddButton_Click(object sender, EventArgs e)
        {
            Habit h = new Habit(habitsTextBox.Text);
            habitsBox.Items.Add(h);
            habitsComboBox.Items.Add(h);
            habitsTextBox.Text = "";
        }

        //This method updates a habit object to be done
        private void habitsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(habitsBox.SelectedItem == null)
            {
                return;
            }
            //if the habit was not already done, set it to be done
            if (!((Habit)habitsBox.SelectedItem).doneToday)
            {
                ((Habit)habitsBox.SelectedItem).doneToday = true;
            }
        }

        //This method handles habit check box enabling and disabling
        private void habitsBox_ItemCheck(object sender, EventArgs e)
        {
            //when the box is checked, disable it 
            if(((ItemCheckEventArgs)e).NewValue == CheckState.Checked)
            {
                ((ItemCheckEventArgs)e).NewValue = CheckState.Indeterminate; 
                //habitsBox.SetItemCheckState(((ItemCheckEventArgs)e).Index, CheckState.Indeterminate);
            }
            //only allow box to be reenabled when trying to disable it - like a toggle
            else if(((ItemCheckEventArgs)e).CurrentValue == CheckState.Indeterminate)
            {
                //if new value is not indeterminate and the habit is done, don't change anything
                if (((ItemCheckEventArgs)e).NewValue != CheckState.Indeterminate && ((Habit)habitsBox.Items[((ItemCheckEventArgs)e).Index]).doneToday)
                    ((ItemCheckEventArgs)e).NewValue = CheckState.Indeterminate;
                //else the habit is not done, but it had to have been, so it must be that we need to uncheck
                else
                    ((ItemCheckEventArgs)e).NewValue = CheckState.Unchecked;
            } 
        }

        //This method should be called at midnight every day, resets habits
        private void dayTimer_Tick(object sender, EventArgs e)
        {
            resetHabits();
        }

        //This method adds a new reminder to the list when the add button is clicked 
        private void reminderAddButton_Click(object sender, EventArgs e)
        {
            DateTime reminderDate = new DateTime(reminderDatePicker.Value.Year, 
                reminderDatePicker.Value.Month, reminderDatePicker.Value.Day, 
                reminderTimePicker.Value.Hour, reminderTimePicker.Value.Minute,
                reminderTimePicker.Value.Second);
            Reminder r = new Reminder(reminderTextBox.Text, reminderDate);
            reminderCheckList.Items.Add(r);

            //Set and start the timer if it is the first reminder 
            if (reminderCheckList.Items.Count <= 1)
            {
                updateReminderTimer(r);
                remindTimer.Start();
            }
            //Else check if it is more recent and update timer accordingly
            else if(isEarliestReminder(r))
            {
                updateReminderTimer(r);
            }
        }

        //This method converts a datetime to a datetimetimer interval representing 
        //the amount of time between now and the datetime
        //This method returns the absolute difference between the two datetimes 
        private Int32 getTimerTicksUntilDate(DateTime futureEvent)
        {
            //There are 10000 ticks in a millisecond
            return Math.Abs((Int32)DateTime.Now.Subtract(futureEvent).Ticks/10000);
        }

        //This method removes all selected reminders when the remove button is clicked 
        private void reminderRemoveButton_Click(object sender, EventArgs e)
        {
            while(reminderCheckList.CheckedItems.Count > 0)
            {
                //since the items are removed from the checked items list
                //we only need to remove the first item and let the list be continually updated
                reminderCheckList.Items.Remove(reminderCheckList.CheckedItems[0]);
            }
        }
        
        //This method removes a reminder and updates the timer if necessary
        private void removeReminder(Reminder r)
        {
            //Check if this is the most recent reminder, then update the timer 
            bool update = false;
            if(isEarliestReminder(r))
            {
                update = true;
            }

            reminderCheckList.Items.Remove(r);
            //If no reminders remain, stop the timer
            if (reminderCheckList.Items.Count <= 0)
            {
                remindTimer.Stop();
            }
            else if(update)
            {
                updateReminderTimer(findEarliestReminder());
            }
        }

        //This method returns the reminder with the earliest remind date in the reminder list,
        //returns null if list is empty 
        private Reminder findEarliestReminder()
        {
            if(reminderCheckList.Items.Count <= 0)
            {
                return null;
            }
            Reminder returnReminder = (Reminder)reminderCheckList.Items[0];
            foreach(Reminder r in reminderCheckList.Items)
            {
                if (r.remindDate.Ticks < returnReminder.remindDate.Ticks)
                    returnReminder = r;
            }
            return returnReminder;
        }

        //This method returns true if the reminder parameter is the earliest reminder
        private bool isEarliestReminder(Reminder inRemind)
        {
            return inRemind.Equals(findEarliestReminder());
        }
        
        //This method updates the reminder timer and sets the notify icon component properties
        //If the next reminder is at the same time, it will show that reminder as well
        private void updateReminderTimer(Reminder r)
        {
            reminderNotifyIcon.BalloonTipTitle = "Reminder!";
            reminderNotifyIcon.BalloonTipText = r.message;
            Int32 tempInterval = getTimerTicksUntilDate(r.remindDate);
            //0 is an invalid interval, so just show the reminder immediately
            if (tempInterval <= 0)
            {
                showReminder();
            }
            //Else update the timer interval
            else 
            {
                remindTimer.Interval = tempInterval;
            }
        }

        //This method will show the reminder when it is time 
        private void remindTimer_Tick(object sender, EventArgs e)
        {
            showReminder();
        }

        //This method will show the reminder message, delete the reminder, and update the timer
        private void showReminder()
        {
            reminderNotifyIcon.ShowBalloonTip(30000);
            //removeReminder stops the timer when there are no more reminders, so we don't have to update it 
            removeReminder(findEarliestReminder());
            Reminder r = findEarliestReminder();
            if (r != null)
            {
                updateReminderTimer(findEarliestReminder());
            }
        }


    }
}
