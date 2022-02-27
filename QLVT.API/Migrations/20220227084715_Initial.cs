using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLVT.API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoPhan",
                columns: table => new
                {
                    IDBP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenBP = table.Column<string>(type: "ntext", nullable: true),
                    TenNDD = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoPhan", x => x.IDBP);
                });

            migrationBuilder.CreateTable(
                name: "DangKy",
                columns: table => new
                {
                    IDDK = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNguoiDK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDBP = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangKy", x => x.IDDK);
                    table.ForeignKey(
                        name: "FK_DangKy_BoPhan_IDBP",
                        column: x => x.IDBP,
                        principalTable: "BoPhan",
                        principalColumn: "IDBP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatHang",
                columns: table => new
                {
                    IDMH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SL = table.Column<int>(type: "int", nullable: false),
                    STT = table.Column<int>(type: "int", nullable: false),
                    IDDK = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatHang", x => x.IDMH);
                    table.ForeignKey(
                        name: "FK_MatHang_DangKy_IDDK",
                        column: x => x.IDDK,
                        principalTable: "DangKy",
                        principalColumn: "IDDK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DangKy_IDBP",
                table: "DangKy",
                column: "IDBP");

            migrationBuilder.CreateIndex(
                name: "IX_MatHang_IDDK",
                table: "MatHang",
                column: "IDDK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatHang");

            migrationBuilder.DropTable(
                name: "DangKy");

            migrationBuilder.DropTable(
                name: "BoPhan");
        }
    }
}
