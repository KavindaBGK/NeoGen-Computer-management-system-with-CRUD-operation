using NeoGen.contextclass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using NeoGen.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<NeoGenComputerShopContext>(options => options.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=NeoGen;Trusted_Connection=True;"));
builder.Services.AddScoped<Seller>();
builder.Services.AddDbContext<NeoGenComputerShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NeoGenComputerShopContext")));
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

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sellers}/{action=Index}/{id?}");



app.Run();
