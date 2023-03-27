public class Message{
	InventoryManager inv;
	public  Message(InventoryManager obj){
		this.inv=obj;
		inv.MaxLevelReached+=  new InventoryManager.InvDel(this.createMsg);
		inv.MinLevelReached+=  new InventoryManager.InvDel(this.createMsg);
	}
	public void createMsg(System.Object source,Inventory e){
	   System.Console.WriteLine("createMsg :"+e.stock);	
	}
}