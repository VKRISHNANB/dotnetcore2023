using System;

public class AccManager // Publisher.
{    
	public delegate void AccDel(object source, Account e);
	public event AccDel OnAccChange;
	public event AccDel OnPANLevel;
	public event AccDel OnOD;
	public event AccDel OnMinLevel;

    public void  DoTrans(string sku, int change)
    {
        if (0 == change) return; 
        Account e = new  Account(sku);
        e.Balance=change;
        OnAccChange(this, e);
        if (e.Balance<0 ) OnOD(this, e);
        if (e.Balance<=2000 )    OnMinLevel(this, e);
        if (e.Balance>=50000 )	OnPANLevel(this, e);   
    }
    
}
