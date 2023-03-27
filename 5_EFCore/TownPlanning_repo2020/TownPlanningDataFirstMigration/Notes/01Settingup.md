##### Create a new ClassLibrary Project for Migrartion
##### Add the following dependencies to the new project
>  
    <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="3.1.3">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="3.1.3">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.3" />
    <PackageReference Include="Microsoft.Extensions.Logging.Console" Version="3.1.3" />
    </ItemGroup>
##### Add the Domain classes to the project
##### Add a DBContext class and include the DBSets for the domain classes
##### Set the console application as the startup project

Add the following package to the console application:  
> - (for <b>powershell:</b>) Microsoft.EntityFrameworkCore.Tools  
> - (for <b>dotnet CLI:</b>) Microsoft.EntityFrameworkCore.Tools.Dotnet  

Add a reference to the MigrationClasslibrary the console application  
##### Load the Package Manager Console
> Tools>Nuget Package Manager > Package Manager Console

Set the Default Project in Package Manager Console to the MigrationClassLibrary Project where the DBContext is present

##### For help on Powershell commands: 
	PM>get-help entityframework

##### Add-migration
Make sure there are no errors in the class library.  
Build the Project to check for ERORRS.  
Then Run the "add-migration" command in the <b>Package Manager Console</b>  

	PM> Add-Migration Init

##### Update-Database
	pm>Update-Database -verbose
This command will create the <b>Database and Tables</b> using the info from the migration file.  
In future if there is any change in the schema of the Entities , then the future run of the "update-database" command will check the snapshot file, and 
will apply the new modifications to the tables.

##### Script-Migration
	pm> Script-Migration  
This will create the relevant SQL file, in this case T-SQL.  
This SQL can be executed on the production SQL Server database by the Database expert, 
if required even make a few changes to the script. 
