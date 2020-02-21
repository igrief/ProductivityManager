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
            this.tabs.SuspendLayout();
            this.todoPage.SuspendLayout();
            this.habitsPage.SuspendLayout();
            this.timerPage.SuspendLayout();
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
            this.checkedListBox1.Size = new System.Drawing.Size(241, 235);
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
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 506);
            this.tabs.TabIndex = 1;
            // 
            // todoPage
            // 
            this.todoPage.Controls.Add(this.checkedListBox1);
            this.todoPage.Location = new System.Drawing.Point(4, 25);
            this.todoPage.Name = "todoPage";
            this.todoPage.Padding = new System.Windows.Forms.Padding(3);
            this.todoPage.Size = new System.Drawing.Size(792, 477);
            this.todoPage.TabIndex = 0;
            this.todoPage.Text = "To Do";
            this.todoPage.UseVisualStyleBackColor = true;
            // 
            // habitsPage
            // 
            this.habitsPage.Controls.Add(this.checkBox1);
            this.habitsPage.Location = new System.Drawing.Point(4, 25);
            this.habitsPage.Name = "habitsPage";
            this.habitsPage.Padding = new System.Windows.Forms.Padding(3);
            this.habitsPage.Size = new System.Drawing.Size(792, 477);
            this.habitsPage.TabIndex = 1;
            this.habitsPage.Text = "Habits";
            this.habitsPage.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 23);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // remindersPage
            // 
            this.remindersPage.Location = new System.Drawing.Point(4, 25);
            this.remindersPage.Name = "remindersPage";
            this.remindersPage.Padding = new System.Windows.Forms.Padding(3);
            this.remindersPage.Size = new System.Drawing.Size(792, 477);
            this.remindersPage.TabIndex = 2;
            this.remindersPage.Text = "Reminders";
            this.remindersPage.UseVisualStyleBackColor = true;
            // 
            // blockerPage
            // 
            this.blockerPage.Location = new System.Drawing.Point(4, 25);
            this.blockerPage.Name = "blockerPage";
            this.blockerPage.Padding = new System.Windows.Forms.Padding(3);
            this.blockerPage.Size = new System.Drawing.Size(792, 477);
            this.blockerPage.TabIndex = 3;
            this.blockerPage.Text = "Blocker";
            this.blockerPage.UseVisualStyleBackColor = true;
            // 
            // schedulePage
            // 
            this.schedulePage.Location = new System.Drawing.Point(4, 25);
            this.schedulePage.Name = "schedulePage";
            this.schedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.schedulePage.Size = new System.Drawing.Size(792, 477);
            this.schedulePage.TabIndex = 4;
            this.schedulePage.Text = "Schedule";
            this.schedulePage.UseVisualStyleBackColor = true;
            // 
            // timerPage
            // 
            this.timerPage.Controls.Add(this.stopwatchLabel);
            this.timerPage.Controls.Add(this.timerLabel);
            this.timerPage.Location = new System.Drawing.Point(4, 27);
            this.timerPage.Name = "timerPage";
            this.timerPage.Padding = new System.Windows.Forms.Padding(3);
            this.timerPage.Size = new System.Drawing.Size(792, 475);
            this.timerPage.TabIndex = 5;
            this.timerPage.Text = "Timer/Stopwatch";
            this.timerPage.UseVisualStyleBackColor = true;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(144, 70);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(84, 34);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "Timer";
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopwatchLabel.Location = new System.Drawing.Point(492, 70);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(140, 34);
            this.stopwatchLabel.TabIndex = 1;
            this.stopwatchLabel.Text = "Stopwatch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Productivity Manager";
            this.tabs.ResumeLayout(false);
            this.todoPage.ResumeLayout(false);
            this.habitsPage.ResumeLayout(false);
            this.habitsPage.PerformLayout();
            this.timerPage.ResumeLayout(false);
            this.timerPage.PerformLayout();
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
    }
}

