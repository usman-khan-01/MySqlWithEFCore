using Microsoft.EntityFrameworkCore;

using MySqlWithEntityFramework.Service;
using MySqlWithEntityFramework.EF;

var builder = WebApplication.CreateBuilder(args);

#region Service Registrations
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<LaptopService>();
#endregion

#region MySql Data Connection
// Replace with your server version and type.
var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
builder.Services.AddDbContext<ApplicationContext>(options
    /// => options.UseMySql(connectionString, serverVersion));
    => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))); // => Alternatively, use 'ServerVersion.
                                                                              // AutoDetect(connectionString)'.
#endregion

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
