Console app has method to convert hijri date to Gregorian\


public static string ConvertHijriToGregorian(string hijriDate)
{
    try
    {
        // Define the Hijri calendar
        UmAlQuraCalendar hijriCalendar = new();

        // Specify the Hijri date format
        CultureInfo hijriCulture = new("ar-SA");
        hijriCulture.DateTimeFormat.Calendar = hijriCalendar;

        // Parse the Hijri date
        DateTime parsedDate = DateTime.ParseExact(hijriDate, "yyyy/MM/dd", hijriCulture);

        // Convert to Gregorian date
        return parsedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
    }
    catch (Exception ex)
    {
        // Handle invalid input or conversion errors
        return $"Error: {ex.Message}";
    }
}


