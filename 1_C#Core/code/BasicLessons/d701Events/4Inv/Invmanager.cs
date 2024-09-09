using System;
public class InventoryManager // Publisher.
{    
public delegate void InvDel(object source, Inventory e);
	public event InvDel InventoryChanged;
	public event InvDel MaxLevelReached;
	public event InvDel ROLevelReached;
	public event InvDel MinLevelReached;
	   Inventory e ;
public void  UpdateInventory(string sku, int change)
    {
        if (0 == change)
            return; 
    if (e==null)
	   e = new  Inventory(sku);
   System.Console.WriteLine("In Update before :"+e.stock);
   e.stock=change;
   System.Console.WriteLine("In Update After :"+e.stock);

   InventoryChanged(this, e);
   if (e.stock<=20 )
   	MinLevelReached(this, e);
   if (e.stock<=50 )
   	ROLevelReached(this, e);
   if (e.stock>=100 )
   	MaxLevelReached(this, e);   
   System.Console.WriteLine("In Update After Event calls:");
   }
  
}
