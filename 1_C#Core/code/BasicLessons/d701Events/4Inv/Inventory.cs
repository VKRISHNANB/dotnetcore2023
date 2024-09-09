using System;
public class Inventory{
    string sku;
    int stockInHand;
public Inventory(string sku) {
        this.sku = sku;
        this.stock = 70;   }
public Inventory(){
	this.sku = "0";
        this.stock = 70;    }
public string Sku {  
    	get{ 
             return sku; 
        }
}
public int stock{  
        get{    
            return stockInHand;  
        }
        set 
        {  
           stockInHand+=value;     
        }
    }
}
