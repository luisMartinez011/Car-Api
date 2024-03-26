using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using CarApi.Models;
using CarApi.Models.SeederData;
using CarApi.Shared;
using System.Configuration;
using System.Collections.Generic;

namespace CarApi.Data.Config
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {

        private HttpClientRepository _httpRepository;
        private IConfiguration configuration;

        public CarConfiguration(HttpClientRepository httpRepository, IConfiguration iConfig)
        {
            _httpRepository = httpRepository;
            configuration = iConfig;
        }

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            
            //builder.HasData(
            //new Post { Id = 1, Author = "Oscar Montenegro", Title = "My first Post", Body = "Hello world, this is my first post" },
            //    new Post { Id = 2, Author = "Oscar Montenegro", Title = "My second Post", Body = "Hello world, this is my second post" }
            //);
        }

        public async Task<List<CarSeeder>> GetCarDataAsync()
        {
            string Url = configuration.GetValue<string>("SeederApis:Car:Url");
            string KeyName = configuration.GetValue<string>("SeederApis:Car:KeyName");
            string ApiKey = configuration.GetValue<string>("SeederApis:Car:ApiKey");

            List<CarSeeder> carSeed = await _httpRepository.GetAsync<CarSeeder>(
                Url,
                KeyName,
                ApiKey
                );
            return carSeed;
        }
    }
}