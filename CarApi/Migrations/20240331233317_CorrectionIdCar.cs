using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionIdCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Cars_Id_Car",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Modified_at",
                table: "Appointments",
                newName: "ModifiedAt");

            migrationBuilder.RenameColumn(
                name: "Id_Car",
                table: "Appointments",
                newName: "IdCar");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Appointments",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_Id_Car",
                table: "Appointments",
                newName: "IX_Appointments_IdCar");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Cars_IdCar",
                table: "Appointments",
                column: "IdCar",
                principalTable: "Cars",
                principalColumn: "IdCar",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Cars_IdCar",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "Appointments",
                newName: "Modified_at");

            migrationBuilder.RenameColumn(
                name: "IdCar",
                table: "Appointments",
                newName: "Id_Car");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Appointments",
                newName: "Created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_IdCar",
                table: "Appointments",
                newName: "IX_Appointments_Id_Car");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "IdBrand",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9233), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9236), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9238), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9242), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9243), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9244), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9245), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9247), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9272), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "IdCar",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9274), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6604), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6609), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6610), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6611), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6612), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6614), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6614), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6615), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6616), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6617), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6618), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6619), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6619), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6621), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6622), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6622), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6624), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6624), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 21,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6625), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 22,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6626), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 23,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6626), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 24,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6627), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 25,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 26,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 27,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 28,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 29,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6630), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 30,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 31,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6631), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 32,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6632), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 33,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6633), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 34,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6634), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 35,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6634), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 36,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6635), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 37,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6636), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 38,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6636), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 39,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6637), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 40,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6637), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 41,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6638), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 42,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6639), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 43,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6639), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 44,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6640), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 45,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6640), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 46,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6641), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 47,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6642), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 48,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6642), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 49,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 50,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 51,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 52,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 53,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6690), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 54,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6691), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 55,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6691), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 56,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6692), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 57,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6693), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 58,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6693), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 59,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6694), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 60,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6694), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 61,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 62,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6696), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 63,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6696), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 64,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6697), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 65,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6697), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 66,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6699), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 67,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6700), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 68,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6700), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 69,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6701), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 70,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6701), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 71,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6702), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 72,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6703), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 73,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6703), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 74,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6704), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 75,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6704), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 76,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6705), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 77,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6706), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 78,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6706), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 79,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 80,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6707), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 81,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6708), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 82,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6709), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 83,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6709), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 84,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 85,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6710), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 86,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 87,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6711), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 88,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6712), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 89,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6713), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 90,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6713), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 91,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6714), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 92,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6715), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 93,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 94,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 95,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 96,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 97,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 98,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 99,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6719), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 100,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6720), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 101,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6720), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 102,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6721), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 103,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6721), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 104,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6722), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 105,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6723), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 106,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6723), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 107,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6724), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 108,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6724), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 109,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6725), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 110,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6725), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 111,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6726), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 112,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6727), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 113,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6727), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 114,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6728), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 115,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6729), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 116,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6729), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 117,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 118,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 119,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 120,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 121,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6732), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 122,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 123,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 124,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6734), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 125,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6734), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 126,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6735), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 127,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6736), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 128,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6736), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 129,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6737), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 130,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6761), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 131,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6761), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 132,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6762), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 133,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6763), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 134,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6763), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 135,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6764), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 136,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6765), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 137,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6765), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 138,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6766), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 139,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6766), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 140,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6767), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 141,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6768), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 142,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6768), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 143,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6769), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 144,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6769), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 145,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6770), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 146,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6771), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 147,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6771), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 148,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6772), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 149,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6772), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 150,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6773), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 151,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6773), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 152,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6774), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 153,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6775), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 154,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6775), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 155,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6776), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 156,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6776), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 157,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6777), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 158,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 159,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 160,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6779), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 161,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6779), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 162,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 163,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6781), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 164,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6781), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 165,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6782), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 166,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6782), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 167,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6783), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 168,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6784), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 169,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6784), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 170,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6785), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 171,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6785), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 172,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6786), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 173,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 174,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 175,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 176,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 177,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 178,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6790), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 179,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6790), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 180,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6791), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 181,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6791), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 182,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 183,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 184,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 185,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 186,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 187,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6795), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 188,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6796), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 189,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6796), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 190,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "IdCountry",
                keyValue: 191,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 3, 30, 17, 27, 5, 213, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Cars_Id_Car",
                table: "Appointments",
                column: "Id_Car",
                principalTable: "Cars",
                principalColumn: "IdCar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
