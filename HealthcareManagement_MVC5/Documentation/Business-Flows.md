# Healthcare Management System — End-to-End Business Flows

## Technical request flow
Browser/UI -> MVC/Web API Controller -> Service Layer -> Entity Framework 6 -> SQL Server -> Response.

## Business flows
1. Patient registration and profile management
2. Provider registration and provider lookup
3. Appointment scheduling, rescheduling and cancellation
4. Eligibility and insurance verification
5. Encounter creation and clinical-service recording
6. Medical claim creation and claim status tracking
7. Claim validation and adjudication workflow
8. Payment/claim settlement tracking
9. Patient billing and outstanding balance
10. Search, dashboard and operational reporting
11. Audit/history tracking

## Interview explanation
This is a legacy ASP.NET MVC 5 / Web API 2 application built with C# and .NET Framework 4.8.
The service layer contains business rules and Entity Framework 6 handles SQL Server data access.
The application is intentionally not ASP.NET Core.
