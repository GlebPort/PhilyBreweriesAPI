using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreweryAPI.Migrations
{
    public partial class PhilyBreweryInitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breweries",
                columns: table => new
                {
                    id = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    brewery_type = table.Column<string>(type: "TEXT", nullable: true),
                    street = table.Column<string>(type: "TEXT", nullable: true),
                    address_2 = table.Column<string>(type: "TEXT", nullable: true),
                    address_3 = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    state = table.Column<string>(type: "TEXT", nullable: true),
                    county_province = table.Column<string>(type: "TEXT", nullable: true),
                    postal_code = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true),
                    longitude = table.Column<string>(type: "TEXT", nullable: true),
                    latitude = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<string>(type: "TEXT", nullable: true),
                    website_url = table.Column<string>(type: "TEXT", nullable: true),
                    updated_at = table.Column<string>(type: "TEXT", nullable: true),
                    created_at = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breweries", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breweries");
        }
        
    }
}
