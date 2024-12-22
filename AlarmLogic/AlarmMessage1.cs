namespace AlarmLogic
{
    internal class AlarmMessage1 : AlarmBase, AlarmTLB.IAlarmMessage
    {
        internal AlarmMessage1(AlarmTLB.Week p_WeekDays)
            :base(p_WeekDays)
        {
        }
        private bool GenerateMessage(in bool[] p_SelectedDays, out string p_szMessage)
        {
            //[日][一][二]][三][四][五][六]
            bool Result = false;
            int t_SelectedCount = 0;
            int t_SelectSingleDay = -1;
            p_szMessage = "";
            string[] t_Days = new string[7] { "日", "一", "二", "三", "四", "五", "六" };
            System.Collections.Generic.List<string> t_TotalDays = new System.Collections.Generic.List<string>();
            try
            {
                do
                {
                    if (null == p_SelectedDays)
                    {
                        throw new System.ArgumentNullException("p_SelectedDays is null.");
                    }
                    if (7 != p_SelectedDays.Length)
                    {
                        throw new System.ArgumentException("p_SelectedDays not full week days.");
                    }
                    for (int t_Index = 0; t_Index < p_SelectedDays.Length; t_Index++)
                    {
                        if (p_SelectedDays[t_Index])
                        {
                            t_SelectedCount += 1;
                            t_SelectSingleDay = t_Index;
                            t_TotalDays.Add("週" + t_Days[t_Index]);
                        }
                    }
                    if (7 == t_SelectedCount)
                    {
                        p_szMessage = "每天";
                        break;
                    }
                    else if (1 == t_SelectedCount)
                    {
                        p_szMessage = "星期" + t_Days[t_SelectSingleDay];
                        break;
                    }
                    else if (0 == t_SelectedCount)
                    {
                        p_szMessage = "永不";
                        break;
                    }
                    if (5 == t_SelectedCount)
                    {
                        if (!p_SelectedDays[0] && !p_SelectedDays[6])
                        {
                            p_szMessage = "平日";
                            break;
                        }
                    }
                    if (2 == t_SelectedCount)
                    {
                        if (p_SelectedDays[0] && p_SelectedDays[6])
                        {
                            p_szMessage = "週末";
                            break;
                        }
                    }
                    for (int t_Index = 0; t_Index < t_TotalDays.Count; t_Index++)
                    {
                        if (t_Index == t_TotalDays.Count - 2)
                        {
                            p_szMessage += t_TotalDays[t_Index] + "和" + t_TotalDays[t_Index + 1];
                            break;
                        }
                        p_szMessage += t_TotalDays[t_Index] + "、";
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
            if (!base.ParseWeekDaysSelected(out bool[] t_SelectedDays))
            {
                throw new System.InvalidOperationException("ParseWeekDaysSelected() occur unexcept context.");
            }
            if (!GenerateMessage(t_SelectedDays, out t_ResultMsg))
            {
                throw new System.InvalidOperationException("GenerateMessage() occur unexcept context.");
            }
            return t_ResultMsg;
        }

        public override AlarmTLB.IAlarm ChangeWeekSetting(AlarmTLB.Week p_NewWeekDays)
        {
            return new AlarmMessage1(p_NewWeekDays);
        }
    }
}
