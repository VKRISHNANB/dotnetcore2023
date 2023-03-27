using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons
{
    class DateDemo
    {
        public static void M1()
        {
            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2018, 04, 10); //yyyy,mm,dd
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
        }

        public static void M2()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }

        public static void FindAgeOfaPerson()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            Console.WriteLine("d1.DayOfWeek " + d1.DayOfWeek);
            Console.WriteLine("d1.DayOfYear " + d1.DayOfYear);
            Console.WriteLine("DateTime.IsLeapYear " + DateTime.IsLeapYear(d1.Year));
            Console.WriteLine("DateTime.DaysInMonth " + DateTime.DaysInMonth(d1.Year, d1.Month));
            Console.WriteLine("d1.Ticks " + d1.Ticks);
            DateTime d2 = DateTime.Now;
            TimeSpan ts = d2.Subtract(d1);
            //Console.WriteLine("Age in TimeSpan " + ts);
            DateTime age = new DateTime(ts.Ticks);
            Console.WriteLine("Age in Date " + age);
        }

        public static void FindAgeFromDob()
        {
            // Prompt the user for their date of birth
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = Console.ReadLine();

            // Parse the date of birth
            DateTime dob = DateTime.Parse(dobString);

            // Calculate the age
            DateTime now = DateTime.Now;
            int ageYears = now.Year - dob.Year;
            if (now < dob.AddYears(ageYears))
            {
                ageYears--;
            }
            int ageMonths = now.Month - dob.Month;
            if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
            {
                ageMonths--;
            }
            int ageDays = now.Day - dob.Day;
            if (now.Day < dob.Day)
            {
                ageDays += DateTime.DaysInMonth(now.Year, now.Month);
            }

            // Print the age
            Console.WriteLine(
                $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
            );
        }

        public static void FindRetirementDate()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            //DateTime d2 = new DateTime(year+60, month+1, 1);
            //DateTime d3 = d2.AddDays(-1);
            DateTime d4 = d1.AddYears(60);
            int year = d4.Year;
            int month = d4.Month;
            int last_day_of_the_month = DateTime.DaysInMonth(d4.Year, d4.Month);
            DateTime retirementdate = new DateTime(year, month, last_day_of_the_month);
            Console.WriteLine("Your Retirement Date is " + retirementdate.ToShortDateString());
        }
    }
}
