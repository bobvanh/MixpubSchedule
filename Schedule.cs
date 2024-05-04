using MixpubSchedule.Rotation;

namespace MixpubSchedule;

public class Schedule
{
    private static Dictionary<DayOfWeek, IGetEventsFor> gettersPerDay = new Dictionary<DayOfWeek, IGetEventsFor>
    {
        { DayOfWeek.Monday, new Monday() },
        { DayOfWeek.Tuesday, new Tuesday() },
        { DayOfWeek.Wednesday, new Wednesday() },
        { DayOfWeek.Thursday, new Thursday() },
        { DayOfWeek.Friday, new Friday() },
        { DayOfWeek.Saturday, new Saturday() },
        { DayOfWeek.Sunday, new Sunday() }
    };
    public IEnumerable<IEnumerable<Event>> Generate(DateOnly startDate, DateOnly endDate)
    {
        if (endDate >= startDate)
        {
            DateOnly date = startDate;
            do
            {
                yield return gettersPerDay[date.DayOfWeek].GetEvents(date);
                date = date.AddDays(1);
            }
            while (date <= endDate);
        }
    }
}
