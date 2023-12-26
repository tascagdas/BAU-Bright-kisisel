USE Northwind
GO

DROP PROC IF EXISTS spGetProductsByCategoryName
GO
CREATE PROC spGetProductsByCategoryName
    @categoryName NVARCHAR(15)
AS
    SELECT
    p.ProductID as [Ürün Seri No],
    p.ProductName as [Ürün],
    p.UnitPrice as [Fiyat]
    FROM Products p JOIN Categories c
        ON p.CategoryID=c.CategoryID
        WHERE c.CategoryName=@categoryName
        ORDER BY [Fiyat] DESC
GO

EXEC spGetProductsByCategoryName 'Beverages'