var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Welcome To EmployeeManagement Portal!");

app.Run();
