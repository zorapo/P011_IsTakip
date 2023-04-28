using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P011_IsTakip.DataAccess.Migrations
{
    public partial class PasswordAnnotationKaldırıldı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 27, 12, 25, 3, 962, DateTimeKind.Local).AddTicks(5285));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 26, 22, 44, 4, 710, DateTimeKind.Local).AddTicks(6940));
        }
    }
}
