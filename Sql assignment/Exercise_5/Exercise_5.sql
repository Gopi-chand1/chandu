--Write a Procedure supplying name information from the Person.Person table and accepting a filter for the first name.
--Alter the above Store Procedure to supply Default Values if user does not enter any value.( Use AdventureWorks)
USE AdventureWorks2008R2
GO

CREATE PROCEDURE Person.getNameSByType
@Type varchar(50)
AS
SELECT FirstName
FROM Person.Person
WHERE personType=@Type;
GO

EXEC Person.getNameByType 'SP';
GO


ALTER PROCEDURE Person.getNamesByType
  @Type varchar(50)='EM'
AS

SELECT FirstName
FROM Person.Person
WHERE PersonType=@Type;
GO
   
  EXEC Person.getNamesByType;
  GO