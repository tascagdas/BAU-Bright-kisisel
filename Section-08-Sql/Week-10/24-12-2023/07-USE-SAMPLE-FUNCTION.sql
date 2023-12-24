USE Northwind
GO

-- DECLARE @metin NVARCHAR(10)

-- SET @metin='Zeynep'
-- SELECT dbo.fnSample(@metin)


SELECT
    c.CompanyName,
    dbo.fnSample(c.CompanyName) as Buyukharfli
FROM Customers c