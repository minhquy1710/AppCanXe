using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace tramcan2.Migrations
{
    public partial class themKhachHang1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TenKhachHang = table.Column<string>(nullable: true),
                    MaKH = table.Column<int>(nullable: false),
                    DtKH = table.Column<int>(nullable: false),
                    DiaChiKH = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    NgayCapKH = table.Column<string>(nullable: true),
                    NoiCapKH = table.Column<string>(nullable: true),
                    CMNDKH = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
