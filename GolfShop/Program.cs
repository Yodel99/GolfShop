using GolfShop.Components;
using Infrastructure;
using Infrastructure.Seeding;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MudBlazor.Services;


var builder = WebApplication.CreateBuilder(args);

var dbSettings = builder.Configuration.GetSection("MongoDbSettings").Get<MongoDbSettings>();

if (dbSettings is null)
    throw new InvalidOperationException("MongoDbSettings is not configured properly in appsettings.json");

var mongoClient = new MongoClient(dbSettings.ConnectionString);

var dbContextOption = new DbContextOptionsBuilder<MongoDbContext>()
    .UseMongoDB(mongoClient, dbSettings.DatabaseName).Options;

var db = new MongoDbContext(dbContextOption);

Seed.Populate(db);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Add MudBlazor services
builder.Services.AddMudServices();

//Create and configure Antiforgery service
//var mongoSettings = builder.Configuration.GetSection("MongoDbSettings").Get<MongoDbSettings>();
//builder.Services.AddSingleton(mongoSettings);
//builder.Services.AddSingleton<MongoDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
