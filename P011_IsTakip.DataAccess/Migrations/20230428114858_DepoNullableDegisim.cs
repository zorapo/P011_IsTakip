using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P011_IsTakip.DataAccess.Migrations
{
    public partial class DepoNullableDegisim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YetkiliTelefon",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 48, 57, 774, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 48, 57, 774, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 48, 57, 774, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 48, 57, 774, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 48, 57, 774, DateTimeKind.Local).AddTicks(8427));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YetkiliTelefon",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aciklama",
                table: "Depo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8527));
        }
    }
}
