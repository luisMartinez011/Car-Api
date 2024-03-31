using Amazon.CognitoIdentityProvider;
using CarApi.Data;
using CarApi.Data.Config;
using CarApi.Data.Repositories;
using CarApi.Shared;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using System.Net;
using System.IdentityModel.Tokens.Jwt;
using Amazon.Extensions.NETCore.Setup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
}); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Configuration = builder.Configuration;
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsHistoryTable("_EfMigrations", Configuration.GetSection("Schema").GetSection("User").Value)));

builder.Services.AddHttpClient("httpClient");
builder.Services.AddSingleton<HttpClientRepository>();
builder.Services.AddSingleton<CarConfiguration>();
builder.Services.AddSingleton<CountryConfiguration>();
builder.Services.AddSingleton<BrandConfiguration>();
builder.Services.AddTransient<IAuthRepository, AuthRepository>();


// Aws configuration
//builder.Services.AddAWSService<IAmazonCognitoIdentityProvider>();
builder.Services.AddCognitoIdentity();

var PoolId = Configuration.GetValue<string>("AWS:UserPoolId");
var ClientId = Configuration.GetValue<string>("AWS:UserPoolClientId");
var RegionId = Configuration.GetValue<string>("AWS:RegionId");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    //.AddCookie(cfg => cfg.SlidingExpiration = true)
.AddJwtBearer(options =>
{
    options.Authority = $"https://cognito-idp.us-east-1.amazonaws.com/us-east-1_QA6faDa0M";
    options.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKeyResolver = (s, securityToken, identifier, parameters) =>
        {
            // get JsonWebKeySet from AWS
            var json = new WebClient().DownloadString($"https://cognito-idp.us-east-1.amazonaws.com/us-east-1_QA6faDa0M/.well-known/jwks.json");
            // serialize the result
            var keys = JsonConvert.DeserializeObject<JsonWebKeySet>(json).Keys;
            // cast the result to be the type expected by IssuerSigningKeyResolver
            return (IEnumerable<SecurityKey>)keys;
        },
        ValidateIssuer = true,
        ValidIssuer= $"https://cognito-idp.us-east-1.amazonaws.com/us-east-1_QA6faDa0M",
        ValidateLifetime= true,
        ValidateIssuerSigningKey = true,
        ValidateAudience = false,
    };
    //options.Configuration = new OpenIdConnectConfiguration();
    //options.RequireHttpsMetadata = false;
    //options.SaveToken = true;
});

//builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

