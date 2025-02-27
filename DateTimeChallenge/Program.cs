GetDateTime();

static bool CheckValue(int value, int min, int max)
{
    return value >= min && value <= max;
}

static void GetDateTime()
{
    Console.WriteLine("Select date to determine how long ago it was:");
    // capture date - print how many days ago it was
    // get month, day and year from user
    bool flag = false;
    int year = 2024;
    //do
    //{
    //    Console.Write("\nYear: ");
    //    int.TryParse(Console.ReadLine(), out year);
    //    flag = CheckValue(year, 1, DateTime.Today.Year);
    //} while (!flag);

    //flag = false;
    int month = 2;
    //do
    //{
    //    Console.Write("\nMonth: ");
    //    int.TryParse(Console.ReadLine(), out month);
    //    flag = CheckValue(month, 1, 12);
    //} while (!flag);

    //flag = false;
    int day = 25;
    //do
    //{
    //    Console.Write("\nDay: ");
    //    int.TryParse(Console.ReadLine(), out day);
    //    flag = CheckValue(day, 1, DateTime.DaysInMonth(year, month));
    //} while (!flag);

    DateTime oldDate = new DateTime(year, month, day);
    DateTime today = DateTime.Now;
    int daysAgo = (today - oldDate).Days;

    Console.WriteLine($"\nInput Date: {oldDate:D} occurred {daysAgo} days ago.");

    // capture time - print how many hours ago it was
    Console.WriteLine("\nEnter a time and see how long ago it was: ");

    flag = false;
    int hour = 14;
    //do
    //{
    //    Console.Write("\nHour: ");
    //    int.TryParse(Console.ReadLine(), out hour);
    //    flag = CheckValue(hour, 1, 23);
    //} while (!flag);

    flag = false;
    int minute = 15;
    //do
    //{
    //    Console.Write("\nMinute: ");
    //    int.TryParse(Console.ReadLine(), out minute);
    //    flag = CheckValue(minute, 1, 59);
    //} while (!flag);

    DateTime oldTime = new DateTime(year, month, day, hour, minute, 0);
    int hoursAgo = (today - oldTime).Hours;
    int minsAgo = (today - oldTime).Minutes;

    Console.WriteLine($"Your input time was {hoursAgo} hours and {minsAgo} minutes ago.");

    // allow user to select 12 or 24 hr format

    // allow user to select month/day/year or day/month/year format
}