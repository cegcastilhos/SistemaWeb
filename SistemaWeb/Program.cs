using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Areas.Identity.Data;
using SistemaWeb.Data;
using SistemaWeb.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SistemaWebContextConnection");builder.Services.AddDbContext<SistemaWebContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddDbContext<Contexto>(options =>
options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SistemaWebUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SistemaWebContext>();
// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "defaut",  
    pattern: "{controller=Home}/{action=Index}/{Id?}");

app.MapRazorPages();

app.Run();
