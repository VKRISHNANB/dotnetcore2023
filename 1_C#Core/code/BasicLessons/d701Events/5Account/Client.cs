using System;
public class BankEventTester
{
    public static void TestEvents()
    {
        AccManager objM = new AccManager();
        AccountSubscriber objW =new AccountSubscriber(objM);
        Console.WriteLine("Enter Amount to Withdraw");
        int amt = int.Parse(Console.ReadLine());
        objM.DoTrans("111 005 383",amt);
    }
}
