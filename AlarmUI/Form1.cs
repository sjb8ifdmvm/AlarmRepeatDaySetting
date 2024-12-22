using System;
using System.Windows.Forms;

namespace AlertUI
{
    public partial class Form1 : Form
    {
        private AlarmTLB.IAlarm m_AlarmObject = null;
        private AlarmTLB.IAlarmObject2 m_AlarmGenerator = null;
        public Form1()
        {
            InitializeComponent();
            LoadAssembly();
        }
        private void LoadAssembly()
        {
            if (!System.IO.File.Exists("AlarmLogic.dll"))
            {
                MessageBox.Show("找不到組件AlarmLogic.dll");
                this.Close();
                return;
            }
            byte[] t_AlertLogicBinary = System.IO.File.ReadAllBytes("AlarmLogic.dll");
            System.Reflection.Assembly t_AsmAlertLogic = System.Reflection.Assembly.Load(t_AlertLogicBinary);
            m_AlarmGenerator = (AlarmTLB.IAlarmObject2)t_AsmAlertLogic.CreateInstance("AlarmLogic.AlarmCreater");
            if (null == m_AlarmGenerator)
            {
                MessageBox.Show("無法建立物件AlertLogic.AlarmCreater");
                this.Close();
                return;
            }
            AlarmTLB.IAlarm t_MessageObject = null;
            CreateAlarmMessage(out t_MessageObject);
            if (null == t_MessageObject)
            {
                MessageBox.Show("預設沒有建立AlarmMessage物件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            m_AlarmObject = t_MessageObject;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUIContent();
        }

        private void RepeatGroupWeekCheckBox_Click(object sender, EventArgs e)
        {
            UpdateUIContent();
        }
        private void UpdateUIContent()
        {
            bool t_FunctionCallResult = false;
            try
            {
                t_FunctionCallResult = GetWeekValue(out AlarmTLB.Week SelectedDays);
                if (!t_FunctionCallResult)
                {
                    System.Windows.Forms.MessageBox.Show("GetWeekValue() fail.");
                    return;
                }
                if (null == m_AlarmObject)
                {
                    System.Windows.Forms.MessageBox.Show("m_MessageObject 物件為null.");
                    return;
                }
                if (!(m_AlarmObject.ChangeWeekSetting(SelectedDays) is AlarmTLB.IAlarmMessage t_AlarmMessageObj))
                {
                    System.Windows.Forms.MessageBox.Show("t_AlarmMessageObj 不是有效的AlarmTLB.IAlarmMessage物件.");
                    return;
                }
                TextOutputMessage.Text = t_AlarmMessageObj.GetMessage();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        private void buttonClearOption_Click(object sender, EventArgs e)
        {
            checkBoxMonday.CheckState = CheckState.Unchecked;
            checkBoxTuesday.CheckState = CheckState.Unchecked;
            checkBoxWednesday.CheckState = CheckState.Unchecked;
            checkBoxThursday.CheckState = CheckState.Unchecked;
            checkBoxFriday.CheckState = CheckState.Unchecked;
            checkBoxSaturday.CheckState = CheckState.Unchecked;
            checkBoxSunday.CheckState = CheckState.Unchecked;
            UpdateUIContent();
        }

        private bool GetWeekValue(out AlarmTLB.Week p_SelectedWeekDay)
        {
            bool Result = false;
            p_SelectedWeekDay = AlarmTLB.Week.None;
            try
            {
                AlarmTLB.Week t_Value = AlarmTLB.Week.None;
                if (CheckState.Checked == checkBoxMonday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Monday;
                }
                if (CheckState.Checked == checkBoxTuesday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Tuesday;
                }
                if (CheckState.Checked == checkBoxWednesday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Wednesday;
                }
                if (CheckState.Checked == checkBoxThursday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Thursday;
                }
                if (CheckState.Checked == checkBoxFriday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Friday;
                }
                if (CheckState.Checked == checkBoxSaturday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Saturday;
                }
                if (CheckState.Checked == checkBoxSunday.CheckState)
                {
                    t_Value ^= AlarmTLB.Week.Sunday;
                }
                p_SelectedWeekDay = t_Value;
                Result = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return Result;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void CreateAlarmMessage(out AlarmTLB.IAlarm p_AlarmMessageObj)
        {
            p_AlarmMessageObj = null;
            if (alarmModeA.Checked)
            {
                p_AlarmMessageObj = m_AlarmGenerator.CreateMessage1Instance(AlarmTLB.Week.None);
                if (null == p_AlarmMessageObj)
                {
                    MessageBox.Show("AlarmMessage1物件建立失敗");
                    this.Close();
                    return;
                }
            }
            else if (alarmModeB.Checked)
            {
                p_AlarmMessageObj = m_AlarmGenerator.CreateMessage2Instance(AlarmTLB.Week.None);
                if (null == p_AlarmMessageObj)
                {
                    MessageBox.Show("AlarmMessage2物件建立失敗");
                    this.Close();
                    return;
                }
            }
        }

        private void AlarmType_Click(object sender, EventArgs e)
        {
            AlarmTLB.IAlarm t_MessageObject = null;
            CreateAlarmMessage(out t_MessageObject);
            if (null == t_MessageObject)
            {
                MessageBox.Show("沒有成功建立AlarmMessage物件", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            m_AlarmObject = t_MessageObject;
            UpdateUIContent();
        }
    }
}
