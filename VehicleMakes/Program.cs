using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using System.Globalization;
using VehicleMakes.Core;
using VehicleMakes.Core.Filters;
using VehicleMakes.Core.MiddleWare;
using VehicleMakes.Data.Entities.Identity;
using VehicleMakes.Infrastructure;
using VehicleMakes.Infrustructure;
using VehicleMakes.Infrustructure.Seeder;
using VehicleMakes.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VehicleMakesDbContext>(Option =>
                 Option.UseSqlServer(builder.Configuration.GetConnectionString("constr")));




builder.Services.AddInfrastructureDependencies()
                .AddServiceDependecies()
                .AddCoreDependencies()
                 .AddServiceRegisteration(builder.Configuration);



#region Localization
builder.Services.AddControllersWithViews();
builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "";
});

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    List<CultureInfo> supportedCultures = new List<CultureInfo>
    {
            new CultureInfo("en-US"),
            new CultureInfo("de-DE"),
            new CultureInfo("fr-FR"),
            new CultureInfo("ar-EG")
    };

    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

#endregion

#region AllowCORS
var CORS = "_cors";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CORS,
                      policy =>
                      {
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                          policy.AllowAnyOrigin();
                      });
});

#endregion

builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
builder.Services.AddTransient<IUrlHelper>(x =>
{
    var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
    var factory = x.GetRequiredService<IUrlHelperFactory>();
    return factory.GetUrlHelper(actionContext);
});
builder.Services.AddTransient<AuthFilter>();

//Serilog
Log.Logger=new LoggerConfiguration()
              .ReadFrom.Configuration(builder.Configuration).CreateLogger();
builder.Services.AddSerilog();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
    await RoleSeeder.SeedAsync(roleManager);
    await UserSeeder.SeedAsync(userManager);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region Localization Middleware
var options = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(options.Value);
#endregion

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();
app.UseCors(CORS);
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();