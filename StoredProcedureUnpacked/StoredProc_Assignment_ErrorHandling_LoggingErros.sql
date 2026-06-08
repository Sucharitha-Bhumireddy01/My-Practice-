alter proc dbo.CalculateVelocity
as
begin try
	declare @logKey varchar(255) = 'CalculateVelocity'
	declare @now as datetime
	declare @logMsg varchar(max);
	
	--write to log
	set @now = getdate()
	set @logMsg = 'CalculateVelocity proc Started.'
    insert into dbo.Log (LogName, LogDate, LogMessage)
    values (@logKey, @now, @logMsg)

	--calculate velocity for observations  
	select d, t, d / t as v
	from Observations

	--calculate average velocity
	declare @avgVelocity as float
	select @avgVelocity = sum(d) / sum(t)
	from Observations

	--write to log
	set @now = getdate()
	set @logMsg = 'The average velocity is ' + cast(@avgVelocity as varchar)
    insert into dbo.Log (LogName, LogDate, LogMessage)
    values (@logKey, @now, @logMsg)	
	
	
	--write to log
	set @now = getdate()
	set @logMsg = 'CalculateVelocity proc finished.'
    insert into dbo.Log (LogName, LogDate, LogMessage)
    values (@logKey, @now, @logMsg)

end try
	
begin catch
	set @now = getdate()
    set @logMsg = 'Error: ' + cast(error_number() as varchar(50))    
            + ' State: ' + cast(error_state() as varchar(50))
            + ' Proc: ' + cast(isnull(error_procedure(), '') as varchar(100)) 
            + ' Msg: ' + cast(isnull(error_message(), '') as varchar(max))

    insert into dbo.Log (LogName, LogDate, LogMessage)
           values (@logKey, @now, @logMsg)
    ;throw;  --Rethrow to calling process        
end catch  

--to look at the last 10 log entries for this stored procedure
/*select top 10 *
from dbo.Log
where LogName = 'CalculateVelocity'
order by LogDate desc */