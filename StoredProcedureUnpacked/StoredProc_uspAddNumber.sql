CREATE PROCEDURE dbo.uspAddNumber
--adding parameters to the stored procedure
	@num1 float,
	@num2 float
AS
BEGIN
--setting NOCOUNT ON to avoid returning extra result showing number of results returned
--when the stored procedure executed
	SET NOCOUNT ON
--statements of the stored procedure
	SELECT @num1+@num2
END
--executing the stored procedure
EXEC dbo.uspAddNumber 5.0, 15.0