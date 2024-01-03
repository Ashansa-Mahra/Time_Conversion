class Result
{

    public static string TimeConversion(string s)
    {
        var hours = int.Parse(s.Substring(0, 2));
        var minutes = int.Parse(s.Substring(3, 2));
        var seconds = int.Parse(s.Substring(6, 2));
        var amPmIndicator = s.Substring(8, 2);

        if (amPmIndicator.Equals("PM", StringComparison.OrdinalIgnoreCase) && hours < 12)
        {
            hours += 12;
        }
        else if (amPmIndicator.Equals("AM", StringComparison.OrdinalIgnoreCase) && hours == 12)
        {
            hours = 0;
        }

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string s = Console.ReadLine();
        string result = Result.TimeConversion(s);

        Console.WriteLine(result);
    }
}
