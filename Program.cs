using System;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        Console.Write("Nhap day: ");
        int date = int.Parse(Console.ReadLine());

        Console.Write("Nhap month: ");
        int month = int.Parse(Console.ReadLine());

        // Days in each month for a non-leap year
        int[] dateinmonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        // Calculate the total number of days from the start of the year to the given date
        int thedate = date + (month > 1 ? dateinmonth[..(month - 1)].Sum() : 0);

        Console.WriteLine($"Date {date} month {month} cach ngay dau nam la {thedate} date");
    }
}