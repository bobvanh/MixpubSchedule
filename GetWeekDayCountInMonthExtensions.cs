namespace MixpubSchedule;

public static class GetWeekDayCountInMonthExtensions
{
    public static int WeekDayCount(this DateOnly date)
    {
        int count = 1;
        while (date.AddDays(count * -7).Month == date.Month)
        {
            count++;
        }
        return count;
    }
}
