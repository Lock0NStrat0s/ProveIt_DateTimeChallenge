
Console.WriteLine("Select date to determine how long ago it was:");
// capture date - print how many days ago it was
// get month, day and year from user
bool flag = false;
int year = 0;
do
{
    Console.Write("\nYear: ");
    int.TryParse(Console.ReadLine(), out year);
    flag = CheckValue(year, 1, DateTime.Today.Year);
} while (!flag);

flag = false;
int month = 0;
do
{
    Console.Write("\nMonth: ");
    int.TryParse(Console.ReadLine(), out month);
    flag = CheckValue(month, 1, 12);
} while (!flag);

flag = false;
int day = 0;
do
{
    Console.Write("\nDay: ");
    int.TryParse(Console.ReadLine(), out day);
    flag = CheckValue(day, 1, DateTime.DaysInMonth(year, month));
} while (!flag);

DateTime oldDate = new DateTime(year, month, day);
DateTime today = DateTime.Today;
int daysAgo = (today - oldDate).Days;

Console.WriteLine($"Your input date occurred {daysAgo} days ago");

// capture time - print how many hours ago it was


// allow user to select 12 or 24 hr format

// allow user to select month/day/year or day/month/year format



bool CheckValue(int value, int min, int max)
{
    return value >= min && value <= max;
}