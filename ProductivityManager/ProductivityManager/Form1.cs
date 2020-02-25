using System;
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
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            todoBox.Items.Remove(todoBox.SelectedItem);
        }

        private void timerTimer_Tick(object sender, EventArgs e)
        {
            if (!timerT.TimerTick())
            {
                timerTimer.Stop();
                //todo: generate a notification 
            }
            timerValue.Text = timerT.ReadTime();
        }

        private void stopwatchTimer_Tick(object sender, EventArgs e)
        {
            stopwatchT.StopwatchTick();
            stopwatchValue.Text = stopwatchT.ReadTime();
        }

        private void timerStartButton_Click(object sender, EventArgs e)
        {
            timerTimer.Start();
        }

        private void timerStopButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
        }

        private void timerResetButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
            timerT.ResetTime();
            timerValue.Text = timerT.ReadTime();
        }

        private void timerSetButton_Click(object sender, EventArgs e)
        {
            timerTimer.Stop();
            timerT.SetTime(Decimal.ToInt32(hoursInput.Value), Decimal.ToInt32(minutesInput.Value), Decimal.ToInt32(secondsInput.Value));
            timerValue.Text = timerT.ReadTime();
        }

        private void stopwatchStartButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Start();
        }

        private void stopwatchStopButton_Click(object sender, EventArgs e)
        {
            stopwatchTimer.Stop();
        }

        private void stopwatchResetButton_Click(object sender, EventArgs e)
        {
            stopwatchT.ResetStopwatch();
            stopwatchTimer.Stop();
            stopwatchValue.Text = stopwatchT.ReadTime();
        }

        private void todoButton_Click(object sender, EventArgs e)
        {
            todoBox.Items.Add(new Todo(todoTextBox.Text));
            todoTextBox.Text = "";
        }

        private void todoTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                todoButton_Click(sender, e);
            }
        }

        private void habitsTextBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                habitsAddButton_Click(sender, e);
            }
        }

        private void habitsRemoveButton_Click(object sender, EventArgs e)
        {
            habitsBox.Items.Remove(habitsComboBox.SelectedItem);
            habitsComboBox.Items.Remove(habitsComboBox.SelectedItem);
            habitsComboBox.Text = "";
        }

        private void habitsAddButton_Click(object sender, EventArgs e)
        {
            Habit h = new Habit(habitsTextBox.Text);
            habitsBox.Items.Add(h);
            habitsComboBox.Items.Add(h);
            habitsTextBox.Text = "";
        }

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

        private void habitsBox_ItemCheck(object sender, EventArgs e)
        {
            //when the box is checked, disable it 
            if(((ItemCheckEventArgs)e).NewValue == CheckState.Checked)
            {
                ((ItemCheckEventArgs)e).NewValue = CheckState.Indeterminate; 
                //habitsBox.SetItemCheckState(((ItemCheckEventArgs)e).Index, CheckState.Indeterminate);
            }
            //only allow box to be reenabled when trying to disable it - like a toggle
            if(((ItemCheckEventArgs)e).CurrentValue == CheckState.Indeterminate
                && ((ItemCheckEventArgs)e).NewValue != CheckState.Indeterminate)
            {
                ((ItemCheckEventArgs)e).NewValue = CheckState.Indeterminate;
            }
        }
    }
}
