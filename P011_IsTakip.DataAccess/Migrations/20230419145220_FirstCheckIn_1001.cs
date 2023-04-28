using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P011_IsTakip.DataAccess.Migrations
{
    public partial class FirstCheckIn_1001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yetkili = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YetkiliTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoRaf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoRaf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DurusTip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurusTip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kalinlik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalinlik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailParametreleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSLKullan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailParametreleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MalzemeTip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalzemeTip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriSinif", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriSinifId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_MusteriSinif_MusteriSinifId",
                        column: x => x.MusteriSinifId,
                        principalTable: "MusteriSinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ajanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ajanda_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepoEnvanter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    DepoRafId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    En = table.Column<float>(type: "real", nullable: false),
                    Boy = table.Column<float>(type: "real", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Agirlik = table.Column<float>(type: "real", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoEnvanter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_DepoRaf_DepoRafId",
                        column: x => x.DepoRafId,
                        principalTable: "DepoRaf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_Kalinlik_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "Kalinlik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_MalzemeTip_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Is",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Teklifli = table.Column<bool>(type: "bit", nullable: false),
                    TeklifNo = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsBitimindeBildir = table.Column<bool>(type: "bit", nullable: false),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnceligi = table.Column<int>(type: "int", nullable: false),
                    MusteriSiparisNo = table.Column<int>(type: "int", nullable: false),
                    IsNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    Iscilik = table.Column<bool>(type: "bit", nullable: false),
                    MalzemeNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Is", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Is_Kalinlik_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "Kalinlik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Is_MalzemeTip_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Is_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    KullaniciKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailBildirim = table.Column<bool>(type: "bit", nullable: false),
                    RolTanim = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullanici_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MusteriKisitlama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemAciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kisitlama = table.Column<bool>(type: "bit", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriKisitlama", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriKisitlama_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriTemsilcisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTemsilcisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriTemsilcisi_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsDosya",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDosya", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsDosya_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimEmri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    IsEmriTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamDurusSuresi = table.Column<int>(type: "int", nullable: false),
                    UretimBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimTamamlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimDurum = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimEmri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimEmri_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UretimDurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimEmriId = table.Column<int>(type: "int", nullable: false),
                    DurusSuresi = table.Column<int>(type: "int", nullable: false),
                    DurusTipId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullaniciId = table.Column<int>(type: "int", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncelleyenKullaniciId = table.Column<int>(type: "int", nullable: false),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDurus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDurus_DurusTip_DurusTipId",
                        column: x => x.DurusTipId,
                        principalTable: "DurusTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UretimDurus_UretimEmri_UretimEmriId",
                        column: x => x.UretimEmriId,
                        principalTable: "UretimEmri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ajanda_MusteriId",
                table: "Ajanda",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_DepoId",
                table: "DepoEnvanter",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_DepoRafId",
                table: "DepoEnvanter",
                column: "DepoRafId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_KalinlikId",
                table: "DepoEnvanter",
                column: "KalinlikId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_MalzemeTipId",
                table: "DepoEnvanter",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_MusteriId",
                table: "DepoEnvanter",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_KalinlikId",
                table: "Is",
                column: "KalinlikId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_MalzemeTipId",
                table: "Is",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_MusteriId",
                table: "Is",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_IsDosya_IsId",
                table: "IsDosya",
                column: "IsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullanici_MusteriId",
                table: "Kullanici",
                column: "MusteriId",
                unique: true,
                filter: "[MusteriId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_MusteriSinifId",
                table: "Musteri",
                column: "MusteriSinifId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriKisitlama_MusteriId",
                table: "MusteriKisitlama",
                column: "MusteriId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MusteriTemsilcisi_MusteriId",
                table: "MusteriTemsilcisi",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_DurusTipId",
                table: "UretimDurus",
                column: "DurusTipId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_UretimEmriId",
                table: "UretimDurus",
                column: "UretimEmriId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimEmri_IsId",
                table: "UretimEmri",
                column: "IsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajanda");

            migrationBuilder.DropTable(
                name: "DepoEnvanter");

            migrationBuilder.DropTable(
                name: "IsDosya");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "MailParametreleri");

            migrationBuilder.DropTable(
                name: "MusteriKisitlama");

            migrationBuilder.DropTable(
                name: "MusteriTemsilcisi");

            migrationBuilder.DropTable(
                name: "Tedarikci");

            migrationBuilder.DropTable(
                name: "UretimDurus");

            migrationBuilder.DropTable(
                name: "Depo");

            migrationBuilder.DropTable(
                name: "DepoRaf");

            migrationBuilder.DropTable(
                name: "DurusTip");

            migrationBuilder.DropTable(
                name: "UretimEmri");

            migrationBuilder.DropTable(
                name: "Is");

            migrationBuilder.DropTable(
                name: "Kalinlik");

            migrationBuilder.DropTable(
                name: "MalzemeTip");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "MusteriSinif");
        }
    }
}
