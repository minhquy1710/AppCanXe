using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace tramcan2.Migrations
{
    public partial class capnhatbang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaTruc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    DateTimeFrom = table.Column<DateTime>(nullable: false),
                    DateTimeTo = table.Column<DateTime>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaTruc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChatLuongHangHoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenChatLuongHangHoa = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLuongHangHoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhoHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenKhoHang = table.Column<string>(nullable: true),
                    DiaChiKhoHang = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KieuCan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenKieuCan = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    SoLanCan = table.Column<int>(nullable: false),
                    TenThongTinChua = table.Column<string>(nullable: true),
                    DuLieuDieuChinh = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuCan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenLoaiHang = table.Column<string>(nullable: true),
                    DonGia = table.Column<double>(nullable: false),
                    TyLeQuyDoi = table.Column<double>(nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NguonGocHangHoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenNGHH = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguonGocHangHoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TramCan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ma = table.Column<string>(nullable: true),
                    TenTramCan = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramCan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaTruc");

            migrationBuilder.DropTable(
                name: "ChatLuongHangHoa");

            migrationBuilder.DropTable(
                name: "KhoHang");

            migrationBuilder.DropTable(
                name: "KieuCan");

            migrationBuilder.DropTable(
                name: "LoaiHang");

            migrationBuilder.DropTable(
                name: "NguonGocHangHoa");

            migrationBuilder.DropTable(
                name: "TramCan");
        }
    }
}
