USE [InsuranceManagement_MVC5Db];
GO
CREATE OR ALTER PROCEDURE dbo.usp_GetDashboard
AS
BEGIN
  SET NOCOUNT ON;
  SELECT
    (SELECT COUNT(*) FROM Customer) AS TotalRecords,
    (SELECT COUNT(*) FROM Customer WHERE Status='Active') AS ActiveRecords,
    (SELECT COUNT(*) FROM InsuranceClaim) AS TransactionCount;
END
GO
