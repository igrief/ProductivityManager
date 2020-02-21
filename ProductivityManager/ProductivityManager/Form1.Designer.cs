namespace ProductivityManager
{
    partial class Form1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.todoPage = new System.Windows.Forms.TabPage();
            this.habitsPage = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.remindersPage = new System.Windows.Forms.TabPage();
            this.blockerPage = new System.Windows.Forms.TabPage();
            this.schedulePage = new System.Windows.Forms.TabPage();
            this.timerPage = new System.Windows.Forms.TabPage();
            this.timerLabel = new System.Windows.Forms.Label();
            this.stopwatchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerStartButton = new System.Windows.Forms.Button();
            this.stopwatchStartButton = new System.Windows.Forms.Button();
            this.timerValue = new System.Windows.Forms.Label();
            this.stopwatchValue = new System.Windows.Forms.Label();
            this.timerStopButton = new System.Windows.Forms.Button();
            this.stopwatchStopButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.stopwatchSetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.stopwatchResetButton = new System.Windows.Forms.Button();
            this.timerResetButton = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.todoPage.SuspendLayout();
            this.habitsPage.SuspendLayout();
            this.timerPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "abc",
            "def",
            "gfyc"});
            this.checkedListBox1.Location = new System.Drawing.Point(49, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(241, 238);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
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
            this.todoPage.Controls.Add(this.checkedListBox1);
            this.todoPage.Location = new System.Drawing.Point(4, 33);
            this.todoPage.Name = "todoPage";
            this.todoPage.Padding = new System.Windows.Forms.Padding(3);
            this.todoPage.Size = new System.Drawing.Size(792, 469);
            this.todoPage.TabIndex = 0;
            this.todoPage.Text = "To Do";
            this.todoPage.UseVisualStyleBackColor = true;
            // 
            // habitsPage
            // 
            this.habitsPage.Controls.Add(this.checkBox1);
            this.habitsPage.Location = new System.Drawing.Point(4, 33);
            this.habitsPage.Name = "habitsPage";
            this.habitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.habitsPage.Size = new System.Drawing.Size(792, 469);
            this.habitsPage.TabIndex = 1;
            this.habitsPage.Text = "Habits";
            this.habitsPage.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // remindersPage
            // 
            this.remindersPage.Location = new System.Drawing.Point(4, 33);
            this.remindersPage.Name = "remindersPage";
            this.remindersPage.Padding = new System.Windows.Forms.Padding(3);
            this.remindersPage.Size = new System.Drawing.Size(792, 469);
            this.remindersPage.TabIndex = 2;
            this.remindersPage.Text = "Reminders";
            this.remindersPage.UseVisualStyleBackColor = true;
            // 
            // blockerPage
            // 
            this.blockerPage.Location = new System.Drawing.Point(4, 27);
            this.blockerPage.Name = "blockerPage";
            this.blockerPage.Padding = new System.Windows.Forms.Padding(3);
            this.blockerPage.Size = new System.Drawing.Size(792, 475);
            this.blockerPage.TabIndex = 3;
            this.blockerPage.Text = "Blocker";
            this.blockerPage.UseVisualStyleBackColor = true;
            // 
            // schedulePage
            // 
            this.schedulePage.Location = new System.Drawing.Point(4, 33);
            this.schedulePage.Name = "schedulePage";
            this.schedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.schedulePage.Size = new System.Drawing.Size(792, 469);
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
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(3, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(478, 34);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Timer";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.Location = new System.Drawing.Point(487, 0);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(478, 55);
            this.stopwatchLabel.TabIndex = 1;
            this.stopwatchLabel.Text = "Stopwatch";
            this.stopwatchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stopwatchLabel.Click += new System.EventHandler(this.stopwatchLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.stopwatchLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.timerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.timerValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.timerStartButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchStartButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.timerStopButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchStopButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stopwatchResetButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.timerResetButton, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 510);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // 
            // timerValue
            // 
            this.timerValue.AutoSize = true;
            this.timerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerValue.Location = new System.Drawing.Point(3, 55);
            this.timerValue.Name = "timerValue";
            this.timerValue.Size = new System.Drawing.Size(478, 215);
            this.timerValue.TabIndex = 4;
            this.timerValue.Text = "00:00:00";
            this.timerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopwatchValue
            // 
            this.stopwatchValue.AutoSize = true;
            this.stopwatchValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchValue.Location = new System.Drawing.Point(487, 55);
            this.stopwatchValue.Name = "stopwatchValue";
            this.stopwatchValue.Size = new System.Drawing.Size(478, 215);
            this.stopwatchValue.TabIndex = 5;
            this.stopwatchValue.Text = "00:00:00";
            this.stopwatchValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.stopwatchSetButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(487, 273);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(478, 84);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(472, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // stopwatchSetButton
            // 
            this.stopwatchSetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopwatchSetButton.Location = new System.Drawing.Point(3, 45);
            this.stopwatchSetButton.Name = "stopwatchSetButton";
            this.stopwatchSetButton.Size = new System.Drawing.Size(233, 36);
            this.stopwatchSetButton.TabIndex = 1;
            this.stopwatchSetButton.Text = "Set Time";
            this.stopwatchSetButton.UseVisualStyleBackColor = true;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(72, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 31);
            this.numericUpDown1.TabIndex = 1;
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(218, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 31);
            this.numericUpDown2.TabIndex = 3;
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
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(369, 3);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(56, 31);
            this.numericUpDown3.TabIndex = 5;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Form1";
            this.Text = "Productivity Manager";
            this.tabs.ResumeLayout(false);
            this.todoPage.ResumeLayout(false);
            this.habitsPage.ResumeLayout(false);
            this.habitsPage.PerformLayout();
            this.timerPage.ResumeLayout(false);
            this.timerPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage todoPage;
        private System.Windows.Forms.TabPage habitsPage;
        private System.Windows.Forms.CheckBox checkBox1;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button stopwatchSetButton;
        private System.Windows.Forms.Button stopwatchResetButton;
        private System.Windows.Forms.Button timerResetButton;
    }
}

