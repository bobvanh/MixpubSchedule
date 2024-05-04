namespace MixpubSchedule.Rotation;

public class Tuesday : IGetEventsFor
{
    TimeOnly defaultStartTime = new TimeOnly(19, 0);

    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return date.WeekDayCount() switch
        {
            1 => [new Event(date, defaultStartTime, "Sonar", "T.B.A.")],
            2 => [new Event(date, defaultStartTime, "Siren Call", "Maximus")],
            3 => [new Event(date, defaultStartTime, "Lucid Dreams", "Trellis")],
            4 => [new Event(date, defaultStartTime, "Mixpub Presents", "Joe Da Vinci")],
            _ => [new Event(date, defaultStartTime, "", "")]
        };
    }
}
