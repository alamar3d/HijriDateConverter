using System.Globalization;

internal class Program
{
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
    private static void Main(string[] args)
    {
       Console.WriteLine( ConvertHijriToGregorian("1445/04/05"));

        Console.ReadLine();
    }
}