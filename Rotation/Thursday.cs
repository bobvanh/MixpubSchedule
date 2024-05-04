namespace MixpubSchedule.Rotation;

public class Thursday : IGetEventsFor
{
    TimeOnly defaultStartTime = new TimeOnly(19, 0);

    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return [new Event(date, defaultStartTime, "Siren Call", "Pete")];
    }
}
