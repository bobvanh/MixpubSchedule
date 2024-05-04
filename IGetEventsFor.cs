namespace MixpubSchedule;

public interface IGetEventsFor
{
    public IEnumerable<Event> GetEvents(DateOnly date);
}
