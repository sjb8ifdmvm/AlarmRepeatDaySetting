using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmTLB
{
    public interface IAlarm
    {
        AlarmTLB.IAlarm ChangeWeekSetting(AlarmTLB.Week p_NewWeekDays);
    }
}
