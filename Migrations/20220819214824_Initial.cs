using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksDirectory.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(25) CHARACTER SET utf8mb4", maxLength: 25, nullable: false),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    PhotoUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Location", "Name", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, "If you enjoy scenic views of deep river canyons or rock climbing, Smith Rock State Park is the place for you. There are several thousand climbs in the park. More than a thousand are bolted routes. We also offer miles of hiking and mountain biking trails. Along your trip through the canyon, you might see golden eagles, prairie falcons, mule deer, river otter and beaver.", "Bend, OR", "Smith Rock State Park", "https://openoregon.pressbooks.pub/app/uploads/sites/44/2018/10/Smith_Rock_in_the_Afternoon.jpg" },
                    { 2, "Wrapping around Tillamook Head, between Seaside and Cannon Beach, Ecola State Park stretches along 9 miles of coastline and offers outstanding sightseeing and recreation opportunities combined with a storied past.  Though the scenic and hiking opportunities may be the main allure, the diversity of outdoor recreation including picnicking, tidepooling, surfing and wildlife observation make Ecola State park a destination year round.", "Seaside, OR", "Ecola State Park", "https://images.squarespace-cdn.com/content/v1/50f189dde4b07e77c464e9f3/1514820900691-0DQ7Z1FW5TCWN4HY4N6M/Cannon+Beach+View.jpg?format=1000w" },
                    { 3, "Portland's signature park isn't just loaded with big trees and picnic tables. Located a mere two miles west of downtown and accessible by MAX light rail, 410-acre Washington Park offers up a zoo, two museums, a spectacular rose garden, one of the most authentic Japanese gardens in the world, all bordered by Forest Park — at 5,100 acres, one of the country's premier urban wildernesses.", "Portland, OR", "Washington Park", "https://images.squarespace-cdn.com/content/v1/5665d770df40f3d958f69fd2/1594098580329-26S5U9BRCO5EGE79Z0PA/International+Rose+Test+Garden6.jpg" },
                    { 4, "People call it the “crown jewel” of the Oregon State Parks system, and once you visit, you know why. Silver Falls State Park is the kind of standout scenic treasure that puts Oregon firmly onto the national—and international—stage. Its beauty, boundless recreational opportunities and historic presence keep it there.", "Salem, OR", "Silver Falls State Park", "https://oregonisforadventure.com/wp-content/uploads/2020/06/silver-falls-state-park-trail-of-ten-falls.jpg" },
                    { 5, "Mt. Hood National Forest offers a huge variety of world-class recreational activities with opportunities for everyone. Mt Hood National Forest encompasses eight unique Wilderness areas as well as multiple barrier free accessible sites to explore. Whether it's skiing, hiking, boating, rafting, climbing, backpacking, horseback riding, or fishing that you are hoping to experience, you're sure to find great opportunities in your National Forest. Camping in one of our developed campgrounds is a wonderful way to enjoy the forest.", "Government Camp, OR", "Mt. Hood Natl. Forest", "https://media.istockphoto.com/photos/mount-hood-oregon-picture-id1268487061?k=20&m=1268487061&s=612x612&w=0&h=RJ1ZSwIVtEkQ8GRnOg7jD0iFH9msAjeIW9k7UmnjP1U=" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
