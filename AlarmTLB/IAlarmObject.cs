using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmTLB
{
    public interface IAlarmObject
    {
        IAlarm CreateMessage1Instance(AlarmTLB.Week p_SelectedDays);
    }
    public interface IAlarmObject2: IAlarmObject
    {
        IAlarm CreateMessage2Instance(AlarmTLB.Week p_SelectedDays);
    }
}
