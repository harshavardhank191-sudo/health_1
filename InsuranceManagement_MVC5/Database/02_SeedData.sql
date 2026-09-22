USE [InsuranceManagement_MVC5Db];
GO
INSERT INTO Customer (ReferenceNumber, Status) VALUES
('REF-10001','Active'),('REF-10002','Active'),('REF-10003','Closed');
INSERT INTO InsuranceClaim (CustomerId, Amount, Status) VALUES
(1,1250.00,'Pending'),(1,750.00,'Approved'),(2,450.00,'Rejected');
GO
