using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowersMvc.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScientificName = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    BloomingSeason = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Fragrance = table.Column<string>(nullable: true),
                    GrowingConditions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");
        }
    }
}
