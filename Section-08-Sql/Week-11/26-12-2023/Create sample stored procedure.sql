/*
Stored Procedure
Server üzerinde çalıştırılan kod parçalarıdır.
Functionlara göre daha güvenli ve hızlı çalışırlar.
Bu yüzdende daha çok tercih edilirler.
*/

USE Northwind
GO

DROP PROCEDURE IF EXISTS spSample
GO

CREATE PROCEDURE spSample
AS
    SELECT
    *
    FROM Products p
    WHERE p.CategoryID=1
    ORDER BY p.UnitPrice DESC
GO

EXECUTE spSample
GO