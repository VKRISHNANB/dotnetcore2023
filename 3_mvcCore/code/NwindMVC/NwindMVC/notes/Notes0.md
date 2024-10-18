https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
### Packages to install  
---
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
	dotnet tool install --global dotnet-ef
	dotnet add package Microsoft.EntityFrameworkCore.Design
Open  Nuget Package Manager Console and  

	Install-Package Microsoft.EntityFrameworkCore.Tools
Verify Installation by typing the following in Package-Console:  

	Get-Help about_EntityFrameworkCore
--------------------------------------------------------------------
### Getting Started with EF Core Data First:  

```Code```
	Scaffold-DbContext -provider Microsoft.EntityFrameworkCore.SqlServer -connection name="NwindConnection"  -OutputDir Models
```

To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.



Scaffold-DbContext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "server=DESKTOP-LSEVB9U;database=Northwind;integrated security=true;Encrypt=false;" -OutputDir Models
