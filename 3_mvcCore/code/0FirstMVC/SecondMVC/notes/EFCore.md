https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
### Packages to install  
---
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
	dotnet tool install --global dotnet-ef
	dotnet add package Microsoft.EntityFrameworkCore.Design
	Install-Package Microsoft.EntityFrameworkCore.Tools
	Get-Help about_EntityFrameworkCore
--------------------------------------------------------------------
### Getting Started with EF Core  

1. Create the model  
	Define a context class and entity classes that make up the model.
	Create the database  
	The following steps use migrations to create a database.  
	```  
	>dotnet ef migrations add InitialCreate // creates 2 files in the \<migrations> folder  
	>dotnet ef database update // will add tables to the db using the above 2 files
	```
