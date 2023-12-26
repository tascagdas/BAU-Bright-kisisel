USE Northwind
GO

SELECT
    e.FirstName+' '+e.LastName as [Çalışan],
    dbo.fnCalculateAge(e.BirthDate) as [Yaş]
FROM Employees e
ORDER BY [Yaş] DESC