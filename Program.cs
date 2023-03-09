using EmployeesMvc.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDataService, DataService2>();
// H�mta connection-str�ngen fr�n AppSettings.json
var connString = builder.Configuration
    .GetConnectionString("DefaultConnection");

// Registrera Context-klassen f�r dependency injection
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