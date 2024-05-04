namespace MixpubSchedule;

public class Event
{
    public Event(DateOnly date, TimeOnly startTime, string eventName, string dj)
    {
        Date = date;
        StartTime = startTime;
        Name = eventName;
        Dj = dj;
    }

    public DateOnly Date { get; }
    public TimeOnly StartTime { get; }
    public string Name { get; }
    public string Dj { get; }
}
