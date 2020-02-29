/*
 * Copyright 2020, Isaiah Grief, All rights reserved.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


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
            eventMonthCalendar.DateSelected += eventDateSelected;
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
            reminderNotifyIcon.BalloonTipTitle = "Productivity Manager";
            LoadLastSession();
            
            //set reminder timer
            Reminder r = findEarliestReminder();
            if (r != null) //r is not null
            {
                updateReminderTimer(r);
            }

            //check all habits that should be checked
            for(int i = 0; i < habitsBox.Items.Count; i++)
            {
                if (((Habit)habitsBox.Items[i]).doneToday)
                {
                    //if its the same day, check it, else it wasn't done today
                    if (((Habit)habitsBox.Items[i]).lastDone.Date == DateTime.Now.Date)
                    {
                        habitsBox.SetItemChecked(i, true);
                    }
                    else
                    {
                        ((Habit)habitsBox.Items[i]).doneToday = false;
                    }
                }
            }

            //update event lists
            updateEventLists();
        }

        private void Save()
        {
            FileStream habitFS = new FileStream("habits.dat", FileMode.Create);
            FileStream todoFS = new FileStream("todos.dat", FileMode.Create);
            FileStream reminderFS = new FileStream("reminders.dat", FileMode.Create);
            FileStream eventFS = new FileStream("events.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            Habit[] habits = new Habit[habitsBox.Items.Count];
            habitsBox.Items.CopyTo(habits, 0);
            Todo[] todos = new Todo[todoBox.Items.Count];
            todoBox.Items.CopyTo(todos, 0);
            Reminder[] reminders = new Reminder[reminderCheckList.Items.Count];
            reminderCheckList.Items.CopyTo(reminders, 0);
            Event[] events = new Event[eventListComboBox.Items.Count];
            eventListComboBox.Items.CopyTo(events, 0);

            try
            {
                formatter.Serialize(habitFS, habits);
                formatter.Serialize(todoFS, todos);
                formatter.Serialize(reminderFS, reminders);
                formatter.Serialize(eventFS, events);
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to serialize: Reason: " + e.Message);
                throw;
            }
            finally
            {
                habitFS.Close();
                todoFS.Close();
                reminderFS.Close();
                eventFS.Close();
            }
        }
        private void LoadLastSession()
        {
            Habit[] habits = null;
            Todo[] todos = null;
            Reminder[] reminders = null;
            Event[] events = null;


            FileStream habitFS;
            FileStream todoFS;
            FileStream reminderFS;
            FileStream eventFS;
            if (File.Exists("habits.dat") && 
                File.Exists("todos.dat") &&
                File.Exists("reminders.dat") &&
                File.Exists("events.dat"))
            {
                habitFS = new FileStream("habits.dat", FileMode.Open);
                todoFS = new FileStream("todos.dat", FileMode.Open);
                reminderFS = new FileStream("reminders.dat", FileMode.Open);
                eventFS = new FileStream("events.dat", FileMode.Open);
            }
            else
            {
                return; //No previous session found
            }
           
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                habits = (Habit[])formatter.Deserialize(habitFS);
                todos = (Todo[])formatter.Deserialize(todoFS);
                reminders = (Reminder[])formatter.Deserialize(reminderFS);
                events = (Event[])formatter.Deserialize(eventFS);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                return;
            }
            finally
            {
                habitFS.Close();
                todoFS.Close();
                reminderFS.Close();
                eventFS.Close();
            }

            //add all the objects to their respective lists
            habitsBox.Items.AddRange(habits);
            habitsComboBox.Items.AddRange(habits);
            todoBox.Items.AddRange(todos);
            reminderCheckList.Items.AddRange(reminders);
            eventListComboBox.Items.AddRange(events);

        }

        /// <summary>
        /// Unchecks all habits at the beginning of a new day 
        /// </summary>
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

        /// <summary>
        /// Removes an item from the todo list when it is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            todoBox.Items.Remove(todoBox.SelectedItem);
        }

        /// <summary>
        /// Updates the timer's timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTimer_Tick(object sender, EventArgs e)
        {
            if (!timerT.TimerTick())
            {
                timerTimer.Stop();
                string storeText = reminderNotifyIcon.BalloonTipText;
                reminderNotifyIcon.BalloonTipText = "Timer Done";
                reminderNotifyIcon.ShowBalloonTip(30000);
                reminderNotifyIcon.BalloonTipText = storeText;
            }
            timerValue.Text = timerT.ReadTime();
        }

        /// <summary>
        /// Updates the stopwatch's timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchT.StopwatchTick();
            stopwatchValue.Text = stopwatchT.ReadTime();
        }

        /// <summary>
        /// Begins the timer when the start button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStartButton_Click(object sender, EventArgs e)
        {
            timerTimer.Start();
        }

        /// <summary>
        /// Pauses the timer when the stop button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStopButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
        }

        /// <summary>
        /// Resets the timer to 00:00:00 when the reset button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerResetButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
            timerT.ResetTime();
            timerValue.Text = timerT.ReadTime();
        }

        /// <summary>
        /// Sets the timer's value when the set button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSetButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
            timerT.SetTime(Decimal.ToInt32(hoursInput.Value), Decimal.ToInt32(minutesInput.Value), Decimal.ToInt32(secondsInput.Value));
            timerValue.Text = timerT.ReadTime();
        }

        /// <summary>
        /// Starts the stopwatch when the start button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopwatchStartButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Start();
        }

        /// <summary>
        /// Pauses the stopwatch when the stop button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopwatchStopButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
        }

        /// <summary>
        /// Resets the stopwatch to the last set value when the reset button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopwatchResetButton_Click(object sender, EventArgs e)
        {
            stopwatchT.ResetStopwatch();
            stopwatchTimer.Stop();
            stopwatchValue.Text = stopwatchT.ReadTime();
        }

        /// <summary>
        /// Adds an item to the todo list when the add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoButton_Click(object sender, EventArgs e)
        {
            if(todoTextBox.Text == "")
            {
                MessageBox.Show("Please enter a task");
                return;
            }
            todoBox.Items.Add(new Todo(todoTextBox.Text));
            todoTextBox.Text = "";
        }

        /// <summary>
        /// Clears the text box when the user presses enter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                todoButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Clears the text box when the user presses enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void habitsTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                habitsAddButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Removes the selected habit when the remove button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void habitsRemoveButton_Click(object sender, EventArgs e)
        {
            habitsBox.Items.Remove(habitsComboBox.SelectedItem);
            habitsComboBox.Items.Remove(habitsComboBox.SelectedItem);
            habitsComboBox.Text = "";
        }

        /// <summary>
        /// Adds a habit to the list when the add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void habitsAddButton_Click(object sender, EventArgs e)
        {
            if(habitsTextBox.Text == "")
            {
                MessageBox.Show("Please enter a habit name");
                return;
            }
            Habit h = new Habit(habitsTextBox.Text);
            habitsBox.Items.Add(h);
            habitsComboBox.Items.Add(h);
            habitsTextBox.Text = "";
        }

        /// <summary>
        /// Updates a habit object to be done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                ((Habit)habitsBox.SelectedItem).lastDone = DateTime.Now.Date;
            }
        }

        /// <summary>
        /// Handles habit check box enabling and disabling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void habitsBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //when the box is checked, disable it 
            if(e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Indeterminate; 
                //habitsBox.SetItemCheckState(((ItemCheckEventArgs)e).Index, CheckState.Indeterminate);
            }
            //only allow box to be reenabled when trying to disable it - like a toggle
            else if(e.CurrentValue == CheckState.Indeterminate)
            {
                //if new value is not indeterminate and the habit is done, don't change anything
                if (e.NewValue != CheckState.Indeterminate && ((Habit)habitsBox.Items[e.Index]).doneToday)
                    e.NewValue = CheckState.Indeterminate;
                //else the habit is not done, but it had to have been, so it must be that we need to uncheck
                else
                    e.NewValue = CheckState.Unchecked;
            } 
        }

        /// <summary>
        /// Resets habits at midnight every day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dayTimer_Tick(object sender, EventArgs e)
        {
            resetHabits();
        }

        /// <summary>
        /// Adds a new reminder to the list when the add button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reminderAddButton_Click(object sender, EventArgs e)
        {
            if(reminderTextBox.Text == "")
            {
                MessageBox.Show("Please enter a reminder message");
                return;
            }
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

        /// <summary>
        /// Converts a datetime to a datetimetimer interval representing the amount of time between now and the datetime
        /// </summary>
        /// <param name="futureEvent"></param>
        /// <returns></returns>
        private Int32 getTimerTicksUntilDate(DateTime futureEvent)
        {
            //There are 10000 ticks in a millisecond
            return (Int32)futureEvent.Subtract(DateTime.Now).Ticks/10000;
        }

        /// <summary>
        /// Removes all selected reminders when the remove button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reminderRemoveButton_Click(object sender, EventArgs e)
        {
            while(reminderCheckList.CheckedItems.Count > 0)
            {
                //since the items are removed from the checked items list
                //we only need to remove the first item and let the list be continually updated
                reminderCheckList.Items.Remove(reminderCheckList.CheckedItems[0]);
            }
        }

        /// <summary>
        /// Removes a reminder and updates the timer if necessary
        /// </summary>
        /// <param name="r"></param>
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

        /// <summary>
        /// Returns the reminder with the earliest remind date in the reminder list.
        /// Returns null if list is empty 
        /// </summary>
        /// <returns></returns>
        private Reminder findEarliestReminder()
        {
            if(reminderCheckList.Items.Count <= 0)
            {
                return null;
            }
            Reminder returnReminder = (Reminder)reminderCheckList.Items[0];
            foreach(Reminder r in reminderCheckList.Items)
            {
                if (r.remindDate.Ticks <= returnReminder.remindDate.Ticks)
                    returnReminder = r;
            }
            return returnReminder;
        }

        /// <summary>
        /// Returns true if the reminder parameter is the earliest reminder
        /// </summary>
        /// <param name="inRemind"></param>
        /// <returns></returns>
        private bool isEarliestReminder(Reminder inRemind)
        {
            return inRemind.Equals(findEarliestReminder());
        }

        /// <summary>
        /// Updates reminder timer and sets the notify icon component properties
        /// </summary>
        /// <param name="r"></param>
        private void updateReminderTimer(Reminder r)
        {
            reminderNotifyIcon.BalloonTipText = "Reminder: " + r.message;
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

        /// <summary>
        /// Shows the reminder message, deletes the reminder, and updates the timer
        /// </summary>
        private void showReminder()
        {
            //if there are no reminders, return
            if(reminderCheckList.Items.Count <= 0)
            {
                return;
            }
            reminderNotifyIcon.ShowBalloonTip(30000);
            //removeReminder stops the timer when there are no more reminders, so we don't have to update it 
            removeReminder(findEarliestReminder());
            Reminder r = findEarliestReminder();
            if (r != null)
            {
                updateReminderTimer(findEarliestReminder());
            }
        }

        /// <summary>
        /// Adds a new event to the schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventAddButton_Click(object sender, EventArgs e)
        {
            if(eventTextBox.Text == "")
            {
                MessageBox.Show("Please enter an event description");
                return;
            }
            Recur recurrence; 
            switch(recurComboBox.Text)
            {
                case "Annually":
                    recurrence = Recur.Annually;
                    break;
                case "Monthly":
                    recurrence = Recur.Monthly;
                    break;
                case "Weekly":
                    recurrence = Recur.Weekly;
                    break;
                case "Daily":
                    recurrence = Recur.Daily;
                    break;
                default:
                    recurrence = Recur.None;
                    break;
            }
            /*if(DateTime.IsLeapYear(eventMonthCalendar.SelectionStart.Year) &&
                (recurrence == Recur.Monthly || recurrence == Recur.Annually) && 
                (eventMonthCalendar.SelectionStart.DayOfYear == 60)) //feb 29 is 60th day of year
            {
                MessageBox.Show("Cannot create a monthly or annually recurring event on this date.");
                return;
            }*/

            Event newEvent = new Event(eventTextBox.Text, eventMonthCalendar.SelectionStart, recurrence);
            eventListComboBox.Items.Add(newEvent);
            eventTextBox.Text = "";
            //Todo: Add to schedule storage
            updateEventLists();
        }

        /// <summary>
        /// Updates list boxes showing daily, weekly, monthly events relative to selected date
        /// </summary>
        private void updateEventLists()
        {
            dayListBox.Items.Clear();
            weekListBox.Items.Clear();
            monthListBox.Items.Clear();
            
            DateTime selected = eventMonthCalendar.SelectionStart;
            foreach (Event e in eventListComboBox.Items)
            {
                //Daily:
                //Events that recur daily
                //or other recurring events that share the same day of the same month
                //or nonrecurring events that share the same exact date

                //Weekly:
                //Events that recur daily and weekly 
                //or other recurring events that share the same week
                //going off the date it would fall on in that particular year and month
                //or nonrecurring events that share the same week 

                //Monthly:
                //Events that recur daily and weekly and monthly
                //or other recurring events that share the same month
                //or nonrecurring events that share the same month

                //store this datetime so we can restore it 
                //the listed dates will be modified to be relative to the selected date
                DateTime lastDate = e.eventDate;
                if (e.recurrence == Recur.Daily)
                {
                    e.eventDate = selected;
                    dayListBox.Items.Add(e);
                    weekListBox.Items.Add(e);
                    monthListBox.Items.Add(e);
                }
                else if (e.recurrence == Recur.Weekly)
                {


                    //Need to match month and year, 
                    //and then figure out what day the same day of the week falls on 
                    //relative to the selected 
                    System.Globalization.Calendar cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                    int dayOfWeek = (int)cal.GetDayOfWeek(e.eventDate);
                    e.eventDate = new DateTime(selected.Year, selected.Month, selected.Day);
                    e.eventDate = e.eventDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(selected) + dayOfWeek);


                    weekListBox.Items.Add(e);
                    monthListBox.Items.Add(e);
                    //add to daily if they share the same month
                    if(e.eventDate.Month == selected.Month && e.eventDate.Day == selected.Day)
                    {
                        dayListBox.Items.Add(e);
                    }
                }
                else if (e.recurrence == Recur.Monthly)
                {
                    //if there are fewer days in the selected month, the event cannot recur
                    //this should also allow us to create leap year recurrences
                    if (DateTime.DaysInMonth(selected.Year, selected.Month) < e.eventDate.Day)
                    {
                        continue;
                    }
                    e.eventDate = new DateTime(selected.Year, selected.Month, e.eventDate.Day);



                    monthListBox.Items.Add(e);
                    //add to daily if they share the same month and day
                    if(e.eventDate.Day == selected.Day)
                    {
                        dayListBox.Items.Add(e);
                    }
                    //add to weekly if they fall on the same week
                    //this is a great solution found on stack overflow modified to use a datetime relative to the selected date
                    System.Globalization.Calendar cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                    if (e.eventDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(e.eventDate)).Day == selected.AddDays(-1 * (int)cal.GetDayOfWeek(selected)).Day)
                    {
                        weekListBox.Items.Add(e);
                    }
                } 
                else if (e.recurrence == Recur.Annually)
                {
                    if (DateTime.DaysInMonth(selected.Year, e.eventDate.Month) < e.eventDate.Day)
                    {
                        continue;
                    }
                    e.eventDate = new DateTime(selected.Year, e.eventDate.Month, e.eventDate.Day);


                    //add to daily if they share the same month and day
                    if (e.eventDate.Month == selected.Month && e.eventDate.Day == selected.Day)
                    {
                        dayListBox.Items.Add(e);
                    }
                    //add to weekly if they fall on the same week
                    //this is a great solution found on stack overflow 
                    System.Globalization.Calendar cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                    if (e.eventDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(e.eventDate)).Day == selected.AddDays(-1 * (int)cal.GetDayOfWeek(selected)).Day)
                    {
                        weekListBox.Items.Add(e);
                    }
                    //add to monthly if they share the same month
                    if (e.eventDate.Month == selected.Month)
                    {
                        monthListBox.Items.Add(e);
                    }
                }
                //if the event is not repeated, we just need to know 
                else
                {
                    //add to daily if they share the exact same date
                    if (e.eventDate.CompareTo(selected) == 0)
                    {
                        dayListBox.Items.Add(e);
                    }
                    //add to weekly if they share the same week
                    System.Globalization.Calendar cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                    if (e.eventDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(e.eventDate)).Day == selected.AddDays(-1 * (int)cal.GetDayOfWeek(selected)).Day)
                    {
                        weekListBox.Items.Add(e);
                    }
                    //add to monthly if they share the same month
                    if (e.eventDate.Year == selected.Year && e.eventDate.Month == selected.Month)
                    {
                        monthListBox.Items.Add(e);
                    }
                }
                e.eventDate = lastDate;
            }
        }

        /// <summary>
        /// Removes event selected in the combo box from the schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventRemoveButton_Click(object sender, EventArgs e)
        {
           // Todo: remove from schedule storage
            eventListComboBox.Items.Remove(eventListComboBox.SelectedItem);
            eventListComboBox.Text = "";
            updateEventLists();
        }

        /// <summary>
        /// Triggers upon changing date on calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventDateSelected(object sender, DateRangeEventArgs e)
        {
            updateEventLists();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                MessageBox.Show("Settings Saved!\nApplication will load saved settings upon next startup.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while saving. Error: " + ex.ToString());
            }
        }
    }
}
