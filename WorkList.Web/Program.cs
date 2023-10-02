using Microsoft.EntityFrameworkCore;
using WorkList.Application.Interfaces;
using WorkList.Application.Services;
using WorkList.Domain.Interfaces;
using WorkList.Infra.Data.Context;
using WorkList.Infra.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IToDoAppService, ToDoAppService>();
builder.Services.AddScoped<IToDoRepository, ToDoRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WorkListContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
