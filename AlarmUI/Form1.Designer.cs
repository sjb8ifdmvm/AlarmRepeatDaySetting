namespace AlertUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RepeatDaysGroup = new System.Windows.Forms.GroupBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.buttonClearOption = new System.Windows.Forms.Button();
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.TextOutputMessage = new System.Windows.Forms.TextBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.alarmTypeGroup = new System.Windows.Forms.GroupBox();
            this.alarmModeB = new System.Windows.Forms.RadioButton();
            this.alarmModeA = new System.Windows.Forms.RadioButton();
            this.ButtonGroup = new System.Windows.Forms.GroupBox();
            this.RepeatDaysGroup.SuspendLayout();
            this.OutputGroup.SuspendLayout();
            this.alarmTypeGroup.SuspendLayout();
            this.ButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // RepeatDaysGroup
            // 
            this.RepeatDaysGroup.Controls.Add(this.checkBoxThursday);
            this.RepeatDaysGroup.Controls.Add(this.checkBoxSunday);
            this.RepeatDaysGroup.Controls.Add(this.checkBoxSaturday);
            this.RepeatDaysGroup.Controls.Add(this.checkBoxFriday);
            this.RepeatDaysGroup.Controls.Add(this.checkBoxWednesday);
            this.RepeatDaysGroup.Controls.Add(this.checkBoxTuesday);
            this.RepeatDaysGroup.Controls.Add(this.checkBoxMonday);
            this.RepeatDaysGroup.Location = new System.Drawing.Point(12, 67);
            this.RepeatDaysGroup.Name = "RepeatDaysGroup";
            this.RepeatDaysGroup.Size = new System.Drawing.Size(267, 232);
            this.RepeatDaysGroup.TabIndex = 0;
            this.RepeatDaysGroup.TabStop = false;
            this.RepeatDaysGroup.Text = "重複日";
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Location = new System.Drawing.Point(141, 81);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxThursday.TabIndex = 0;
            this.checkBoxThursday.Text = "星期四";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            this.checkBoxThursday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Location = new System.Drawing.Point(16, 173);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxSunday.TabIndex = 0;
            this.checkBoxSunday.Text = "星期日";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            this.checkBoxSunday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(141, 127);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxSaturday.TabIndex = 0;
            this.checkBoxSaturday.Text = "星期六";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            this.checkBoxSaturday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Location = new System.Drawing.Point(16, 127);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxFriday.TabIndex = 0;
            this.checkBoxFriday.Text = "星期五";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            this.checkBoxFriday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Location = new System.Drawing.Point(16, 81);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxWednesday.TabIndex = 0;
            this.checkBoxWednesday.Text = "星期三";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            this.checkBoxWednesday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(141, 33);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxTuesday.TabIndex = 0;
            this.checkBoxTuesday.Text = "星期二";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            this.checkBoxTuesday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Location = new System.Drawing.Point(16, 33);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxMonday.TabIndex = 0;
            this.checkBoxMonday.Text = "星期一";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            this.checkBoxMonday.Click += new System.EventHandler(this.RepeatGroupWeekCheckBox_Click);
            // 
            // buttonClearOption
            // 
            this.buttonClearOption.Location = new System.Drawing.Point(6, 47);
            this.buttonClearOption.Name = "buttonClearOption";
            this.buttonClearOption.Size = new System.Drawing.Size(161, 87);
            this.buttonClearOption.TabIndex = 2;
            this.buttonClearOption.Text = "清除重選";
            this.buttonClearOption.UseVisualStyleBackColor = true;
            this.buttonClearOption.Click += new System.EventHandler(this.buttonClearOption_Click);
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.TextOutputMessage);
            this.OutputGroup.Location = new System.Drawing.Point(12, 305);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(455, 76);
            this.OutputGroup.TabIndex = 1;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "輸出";
            // 
            // TextOutputMessage
            // 
            this.TextOutputMessage.Location = new System.Drawing.Point(16, 32);
            this.TextOutputMessage.Name = "TextOutputMessage";
            this.TextOutputMessage.Size = new System.Drawing.Size(433, 33);
            this.TextOutputMessage.TabIndex = 0;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(6, 176);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(161, 87);
            this.buttonFinish.TabIndex = 2;
            this.buttonFinish.Text = "結束";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // alarmTypeGroup
            // 
            this.alarmTypeGroup.Controls.Add(this.alarmModeB);
            this.alarmTypeGroup.Controls.Add(this.alarmModeA);
            this.alarmTypeGroup.Location = new System.Drawing.Point(12, 2);
            this.alarmTypeGroup.Name = "alarmTypeGroup";
            this.alarmTypeGroup.Size = new System.Drawing.Size(267, 59);
            this.alarmTypeGroup.TabIndex = 3;
            this.alarmTypeGroup.TabStop = false;
            this.alarmTypeGroup.Text = "模式";
            // 
            // alarmModeB
            // 
            this.alarmModeB.AutoSize = true;
            this.alarmModeB.Location = new System.Drawing.Point(141, 28);
            this.alarmModeB.Name = "alarmModeB";
            this.alarmModeB.Size = new System.Drawing.Size(90, 25);
            this.alarmModeB.TabIndex = 0;
            this.alarmModeB.Text = "B模式";
            this.alarmModeB.UseVisualStyleBackColor = true;
            this.alarmModeB.Click += new System.EventHandler(this.AlarmType_Click);
            // 
            // alarmModeA
            // 
            this.alarmModeA.AutoSize = true;
            this.alarmModeA.Checked = true;
            this.alarmModeA.Location = new System.Drawing.Point(6, 28);
            this.alarmModeA.Name = "alarmModeA";
            this.alarmModeA.Size = new System.Drawing.Size(91, 25);
            this.alarmModeA.TabIndex = 0;
            this.alarmModeA.TabStop = true;
            this.alarmModeA.Text = "A模式";
            this.alarmModeA.UseVisualStyleBackColor = true;
            this.alarmModeA.Click += new System.EventHandler(this.AlarmType_Click);
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.Controls.Add(this.buttonClearOption);
            this.ButtonGroup.Controls.Add(this.buttonFinish);
            this.ButtonGroup.Location = new System.Drawing.Point(285, 2);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new System.Drawing.Size(182, 297);
            this.ButtonGroup.TabIndex = 4;
            this.ButtonGroup.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 392);
            this.Controls.Add(this.ButtonGroup);
            this.Controls.Add(this.alarmTypeGroup);
            this.Controls.Add(this.OutputGroup);
            this.Controls.Add(this.RepeatDaysGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鬧鐘重複日設定";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RepeatDaysGroup.ResumeLayout(false);
            this.RepeatDaysGroup.PerformLayout();
            this.OutputGroup.ResumeLayout(false);
            this.OutputGroup.PerformLayout();
            this.alarmTypeGroup.ResumeLayout(false);
            this.alarmTypeGroup.PerformLayout();
            this.ButtonGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RepeatDaysGroup;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.Button buttonClearOption;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox TextOutputMessage;
        private System.Windows.Forms.GroupBox alarmTypeGroup;
        private System.Windows.Forms.RadioButton alarmModeA;
        private System.Windows.Forms.GroupBox ButtonGroup;
        private System.Windows.Forms.RadioButton alarmModeB;
    }
}

