TownPlanningDB
---------------
Tables
1. Village
	VillageId (pk)
	Name
	City
	State
	Pincode
	Residents - List<Person> 
	------------------------
2. Person
	PersonId (pk)
	Name
	VillageId (fk)
	DateOfBirth
	AadhaarNo (fk)
	Assets - List<Asset>
	--------------------
3. AadhaarCard
	AadhaarNo (pk)
	DateOfIssue
	ValidTill
	-------------------
4. Asset
	AssetId (pk)
	Description
	Type (Land, CommercialBuilding, House )
	PlotNo
	VillageId (fk)
	--------------------

Relationships
-------------
	1. One to One 
		- One Person One Aadhaar Card
	2. Many to Many (Person to Asset)
		- One Person can have Many Assets
		- One Asset can be Owned by many People
	3. One to Many 
		- One Village Many People
