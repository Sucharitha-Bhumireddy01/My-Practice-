create proc dbo.UpperCity
As
Begin
	--declaring variables
	DECLARE @name VARCHAR(40) = 'unknown';
	--print statement
	PRINT @name;
	--setting value
	SET @name = 'Chicago';
	--print statement
	PRINT 'The uppercase value of ''' + @name + '''is ' + UPPER(@name);
end

--execution statement
exec dbo.UpperCity;