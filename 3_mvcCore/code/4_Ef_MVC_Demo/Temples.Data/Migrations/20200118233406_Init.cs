using Microsoft.EntityFrameworkCore.Migrations;

namespace Temples.DataFirstMigration.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kadavuls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kadavuls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Temples",
                columns: table => new
                {
                    TempleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temples", x => x.TempleId);
                });

            migrationBuilder.CreateTable(
                name: "Sannidhis",
                columns: table => new
                {
                    SannidhiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    KadavulId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sannidhis", x => x.SannidhiId);
                    table.ForeignKey(
                        name: "FK_Sannidhis_Kadavuls_KadavulId",
                        column: x => x.KadavulId,
                        principalTable: "Kadavuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TempleSannidhiDetails",
                columns: table => new
                {
                    TempleId = table.Column<int>(nullable: false),
                    KadavulId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempleSannidhiDetails", x => new { x.TempleId, x.KadavulId });
                    table.ForeignKey(
                        name: "FK_TempleSannidhiDetails_Kadavuls_KadavulId",
                        column: x => x.KadavulId,
                        principalTable: "Kadavuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TempleSannidhiDetails_Temples_TempleId",
                        column: x => x.TempleId,
                        principalTable: "Temples",
                        principalColumn: "TempleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sannidhis_KadavulId",
                table: "Sannidhis",
                column: "KadavulId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TempleSannidhiDetails_KadavulId",
                table: "TempleSannidhiDetails",
                column: "KadavulId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sannidhis");

            migrationBuilder.DropTable(
                name: "TempleSannidhiDetails");

            migrationBuilder.DropTable(
                name: "Kadavuls");

            migrationBuilder.DropTable(
                name: "Temples");
        }
    }
}
