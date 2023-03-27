##### One to One
  - One Person lives in One Village  
  - One Person has One Role  
  - One Person has One Aadhaar Card  
  - One Aadhaar Card belongs to One Person   
For BI-Directional Association between <b>Person and AadhaarCard</b>  
   * use Fluent API - OnModelCreating(...) OR  
   * have the PersonID as nullable in AadhaarCard - (not advisable in this case)  
##### One to Many 
  - One Village Many People  

##### Many to Many
  - One Asset Many Owners - CIRCULAR Reference is handled in DbContext OnModelCreating(...) 
  - One Person can have Many Assets
    * May cause CIRCULAR Reference - Check DbContext for solution
 
```<language>
    builder.Entity<AssetDetails>(entity =>
    {
        /** Compound key **/
        entity.HasKey(e => new {e.AssetID,e.PersonId});
        entity.HasOne(d => d.Owner)
            .WithMany(p => p.Assets)
            /** disable cascade DELETE to avoid circular operation **/
            .HasForeignKey(d => d.AssetID)
                .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(d=>d.PersonId)
                .OnDelete(DeleteBehavior.NoAction);                        
    });
```
  - AssetDetails is an Associated Type
```<language>
public List<AssetDetails> Owners{get;set;}
```
 
