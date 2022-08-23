using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemasWeb2.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();;


builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>

{

    endpoints.MapControllerRoute(
        
        name: "Areas",
        pattern: "{controller=Home}/{action=Index}/{id?}");
        


    endpoints.MapAreaControllerRoute(name: "Principal", 
        areaName: "Principal", 
        pattern: "{controller=Principal}/{action=Index}/{id?}");


    
    endpoints.MapAreaControllerRoute(name: "Categorias", 
        areaName: "Categorias", 
        pattern: "{controller=Categorias}/{action=Index}/{id?}");
    
    endpoints.MapRazorPages();

});

/* DEFAULT */
/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
*/

/*
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();


    endpoints.MapAreaControllerRoute(
        name: "Principal", 
        areaName: "Principal", 
        pattern: "{controller=Principal}/{action=Index}/{id?}");

    endpoints.MapAreaControllerRoute(
        name: "Categorias", 
        areaName: "categorias", 
        pattern: "{controller=Categorias}/{action=Index}/{id?}");



});*/





app.Run();
