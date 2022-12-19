﻿// <auto-generated />
using BreweryAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BreweryAPI.Migrations
{
    [DbContext(typeof(BreweryDbContext))]
    [Migration("20221218021050_SeedingDataMigration")]
    partial class SeedingDataMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("BreweryAPI.Entities.Brewery", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("address_2")
                        .HasColumnType("TEXT");

                    b.Property<string>("address_3")
                        .HasColumnType("TEXT");

                    b.Property<string>("brewery_type")
                        .HasColumnType("TEXT");

                    b.Property<string>("city")
                        .HasColumnType("TEXT");

                    b.Property<string>("country")
                        .HasColumnType("TEXT");

                    b.Property<string>("county_province")
                        .HasColumnType("TEXT");

                    b.Property<string>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("latitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("longitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("postal_code")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .HasColumnType("TEXT");

                    b.Property<string>("street")
                        .HasColumnType("TEXT");

                    b.Property<string>("updated_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("website_url")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Breweries");

                    b.HasData(
                        new
                        {
                            id = "2nd-story-brewing-company-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            name = "2nd Story Brewing Company",
                            phone = "2673145770",
                            postal_code = "19106-4700",
                            state = "Pennsylvania",
                            street = "117 Chestnut St Frnt",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.2ndstorybrewing.com/"
                        },
                        new
                        {
                            id = "attic-brewing-philadelphia",
                            brewery_type = "planning",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            name = "Attic Brewing",
                            phone = "7082047376",
                            postal_code = "19144-3603",
                            state = "Pennsylvania",
                            updated_at = "2022-11-11T05:07:58.723Z"
                        },
                        new
                        {
                            id = "bar-hygge-brewery-techne-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.96707286",
                            longitude = "-75.16567302",
                            name = "Bar Hygge / Brewery Techne",
                            postal_code = "19130-2858",
                            state = "Pennsylvania",
                            street = "1720 Fairmount Ave",
                            updated_at = "2022-11-11T05:07:58.723Z"
                        },
                        new
                        {
                            id = "brewery-ars-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            name = "Brewery ARS",
                            phone = "2159605173",
                            postal_code = "19145-3620",
                            state = "Pennsylvania",
                            street = "1927-29 W Passyunk Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://breweryars.com"
                        },
                        new
                        {
                            id = "crime-and-punishment-brewing-company-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.9743646",
                            longitude = "-75.1808422",
                            name = "Crime & Punishment Brewing Company",
                            phone = "2152352739",
                            postal_code = "19130-1212",
                            state = "Pennsylvania",
                            street = "2711 W Girard Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.crimeandpunishmentbrewery.com"
                        },
                        new
                        {
                            id = "dock-street-brewery-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            name = "Dock Street Brewery",
                            phone = "2157262337",
                            postal_code = "19143-1689",
                            state = "Pennsylvania",
                            street = "701 S 50th St Fl 1",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.dockstreetbeer.com"
                        },
                        new
                        {
                            id = "dock-street-brewing-co-philadelphia",
                            brewery_type = "planning",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            name = "Dock Street Brewing Co",
                            postal_code = "19146",
                            state = "Pennsylvania",
                            updated_at = "2022-11-11T05:07:58.723Z"
                        },
                        new
                        {
                            id = "earth-bread-brewery-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "40.0591996",
                            longitude = "-75.1903546",
                            name = "Earth Bread + Brewery",
                            phone = "2152426666",
                            postal_code = "19119-1843",
                            state = "Pennsylvania",
                            street = "7136 Germantown Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.earthbreadbrewery.com"
                        },
                        new
                        {
                            id = "evil-genius-beer-co-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.97578018",
                            longitude = "-75.13401561",
                            name = "Evil Genius Beer Co",
                            phone = "2154256820",
                            postal_code = "19122-3203",
                            state = "Pennsylvania",
                            street = "1727 N Front St",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.evilgeniusbeer.com"
                        },
                        new
                        {
                            id = "fermentery-form-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.976092",
                            longitude = "-75.136886",
                            name = "Fermentery Form",
                            phone = "2675183676",
                            postal_code = "19122-3234",
                            state = "Pennsylvania",
                            street = "161 Cecil B Moore Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.fermenteryform.com"
                        },
                        new
                        {
                            id = "fishtown-brewing-co-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "40.0460129",
                            longitude = "-75.0159588",
                            name = "Fishtown Brewing Co",
                            phone = "2159901396",
                            postal_code = "19125-4153",
                            state = "Pennsylvania",
                            street = "1101 Frankford Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://fishtownbrewpub.com"
                        },
                        new
                        {
                            id = "goose-island-philadelphia-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.9648491",
                            longitude = "-75.13506341",
                            name = "Goose Island Philadelphia",
                            postal_code = "19123",
                            state = "Pennsylvania",
                            street = "1002 Canal St",
                            updated_at = "2022-11-11T05:07:58.723Z"
                        },
                        new
                        {
                            id = "iron-hill-brewery-and-restaurant-chestnut-hill-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "40.075132",
                            longitude = "-75.205095",
                            name = "Iron Hill Brewery & Restaurant - Chestnut Hill",
                            phone = "2159485600",
                            postal_code = "19118-3328",
                            state = "Pennsylvania",
                            street = "8400 Germantown Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.ironhillbrewery.com"
                        },
                        new
                        {
                            id = "kensington-barrel-project-philadelphia",
                            brewery_type = "planning",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            name = "Kensington Barrel Project",
                            phone = "16199488705",
                            postal_code = "19134",
                            state = "Pennsylvania",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.kensingtonbarrelproject.com"
                        },
                        new
                        {
                            id = "love-city-brewing-company-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.96067782",
                            longitude = "-75.15509414",
                            name = "Love City Brewing Company",
                            postal_code = "19123-3703",
                            state = "Pennsylvania",
                            street = "1016 Buttonwood St",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.lovecitybrewing.com"
                        },
                        new
                        {
                            id = "manayunk-brewing-co-and-restaurant-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "40.0223235",
                            longitude = "-75.2189308",
                            name = "Manayunk Brewing Co & Restaurant",
                            phone = "2154828220",
                            postal_code = "19127-1618",
                            state = "Pennsylvania",
                            street = "4120 Main St",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.manayunkbrewery.com"
                        },
                        new
                        {
                            id = "philadelphia-brewing-co-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.98282736",
                            longitude = "-75.12769991",
                            name = "Philadelphia Brewing Co",
                            phone = "2154272739",
                            postal_code = "19125-1606",
                            state = "Pennsylvania",
                            street = "2423 Amber St",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.philadelphiabrewing.com"
                        },
                        new
                        {
                            id = "point-breeze-brewing-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.9382866",
                            longitude = "-75.1900898",
                            name = "Point Breeze Brewing",
                            postal_code = "19146-",
                            state = "Pennsylvania",
                            street = "1225 S 28th St",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.pointbreezebrewing.com"
                        },
                        new
                        {
                            id = "saint-benjamin-brewing-co-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.9562965",
                            longitude = "-75.1475016",
                            name = "Saint Benjamin Brewing Co",
                            postal_code = "19122-2909",
                            state = "Pennsylvania",
                            street = "1710 N 5th St",
                            updated_at = "2022-11-11T05:07:58.723Z"
                        },
                        new
                        {
                            id = "second-district-brewing-co-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.92679584",
                            longitude = "-75.17297324",
                            name = "Second District Brewing Co.",
                            phone = "2155755900",
                            postal_code = "19145",
                            state = "Pennsylvania",
                            street = "1939 S. Bancroft St.",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://seconddistrictbrewing.com"
                        },
                        new
                        {
                            id = "urban-village-brewing-company-philadelphia",
                            brewery_type = "brewpub",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.9662701",
                            longitude = "-75.1400237",
                            name = "Urban Village Brewing Company",
                            phone = "2676871961",
                            postal_code = "19123-1612",
                            state = "Pennsylvania",
                            street = "1001 N 2nd St",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.urbanvillagebrewing.com"
                        },
                        new
                        {
                            id = "wissahickon-brewing-company-philadelphia",
                            brewery_type = "micro",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "40.013655",
                            longitude = "-75.20047033",
                            name = "Wissahickon Brewing Company",
                            phone = "2154838833",
                            postal_code = "19129-1738",
                            state = "Pennsylvania",
                            street = "3705 W School House Ln",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.wissahickonbrew.com"
                        },
                        new
                        {
                            id = "yards-brewing-co-philadelphia",
                            brewery_type = "regional",
                            city = "Philadelphia",
                            country = "United States",
                            created_at = "2022-11-11T05:07:58.723Z",
                            latitude = "39.9655175",
                            longitude = "-75.1324016",
                            name = "Yards Brewing Co",
                            phone = "2156342600",
                            postal_code = "19123-3110",
                            state = "Pennsylvania",
                            street = "901 N Delaware Ave",
                            updated_at = "2022-11-11T05:07:58.723Z",
                            website_url = "http://www.yardsbrewing.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
