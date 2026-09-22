# Insurance Management System — End-to-End Business Flows

## Technical request flow
Browser/UI -> MVC/Web API Controller -> Service Layer -> Entity Framework 6 -> SQL Server -> Response.

## Business flows
1. Customer/member registration and profile management
2. Insurance product and plan setup
3. Quote creation and premium calculation
4. Policy application submission
5. Underwriting review and approval/rejection
6. Policy issuance and policy document tracking
7. Premium payment and payment history
8. Policy renewal and cancellation
9. Endorsement/change request processing
10. Claim registration and document capture
11. Claim validation, assessment and settlement
12. Fraud/risk review status tracking
13. Agent/customer service case management
14. Search, dashboards and operational reporting
15. Audit/history tracking

## Interview explanation
This is a legacy ASP.NET MVC 5 / Web API 2 application built with C# and .NET Framework 4.8.
The service layer contains business rules and Entity Framework 6 handles SQL Server data access.
The application is intentionally not ASP.NET Core.
