using Microsoft.EntityFrameworkCore;
using MiniRentalSystem.Application.Interfaces;
using MiniRentalSystem.Application.Services;
using MiniRentalSystem.Infrastructure.Persistence;
using MiniRentalSystem.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories first
builder.Services.AddScoped<IBookRepository, BookRepository>();

// Then register services that depend on them
builder.Services.AddScoped<IBookService, BookService>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Books}/{action=Index}/{id?}");

app.Run();