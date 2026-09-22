USE [HealthcareManagement_MVC5Db];
GO
CREATE OR ALTER PROCEDURE dbo.usp_GetDashboard
AS
BEGIN
  SET NOCOUNT ON;
  SELECT
    (SELECT COUNT(*) FROM Patient) AS TotalRecords,
    (SELECT COUNT(*) FROM Patient WHERE Status='Active') AS ActiveRecords,
    (SELECT COUNT(*) FROM MedicalClaim) AS TransactionCount;
END
GO
