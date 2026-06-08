create proc dbo.CalcPricePerPound
as
begin
	DECLARE @weight FLOAT;
	DECLARE @totalPrice FLOAT;
	DECLARE @pricePerPound FLOAT;

	SET @weight = 2.5;
	SET @totalPrice = 10.98;

	IF @weight = 0
	BEGIN
		PRINT 'Weight is 0, this is not allowed, changing weight to 1';
		SET @weight = 1.0;
		IF @totalPrice > 100
		BEGIN
			PRINT 'Total Price too large, setting to 100.';
			SET @totalPrice = 100;
		END
	END
	ELSE
	BEGIN
		Print 'Valid weight entered, calculating price per pound.'
		IF @totalPrice > 100
		BEGIN
			PRINT 'Total Price too large, setting to 100.';
			SET @totalPrice = 100;
		END
	END

	SET @pricePerPound = @totalPrice / @weight
	PRINT 'The price per pound is ' + CAST(@pricePerPound as NVARCHAR)
end