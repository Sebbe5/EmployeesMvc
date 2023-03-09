using EmployeesMvc.Models;

var builder = WebApplication.CreateBuilder(args);

//
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IDataService, DataService>();
//

var app = builder.Build();

//
app.UseRouting();
app.UseStaticFiles();
app.UseEndpoints(o => o.MapControllers());
//

app.Run();