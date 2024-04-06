using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class Caraddedcolumnmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1951), "Cavalier", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1951), "Chevrolet Cavalier 2019" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1955), "Aveo", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1955), "Chevrolet Aveo 2020" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1957), "Trax", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1958), "Chevrolet Trax 2016" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1960), "Onix", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1960), "Chevrolet Onix 2021" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1963), "X-Trail", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1963), "Nissan X-Trail 2017" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1966), "Altima", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1966), "Nissan Altima 2016" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1968), "Versa", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1968), "Nissan Versa 2019" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1970), "Rogue", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1970), "Nissan Rogue 2016" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1973), "Figo", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1973), "Ford Figo 2019" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1976), "Edge", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1976), "Ford Edge 2016" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1978), "EcoSport", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1978), "Ford EcoSport 2017" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Model", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1980), "Escape", new DateTime(2024, 4, 6, 21, 48, 3, 197, DateTimeKind.Utc).AddTicks(1980), "Ford Escape 2015" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9654), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9655) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9659), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9661), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9662), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9663), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9667), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9699), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9701), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9703), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9704), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9706), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9707), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9708), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9709), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9711), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9711) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9712), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9714), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9714) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9715), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9716), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9717), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9717) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9718), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9719), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9721), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9722), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9723), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9724), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9725), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9725) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9726), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9728), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9729), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9730), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9731), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9733), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9734), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9736), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9738), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9739), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9741), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9743), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9744), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9745), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9747), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9748), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9751), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9752), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9753), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9754), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9755), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9756), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9757), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9759), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9761), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9762), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9764), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9765), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9766), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9768), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9769), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9771), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9772), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9773), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9774), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9776), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9777), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9778), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9779), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9780), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9781), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9784), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9785), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9786), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9787), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9788), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9791), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9821), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9824), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9825), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9827), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9829), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9831), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9832), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9835), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9836), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9838), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9841), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9843), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9844), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9846), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9847), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9849), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9852), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9853), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9854), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9856), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9857), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9862), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9866), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9869), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9871), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9874), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9876), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9877), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9878), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9879), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9881), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9883), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9885), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9886), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9893), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9894), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9895), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9896), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9898), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9901), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9903), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9905), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9907), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9938), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9941), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9942), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9943), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9944), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9945), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9947), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9948), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9949), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9953), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9955), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9956), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9957), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9958), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9961), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9962), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9963), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9965), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9966), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9968), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9969), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9971), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 4, 6, 21, 48, 3, 196, DateTimeKind.Utc).AddTicks(9973) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");

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
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3272), "Cavalier" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3275), "Aveo" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3277), "Trax" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3279), "Onix" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3281), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3281), "X-Trail" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3283), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3283), "Altima" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3284), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3285), "Versa" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3286), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3286), "Rogue" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3288), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3288), "Figo" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3290), "Edge" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3291), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3291), "EcoSport" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3292), new DateTime(2024, 4, 4, 22, 15, 44, 672, DateTimeKind.Utc).AddTicks(3292), "Escape" });

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
    }
}
