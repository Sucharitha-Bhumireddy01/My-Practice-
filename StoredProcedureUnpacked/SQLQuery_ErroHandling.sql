alter proc dbo.ErrorHandling
as
--writing the try block
begin --try
	--declaring variables 
	declare @a int=12;
	declare @b int = 0;
	declare @c int;
	--setting c=a/b
	set @c=@a/@b;
	--priniting the output
	--print 'Result: ' + cast(@c as varchar);
	if @@ERROR <>0 print 'divide by zero error!'
	else print 'Result: '+ @c;
end --try
--strting the catch block
--if error occurs in try block the execution flow diverts to catch
/*begin catch
	print N'Error Message - '+error_message();
	print N'Error Line - '+cast(error_line() as varchar);
	print 'divide by zero error!';
end catch*/