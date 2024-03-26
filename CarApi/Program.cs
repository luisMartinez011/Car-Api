using CarApi.Data;
using CarApi.Data.Config;
using CarApi.Shared;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsHistoryTable("_EfMigrations", Configuration.GetSection("Schema").GetSection("User").Value)));

builder.Services.AddHttpClient("httpClient");
builder.Services.AddSingleton<HttpClientRepository>();
//builder.Services.AddSingleton<ReadAndParseJson>();
builder.Services.AddSingleton<CarConfiguration>();
builder.Services.AddSingleton<CountryConfiguration>();
builder.Services.AddSingleton<BrandConfiguration>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
