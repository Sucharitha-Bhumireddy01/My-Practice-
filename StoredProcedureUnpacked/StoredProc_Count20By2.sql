/*Create a stored procedure name dbo.Count20by2 that counts by two from 2 to 20.
The stored procedure should print out the count each time it changes.*/
----------------------------------------------------------
--SOLUTION: Count to 20 by 2
----------------------------------------------------------
 --Using the WHILE statement change the code block so it counts by two from 2 to 20.
ALTER PROC dbo.Count20By2
AS
BEGIN
    DECLARE @i int = 2;
    WHILE @i<=20
        BEGIN
        PRINT 'Current Count:  ' + CAST(@i as VARCHAR);
        SET @i=@i+2;
        END
END