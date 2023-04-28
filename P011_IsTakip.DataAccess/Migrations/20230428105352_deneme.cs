using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P011_IsTakip.DataAccess.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ad", "KullaniciKodu", "OlusturanKullanici", "OlusturmaTarihi", "Soyad" },
                values: new object[] { "Ediz", "Ediz", "Ediz", new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8494), "Hun" });

            migrationBuilder.InsertData(
                table: "Kullanici",
                columns: new[] { "Id", "Ad", "Aktif", "GuncelleyenKullanici", "GuncelleyenKullaniciId", "KullaniciKodu", "KullaniciSifre", "MailBildirim", "MusteriId", "OlusturanKullanici", "OlusturanKullaniciId", "OlusturmaTarihi", "RolTanim", "Silindi", "Soyad" },
                values: new object[,]
                {
                    { 2, "Kemal", true, null, null, "Kemal", "1234", false, null, "Kemal", 2, new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8518), 0, false, "Sunal" },
                    { 3, "Tarık", true, null, null, "Tarık", "asd", false, null, "Tarık", 3, new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8522), 0, false, "Akan" },
                    { 4, "Filiz", true, null, null, "Filiz", "321", false, null, "Filiz", 4, new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8524), 0, false, "Akın" },
                    { 5, "Türkan", true, null, null, "Türkan", "qwe", false, null, "Türkan", 5, new DateTime(2023, 4, 28, 13, 53, 51, 843, DateTimeKind.Local).AddTicks(8527), 0, false, "Şoray" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Kullanici",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ad", "KullaniciKodu", "OlusturanKullanici", "OlusturmaTarihi", "Soyad" },
                values: new object[] { "Selami", "Selami", "Selami", new DateTime(2023, 4, 27, 12, 25, 3, 962, DateTimeKind.Local).AddTicks(5285), "Şahin" });
        }
    }
}
