use Northwind
go

-- SELECT*
-- from Products

-- SELECT*
-- from Products
-- WHERE ProductID=8

-- SELECT*
-- From Products
-- WHERE CategoryID=1 and UnitsInStock>=50 and SupplierID=16

-- SELECT*
-- From Products
-- WHERE CategoryID=1 or CategoryID=2

-- SELECT*
-- From Products
-- Where UnitPrice>=50 and UnitPrice<=60

-- SELECT count(*) as [Icecekler kategorisindeki urun sayisi]
-- from Products
-- WHERE CategoryID=1

-- SELECT min(UnitPrice) as [Minimum urun fiyati]
-- from Products

-- SELECT max(UnitPrice) as [Maximum urun fiyati]
-- from Products

-- SELECT *, od.UnitPrice*od.Quantity as [Total]
-- from OrderDetails od 

-- SELECT  SUM(od.UnitPrice*od.Quantity) as [Ciro]
-- from OrderDetails od 

-- SELECT  avg(od.UnitPrice*od.Quantity) as [Ortalama Satis]
-- from OrderDetails od 

-- SELECT e.TitleOfCourtesy+' '+ e.FirstName +' '+ e.LastName as [Employee], e.City, e.Country
-- FROM Employees e

-- SELECT UPPER(e.LastName)
-- from Employees e 

-- SELECT
-- e.FirstName as [ad],
-- e.LastName as [soyad],
-- LOWER(e.FirstName+'.'+e.LastName+'@bright.com')as[Mail]
-- FROM Employees e

-- SELECT len(e.LastName) as uzunluk
-- from Employees e 

-- SELECT
--     p.ProductName as Name,
--     lower(replace(replace(p.ProductName,' ','-'),'''','')) as url
-- from Products p

-- SELECT
-- o.EmployeeID as [Calisan],
-- COUNT(*) as [Satis Adedi]
-- FROM Orders o
-- GROUP by o.EmployeeID

-- SELECT
-- sum(od.UnitPrice*od.Quantity) as [Order Total]
-- FROM OrderDetails od
-- GROUP by od.OrderID

SELECT 
o.EmployeeID,
o.CustomerID,
COUNT(*) as [quantity]
FROM Orders o
GROUP by o.EmployeeID, o.CustomerID