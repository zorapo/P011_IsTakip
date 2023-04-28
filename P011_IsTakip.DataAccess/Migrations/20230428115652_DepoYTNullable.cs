using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P011_IsTakip.DataAccess.Migrations
{
    public partial class DepoYTNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 56, 51, 770, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 56, 51, 770, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 56, 51, 770, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 56, 51, 770, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 14, 56, 51, 770, DateTimeKind.Local).AddTicks(1181));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
