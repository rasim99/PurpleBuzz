using Microsoft.EntityFrameworkCore;
using PB401PurpleBuzz.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
  opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);
var app = builder.Build();

app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.Run();
