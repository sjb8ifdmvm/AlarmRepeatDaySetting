namespace AlarmLogic
{
    internal class AlarmMessage2 : AlarmBase, AlarmTLB.IAlarmMessage
    {
        private System.Collections.Generic.List<string> m_TotalDays = null;
        internal AlarmMessage2(AlarmTLB.Week p_WeekDays) :
            base(p_WeekDays)
        {
            m_TotalDays = new System.Collections.Generic.List<string>();

            if (!base.ParseWeekDaysSelected(out bool[] t_SelectedDays))
            {
                throw new System.InvalidOperationException("ParseWeekDaysSelected() occur unexcept context.");
            }
            if (!PrepareMessage(t_SelectedDays))
            {
                throw new System.InvalidOperationException("GenerateMessage() occur unexcept context.");
            }
        }
        private bool PrepareMessage(in bool[] p_SelectedDays)
        {
            //[日][一][二]][三][四][五][六]
            bool Result = false;
            int t_SelectedCount = 0;
            int t_SelectSingleDay = -1;
            string[] t_Days = new string[7] { "日", "一", "二", "三", "四", "五", "六" };
            try
            {
                do
                {
                    if (null == m_TotalDays)
                    {
                        throw new System.ArgumentNullException("m_TotalDays is null.");
                    }
                    if (null == p_SelectedDays)
                    {
                        throw new System.ArgumentNullException("p_SelectedDays is null.");
                    }
                    if (7 != p_SelectedDays.Length)
                    {
                        throw new System.ArgumentException("p_SelectedDays not full week days.");
                    }
                    for (int t_Index = 1; t_Index < p_SelectedDays.Length - 1; t_Index++)
                    {
                        if (p_SelectedDays[t_Index])
                        {
                            t_SelectedCount += 1;
                            t_SelectSingleDay = t_Index;
                            m_TotalDays.Add("週" + t_Days[t_Index]);
                        }
                    }
                    if (5 == t_SelectedCount)
                    {
                        m_TotalDays.Clear();
                        if (p_SelectedDays[0] && p_SelectedDays[6])
                        {
                            m_TotalDays.Add("每天");
                            break;
                        }
                        else
                        {
                            m_TotalDays.Add("平日");
                        }
                    }
                    if (p_SelectedDays[0] && p_SelectedDays[6])
                    {
                        t_SelectedCount += 2;
                        m_TotalDays.Add("週末");
                    }
                    else if (p_SelectedDays[0])
                    {
                        t_SelectedCount += 1;
                        t_SelectSingleDay = 0;
                        m_TotalDays.Add("週日");
                    }
                    else if (p_SelectedDays[6])
                    {
                        t_SelectedCount += 1;
                        t_SelectSingleDay = 6;
                        m_TotalDays.Add("週六");
                    }
                    if (1 == t_SelectedCount)
                    {
                        m_TotalDays.Clear();
                        m_TotalDays.Add("星期" + t_Days[t_SelectSingleDay]);
                        break;
                    }
                    else if (0 == t_SelectedCount)
                    {
                        m_TotalDays.Clear();
                        m_TotalDays.Add("永不");
                        break;
                    }
                } while (false);
                Result = true;
            }
            catch
            {
            }
            return Result;
        }
        public virtual string GetMessage()
        {
            string t_ResultMsg = "";

            if (1 == m_TotalDays.Count)
            {
                t_ResultMsg = m_TotalDays[0];
            }
            else if (2 <= m_TotalDays.Count)
            {
                for (int t_Index = 0; t_Index < m_TotalDays.Count; t_Index++)
                {
                    if (t_Index == m_TotalDays.Count - 2)
                    {
                        t_ResultMsg += m_TotalDays[t_Index] + "和" + m_TotalDays[t_Index + 1];
                        break;
                    }
                    t_ResultMsg += m_TotalDays[t_Index] + "、";
                }
            }
            return t_ResultMsg;
        }

        public override AlarmTLB.IAlarm ChangeWeekSetting(AlarmTLB.Week p_NewWeekDays)
        {
            return new AlarmMessage2(p_NewWeekDays);
        }
    }
}
