public class AuditTrail{
	InventoryManager inv;
	public  AuditTrail(InventoryManager obj){
		this.inv=obj;
		inv.InventoryChanged+=  new InventoryManager.InvDel(this.Log);
	}
	public void Log(System.Object source,Inventory e){
	   System.Console.WriteLine("Log :"+e.stock);	
	}
}
