/* Creating a new DateTime value
 * 
 * DateTime.Now - Current System Date + Time
 * DateTime.Today - Current System Date + Midnight
 * DateTime.UtcNow - Current System Date + UTC Time (for time zone neutral)
 * 
 * new DateTime(year, month, day)
 * new DateTime(year, month, day, hour, minute, second)
 * 
 */

DateTime d1 = DateTime.Now;
DateTime d2 = new DateTime(2022, 1, 5); // January 5th, 2022, 00:00:00
DateTime d3 = new DateTime(2022, 1, 5, 14, 30, 45); // January 5th, 2022, 2:30:45PM
Console.WriteLine(d1.Ticks); // Ticks are the base storage unit

/* Parsing
 * 
 * DateTime.Parse() and DateTime.TryParse()
 * Any valid culture format works. For example:
 * 1/5/2022
 * 1/5/2022 14:30:45
 * Wed Jan 5, 2022
 * 
 */
DateTime d4 = DateTime.Parse("1/5/2022 14:30:45"); // United States format, January 5th, 2022
Console.WriteLine(d4);
d4 = DateTime.Parse("Thu Jan 6, 2022");
Console.WriteLine(d4);

/* TimeSpan Type
 * 
 * Can add or subtract values from dates and is used to calculated differences
 * new TimeSpan(days, hours, minutes, seconds)
 * new TimeSpan(hours, minutes, seconds)
 * 
 * Negative values can go backwards in time
 * 
 */
TimeSpan ts = d1.Subtract(d3); // how long since Jan 5, 2022 14:30:45?
Console.WriteLine($"{ts.Days}d, {ts.Hours}h {ts.Minutes}m {ts.Seconds}s");

ts = new TimeSpan(5, 12, 0, 0); // 5 days, 12 hours
d4 = d1.Add(ts); // Add to date

Console.WriteLine(d4);

// We can compare dates too since it compares the ticks
Console.WriteLine(d4 > d1); // true, d4 is in the future from d1

/* Date Parts
 * 
 * We can get just parts of dates using property values
 * 
 */
Console.WriteLine($"{d1.Month}/{d1.Day}/{d1.Year} {d1.Hour}:{d1.Minute}:{d1.Second}:{d1.Millisecond}");
d4 = new DateTime(d1.AddYears(1).Year, 1, 1); // Jan 1st, of the next year from d1

/* DayOfWeek
 * 
 * Lets us compare what day of the week a date is.
 * 
 */

if(d1.DayOfWeek == DayOfWeek.Sunday || d1.DayOfWeek == DayOfWeek.Saturday)
{
    Console.WriteLine($"{d1:d} is a weekend!");
}
else
{
    Console.WriteLine($"{d1:d} is a weekday!");
}

/* Adding date values
 * 
 * We can use a timespan type or one or more of the .Add() methods
 * Again, negative values can move backwards in time
 * 
 */

d4 = d1.AddYears(1); // Creates a new date 1 year in the future from d1
Console.WriteLine(d4);

d4 = d1.AddMonths(2).AddDays(-5); // Creates a new date 2 months in the future less 5 days
Console.WriteLine(d4);