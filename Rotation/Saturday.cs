namespace MixpubSchedule.Rotation;

public class Saturday : IGetEventsFor
{
    const string mindscape = "Mindscape";
    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return date.WeekDayCount() switch
        {
            3 => [
                new Event(date, new TimeOnly(15, 0), mindscape, "Trellis"),
                new Event(date, new TimeOnly(17, 0), mindscape, "Soundswivel"),
                new Event(date, new TimeOnly(19, 0), mindscape, "Richie"),
                new Event(date, new TimeOnly(21, 0), mindscape, "Leigh")
            ],
            _ => [
                new Event(date, new TimeOnly(17, 0), mindscape, "Trellis"),
                new Event(date, new TimeOnly(19, 0), mindscape, "Richie"),
                new Event(date, new TimeOnly(21, 0), mindscape, "Leigh")
            ]
        };
    }
}
