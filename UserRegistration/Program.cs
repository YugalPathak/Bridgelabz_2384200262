using BusinessLayer.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NLog.Web;
using RepositoryLayer.Context;
using RepositoryLayer.Service;
using StackExchange.Redis;
using System.Text;
using static BusinessLayer.Service.ResetPasswordBL;
using static RepositoryLayer.Service.ResetPasswordRL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<RabbitMQProducer>();
builder.Services.AddSingleton<RabbitMQConsumer>();
builder.Services.AddSingleton<EmailService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddSingleton<UserRepository>();

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

// Load configuration
var configuration = builder.Configuration;
var redisConnection = configuration["Redis:ConnectionString"];

// Register RedisCacheService
builder.Services.AddSingleton(new RedisCacheService(redisConnection));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UserRegistrationBL>();
builder.Services.AddScoped<RedisCacheService>();
builder.Services.AddScoped<UserRegistrationRL>();

builder.Logging.ClearProviders(); 
/*builder.Logging.AddConsole(); 
builder.Logging.AddDebug();*/
builder.Host.UseNLog();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<UserRegistrationContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Swagger to list all apis
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Start RabbitMQ Consumer in a Background Thread
var rabbitMQConsumer = app.Services.GetRequiredService<RabbitMQConsumer>();
Task.Run(() => rabbitMQConsumer.StartListening());

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
