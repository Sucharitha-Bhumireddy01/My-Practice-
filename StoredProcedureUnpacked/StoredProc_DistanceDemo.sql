create proc dbo.DistanceDemo
as
begin
	--declaring variables
	DECLARE @velocity float;
	DECLARE @time float;
	DECLARE @distance float;

	--setting values
	SET @velocity = 80;
	SET @time = 2.5;
	SET @distance = @velocity * @time;
--statement
PRINT 'Calculated Distance is ' + CAST(@distance as NVARCHAR);
end

--execution statement
--exec dbo.DistanceDemo;