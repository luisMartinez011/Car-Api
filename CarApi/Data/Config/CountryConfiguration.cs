using CarApi.Models.SeederData;
using CarApi.Models;
using CarApi.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Data.Config
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        
        private string fileName = "Countries.json";

        public CountryConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<Country> builder) {
            
            List<CountrySeeder> countrySeeders = GetCountryData();

            List<Country> countries = new List<Country>();
            int index = 1;
            countrySeeders.ForEach(countrySeeder =>
            {
                Country country = new Country { 
                    IdCountry = index,
                    Name = countrySeeder.Country,
                    CountryCode = countrySeeder.Code,
                    Flag = countrySeeder.Flag,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt= DateTime.UtcNow,
                };

                countries.Add(country);
                index++;
            });

            
            try
            {
                builder.HasData(countries);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public List<CountrySeeder> GetCountryData()
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine the current directory with the filename
            string filePath = Path.Combine(currentDirectory, "Data", "Config", "JsonFiles", fileName);
            ReadAndParseJson readAndParseJson = new ReadAndParseJson(filePath);

            List<CountrySeeder> countrySeed = readAndParseJson.ReadJson<CountrySeeder>();
            
            return countrySeed;
        }

    }
}
