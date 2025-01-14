using Microsoft.EntityFrameworkCore;
using service_deskjr.Data;
using service_deskjr.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configure DbContext with MySQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(9, 1, 0)) // MySQL server version
    )
);

// Configure Identity
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts(); // Adds HTTP Strict Transport Security (HSTS) headers
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseStaticFiles(); // Serve static files

app.UseRouting(); // Enable routing

app.UseAuthentication(); // Add authentication middleware
app.UseAuthorization(); // Add authorization middleware

// Map Razor Pages and Controllers
app.MapRazorPages();
app.MapDefaultControllerRoute();

app.Run();
