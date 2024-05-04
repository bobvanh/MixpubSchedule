// See https://aka.ms/new-console-template for more information
using MixpubSchedule;

var startDate = new DateOnly(2024, 6, 1);
var endDate = new DateOnly(2025, 1, 1);
foreach (var @event in new Schedule().Generate(startDate, endDate).SelectMany(e => e))
{
    Console.WriteLine(string.Join("\t",
        [
            @event.Date.ToString("dd-MM-yyyy"),
            @event.StartTime.ToString(),
            @event.Name,
            @event.Dj
        ]));
}
