create proc dbo.FindPerson
as
Begin 
	--declaring variables
	DECLARE @firstName varchar(40);
	DECLARE @personID int = 6990;

	--statements
	SELECT @firstName = FirstName
	FROM   Person.Person
	WHERE  BusinessEntityID = @PersonID

	PRINT @firstName
end

--execution statement
exec dbo.FindPerson;