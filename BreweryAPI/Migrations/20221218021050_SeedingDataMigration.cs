using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BreweryAPI.Migrations
{
    public partial class SeedingDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "2nd-story-brewing-company-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", null, null, "2nd Story Brewing Company", "2673145770", "19106-4700", "Pennsylvania", "117 Chestnut St Frnt", "2022-11-11T05:07:58.723Z", "http://www.2ndstorybrewing.com/" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "attic-brewing-philadelphia", null, null, "planning", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", null, null, "Attic Brewing", "7082047376", "19144-3603", "Pennsylvania", null, "2022-11-11T05:07:58.723Z", null });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "bar-hygge-brewery-techne-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.96707286", "-75.16567302", "Bar Hygge / Brewery Techne", null, "19130-2858", "Pennsylvania", "1720 Fairmount Ave", "2022-11-11T05:07:58.723Z", null });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "brewery-ars-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", null, null, "Brewery ARS", "2159605173", "19145-3620", "Pennsylvania", "1927-29 W Passyunk Ave", "2022-11-11T05:07:58.723Z", "http://breweryars.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "crime-and-punishment-brewing-company-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.9743646", "-75.1808422", "Crime & Punishment Brewing Company", "2152352739", "19130-1212", "Pennsylvania", "2711 W Girard Ave", "2022-11-11T05:07:58.723Z", "http://www.crimeandpunishmentbrewery.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "dock-street-brewery-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", null, null, "Dock Street Brewery", "2157262337", "19143-1689", "Pennsylvania", "701 S 50th St Fl 1", "2022-11-11T05:07:58.723Z", "http://www.dockstreetbeer.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "dock-street-brewing-co-philadelphia", null, null, "planning", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", null, null, "Dock Street Brewing Co", null, "19146", "Pennsylvania", null, "2022-11-11T05:07:58.723Z", null });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "earth-bread-brewery-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "40.0591996", "-75.1903546", "Earth Bread + Brewery", "2152426666", "19119-1843", "Pennsylvania", "7136 Germantown Ave", "2022-11-11T05:07:58.723Z", "http://www.earthbreadbrewery.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "evil-genius-beer-co-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.97578018", "-75.13401561", "Evil Genius Beer Co", "2154256820", "19122-3203", "Pennsylvania", "1727 N Front St", "2022-11-11T05:07:58.723Z", "http://www.evilgeniusbeer.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "fermentery-form-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.976092", "-75.136886", "Fermentery Form", "2675183676", "19122-3234", "Pennsylvania", "161 Cecil B Moore Ave", "2022-11-11T05:07:58.723Z", "http://www.fermenteryform.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "fishtown-brewing-co-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "40.0460129", "-75.0159588", "Fishtown Brewing Co", "2159901396", "19125-4153", "Pennsylvania", "1101 Frankford Ave", "2022-11-11T05:07:58.723Z", "http://fishtownbrewpub.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "goose-island-philadelphia-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.9648491", "-75.13506341", "Goose Island Philadelphia", null, "19123", "Pennsylvania", "1002 Canal St", "2022-11-11T05:07:58.723Z", null });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "iron-hill-brewery-and-restaurant-chestnut-hill-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "40.075132", "-75.205095", "Iron Hill Brewery & Restaurant - Chestnut Hill", "2159485600", "19118-3328", "Pennsylvania", "8400 Germantown Ave", "2022-11-11T05:07:58.723Z", "http://www.ironhillbrewery.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "kensington-barrel-project-philadelphia", null, null, "planning", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", null, null, "Kensington Barrel Project", "16199488705", "19134", "Pennsylvania", null, "2022-11-11T05:07:58.723Z", "http://www.kensingtonbarrelproject.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "love-city-brewing-company-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.96067782", "-75.15509414", "Love City Brewing Company", null, "19123-3703", "Pennsylvania", "1016 Buttonwood St", "2022-11-11T05:07:58.723Z", "http://www.lovecitybrewing.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "manayunk-brewing-co-and-restaurant-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "40.0223235", "-75.2189308", "Manayunk Brewing Co & Restaurant", "2154828220", "19127-1618", "Pennsylvania", "4120 Main St", "2022-11-11T05:07:58.723Z", "http://www.manayunkbrewery.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "philadelphia-brewing-co-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.98282736", "-75.12769991", "Philadelphia Brewing Co", "2154272739", "19125-1606", "Pennsylvania", "2423 Amber St", "2022-11-11T05:07:58.723Z", "http://www.philadelphiabrewing.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "point-breeze-brewing-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.9382866", "-75.1900898", "Point Breeze Brewing", null, "19146-", "Pennsylvania", "1225 S 28th St", "2022-11-11T05:07:58.723Z", "http://www.pointbreezebrewing.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "saint-benjamin-brewing-co-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.9562965", "-75.1475016", "Saint Benjamin Brewing Co", null, "19122-2909", "Pennsylvania", "1710 N 5th St", "2022-11-11T05:07:58.723Z", null });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "second-district-brewing-co-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.92679584", "-75.17297324", "Second District Brewing Co.", "2155755900", "19145", "Pennsylvania", "1939 S. Bancroft St.", "2022-11-11T05:07:58.723Z", "http://seconddistrictbrewing.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "urban-village-brewing-company-philadelphia", null, null, "brewpub", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.9662701", "-75.1400237", "Urban Village Brewing Company", "2676871961", "19123-1612", "Pennsylvania", "1001 N 2nd St", "2022-11-11T05:07:58.723Z", "http://www.urbanvillagebrewing.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "wissahickon-brewing-company-philadelphia", null, null, "micro", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "40.013655", "-75.20047033", "Wissahickon Brewing Company", "2154838833", "19129-1738", "Pennsylvania", "3705 W School House Ln", "2022-11-11T05:07:58.723Z", "http://www.wissahickonbrew.com" });

            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "id", "address_2", "address_3", "brewery_type", "city", "country", "county_province", "created_at", "latitude", "longitude", "name", "phone", "postal_code", "state", "street", "updated_at", "website_url" },
                values: new object[] { "yards-brewing-co-philadelphia", null, null, "regional", "Philadelphia", "United States", null, "2022-11-11T05:07:58.723Z", "39.9655175", "-75.1324016", "Yards Brewing Co", "2156342600", "19123-3110", "Pennsylvania", "901 N Delaware Ave", "2022-11-11T05:07:58.723Z", "http://www.yardsbrewing.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "2nd-story-brewing-company-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "attic-brewing-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "bar-hygge-brewery-techne-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "brewery-ars-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "crime-and-punishment-brewing-company-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "dock-street-brewery-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "dock-street-brewing-co-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "earth-bread-brewery-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "evil-genius-beer-co-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "fermentery-form-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "fishtown-brewing-co-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "goose-island-philadelphia-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "iron-hill-brewery-and-restaurant-chestnut-hill-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "kensington-barrel-project-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "love-city-brewing-company-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "manayunk-brewing-co-and-restaurant-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "philadelphia-brewing-co-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "point-breeze-brewing-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "saint-benjamin-brewing-co-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "second-district-brewing-co-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "urban-village-brewing-company-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "wissahickon-brewing-company-philadelphia");

            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "id",
                keyValue: "yards-brewing-co-philadelphia");
        }
    }
}
