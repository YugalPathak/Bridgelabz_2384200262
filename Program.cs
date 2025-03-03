using BusinessLayer.Service;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using NLog.Web;
using NLog;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
try
{
    logger.Info("Application is starting...");
    var builder = WebApplication.CreateBuilder(args);

    // Clear default logging providers and add NLog
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    // Add services to the container.

    builder.Services.AddControllers();
builder.Services.AddScoped<IRegistrationHelloBL,RegisterHelloBL>();
builder.Services.AddScoped<IRegistrationHelloRL,RegisterHelloRL>();
var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));

// Add swagger to container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

}
catch (Exception ex)
{
    logger.Error(ex, "Application encountered an error and stopped.");
    throw;
}
finally
{
    LogManager.Shutdown();
}
