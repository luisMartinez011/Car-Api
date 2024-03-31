using System;
using CarApi.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarApi.Migrations
{
    /// <inheritdoc />
    public partial class GeneralMigration3 : Migration
    {
        /// <inheritdoc />
        public void Convert(MigrationBuilder migrationBuilder, string Parent, params string[] children)
        {
            string idName = "IdUser";

            migrationBuilder.AddColumn<Guid>("Id2", $"{Parent}", nullable: false);
            foreach (var Child in children)
            {
                migrationBuilder.DropForeignKey($"FK_{Child}_{Parent}_{idName}", $"{Child}");
                migrationBuilder.DropIndex($"IX_{Child}_{idName}", $"{Child}");

                //if FK reference exists in child you can wipe the child table or..... instead of drop + add column below, need to call renamecolumn, then addcolumn, then use Andreas' post with migrationBuilder.SQL() and update to convert old keys to guid, then finally drop column.
                migrationBuilder.DropColumn($"{idName}", $"{Child}");
                migrationBuilder.AddColumn<Guid>($"{idName}", $"{Child}", nullable: false);
                //
            }


            migrationBuilder.DropPrimaryKey($"PK_{Parent}", $"{Parent}");
            migrationBuilder.DropColumn($"{idName}", $"{Parent}");
            migrationBuilder.RenameColumn("Id2", $"{Parent}", $"{idName}");
            migrationBuilder.AddPrimaryKey($"PK_{Parent}", $"{Parent}", column: $"{idName}");
            
            foreach (var Child in children)
            {
                migrationBuilder.CreateIndex($"IX_{Child}_{idName}", $"{Child}", $"{idName}");
                migrationBuilder.AddForeignKey(
                    name: $"FK_{Child}_{Parent}_{idName}",
                    table: $"{Child}",
                    column: $"{idName}",
                    principalTable: $"{Parent}",
                    principalColumn: $"{idName}",
                    onDelete: ReferentialAction.Cascade);

            }
        }
    
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string[] children = { "UserAddresses", "OrderDetails", "Appointments" }; 
            Convert(migrationBuilder, Parent:"Users", children);

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "IdUser",
            //    table: "Users",
            //    type: "uuid",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "integer")
            //    .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "IdUser",
            //    table: "UserAddresses",
            //    type: "uuid",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "integer");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "IdUser",
            //    table: "OrderDetails",
            //    type: "uuid",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "integer");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "IdUser",
            //    table: "Appointments",
            //    type: "uuid",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "integer");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "UserAddresses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "OrderDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<int>(
                name: "IdUser",
                table: "Appointments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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
        }
    }
}
