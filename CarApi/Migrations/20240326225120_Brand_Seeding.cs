using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class Brand_Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "IdBrand", "CreatedAt", "IdCountry", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2401), 1, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2406), "Chevrolet" },
                    { 2, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2409), 81, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2409), "Nissan" },
                    { 3, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2410), 1, new DateTime(2024, 3, 26, 22, 51, 20, 695, DateTimeKind.Utc).AddTicks(2411), "Ford" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(359), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(365), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(366), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(368), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(401), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(404), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(406), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(407), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(408), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(410), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(411), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(412), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(414), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(415), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(416), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(418), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(418), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(419), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(420), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(421), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(422), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(423), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(424), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(425), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(426), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(427), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(432), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(433), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(436), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(437), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(438), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(438), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(439), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(440), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(441), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(442), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(444), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(446), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(446), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(447), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(448), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(449), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(450), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(451), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(452), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(452), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(453), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(454), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(455), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(455), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(456), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(458), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(459), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(460), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(460), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(462), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(463), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(463), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(464), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(465), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(466), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(467), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(467), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(468), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(502), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(504), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(505), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(509), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(511), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(511), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(513), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(516), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(524), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(526), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(526), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(527), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(528), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(529), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(529), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(530), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(531), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(532), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(533), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(533), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(534), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(535), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(536), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(536), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(537), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(538), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(539), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(540), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(540), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(542), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(543), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(544), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(546), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(546), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(548), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(550), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(554), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(555), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(557), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(559), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(559), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(561), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(598), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(600), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(603), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(603), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(604), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(607), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(607), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(608), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(609), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(610), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(610), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(611), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(612), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(613), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(614), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(614), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(615), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(616), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(617), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(619), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(620), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(621), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(622), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(623), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(624), new DateTime(2024, 3, 26, 20, 22, 32, 381, DateTimeKind.Utc).AddTicks(624) });
        }
    }
}
