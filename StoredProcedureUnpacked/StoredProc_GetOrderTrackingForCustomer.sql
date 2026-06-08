--Evolution #1 - Define Procedure
CREATE PROCEDURE GetOrderTrackingForCustomer
AS
BEGIN
    PRINT 'Display Credit Card Information Here.';
END

--Try it!
Exec GetOrderTrackingForCustomer


--Evolution #2 -- Define Query
--Get Latest Sales Order Header
SELECT TOP 1 SOH.SalesOrderID
	FROM   Sales.SalesOrderHeader SOH
		   INNER JOIN Sales.Customer C ON SOH.CustomerID = C.CustomerID
		   INNER JOIN Sales.Store S ON C.StoreID = S.BusinessEntityID
	WHERE  S.Name = 'Good Toys'
	ORDER BY SOH.OrderDate DESC;

--Get Tracking Number -- Last Tracking Entry for Sales Order
SELECT TOP 1 SOD.CarrierTrackingNumber
FROM Sales.SalesOrderDetail SOD
WHERE SOD.SalesOrderID = 71774 and SOD.CarrierTrackingNumber is not null;

go;


-- Evolution #3 Stored Procedure with Query....
ALTER PROCEDURE GetOrderTrackingForCustomer
AS
BEGIN

    --declare variables
    DECLARE @salesOrderID int;
    DECLARE @trackingNumber varchar(25);

    --Lookup Sales Order Header
    SELECT TOP 1 @salesOrderID = SOH.SalesOrderID
	FROM   Sales.SalesOrderHeader SOH
		   INNER JOIN Sales.Customer C ON SOH.CustomerID = C.CustomerID
		   INNER JOIN Sales.Store S ON C.StoreID = S.BusinessEntityID
	WHERE  S.Name = 'Good Toys'
	ORDER BY SOH.OrderDate DESC;

    --Get Tracking Number -- Last Tracking Entry for Sales Order
    SELECT TOP 1 @trackingNumber = SOD.CarrierTrackingNumber
    FROM Sales.SalesOrderDetail SOD
    WHERE SOD.SalesOrderID = @salesOrderID and SOD.CarrierTrackingNumber is not null;

    --Print Tracking Information
    PRINT 'Tracking Number: ' + @TrackingNumber

END


go;
-- Evoluton #4 add Parameter for Store Name.
ALTER PROCEDURE GetOrderTrackingForCustomer
   @StoreName varchar(50)
AS
BEGIN

    --declare variables
    DECLARE @salesOrderID int;
    DECLARE @trackingNumber varchar(25);

    --Lookup Sales Order Header
    SELECT TOP 1 @salesOrderID = SOH.SalesOrderID
	FROM   Sales.SalesOrderHeader SOH
		   INNER JOIN Sales.Customer C ON SOH.CustomerID = C.CustomerID
		   INNER JOIN Sales.Store S ON C.StoreID = S.BusinessEntityID
	WHERE  S.Name = @storeName
	ORDER BY SOH.OrderDate DESC;

    --Get Tracking Number -- Last Tracking Entry for Sales Order
    SELECT TOP 1 @trackingNumber = SOD.CarrierTrackingNumber
    FROM Sales.SalesOrderDetail SOD
    WHERE SOD.SalesOrderID = @salesOrderID and SOD.CarrierTrackingNumber is not null;

    --Print Tracking Information
    PRINT 'Tracking Number: ' + @TrackingNumber

END


go;
ALTER PROCEDURE GetOrderTrackingForCustomer
    @StoreName varchar(50),
    @TrackingNumber varchar(25) OUTPUT
AS
BEGIN

    --declare variables
    DECLARE @SalesOrderID int;

    --Get Latest Sales Order Header
    SELECT TOP 1 @SalesOrderID = SOH.SalesOrderID
    FROM Sales.SalesOrderHeader SOH
        INNER JOIN Sales.Customer c ON SOH.CustomerID = c.CustomerID
        INNER JOIN Sales.Store s ON c.StoreID = s.BusinessEntityID
    WHERE s.Name = @StoreName
    ORDER BY SOH.OrderDate DESC

    IF @@ROWCOUNT > 0 BEGIN
        --Get Tracking Number -- Last Tracking Entry for Sales Order
        SELECT TOP 1 @TrackingNumber = ISNULL(SOD.CarrierTrackingNumber, 'No Tracking Number for Store.')
        FROM Sales.SalesOrderDetail SOD
        WHERE SOD.SalesOrderID = @SalesOrderID
    END
    ELSE BEGIN
        SET @TrackingNumber = 'Store Not Found.'
    END

END

-- Testing...
-- Test 1
-------------------------------------------
DECLARE @name varchar(25)
DECLARE @trackInfo varchar(50)
-------------------------------------------

set @name = 'Good Toys';
set @trackInfo = null;
exec GetOrderTrackingForCustomer @name, @trackInfo OUTPUT
Select 'Test 1',  @trackInfo


-- Test 2
set @name = 'Broken Toys'
set @trackInfo = null;
exec GetOrderTrackingForCustomer @name, @trackInfo OUTPUT
Select 'Test 2', @trackInfo

