using CarApi.Models.SeederData;
using CarApi.Models;
using CarApi.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Data.Config
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        private ReadAndParseJson readAndParseJson;
        private IConfiguration configuration;
        private string fileName = "Countries.json";

        public CountryConfiguration(ReadAndParseJson _readAndParseJson, IConfiguration iConfig)
        {
            readAndParseJson = _readAndParseJson;
            configuration = iConfig;
        }

        public CountryConfiguration()
        {
            
        }

        public void Configure(EntityTypeBuilder<Country> builder) {
            List<CountrySeeder> countrySeeders = GetCountryDataAsync();

            List<Country> countries = new List<Country>();
            countrySeeders.ForEach(countrySeeder =>
            {
                Country country = new Country{
                    Name = countrySeeder.Country,
                    CountryCode = countrySeeder.Code,
                    Flag = countrySeeder.Flag,
                    CreatedAt = DateTime.Today,
                    ModifiedAt= DateTime.Today,
                };
            });

            builder.HasData(countries);

            //builder.HasData(
            //new Post { Id = 1, Author = "Oscar Montenegro", Title = "My first Post", Body = "Hello world, this is my first post" },
            //    new Post { Id = 2, Author = "Oscar Montenegro", Title = "My second Post", Body = "Hello world, this is my second post" }
            //);
        }

        public List<CountrySeeder> GetCountryDataAsync()
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine the current directory with the filename
            string filePath = Path.Combine(currentDirectory, "Data", "Config", fileName);

            List<CountrySeeder> countrySeed = readAndParseJson.ReadJson<CountrySeeder>(filePath);
            return countrySeed;
        }



        

    }
}
