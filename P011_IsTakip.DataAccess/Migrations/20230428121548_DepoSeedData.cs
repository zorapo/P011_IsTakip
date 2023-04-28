using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P011_IsTakip.DataAccess.Migrations
{
    public partial class DepoSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Depo",
                columns: new[] { "Id", "Aciklama", "Aktif", "GuncelleyenKullanici", "GuncelleyenKullaniciId", "OlusturanKullanici", "OlusturanKullaniciId", "OlusturmaTarihi", "Silindi", "Tanim", "Yetkili", "YetkiliTelefon" },
                values: new object[,]
                {
                    { 1, null, true, null, null, "Ediz", 1, new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3583), false, "Depo1", "Ahmet Taş", null },
                    { 2, null, true, null, null, "Kemal", 2, new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3606), false, "Depo2", "Murat Can", null },
                    { 3, null, true, null, null, "Tarık", 3, new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3608), false, "Depo3", "Mehmet Tok", null },
                    { 4, null, true, null, null, "Filiz", 4, new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3610), false, "Depo4", "Cem Dönmez", null }
                });

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 2,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 3,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 4,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 5,
                column: "OlusturmaTarihi",
                value: new DateTime(2023, 4, 28, 15, 15, 47, 937, DateTimeKind.Local).AddTicks(3720));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Depo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Depo",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Depo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Depo",
                keyColumn: "Id",
                keyValue: 4);

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
    }
}
