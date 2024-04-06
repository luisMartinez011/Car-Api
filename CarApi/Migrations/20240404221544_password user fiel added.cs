using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class passworduserfieladded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(2354), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(2355), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3281), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3283), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3284), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3286), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3288), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3291), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3292), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1224), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1226), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1230), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1231), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1232), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1235), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1239), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1242), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1245), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1246), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1250), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1251), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1253), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1254), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1256), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1257), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1258), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1260), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1261), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1262), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1264), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1265), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1266), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1267), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1268), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1269), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1270), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1271), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1272), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1273), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1274), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1276), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1277), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1278), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1279), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1280), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1281), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1282), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1307), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1310), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1311), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1312), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1313), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1315), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1316), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1317), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1318), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1319), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1320), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1322), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1324), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1325), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1326), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1327), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1328), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1329), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1332), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1333), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1334), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1335), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1336), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1337), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1338), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1339), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1340), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1342), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1343), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1344), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1345), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1346), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1348), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1349), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1350), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1353), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1354), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1355), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1356), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1357), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1358), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1359), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1361), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1362), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1366), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1367), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1368), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1373), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1376), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1378), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1381), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1382), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1383), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1384), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1385), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1386), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1388), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1389), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1390), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1391), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1393), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1416), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1417), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1418), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1419), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1420), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1421), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1422), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1423), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1424), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1425), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1427), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1428), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1429), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1431), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1432), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1433), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1434), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1435), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1436), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1437), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1439), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1440), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1441), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1442), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1443), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1444), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1445), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1446), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1447), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1448), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1450), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1451), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1452), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1453), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1454), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1455), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1457), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1459), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1460), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1462), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1466), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1473), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1478), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(1483) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(3276), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(3282), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(3283), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4774), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4780), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4781), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4785), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4786), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4788), new DateTime(2024, 4, 2, 0, 49, 7, 137, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8808), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8816), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8818), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8820), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8821), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8827), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8829), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8832), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8834), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8835), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8837), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8838), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8839), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8840), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8841), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8844), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8845), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8846), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8848), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8849), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8881), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8883), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8884), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8887), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8890), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8900), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8903), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8907), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8909), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8910), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8912), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8913), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8916), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8919), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8922), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8924), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8927), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8928), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8931), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8932), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8934), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8938), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8939), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8940), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8941), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8943), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8944), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8945), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8947), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8948), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8949), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8951), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8952), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8954), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8955), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8956), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8957), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8959), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8961), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8962), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8964), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8965), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8966), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8967), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8969), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8971), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8972), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8973), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8976), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8978), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8979), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8982), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8983), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9012), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9014), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9016), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9017), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9018), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9019), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9021), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9024), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9026), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9027), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9028), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9029), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9031), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9033), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9034), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9035), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9036), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9037), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9039), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9042), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9043), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9045), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9046), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9047), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9048), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9051), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9052), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9053), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9054), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9055), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9056), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9058), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9059), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9060), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9062), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9063) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9063), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9065), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9066), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9067), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9067) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9068), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9069), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9071), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9072), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9074), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9075), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9076), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9077), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9078), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9079), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9080), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9082), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9083), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9084), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9085), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9086), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9087), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9088), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9089), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9090), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9091), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9093), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9094), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9095), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9096), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9097), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9098), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9099), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9100), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9129), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9130), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9131), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9132), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9133), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9134), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9136), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9137), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9138), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9139), new DateTime(2024, 4, 2, 0, 49, 7, 136, DateTimeKind.Utc).AddTicks(9139) });
        }
    }
}
