using System;

public class AccountSubscriber
{
    public AccountSubscriber(AccManager obj)
    {
       obj.OnAccChange += new AccManager.AccDel(Update);
       obj.OnMinLevel += new AccManager.AccDel(ChargeAcc);
       obj.OnPANLevel += new AccManager.AccDel(CreatePanMsg);
       obj.OnMinLevel += new AccManager.AccDel(CreateMinMsg);
       obj.OnOD += new AccManager.AccDel(AuthTrans);
    }
    void Update(object source, Account e)
    {
        int change = e.Balance;
        Console.WriteLine("Account '{0}' was {1} to {2} rupees",
            e.Sku,
            change > 5000 ? "increased" : "decreased",
            Math.Abs(change));
    }
    void ChargeAcc(object source, Account e)
    {
    int change = e.Balance;
    Console.WriteLine("Bank Charges Rupees "+ (2000-change)*0.06 + " for " + e.Sku);
    }
    void AuthTrans(object source, Account e)
    {
        int change = e.Balance;
        Console.WriteLine("From AuthTrans "+ change + " for " + e.Sku);
    }

    void CreatePanMsg(object source, Account e)
    {
        int change = e.Balance;
        Console.WriteLine("Provide PAN "+ change + " for " + e.Sku);
    }
    void CreateMinMsg(object source, Account e)
    {
        int change = e.Balance;
        Console.WriteLine("Warning  Min Balance Msg "+ change + " for " + e.Sku);
    }
}