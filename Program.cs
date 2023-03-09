using EmployeesMvc.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDataService, DataService2>();
// Hämta connection-strängen från AppSettings.json
var connString = builder.Configuration
    .GetConnectionString("DefaultConnection");

// Registrera Context-klassen för dependency injection
builder.Services.AddDbContext<ApplicationContext>
    (o => o.UseSqlServer(connString));

//

var app = builder.Build();

//
app.UseRouting();
app.UseStaticFiles();
app.UseEndpoints(o => o.MapControllers());
//

app.Run();