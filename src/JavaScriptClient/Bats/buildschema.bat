rmdir /S /Q "Data/Migrations"

dotnet ef migrations add InitialData -c ApplicationDbContext -o Data/Migrations/IdentityServer/ApplicationDb
