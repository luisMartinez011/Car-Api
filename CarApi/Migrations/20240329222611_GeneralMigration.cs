using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class GeneralMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddressKey",
                table: "UserAddresses",
                newName: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "UserAddresses",
                newName: "AddressKey");

            migrationBuilder.AlterColumn<int>(
                name: "LastName",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7688), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7696), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7698), new DateTime(2024, 3, 26, 23, 11, 19, 725, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(659), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(664), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(665), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(667), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(669), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(670), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(671), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(673), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(675), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(676), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 3, 26, 23, 11, 19, 726, DateTimeKind.Utc).AddTicks(677) });

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
    }
}
