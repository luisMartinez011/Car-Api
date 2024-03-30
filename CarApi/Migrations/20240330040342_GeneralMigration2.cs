using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class GeneralMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_IdUser",
                table: "UserAddresses");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(6998), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8026), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8029), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8031), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8032), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8034), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8037), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8038), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8039), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8040), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8041), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5785), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5791), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5792), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5793), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5795), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5796), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5796), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5797), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5798), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5799), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5801), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5805), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5806), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5806), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5807), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5809), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5809), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5811), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5811) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5814), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5815), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5816), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5817), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5818), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5819), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5819), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5821), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5821), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5822), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5823), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5824), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5824), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5825), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5825), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5827), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5829), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5829), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5831), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5833), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5857), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5858), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5861), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5862), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5863), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5863), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5865), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5866), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5866), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5867), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5867), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5868), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5870), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5870), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5871), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5872), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5872), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5873), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5873), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5874), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5876), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5876), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5877), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5878), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5879), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5881), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5882), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5882), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5883), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5884), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5885), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5885), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5886), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5887), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5888), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5889), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5891), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5891), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5892), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5892), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5893), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5894), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5894), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5895), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5897), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5898), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5919), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5922), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5922), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5923), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5927), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5928), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5931), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5932), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5933), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5934), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5936), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5936), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5937), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5939), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5942), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5944), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5945), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5947), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5947), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5949), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5949), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5952), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5952), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5953), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5953), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5954), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5954), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5955), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5956), new DateTime(2024, 3, 30, 4, 3, 42, 429, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_IdUser",
                table: "UserAddresses",
                column: "IdUser",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_IdUser",
                table: "UserAddresses");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(9349), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(9355), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2528), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2531), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2533), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2535), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2537), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2539), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2542), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 3, 29, 22, 26, 11, 527, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4741), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4746), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4747), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4748), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4749), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4752), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4753), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4755), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4756), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4757), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4757), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4758), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4760), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4761), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4763), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4766), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4769), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4773), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4774), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4774), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4775), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4777), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4780), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4782), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4785), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4787), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4789), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4789), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4790), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4791), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4791), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4815), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4818), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4820), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4821), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4822), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4823), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4823), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4824), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4825), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4825), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4826), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4827), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4828), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4830), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4830), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4831), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4832), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4832), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4833), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4834), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4834), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4835), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4835), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4836), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4837), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4837), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4838), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4839), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4839), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4840), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4840), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4842), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4842), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4843), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4844), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4844), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4847), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4847), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4848), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4849), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4849), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4850), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4851), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4851), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4852), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4852), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4853), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4854), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4854), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4855), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4856), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4857), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4858), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4859), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4859), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4889), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4891), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4892), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4892), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4893), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4894), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4895), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4895), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4896), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4896), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4897), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4898), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4898), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4899), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4900), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4900), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4901), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4901), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4902), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4903), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4903), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4904), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4904), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4906), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4906), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4907), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4909), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4909), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4910), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4912), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4913), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4913), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4914), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4914), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4915), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4916), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4916), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4917), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4918), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4918), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4919), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4919), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4920), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4921), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4921), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4922), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4922), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4923), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4924), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4926), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4926), new DateTime(2024, 3, 29, 22, 26, 11, 526, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_IdUser",
                table: "UserAddresses",
                column: "IdUser");
        }
    }
}
