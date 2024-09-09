public class PurchaseOrder{
	InventoryManager inv;
	public  PurchaseOrder(InventoryManager obj){
		this.inv=obj;
		inv.ROLevelReached+=  new InventoryManager.InvDel(this.createPO);
		inv.ROLevelReached+=  new InventoryManager.InvDel(this.AuthorizePO);
	}
	public void createPO(System.Object source,Inventory e){
	   System.Console.WriteLine("createPO :"+e.stock);	
	}
	public void AuthorizePO(System.Object source,Inventory e){
		   System.Console.WriteLine("AuthorizePO :"+e.stock);	
	}
}
