namespace MixpubSchedule.Rotation;

public class Friday : IGetEventsFor
{
    public IEnumerable<Event> GetEvents(DateOnly date)
    {
        return
            [
                new Event(date, new TimeOnly(18, 00), "Elysium", "Dizzy"),
                new Event(date, new TimeOnly(19, 00), "The Friday Night Guest Mix", "T.B.A."),
                new Event(date, new TimeOnly(21, 00), "Underground Frequencies", "Leigh")
            ];
    }
}
