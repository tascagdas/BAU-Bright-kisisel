-- USE MoviesDB
-- GO

-- SELECT
--         c.Name as Film,
--         COUNT(f.Id) as [Film Adedi]
--     FROM Films f RIGHT JOIN Categories c
--         on f.CategoryId=c.Id
--     GROUP BY c.Name
--     ORDER by [Film Adedi] DESC


-- SELECT
--         d.Name as Yönetmen,
--         COUNT(f.Id) as [Film Adedi]
--     FROM Directors d LEFT JOIN Films f
--         ON d.Id=f.DirectorId
--     GROUP BY d.Name
--     ORDER by [Film Adedi] DESC

-- Hangi filmlerin oyuncusu yoktur.

-- SELECT
-- f.Name
-- FROM Films f LEFT OUTER JOIN FilmsStars fs
--     ON f.Id=fs.FilmId JOIN Stars s
--         ON fs.StarId=s.Id
-- GROUP BY f.Name
-- HAVING COUNT(s.Id)=0

USE Northwind
GO

-- SELECT
-- TOP(1)
-- c.CategoryName as Kategori,
-- SUM(od.UnitPrice*od.Quantity) as Tutar
-- FROM Categories c JOIN Products p
--     ON c.CategoryID=p.CategoryID JOIN OrderDetails od
--         ON p.ProductID=od.ProductID
-- GROUP BY c.CategoryName
-- ORDER BY [Tutar] DESC

--Hangi üründen kaç adet satılmıştır.
--Not: Satışı yapılmamış ürün varsa oda listelensin.

-- SELECT
-- p.ProductName as Ürün,
-- SUM(od.Quantity) as Adet
-- FROM Products p LEFT JOIN OrderDetails od
--     ON p.ProductID=od.ProductID
-- GROUP BY p.ProductName
-- ORDER BY [Adet] asc


-- SELECT
-- p.ProductName as Ürün
-- FROM Products p LEFT JOIN OrderDetails od
--     ON p.ProductID=od.ProductID
-- GROUP BY p.ProductName

-- HAVING SUM(od.Quantity) IS NULL

--ençok ciro yapılan üç ürün hangisidir?Ciroyla birlikte listeleyiniz.

-- SELECT
-- top(3)
--     p.ProductName as Product,
--     sum(od.UnitPrice*od.Quantity) as Ciro
-- FROM Products p JOIN OrderDetails od
--     ON p.ProductID=od.ProductID
-- GROUP BY p.ProductName
-- ORDER BY [Ciro] desc

--Hangi Müşteriye ne kadarlık satış yapılmıştır. büyükten küçüğe sıralı.

-- SELECT
-- *
-- FROM Customers c JOIN Orders o
--     ON c.CustomerID=o.CustomerID JOIN OrderDetails od
--         ON c.order

SELECT
    r.RegionDescription as Bölge,
    p.ProductName as Ürün,
    SUM(od.UnitPrice*od.Quantity) as Tutar
FROM Region r JOIN Territories t
    ON r.RegionID=t.RegionID JOIN EmployeeTerritories et
        ON t.TerritoryID=et.TerritoryID JOIN Employees e
            ON et.EmployeeID=e.EmployeeID JOIN Orders o
                ON e.EmployeeID=o.EmployeeID JOIN OrderDetails od
                    ON o.OrderID=od.OrderID JOIN Products p
                        ON od.ProductID=p.ProductID
Where r.RegionDescription='Southern'
GROUP BY r.RegionDescription, p.ProductName
ORDER BY r.RegionDescription, [Tutar] desc