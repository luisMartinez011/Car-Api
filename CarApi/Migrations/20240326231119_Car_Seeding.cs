using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class Car_Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cars",
                newName: "Image");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdCountry", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7688), 60, new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdCountry", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7696), 92, new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdCountry", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7698), 60, new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "IdCar", "CreatedAt", "IdBrand", "Image", "ModifiedAt", "Name", "Price", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(659), 1, "https://images.prd.kavak.io/eyJidWNrZXQiOiJrYXZhay1pbWFnZXMiLCJrZXkiOiJpbWFnZXMvMzA1NDY4L0VYVEVSSU9SLWZyb250U2lkZVBpbG90TmVhci0xNzEwMjYyNDc4ODczLmpwZWciLCJlZGl0cyI6eyJyZXNpemUiOnsid2lkdGgiOjgxMCwiaGVpZ2h0Ijo0NjV9fX0=", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(660), "Cavalier", 220.999f, 2019f },
                    { 2, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(663), 1, "https://www.chevrolet.com.mx/content/dam/chevrolet/na/mx/es/index/cars/2024-aveo-sedan/colorizer/01-images/rojo-metalico.jpg?imwidth=960", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(663), "Aveo", 210.999f, 2020f },
                    { 3, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(664), 1, "https://images.kavak.services/assets/images/families/chevrolet/trax-2013-2016-suv.png", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(664), "Trax", 217.999f, 2016f },
                    { 4, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(665), 1, "https://d3s2hob8w3xwk8.cloudfront.net/autos-landing/chevrolet/onix-2021/colores/AZUL-PACIFICO.png", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(665), "Onix", 220.999f, 2021f },
                    { 5, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(667), 2, "https://images.kavak.services/assets/images/families/nissan/x-trail-2015-2017-suv.png", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(667), "X-Trail", 315.999f, 2017f },
                    { 6, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(669), 2, "https://wieck-nissanao-production.s3.amazonaws.com/photos/5b0b30b905a278c72e619ab8bcd7fdc33bd08f88/preview-928x522.jpg", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(669), "Altima", 216.999f, 2016f },
                    { 7, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(670), 2, "https://images.kavak.services/assets/images/families/nissan/versa-2015-2019-sedan.png", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(671), "Versa", 237.999f, 2019f },
                    { 8, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(671), 2, "https://platform.cstatic-images.com/xlarge/in/v2/stock_photos/4e76df27-9d8d-4673-b870-1b76ad914ba7/0d0f491e-6cdb-4803-a30a-0495cc0f7b24.png", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(672), "Rogue", 206.999f, 2016f },
                    { 9, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(673), 3, "https://acnews.blob.core.windows.net/imgnews/large/NAZ_8aa982c8ca9448559f09c9745499ed45.jpg", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(673), "Figo", 195.999f, 2019f },
                    { 10, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(675), 3, "https://www.cars.com/i/large/in/v2/stock_photos/92283502-8e37-4f02-88d0-cd4ba8403e95/83d3fa63-75fa-4fe1-8232-00c34a724eb8.png", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(675), "Edge", 321.999f, 2016f },
                    { 11, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(676), 3, "https://images.prd.kavak.io/eyJidWNrZXQiOiJrYXZhay1pbWFnZXMiLCJrZXkiOiJpbWFnZXMvMjkzMjUyL0VYVEVSSU9SLWZyb250U2lkZVBpbG90TmVhci0xNzA0NDgzMzQxNDg0LmpwZWciLCJlZGl0cyI6eyJyZXNpemUiOnsid2lkdGgiOjU0MCwiaGVpZ2h0IjozMTB9fX0=", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(676), "EcoSport", 222.999f, 2017f },
                    { 12, new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(677), 3, "https://cdn.wheel-size.com/automobile/body/ford-escape-2013-2016-1673340295.7682333.jpg", new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(677), "Escape", 214.999f, 2015f }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3223), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3231), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3232), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3234), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3236), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3237), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3237), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3238), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3242), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3243), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3245), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3248), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3253), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3254), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3254), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3255), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3256), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3256), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3258), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3259), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3265), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3266), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3266), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3267), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3269), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3272), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3272), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3273), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3276), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3279), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3279), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3281), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3309), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3310), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3311), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3313), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3313), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3314), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3315), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3316), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3316), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3317), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3318), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3318), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3319), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3320), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3320), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3321), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3322), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3323), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3323), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3324), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3325), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3325), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3326), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3327), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3327), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3328), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3329), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3329), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3330), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3331), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3331), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3332), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3333), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3333), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3334), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3335), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3335), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3336), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3337), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3338), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3339), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3339), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3340), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3341), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3341), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3342), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3343), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3343), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3344), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3345), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3345), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3346), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3347), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3347), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3348), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3349), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3350), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3352), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3353), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3353), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3355), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3356), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3377), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3380), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3380), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3381), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3382), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3382), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3383), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3384), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3384), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3385), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3386), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3386), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3387), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3389), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3390), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3390), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3391), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3392), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3392), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3394), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3396), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3398), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3399), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3399), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3400), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3401), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3401), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3402), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3403), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3403), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3404), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3406), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3407), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3407), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3408), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3409), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3409), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3413), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3413), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3414), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3416), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3418), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(3418) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12);

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Cars",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdCountry", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2401), 1, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdCountry", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2409), 81, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdCountry", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2410), 1, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7719), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7720), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7721), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7727), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7728), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7754), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7756), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7758), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7762), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7764), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7766), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7767), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7770), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7771), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7773), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7774), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7777), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7779), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7781), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7783), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7784), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7785), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7785), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7787), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7792), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7793), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7795), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7796), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7796), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7797), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7799), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7800), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7801), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7803), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7806), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7806), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7807), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7809), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7809), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7811), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7812), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7814), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7815), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7816), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7816), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7820), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7822), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7823), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7825), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7826), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7827), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7828), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7828), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7831), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7832), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7833), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8003), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8006), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8007), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8010), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8012), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8014), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8014), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8017), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8017), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8020), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8021), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8021), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8022), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8024), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8025), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8025), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8026), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8027), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8029), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8030), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8030), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8032), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8032), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8033), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8034), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8034), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8035), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8037), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8040), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8043), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8043), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8044), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8045), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8046), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8047), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8047), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8048), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8049), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8050), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8050), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8051), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8052), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8053), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8054), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8055), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8055), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8056), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8057), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8058), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8059), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8059), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8060), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8061), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8062), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8062), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8095), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8097), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8098), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8098), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8099), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8100), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8101), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8101), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8102), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8104), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8105), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8107), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8108), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8108), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8109), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8110), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8111), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8111), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8112), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8113), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8113), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8116), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8116), new DateTime(2024, 3, 26, 22, 51, 20, 691, DateTimeKind.Utc).AddTicks(8116) });
        }
    }
}
