use Northwind
GO

DROP FUNCTION IF EXISTS dbo.fnCalculateAge
GO

CREATE FUNCTION fnCalculateAge (@birthDay date)
    RETURNS INT
BEGIN
    DECLARE @result INT
    DECLARE @today DATE
    set @today=GETDATE()
    SET @result=DATEDIFF(YEAR,@birthDay,@today)
    RETURN @result
END
GO
