namespace ProductivityManager
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.todoBox = new System.Windows.Forms.CheckedListBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.todoPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.todoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.todoButton = new System.Windows.Forms.Button();
            this.habitsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.habitsBox = new System.Windows.Forms.CheckedListBox();
            this.habitsTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.habitsAddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.habitsRemoveButton = new System.Windows.Forms.Button();
            this.habitsComboBox = new System.Windows.Forms.ComboBox();
            this.remindersPage = new System.Windows.Forms.TabPage();
            this.blockerPage = new System.Windows.Forms.TabPage();
            this.schedulePage = new System.Windows.Forms.TabPage();
            this.timerPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.minutesInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.secondsInput = new System.Windows.Forms.NumericUpDown();
            this.timerSetButton = new System.Windows.Forms.Button();
            this.stopwatchLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerValue = new System.Windows.Forms.Label();
            this.stopwatchValue = new System.Windows.Forms.Label();
            this.timerStartButton = new System.Windows.Forms.Button();
            this.stopwatchStartButton = new System.Windows.Forms.Button();
            this.timerStopButton = new System.Windows.Forms.Button();
            this.stopwatchStopButton = new System.Windows.Forms.Button();
            this.stopwatchResetButton = new System.Windows.Forms.Button();
            this.timerResetButton = new System.Windows.Forms.Button();
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.stopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.dayTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.reminderTextBox = new System.Windows.Forms.TextBox();
            this.reminderAddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.reminderRemoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.reminderDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reminderTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reminderCheckList = new System.Windows.Forms.CheckedListBox();
            this.tabs.SuspendLayout();
            this.todoPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.habitsPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.remindersPage.SuspendLayout();
            this.timerPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsInput)).BeginInit();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // todoBox
            // 
            this.todoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoBox.CheckOnClick = true;
            this.todoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoBox.FormattingEnabled = true;
            this.todoBox.Location = new System.Drawing.Point(5, 5);
            this.todoBox.Margin = new System.Windows.Forms.Padding(5);
            this.todoBox.Name = "todoBox";
            this.tableLayoutPanel3.SetRowSpan(this.todoBox, 2);
            this.todoBox.Size = new System.Drawing.Size(531, 500);
            this.todoBox.TabIndex = 0;
            this.todoBox.ThreeDCheckBoxes = true;
            this.todoBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.todoPage);
            this.tabs.Controls.Add(this.habitsPage);
            this.tabs.Controls.Add(this.remindersPage);
            this.tabs.Controls.Add(this.blockerPage);
            this.tabs.Controls.Add(this.schedulePage);
            this.tabs.Controls.Add(this.timerPage);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(982, 553);
            this.tabs.TabIndex = 1;
            // 
            // todoPage
            // 
            this.todoPage.Controls.Add(this.tableLayoutPanel3);
            this.todoPage.Location = new System.Drawing.Point(4, 33);
            this.todoPage.Name = "todoPage";
            this.todoPage.Padding = new System.Windows.Forms.Padding(3);
            this.todoPage.Size = new System.Drawing.Size(974, 516);
            this.todoPage.TabIndex = 0;
            this.todoPage.Text = "To Do";
            this.todoPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.88843F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.11157F));
            this.tableLayoutPanel3.Controls.Add(this.todoBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.todoTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.19608F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(968, 510);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // todoTextBox
            // 
            this.todoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoTextBox.Location = new System.Drawing.Point(544, 3);
            this.todoTextBox.Name = "todoTextBox";
            this.todoTextBox.Size = new System.Drawing.Size(421, 31);
            this.todoTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.todoButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(544, 52);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(421, 124);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // todoButton
            // 
            this.todoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todoButton.Location = new System.Drawing.Point(3, 3);
            this.todoButton.Name = "todoButton";
            this.todoButton.Size = new System.Drawing.Size(204, 56);
            this.todoButton.TabIndex = 0;
            this.todoButton.Text = "Add Item";
            this.todoButton.UseVisualStyleBackColor = true;
            this.todoButton.Click += new System.EventHandler(this.todoButton_Click);
            // 
            // habitsPage
            // 
            this.habitsPage.Controls.Add(this.tableLayoutPanel5);
            this.habitsPage.Location = new System.Drawing.Point(4, 33);
            this.habitsPage.Name = "habitsPage";
            this.habitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.habitsPage.Size = new System.Drawing.Size(974, 516);
            this.habitsPage.TabIndex = 1;
            this.habitsPage.Text = "Habits";
            this.habitsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.habitsBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.habitsTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.habitsComboBox, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(968, 510);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // habitsBox
            // 
            this.habitsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.habitsBox.CheckOnClick = true;
            this.habitsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitsBox.FormattingEnabled = true;
            this.habitsBox.Location = new System.Drawing.Point(3, 3);
            this.habitsBox.Name = "habitsBox";
            this.tableLayoutPanel5.SetRowSpan(this.habitsBox, 4);
            this.habitsBox.Size = new System.Drawing.Size(478, 504);
            this.habitsBox.TabIndex = 0;
            this.habitsBox.SelectedIndexChanged += new System.EventHandler(this.habitsBox_SelectedIndexChanged);
            // 
            // habitsTextBox
            // 
            this.habitsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitsTextBox.Location = new System.Drawing.Point(487, 3);
            this.habitsTextBox.Name = "habitsTextBox";
            this.habitsTextBox.Size = new System.Drawing.Size(478, 31);
            this.habitsTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.habitsAddButton, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(487, 88);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(478, 163);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // habitsAddButton
            // 
            this.habitsAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitsAddButton.Location = new System.Drawing.Point(3, 3);
            this.habitsAddButton.Name = "habitsAddButton";
            this.habitsAddButton.Size = new System.Drawing.Size(233, 75);
            this.habitsAddButton.TabIndex = 0;
            this.habitsAddButton.Text = "Add Habit";
            this.habitsAddButton.UseVisualStyleBackColor = true;
            this.habitsAddButton.Click += new System.EventHandler(this.habitsAddButton_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.habitsRemoveButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(487, 342);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(478, 165);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // habitsRemoveButton
            // 
            this.habitsRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitsRemoveButton.Location = new System.Drawing.Point(3, 3);
            this.habitsRemoveButton.Name = "habitsRemoveButton";
            this.habitsRemoveButton.Size = new System.Drawing.Size(233, 76);
            this.habitsRemoveButton.TabIndex = 0;
            this.habitsRemoveButton.Text = "Remove Habit";
            this.habitsRemoveButton.UseVisualStyleBackColor = true;
            this.habitsRemoveButton.Click += new System.EventHandler(this.habitsRemoveButton_Click);
            // 
            // habitsComboBox
            // 
            this.habitsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitsComboBox.FormattingEnabled = true;
            this.habitsComboBox.Location = new System.Drawing.Point(487, 257);
            this.habitsComboBox.Name = "habitsComboBox";
            this.habitsComboBox.Size = new System.Drawing.Size(478, 32);
            this.habitsComboBox.TabIndex = 4;
            // 
            // remindersPage
            // 
            this.remindersPage.Controls.Add(this.tableLayoutPanel8);
            this.remindersPage.Location = new System.Drawing.Point(4, 33);
            this.remindersPage.Name = "remindersPage";
            this.remindersPage.Padding = new System.Windows.Forms.Padding(3);
            this.remindersPage.Size = new System.Drawing.Size(974, 516);
            this.remindersPage.TabIndex = 2;
            this.remindersPage.Text = "Reminders";
            this.remindersPage.UseVisualStyleBackColor = true;
            // 
            // blockerPage
            // 
            this.blockerPage.Location = new System.Drawing.Point(4, 33);
            this.blockerPage.Name = "blockerPage";
            this.blockerPage.Padding = new System.Windows.Forms.Padding(3);
            this.blockerPage.Size = new System.Drawing.Size(974, 516);
            this.blockerPage.TabIndex = 3;
            this.blockerPage.Text = "Blocker";
            this.blockerPage.UseVisualStyleBackColor = true;
            // 
            // schedulePage
            // 
            this.schedulePage.Location = new System.Drawing.Point(4, 33);
            this.schedulePage.Name = "schedulePage";
            this.schedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.schedulePage.Size = new System.Drawing.Size(974, 516);
            this.schedulePage.TabIndex = 4;
            this.schedulePage.Text = "Schedule";
            this.schedulePage.UseVisualStyleBackColor = true;
            // 
            // timerPage
            // 
            this.timerPage.Controls.Add(this.tableLayoutPanel1);
            this.timerPage.Location = new System.Drawing.Point(4, 33);
            this.timerPage.Name = "timerPage";
            this.timerPage.Padding = new System.Windows.Forms.Padding(3);
            this.timerPage.Size = new System.Drawing.Size(974, 516);
            this.timerPage.TabIndex = 5;
            this.timerPage.Text = "Timer/Stopwatch";
            this.timerPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.timerValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.timerStartButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchStartButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.timerStopButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchStopButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchResetButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.timerResetButton, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 510);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.timerSetButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 273);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 84);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.hoursInput);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.minutesInput);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.secondsInput);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours:";
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(72, 3);
            this.hoursInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(56, 31);
            this.hoursInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutes:";
            // 
            // minutesInput
            // 
            this.minutesInput.Location = new System.Drawing.Point(218, 3);
            this.minutesInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesInput.Name = "minutesInput";
            this.minutesInput.Size = new System.Drawing.Size(56, 31);
            this.minutesInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seconds:";
            // 
            // secondsInput
            // 
            this.secondsInput.Location = new System.Drawing.Point(369, 3);
            this.secondsInput.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsInput.Name = "secondsInput";
            this.secondsInput.Size = new System.Drawing.Size(56, 31);
            this.secondsInput.TabIndex = 5;
            // 
            // timerSetButton
            // 
            this.timerSetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerSetButton.Location = new System.Drawing.Point(3, 45);
            this.timerSetButton.Name = "timerSetButton";
            this.timerSetButton.Size = new System.Drawing.Size(233, 36);
            this.timerSetButton.TabIndex = 1;
            this.timerSetButton.Text = "Set Time";
            this.timerSetButton.UseVisualStyleBackColor = true;
            this.timerSetButton.Click += new System.EventHandler(this.timerSetButton_Click);
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.Location = new System.Drawing.Point(487, 0);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(478, 120);
            this.stopwatchLabel.TabIndex = 1;
            this.stopwatchLabel.Text = "Stopwatch";
            this.stopwatchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(3, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(478, 34);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Countdown Timer";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerValue
            // 
            this.timerValue.AutoSize = true;
            this.timerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerValue.Location = new System.Drawing.Point(3, 120);
            this.timerValue.Name = "timerValue";
            this.timerValue.Size = new System.Drawing.Size(478, 150);
            this.timerValue.TabIndex = 4;
            this.timerValue.Text = "00:00:00";
            this.timerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopwatchValue
            // 
            this.stopwatchValue.AutoSize = true;
            this.stopwatchValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchValue.Location = new System.Drawing.Point(487, 120);
            this.stopwatchValue.Name = "stopwatchValue";
            this.stopwatchValue.Size = new System.Drawing.Size(478, 150);
            this.stopwatchValue.TabIndex = 5;
            this.stopwatchValue.Text = "00:00:00";
            this.stopwatchValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerStartButton
            // 
            this.timerStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerStartButton.Location = new System.Drawing.Point(3, 363);
            this.timerStartButton.Name = "timerStartButton";
            this.timerStartButton.Size = new System.Drawing.Size(478, 44);
            this.timerStartButton.TabIndex = 2;
            this.timerStartButton.Text = "Start Timer";
            this.timerStartButton.UseVisualStyleBackColor = true;
            this.timerStartButton.Click += new System.EventHandler(this.timerStartButton_Click);
            // 
            // stopwatchStartButton
            // 
            this.stopwatchStartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchStartButton.Location = new System.Drawing.Point(487, 363);
            this.stopwatchStartButton.Name = "stopwatchStartButton";
            this.stopwatchStartButton.Size = new System.Drawing.Size(478, 44);
            this.stopwatchStartButton.TabIndex = 3;
            this.stopwatchStartButton.Text = "Start Stopwatch";
            this.stopwatchStartButton.UseVisualStyleBackColor = true;
            this.stopwatchStartButton.Click += new System.EventHandler(this.stopwatchStartButton_Click);
            // 
            // timerStopButton
            // 
            this.timerStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerStopButton.Location = new System.Drawing.Point(3, 413);
            this.timerStopButton.Name = "timerStopButton";
            this.timerStopButton.Size = new System.Drawing.Size(478, 44);
            this.timerStopButton.TabIndex = 7;
            this.timerStopButton.Text = "Stop Timer";
            this.timerStopButton.UseVisualStyleBackColor = true;
            this.timerStopButton.Click += new System.EventHandler(this.timerStopButton_Click);
            // 
            // stopwatchStopButton
            // 
            this.stopwatchStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchStopButton.Location = new System.Drawing.Point(487, 413);
            this.stopwatchStopButton.Name = "stopwatchStopButton";
            this.stopwatchStopButton.Size = new System.Drawing.Size(478, 44);
            this.stopwatchStopButton.TabIndex = 8;
            this.stopwatchStopButton.Text = "Stop Stopwatch";
            this.stopwatchStopButton.UseVisualStyleBackColor = true;
            this.stopwatchStopButton.Click += new System.EventHandler(this.stopwatchStopButton_Click);
            // 
            // stopwatchResetButton
            // 
            this.stopwatchResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchResetButton.Location = new System.Drawing.Point(487, 463);
            this.stopwatchResetButton.Name = "stopwatchResetButton";
            this.stopwatchResetButton.Size = new System.Drawing.Size(478, 44);
            this.stopwatchResetButton.TabIndex = 10;
            this.stopwatchResetButton.Text = "Reset Stopwatch";
            this.stopwatchResetButton.UseVisualStyleBackColor = true;
            this.stopwatchResetButton.Click += new System.EventHandler(this.stopwatchResetButton_Click);
            // 
            // timerResetButton
            // 
            this.timerResetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerResetButton.Location = new System.Drawing.Point(3, 463);
            this.timerResetButton.Name = "timerResetButton";
            this.timerResetButton.Size = new System.Drawing.Size(478, 44);
            this.timerResetButton.TabIndex = 11;
            this.timerResetButton.Text = "Reset Timer";
            this.timerResetButton.UseVisualStyleBackColor = true;
            this.timerResetButton.Click += new System.EventHandler(this.timerResetButton_Click);
            // 
            // timerTimer
            // 
            this.timerTimer.Interval = 1000;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // stopwatchTimer
            // 
            this.stopwatchTimer.Interval = 1000;
            this.stopwatchTimer.Tick += new System.EventHandler(this.stopwatchTimer_Tick);
            // 
            // dayTimer
            // 
            this.dayTimer.Tick += new System.EventHandler(this.dayTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.reminderCheckList, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.92157F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.07843F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(968, 510);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.45607F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.54393F));
            this.tableLayoutPanel9.Controls.Add(this.reminderTextBox, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.reminderAddButton, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(487, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(478, 167);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // reminderTextBox
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.reminderTextBox, 2);
            this.reminderTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reminderTextBox.Location = new System.Drawing.Point(3, 49);
            this.reminderTextBox.Name = "reminderTextBox";
            this.reminderTextBox.Size = new System.Drawing.Size(472, 31);
            this.reminderTextBox.TabIndex = 0;
            // 
            // reminderAddButton
            // 
            this.reminderAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderAddButton.Location = new System.Drawing.Point(335, 86);
            this.reminderAddButton.Name = "reminderAddButton";
            this.reminderAddButton.Size = new System.Drawing.Size(140, 78);
            this.reminderAddButton.TabIndex = 2;
            this.reminderAddButton.Text = "Add Reminder";
            this.reminderAddButton.UseVisualStyleBackColor = true;
            this.reminderAddButton.Click += new System.EventHandler(this.reminderAddButton_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.reminderRemoveButton, 1, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(487, 176);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.77465F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.22535F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(478, 331);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // reminderRemoveButton
            // 
            this.reminderRemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderRemoveButton.Location = new System.Drawing.Point(242, 253);
            this.reminderRemoveButton.Name = "reminderRemoveButton";
            this.reminderRemoveButton.Size = new System.Drawing.Size(233, 75);
            this.reminderRemoveButton.TabIndex = 0;
            this.reminderRemoveButton.Text = "Remove Reminders";
            this.reminderRemoveButton.UseVisualStyleBackColor = true;
            this.reminderRemoveButton.Click += new System.EventHandler(this.reminderRemoveButton_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.reminderDatePicker, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.reminderTimePicker, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 86);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(326, 78);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // reminderDatePicker
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.reminderDatePicker, 2);
            this.reminderDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderDatePicker.Location = new System.Drawing.Point(3, 3);
            this.reminderDatePicker.Name = "reminderDatePicker";
            this.reminderDatePicker.Size = new System.Drawing.Size(320, 31);
            this.reminderDatePicker.TabIndex = 0;
            // 
            // reminderTimePicker
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.reminderTimePicker, 2);
            this.reminderTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reminderTimePicker.Location = new System.Drawing.Point(3, 42);
            this.reminderTimePicker.Name = "reminderTimePicker";
            this.reminderTimePicker.ShowUpDown = true;
            this.reminderTimePicker.Size = new System.Drawing.Size(320, 31);
            this.reminderTimePicker.TabIndex = 1;
            // 
            // reminderCheckList
            // 
            this.reminderCheckList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminderCheckList.FormattingEnabled = true;
            this.reminderCheckList.Location = new System.Drawing.Point(3, 3);
            this.reminderCheckList.Name = "reminderCheckList";
            this.tableLayoutPanel8.SetRowSpan(this.reminderCheckList, 2);
            this.reminderCheckList.Size = new System.Drawing.Size(478, 504);
            this.reminderCheckList.TabIndex = 2;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Manager";
            this.Text = "Productivity Manager";
            this.tabs.ResumeLayout(false);
            this.todoPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.habitsPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.remindersPage.ResumeLayout(false);
            this.timerPage.ResumeLayout(false);
            this.timerPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsInput)).EndInit();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox todoBox;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage todoPage;
        private System.Windows.Forms.TabPage habitsPage;
        private System.Windows.Forms.TabPage remindersPage;
        private System.Windows.Forms.TabPage blockerPage;
        private System.Windows.Forms.TabPage schedulePage;
        private System.Windows.Forms.TabPage timerPage;
        private System.Windows.Forms.Label stopwatchLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button stopwatchStartButton;
        private System.Windows.Forms.Button timerStartButton;
        private System.Windows.Forms.Label timerValue;
        private System.Windows.Forms.Label stopwatchValue;
        private System.Windows.Forms.Button timerStopButton;
        private System.Windows.Forms.Button stopwatchStopButton;
        private System.Windows.Forms.Button stopwatchResetButton;
        private System.Windows.Forms.Button timerResetButton;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.Timer stopwatchTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hoursInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown minutesInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown secondsInput;
        private System.Windows.Forms.Button timerSetButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox todoTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button todoButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckedListBox habitsBox;
        private System.Windows.Forms.TextBox habitsTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button habitsAddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button habitsRemoveButton;
        private System.Windows.Forms.ComboBox habitsComboBox;
        private System.Windows.Forms.Timer dayTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox reminderTextBox;
        private System.Windows.Forms.Button reminderAddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button reminderRemoveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.DateTimePicker reminderDatePicker;
        private System.Windows.Forms.DateTimePicker reminderTimePicker;
        private System.Windows.Forms.CheckedListBox reminderCheckList;
    }
}

