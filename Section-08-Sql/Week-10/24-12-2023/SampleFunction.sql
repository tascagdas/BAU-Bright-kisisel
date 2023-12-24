--Functions
/*
        -Geriye değer döndürebilen yapılardır.
        -Sorguların içinde kullanılabilirler.
        -Geriye bir DEĞER yada TABLO döndürebilirler.
        -Parametre alabilirler.
        -Bir fonksiyon tablo üzerinde INSERT, UPDATE, DELETE gibi işlemleri YAPAMAZ!! Ama INSERT, DELETE, UPDATE sorgusu içerisinde de fonsiyon kullanılabilir.
*/
USE Northwind
GO

CREATE FUNCTION fnSample(@txt NVARCHAR(max))
    RETURNS NVARCHAR(max)

BEGIN
    RETURN UPPER(@txt)
END