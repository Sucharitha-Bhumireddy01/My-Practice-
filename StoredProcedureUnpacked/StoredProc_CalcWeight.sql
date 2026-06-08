/*Write the stored procedure so if the total weight is greater than or equal to 1000,
the total weight is converted from grams to kilograms, and the unit of measure changed to Kg (Kilograms).*/
ALTER PROC dbo.CalcWeight
AS
BEGIN
	
	--declaring variables
	DECLARE @quantity  as FLOAT = 10.0
	DECLARE @pieceWeight as FLOAT = 15.5 -- in grams
	DECLARE @totalWeight as FLOAT
	DECLARE @UoM as VARCHAR(10) = 'g'
	
	--setting values
	SET @totalWeight = @quantity * @pieceWeight
	
	-- If Total Weight is greater than 1000 then switch
	-- Weight to Kilograms and Uom to Kg.
	
	-- enter your code here!
	if @totalWeight>1000 BEGIN
		SET @totalWeight=@totalWeight/1000
		SET @UoM='Kg'
	END
	 
END
