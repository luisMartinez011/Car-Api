using CarApi.Models.SeederData;
using CarApi.Models;
using CarApi.Shared;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarApi.Data.Config
{
    public class BrandConfiguration
    {
        private string fileName = "Brands.json";

        public BrandConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<Brand> builder)
        {

            List<BrandSeeder> brandSeeders = GetBrandData();

            List<Brand> brands = new List<Brand>();
            

            brandSeeders.ForEach(brandSeeder =>
            {
                Brand brand = new Brand
                {
                    IdBrand = brandSeeder.Id,
                    Name = brandSeeder.Name,
                    IdCountry = brandSeeder.Country,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                };

                brands.Add(brand);
            });


            try
            {
                builder.HasData(brands);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public List<BrandSeeder> GetBrandData()
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine the current directory with the filename
            string filePath = Path.Combine(currentDirectory, "Data", "Config", "JsonFiles", fileName);
            ReadAndParseJson readAndParseJson = new ReadAndParseJson(filePath);

            List<BrandSeeder> countrySeed = readAndParseJson.ReadJson<BrandSeeder>();

            return countrySeed;
        }

    }
}
