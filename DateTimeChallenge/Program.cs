// allow user to select 12 or 24 hr format
// allow user to select month/day/year or day/month/year format

bool dateFormatMDY = true;
bool hourFormat24 = true;
int userInput = 0;

Console.WriteLine("Enter date and time to determine how long ago it was:");
Console.Write("Date format:\n1 - Month/Day/Year (default)\n2 - Day/Month/Year\nYour selection: ");
int.TryParse(Console.ReadLine(), out userInput);
if (userInput == 2) dateFormatMDY = false;

userInput = 0;
Console.Write("Hour format:\n1 - 24 hrs (default)\n2 - 12 hrs\nYour selection: ");
int.TryParse(Console.ReadLine(), out userInput);
if (userInput == 2) hourFormat24 = false;

GetDateTime(hourFormat24, dateFormatMDY);

static void GetDateTime(bool hourFormat24, bool dateFormatMDY)
{
    Console.WriteLine("Enter date: ");
    // capture date - print how many days ago it was
    // get month, day and year from user
    bool flag = false;
    int year = 2024;
    do
    {
        Console.Write("\nYear: ");
        int.TryParse(Console.ReadLine(), out year);
        flag = CheckValue(year, 1, DateTime.Today.Year);
    } while (!flag);

    //flag = false;
    int month = 2;
    do
    {
        Console.Write("\nMonth: ");
        int.TryParse(Console.ReadLine(), out month);
        flag = CheckValue(month, 1, 12);
    } while (!flag);

    //flag = false;
    int day = 25;
    do
    {
        Console.Write("\nDay: ");
        int.TryParse(Console.ReadLine(), out day);
        flag = CheckValue(day, 1, DateTime.DaysInMonth(year, month));
    } while (!flag);

    // capture time - print how many hours ago it was
    Console.WriteLine("\nEnter time: ");

    flag = false;
    int hour = 14;
    do
    {
        Console.Write("\nHour: ");
        int.TryParse(Console.ReadLine(), out hour);
        flag = CheckValue(hour, 1, 23);
    } while (!flag);

    flag = false;
    int minute = 15;
    do
    {
        Console.Write("\nMinute: ");
        int.TryParse(Console.ReadLine(), out minute);
        flag = CheckValue(minute, 1, 59);
    } while (!flag);


    DateTime oldDate = new DateTime(year, month, day, hour, minute, 0);
    DateTime today = DateTime.Now;
    int daysAgo = (today - oldDate).Days;
    int hoursAgo = (today - oldDate).Hours;
    int minsAgo = (today - oldDate).Minutes;

    Console.Write("\nInput Date: ");
    if (dateFormatMDY)
        Console.Write($"{oldDate.ToString("MM/dd/yyyy")}");
    else
        Console.Write($"{oldDate.ToString("dd/MM/yyyy")}");
    Console.WriteLine($" occurred {daysAgo} days ago.");

    Console.Write("\nInput Time: ");
    if (hourFormat24)
        Console.Write($"{oldDate.ToString("HH/mm")}");
    else
        Console.Write($"{oldDate.ToString("hh/mm")}");
    Console.WriteLine($" occurred {hoursAgo} hours and {minsAgo} minutes ago.");
}

static bool CheckValue(int value, int min, int max)
{
    return value >= min && value <= max;
}
