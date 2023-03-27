using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class DateDemo
    {
        public static void M1()
        {
            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2018, 04, 10);//yyyy,mm,dd
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
            #region a
            //Console.WriteLine("DOB in Years " + d1.Year);
            //Console.WriteLine("DOB in Month " + d1.Month);
            //Console.WriteLine("DOB in Days " + d1.Day);
            //Console.WriteLine("d1.DayOfWeek " + d1.DayOfWeek);
            //Console.WriteLine("d1.DayOfYear " + d1.DayOfYear);
            //Console.WriteLine("DateTime.IsLeapYear " + DateTime.IsLeapYear(d1.Year));
            //Console.WriteLine("DateTime.DaysInMonth " + DateTime.DaysInMonth(d1.Year, d1.Month));
            //Console.WriteLine("d1.Ticks " + d1.Ticks);
            #endregion a
            #region b
            //DateTime d2 = DateTime.Now;
            //TimeSpan difference = d2.Subtract(d1);
            //Console.WriteLine("Age in TimeSpan " + difference);
            //DateTime age = new DateTime(difference.Ticks);
            //DateTime age = DateTime.MinValue + difference;

            #endregion b
            DateTime age = CalculateAge(d1);
            Console.WriteLine("Age in Date " + age);
            Console.WriteLine("Age in Years " + age.Year);
            Console.WriteLine("Age in Month " + age.Month);
            Console.WriteLine("Age in Days " + age.Day);
            //Console.WriteLine("Age.DayOfYear " + age.DayOfYear);
            //Console.WriteLine("DateTime.IsLeapYear " + DateTime.IsLeapYear(age.Year));
        }
        private static DateTime CalculateAge(DateTime dob)
        {
            DateTime age = DateTime.MinValue;
            DateTime dtCurrentDate = DateTime.Now;
            if (dob > dtCurrentDate)
                throw new Exception("Date of Birth is in FUTURE");
            TimeSpan difference = dtCurrentDate.Subtract(dob);
            age = new DateTime(difference.Ticks);
            if (dob.Month < DateTime.Now.Month)
            {
                if (age.DayOfYear > 30)
                {
                    // find the literal difference
                    //int intNoOfDays = dtCurrentDate.Day - dob.Day;
                    //int intNoOfMonths = dtCurrentDate.Month - dob.Month;
                    //int intNoOfYears = dtCurrentDate.Year - dob.Year;
                    //if (intNoOfYears <= 0)
                    //{
                    //    intNoOfYears = 1;

                    //}
                    //if (intNoOfDays <= 0)
                    //{
                    //    intNoOfDays += DateTime.DaysInMonth(dtCurrentDate.Year, dtCurrentDate.Month);
                    //    intNoOfMonths--;
                    //}

                    //if (intNoOfMonths <= 0)
                    //{
                    //    intNoOfMonths += 12;
                    //    if (intNoOfYears > 1)
                    //    {
                    //        intNoOfYears--;
                    //    }
                    //}

                    //age = new DateTime(intNoOfYears, intNoOfMonths, intNoOfDays);
                }
            }

            return age;
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
