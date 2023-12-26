USE Northwind
GO

DROP PROC IF EXISTS spGetOrdersWithDiscount
GO
CREATE PROC spGetOrdersWithDiscount
AS
    SELECT
    od.OrderID as [Sipariş No],
    SUM(od.UnitPrice*od.Quantity*(1-od.Discount))as[Sipariş Tutarı]
    FROM OrderDetails od
    GROUP BY od.OrderID
GO

--Test
EXEC spGetOrdersWithDiscount
go