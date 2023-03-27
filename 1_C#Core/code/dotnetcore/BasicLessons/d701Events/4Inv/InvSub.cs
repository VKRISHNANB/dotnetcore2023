using System;

public class InventoryWatcher // Subscriber.
{
    public InventoryWatcher(InventoryManager obj)
    {
       obj.InventoryChanged += new InventoryManager.InvDel(OnChange);
       obj.ROLevelReached += new InventoryManager.InvDel(CreatePO);
       obj.MaxLevelReached += new InventoryManager.InvDel(CreateMaxMsg);
       obj.MinLevelReached += new InventoryManager.InvDel(CreateMinMsg);
       obj.ROLevelReached += new InventoryManager.InvDel(AuthPO);
    }
    void OnChange(object source, Inventory e)
    {
        int change = e.stock;
        Console.WriteLine("Part '{0}' was {1} to {2} units",e.Sku, change > 50 ? "increased" : "decreased",           Math.Abs(change));
    }
     void CreatePO(object source, Inventory e)
        {
            int change = e.stock;
            Console.WriteLine("From CreatePo "+ (100-change) + " for " + e.Sku);
    }
         void AuthPO(object source, Inventory e)
            {
                int change = e.stock;
                Console.WriteLine("From AuthPo "+ (100-change) + " for " + e.Sku);
        }
void CreateMaxMsg(object source, Inventory e)
{
int change = e.stock;
Console.WriteLine("Warning From CreateMaxMsg "+ change + " for " + e.Sku);
InventoryManager m=(InventoryManager)source;
m.UpdateInventory(e.Sku,99-e.stock);
}
void CreateMinMsg(object source, Inventory e)
  {
int change = e.stock;
Console.WriteLine("Warning From CreateMinMsg "+ change + " for " + e.Sku);
        }
}