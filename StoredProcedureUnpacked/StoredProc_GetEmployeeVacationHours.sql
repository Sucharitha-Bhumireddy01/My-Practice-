--Example Showing Steps to Use Log File to Cach Error
--Log it to Log Table, and Throw to calling process.
alter proc dbo.GetAverageEmployeeVacationHours
as
begin try
	declare @logMessage varchar(max)
	declare @logKey varchar(255) = 'GetAverageEmployeeVacationHours'
	declare @now as datetime

	declare @totalHours float, 
			@totalEmployees float,
			@avgHours float


	select @totalHours =  sum(VacationHours)
	from HumanResources.Employee;

	select @totalEmployees = COUNT(*)
	from HumanResources.Employee
	where HireDate>'2014-05-05';

	set @AvgHours = @TotalHours / @TotalEmployees;
	print 'Average Vacation Hours For Employees Are:  ' + cast(@AvgHours as varchar);
	
end try

begin catch
	set @now = getdate()
    set @logMessage = 'Error: ' + cast(error_number() as varchar(50))    
            + ' State: ' + cast(error_state() as varchar(50))
            + ' Proc: ' + cast(isnull(error_procedure(), '') as varchar(100)) 
            + ' Msg: ' + cast(isnull(error_message(), '') as varchar(max))

    insert into dbo.Log (LogName, LogDate, LogMessage)
           values (@logKey, @now, @LogMessage)

    ;throw;  --Rethrow to calling process        
end catch  