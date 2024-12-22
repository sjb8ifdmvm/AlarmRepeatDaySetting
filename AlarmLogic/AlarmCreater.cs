namespace AlarmLogic
{
    internal class AlarmCreater : AlarmTLB.IAlarmObject2
    {
        public AlarmTLB.IAlarm CreateMessage1Instance(AlarmTLB.Week p_SelectedDays)
        {
            return new AlarmMessage1(p_SelectedDays);
        }
        public AlarmTLB.IAlarm CreateMessage2Instance(AlarmTLB.Week p_SelectedDays)
        {
            return new AlarmMessage2(p_SelectedDays);
        }
    }
}
