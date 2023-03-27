using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties
{
    public class TestAccount
    {
        public static void TestWrongAccountNO()
        {
            Account acc1 = new Account(500, 1, new DateTime(2005, 2, 15));
            acc1.AccountType = BankAccountType.Saving;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = 5000;
            Console.WriteLine("Success");

        }
        public static void TestWrongCustomerID()
        {
            Account acc1 = new Account(1500, -20, new DateTime(2005, 2, 15));
            acc1.AccountType = BankAccountType.Saving;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = 5000;
            Console.WriteLine("Success");

        }
        public static void TestWrongAccountOpeningDate()
        {
            Account acc1 = new Account(1500, 10, new DateTime(2025, 2, 15));
            acc1.AccountType = BankAccountType.Saving;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = 5000;
            Console.WriteLine("Success");

        }
        public static void TestWrongCurrentBalanceForSaving()
        {
            Account acc1 = new Account(1500, 10, new DateTime(2005, 2, 15));
            acc1.AccountType = BankAccountType.Saving;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = -500;
            Console.WriteLine("Success");

        }
        public static void TestWrongCurrentBalanceForCurrent()
        {
            Account acc1 = new Account(1500, 10, new DateTime(2005, 2, 15));
            acc1.AccountType = BankAccountType.Current;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = -500;
            Console.WriteLine("Success");

        }
        public static void TestCurrentBalanceForOD()
        {
            Account acc1 = new Account(1500, 10, new DateTime(2005, 2, 15));
            acc1.AccountType = BankAccountType.OD;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = -500;
            Console.WriteLine("Success");

        }
        public static void HappyTestCurrentBalanceForSaving()
        {
            Account acc1 = new Account(1500, 10, new DateTime(2005, 2, 15));
            acc1.AccountType = BankAccountType.Saving;
            acc1.Status = BankAccountStatus.Active;
            acc1.CurrentBalance = 500;
            Console.WriteLine("Success");
        }
    }
}
