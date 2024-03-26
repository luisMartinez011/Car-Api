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

        private string fileName = "Cars.json";

        public CarConfiguration()
        {

        }

        public void Configure(EntityTypeBuilder<Car> builder)
        {

            List<CarSeeder> carSeeders = GetCarData();

            List<Car> cars = new List<Car>();
            int index = 1;
            carSeeders.ForEach(carSeeder =>
            {
                int idBrand = 0;
                switch (carSeeder.brand)
                {
                    case "Chevrolet":
                        idBrand= 1;
                        break;
                    case "Nissan":
                        idBrand = 2;
                        break;
                    case "Ford":
                        idBrand = 3;
                        break;
                }
                Car car = new Car
                {
                    IdCar = index,
                    Name = carSeeder.model,
                    Year = carSeeder.year,
                    Price = carSeeder.price,
                    Image = carSeeder.image,
                    IdBrand = idBrand,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                };

                cars.Add(car);
                index++;
            });


            try
            {
                builder.HasData(cars);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        public List<CarSeeder> GetCarData()
        {

            string currentDirectory = Directory.GetCurrentDirectory();

            // Combine the current directory with the filename
            string filePath = Path.Combine(currentDirectory, "Data", "Config", "JsonFiles", fileName);
            ReadAndParseJson readAndParseJson = new ReadAndParseJson(filePath);

            List<CarSeeder> countrySeed = readAndParseJson.ReadJson<CarSeeder>();

            return countrySeed;
        }
    }
}