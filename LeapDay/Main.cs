using System;
using System.Diagnostics;
using System.Linq;

namespace DaysBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = DaysBetween();
            Console.WriteLine($"There are {result} days between the two given dates.");
        }

        static int DaysBetween()
        {
            double daysInMonth = 30.4167;

            var (sY, sM, sD) = DateInputHandler.GetValidDateInput("Start");
            var (eY, eM, eD) = DateInputHandler.GetValidDateInput("End");

            CheckBothDates(sY, sM, sD, eY, eM, eD);

            int leapCount = DateInputHandler.CountLeapYears(sY, eY);

            int fullYearDays = (365 * ((eY - sY) - 1) + leapCount);

            int toEOY = DateInputHandler.DaysToEndOfYear(sM, sD, daysInMonth);

            int toEndDay = DateInputHandler.DaysToEndDay(eM, eD, daysInMonth);

            int daysBetween = fullYearDays + toEOY + toEndDay;

            return daysBetween;
        }

        static void CheckBothDates(int sY, int sM, int sD, int eY, int eM, int eD)
        {
            string err = "The end date is before the start date";
            string errSame = "The start and end dates are the same";
            Debug.Assert(eY > sY || (eY == sY && eM > sM) || (eY == sY && eM == sM && eD >= sD), err);
            Debug.Assert(!(eY == sY && eM == sM && eD == sD), errSame);
        }
    }
}
