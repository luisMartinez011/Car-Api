using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class DeleteOrderTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(6073), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(6078), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(6079), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8882), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8884), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8890), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2228), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2233), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2235), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2236), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2237), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2240), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2241), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2242), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2243), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2245), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2247), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2248), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2249), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2251), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2252), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2253), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2254), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2256), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2257), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2258), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2259), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2260), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2261), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2263), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2264), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2265), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2266), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2267), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2268), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2269), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2270), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2272), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2273), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2276), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2279), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2281), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2282), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2283), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2285), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2286), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2288), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2291), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2293), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2294), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2296), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2298), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2299), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2301), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2302), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2303), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2304), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2307), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2309), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2310), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2337), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2338), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2339), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2342), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2343), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2344), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2345), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2346), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2347), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2349), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2351), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2352), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2353), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2354), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2355), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2357), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2359), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2361), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2362), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2363), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2367), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2368), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2370), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2372), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2373), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2374), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2375), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2377), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2378), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2379), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2384), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2385), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2388), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2390), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2392), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2393), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2394), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2396), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2397), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2398), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2399), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2401), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2403), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2404), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2405), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2406), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2407), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2409), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2412), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2413), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2414), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2415), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2416), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2418), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2419), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2421), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2445), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2448), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2449), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2451), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2452), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2456), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2457), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2459), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2460), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2461), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2462), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2464), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2465), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2466), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2467), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2468), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2469), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2470), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2472), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2473), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2474), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2475), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2476), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2477), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2479), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2481), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2482), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2483), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2484), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2486), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2488), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2489), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2491), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2493), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2494), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2496), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2497), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2498), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2501), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2503), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 4, 2, 0, 38, 50, 846, DateTimeKind.Utc).AddTicks(2504) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    IdOrderDetail = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdUser = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.IdOrderDetail);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    IdOrderItem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCar = table.Column<int>(type: "integer", nullable: false),
                    OrderDetailIdOrderDetail = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IdOrderDetail = table.Column<int>(type: "integer", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.IdOrderItem);
                    table.ForeignKey(
                        name: "FK_OrderItems_Cars_IdCar",
                        column: x => x.IdCar,
                        principalTable: "Cars",
                        principalColumn: "IdCar",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_OrderDetails_OrderDetailIdOrderDetail",
                        column: x => x.OrderDetailIdOrderDetail,
                        principalTable: "OrderDetails",
                        principalColumn: "IdOrderDetail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(6855), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(6860), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(6861), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9003), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9015), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9017), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9025), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3444), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3449), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3450), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3453), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3455), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3458), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3459), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3461), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3463), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3464), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3465), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3467), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3470), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3471), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3473), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3474), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3476), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3478), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3479), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3481), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3482), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3483), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3485), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3486), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3487), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3488), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3489), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3523), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3525), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3527), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3529), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3531), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3532), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3534), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3535), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3537), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3538), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3539), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3540), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3541), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3542), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3544), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3545), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3546), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3547), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3549), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3551), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3552), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3553), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3554), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3555), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3557), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3558), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3559), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3560), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3561), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3563), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3565), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3566), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3567), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3568), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3569), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3570), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3574), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3575), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3576), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3577), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3579), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3580), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3581), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3582), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3583), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3584), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3586), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3587), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3588), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3589), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3590), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3591), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3592), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3594), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3595), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3596), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3597), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3599), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3600), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3601), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3602), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3603), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3604), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3606), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3607), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3608), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3609), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3611), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3612), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3614), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3615), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3616), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3617), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3619), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3621), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3652), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3660), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3665), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3666), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3668), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3671), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3673), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3678), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3680), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3682), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3683), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3684), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3685), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3688), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3689), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3690), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3691), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3692), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3693), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3695), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3696), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3697), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3698), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3699), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3700), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3704), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3705), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3706), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3707), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3709), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3710), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3711), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3712), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3714), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3717), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3718), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3719), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3720), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3721), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3723), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3724), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3725), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3726), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3727), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3731), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3732), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3733), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3734), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3735), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3761), new DateTime(2024, 3, 31, 23, 33, 17, 180, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IdUser",
                table: "OrderDetails",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_IdCar",
                table: "OrderItems",
                column: "IdCar");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderDetailIdOrderDetail",
                table: "OrderItems",
                column: "OrderDetailIdOrderDetail");
        }
    }
}
