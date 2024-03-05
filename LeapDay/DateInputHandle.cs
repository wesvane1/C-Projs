using System;
using System.Diagnostics;
using System.Linq;

namespace DaysBetween
{
    class DateInputHandler
    {
        // Public because it is being access by another class, (int, int, int) means that it will be returning a tuple of 3 integers.
        public static (int, int, int) GetValidDateInput(string prompt)
        {
            int year, month, day;
            do
            {
                Console.WriteLine(prompt + " Year:");
            } while (!int.TryParse(Console.ReadLine(), out year));

            do
            {
                Console.WriteLine(prompt + " Month:");
            } while (!int.TryParse(Console.ReadLine(), out month));

            do
            {
                Console.WriteLine(prompt + " Day:");
            } while (!int.TryParse(Console.ReadLine(), out day));

            CheckDate(year, month, day);
            return (year, month, day);
        }

        // This is private because only this class uses the check date method.
        private static void CheckDate(int year, int month, int day)
        {
            string dayErr = "The day you have entered is not valid for the given month";
            Debug.Assert(year >= 1753, "Please enter a year AFTER 1753");
            Debug.Assert(1 <= month && month <= 12, "Please select a month from 1 to 12");
            if (new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(month))
            {
                Debug.Assert(1 <= day && day <= 31, dayErr);
            }
            else if (new int[] { 4, 6, 9, 11 }.Contains(month))
            {
                Debug.Assert(1 <= day && day <= 30, dayErr);
            }
            else
            {
                if (IsLeapYear(year))
                {
                    Debug.Assert(1 <= day && day <= 29, dayErr);
                }
                else
                {
                    Debug.Assert(1 <= day && day <= 28, dayErr);
                }
            }
        }

        public static int CountLeapYears(int sY, int eY)
        {
            int leapYears = 0;

            for (int year = sY; year < eY; year++)
            {
                if (IsLeapYear(year))
                {
                    leapYears += 1;
                }
            }

            return leapYears;
        }

        public static int DaysToEndOfYear(int month, int day, double daysInMonth)
        {
            double fullMonths = (12-month)* daysInMonth;
            double remainingDaysInStartMonth = daysInMonth-day;
            // This means that an int will be returned and not a double, since the two numbers in the return statement are doubles.
            return (int)Math.Floor(fullMonths + remainingDaysInStartMonth);
        }

        public static int DaysToEndDay(int month, int day, double daysInMonth)
        {
            double fullMonths = (month-1)*daysInMonth;
            // This means that an int will be returned and not a double, since the two numbers in the return statement are doubles.
            return (int)Math.Floor(fullMonths + day);
        }

        // This checks to see how many leap years there are BETWEEN 2 years, ex 1999 and 2004, there is one leap year (since 2004 is not counted yet)
        private static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}