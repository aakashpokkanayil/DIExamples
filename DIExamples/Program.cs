var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();// if we are using MVC Framework
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
