using Microsoft.EntityFrameworkCore;
using Portfolio.Api;
using Portfolio.Api.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Environment.IsEnvironment(Environments.Development)
    ? builder.Configuration.GetConnectionString("Local")
    : Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")!;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddScoped<ICaseService, CaseService>();
builder.Services.AddScoped<IImageService, ImageService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
    app.UseCors(builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();