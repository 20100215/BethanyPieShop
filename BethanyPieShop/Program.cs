using BethanyPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository,MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository,MockPieRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

//middleware
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
