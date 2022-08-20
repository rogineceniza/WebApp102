var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Middlewares

app.MapDefaultControllerRoute();

//app.MapGet("/", () => "Hello World!");

app.Run();
