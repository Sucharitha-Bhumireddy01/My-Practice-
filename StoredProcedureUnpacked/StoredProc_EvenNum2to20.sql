-- prints even numbers 2-20
--If the number is 10, also print halfway there!
--Within each loop delay execution 1 second.
--Write sample code to satisfy the requirements using a WHILE loop
/*Write sample code to satisfy the requirements using a GOTO statement
to iterate through the even numbers.*/
alter proc dbo.EvenNum2to20
as
begin
	declare @i int=2
	--using while loop
	--while @i<=20
	--begin
start:	-->label
	print @i
	if @i=10
		print 'half way there!'
	waitfor delay '00:00:01'
	set @i=@i+2
	IF @i <= 20 GOTO start -->using goto
	--end
end