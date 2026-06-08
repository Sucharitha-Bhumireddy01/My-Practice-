--Create Log File
create table dbo.Log
(
	LogName varchar(255) not null,
	LogDate datetime not null,
	LogMessage nvarchar(max) null
)
--creating index
create index IdxLogNameLogDate on dbo.Log (LogName, LogDate)

--select statement to look at the table
select * from log

select max(HireDate) from HumanResources.Employee