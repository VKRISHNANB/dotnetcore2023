using System;
public class Account 
{
    string sku;
    int AccBalance;
    public Account(string sku, int change) {
        this.sku = sku;
        this.Balance = change;
    }
    public Account(string sku) {
        this.sku = sku;
        this.Balance = 5000;
    }
    public Account() 
    {
        this.sku = "0";
        this.Balance = 5000;
    }

    public string Sku
    {  
    	get
        { 
            return sku; 
        }
    }
    public int Balance
    {  
        get   
        {    
            return AccBalance;  
        }
        set 
        {  
            AccBalance=AccBalance+value;     
        }
    }
}
