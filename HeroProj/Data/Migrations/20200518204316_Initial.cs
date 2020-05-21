using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroProj.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheros",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    AlterEgo = table.Column<string>(nullable: true),
                    PrimaryAbility = table.Column<string>(nullable: true),
                    SecondaryAbility = table.Column<string>(nullable: true),
                    CatchPhrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheros", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Superheros");
        }
    }
}
