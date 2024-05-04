namespace MixpubSchedule.Rotation;

public class Sunday : IGetEventsFor
{
    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return date.WeekDayCount() switch
        {
            3 => [
                new Event(date, new TimeOnly(17, 0), "Refractions", "Maximus"),
                new Event(date, new TimeOnly(19, 0), "Last Lap", "Leigh"),
                new Event(date, new TimeOnly(20, 0), "Residential", "T.B.A.")
            ],
            _ => [
                new Event(date, new TimeOnly(17, 0), "Refractions", "Denz"),
                new Event(date, new TimeOnly(19, 0), "Last Lap", "Leigh"),
                new Event(date, new TimeOnly(20, 0), "Residential", "T.B.A.")
            ]
        };
    }
}
