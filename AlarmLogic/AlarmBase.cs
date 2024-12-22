using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmLogic
{
    public abstract class AlarmBase : AlarmTLB.IAlarm
    {
        protected readonly AlarmTLB.Week m_WeekDays = AlarmTLB.Week.None;
        protected AlarmBase(AlarmTLB.Week p_WeekDays)
        {
            if (AlarmTLB.Week.None > p_WeekDays)
            {
                throw new System.ArgumentException("Invalid Param 'AlarmTLB.Week is nagetive.'");
            }
            if (AlarmTLB.Week.MAX_SIZE <= p_WeekDays)
            {
                throw new System.ArgumentException("Invalid Param 'AlarmTLB.Week overflow max size.'");
            }
            m_WeekDays = p_WeekDays;
        }
        protected bool ParseWeekDaysSelected(out bool[] p_SelectedDays)
        {
            bool Result = false;
            p_SelectedDays = null;
            try
            {
                bool[] t_EnabledDays = new bool[7];
                for (int t_Index = 0; t_Index < t_EnabledDays.Length; t_Index++)
                {
                    AlarmTLB.Week t_SelectedDay = (AlarmTLB.Week)((int)AlarmTLB.Week.Sunday << t_Index);
                    if (0 != (t_SelectedDay & m_WeekDays))
                    {
                        t_EnabledDays[t_Index] = true;
                    }
                }
                p_SelectedDays = t_EnabledDays;
                Result = true;
            }
            catch
            {
            }
            return Result;
        }
        public abstract AlarmTLB.IAlarm ChangeWeekSetting(AlarmTLB.Week p_NewWeekDays);
    }
}
