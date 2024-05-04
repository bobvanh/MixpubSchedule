namespace MixpubSchedule.Rotation;

public class Monday : IGetEventsFor
{
    TimeOnly defaultStartTime = new TimeOnly(19, 0);
    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return date.WeekDayCount() switch
        {
            1 => [new Event(date, defaultStartTime, "West Wind", "Zephyr")],
            2 => [new Event(date, defaultStartTime, "Dark Side of the Moon", "Bren Hughes")],
            4 => [new Event(date, defaultStartTime, "Mixpub presents", "Maximus")],
            _ => Enumerable.Empty<Event>()
        };
    }
}
