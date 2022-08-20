var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Middlewares
app.UseStaticFiles(); // maka dl using wwwroot, and maka access sa iya folder
app.MapDefaultControllerRoute();

//app.MapGet("/", () => "Hello World!");

app.Run();
