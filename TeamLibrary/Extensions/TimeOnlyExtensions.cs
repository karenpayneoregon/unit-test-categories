namespace TeamLibrary.Extensions;
public static class TimeOnlyExtensions
{
    /// <summary>
    /// Get current time broken down by hour, minutes, seconds
    /// </summary>
    /// <param name="sender">DateTime</param>
    /// <returns>named value tuple</returns>
    public static (int hour, int minute, int second) TimeSegments(this TimeOnly sender)
        => (sender.Hour, sender.Minute, sender.Second);
}
