--Write a trigger for the Product table to ensure the list price can never be raised more than 15 Percent in a single change. 
--Modify the above trigger to execute its check code only if the ListPrice column is updated (Use AdventureWorks Database).
USE AdventureWorks2008R2
GO

Select * from Production.Product;



GO
CREATE TRIGGER PriceRiseChecker
ON Production.Product
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
IF UPDATE(ListPrice)
        BEGIN
            UPDATE Production.Product SET ListPrice = IIF((i.ListPrice - d.ListPrice) > d.ListPrice*0.15, d.ListPrice, i.ListPrice)
            FROM deleted AS d, Production.Product AS p
            INNER JOIN inserted AS i ON i.ProductID = p.ProductID
        END
END
GO



   SELECT ListPrice from Production.Product where ProductID =680;
UPDATE Production.Product SET ListPrice = 1800 WHERE ProductID = 680;
