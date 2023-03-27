using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d4ClassesNProperties
{
    public enum BankAccountType {Saving=0,Current=1,Loan=2,OD=3 }
    public enum BankAccountStatus { Active=0,InActive=1}
    public class Account
    {
        //private and readonly fields
        private readonly int accountNo;
        private readonly int customerID;
        public readonly DateTime accountOpeningDate;
        //private fields
        private double currentBalance;
        //public fields
        public BankAccountStatus Status;
        public BankAccountType AccountType;

        public Account(int accno,int cid,DateTime opDate)
        {
            if (accno <=1000)
            {
                Console.WriteLine("Account No Must be >1000");
                return;
            }
            accountNo = accno;
            if (cid <= 0)
            {
                Console.WriteLine("CustomerID Must be >0");
                return;
            }
            customerID = cid;
            if (opDate >DateTime.Now )
            {
                Console.WriteLine("Date Can not be in Future");
                return;
            }
            else if(opDate.Year <2000 )
            {
                Console.WriteLine("Date Can not be before 2000");
                return;
            }
            accountOpeningDate = opDate;
        }//end of constructor

        public double CurrentBalance
        {
            get { return currentBalance; }
            set
            {
                if(AccountType ==BankAccountType.Saving || 
                    AccountType  == BankAccountType.Current)
                {
                    if(value<0)
                    {
                        Console.WriteLine("Insufficient FUNDS!!!");
                        return;
                    }
                }
                currentBalance = value;
            }
        }
    }
}
