using System;
public class InventoryEventsTester
{
    public static void TestEvents()
    {
	    InventoryManager objM = new InventoryManager();
	    PurchaseOrder objW =new PurchaseOrder(objM);
	    AuditTrail at =new AuditTrail(objM);
	    Message msg =new Message(objM);
        Console.WriteLine("Enter Quantity to Update");
        int qty = int.Parse(Console.ReadLine());
        objM.UpdateInventory("111 00" ,qty);
    }
}
