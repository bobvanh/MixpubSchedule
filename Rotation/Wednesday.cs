namespace MixpubSchedule.Rotation;

public class Wednesday : IGetEventsFor
{
    TimeOnly defaultStartTime = new TimeOnly(19, 0);

    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return date.WeekDayCount() switch
        {
            1 => [new Event(date, defaultStartTime, "Erik Bruce sessions", "THE Erik Bruce")],
            3 => [new Event(date, defaultStartTime, "Ignition", "T.B.A.")],
            4 => [new Event(date, defaultStartTime, "Mixpub Presents", "Jason Brauer")],
            _ => Enumerable.Empty<Event>()
        };
    }
}
