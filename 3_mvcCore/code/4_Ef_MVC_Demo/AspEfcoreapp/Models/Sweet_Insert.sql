SET IDENTITY_INSERT Sweets OFF
-- Insert 100 Rows
DECLARE @cnt INT = 1;
WHILE @cnt < 101
BEGIN
	insert into Sweets values (CONCAT( 'Sweet',@cnt),10*@cnt,'NA','Sweet');
   SET @cnt = @cnt + 1;
END;
--update Name and Time
set @cnt = 2;
WHILE @cnt < 101
BEGIN
   update Sweets set Name = CONCAT( 'Sweet',@cnt),CookingTime = 10*@cnt where id=@cnt;
   SET @cnt = @cnt + 1;
END;
-- Update Type
DECLARE @cnt1 INT = 1;
WHILE @cnt1 < 101
BEGIN
	if (@cnt1 % 3 = 0) and (@cnt1 % 5 = 0) 
		update Sweets set DishType = 'Payasam' where Id=@cnt1;
	else if (@cnt1 % 3 = 0)  
		update Sweets set Name='NotSweet', DishType = 'NotSweet' where Id=@cnt1;
	else if (@cnt1 % 5 = 0 )
		update Sweets set DishType = 'SecondDish' where Id=@cnt1;

   SET @cnt1 = @cnt1 + 1;
END;
