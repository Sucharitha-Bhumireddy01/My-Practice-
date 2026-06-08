/*Using the WHILE command create a stored procedure to process 
the string New York 10001ADT*/
CREATE PROC dbo.StringProcess
AS
BEGIN
 
    DECLARE @value as varchar(80) = 'New York 10001ADT' -- Test value
    DECLARE @position as integer = 1
    DECLARE @curText as varchar(1)
 
    -- Functions you can use to create your procedure
    -- LEN(@value) -- returns the number of characters in @value.
    -- SUBSTRING(@value,@position,1) returns the 
    -- character at a specific position.
    -- So SUBSTRING('New York',3,1) returns 'w'
    WHILE @position <= LEN(@value) 
        BEGIN
	    SET @curText = SUBSTRING(@value,@position,1)
	    IF @curText between '0' and '9' BREAK
	    IF @curText <> ' ' PRINT CAST(@position as VARCHAR) + ' ' + @curText
	    SET @position = @position + 1
        END
 
END