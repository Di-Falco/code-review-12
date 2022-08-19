using Microsoft.EntityFrameworkCore;

namespace ParksDirectory.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options)
      : base(options) { }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>().HasData(
        new Park { ParkId = 1, Name = "Smith Rock State Park", Location = "Bend, OR",
                   Description = "If you enjoy scenic views of deep river canyons or rock climbing, Smith Rock State Park is the place for you. There are several thousand climbs in the park. More than a thousand are bolted routes. We also offer miles of hiking and mountain biking trails. Along your trip through the canyon, you might see golden eagles, prairie falcons, mule deer, river otter and beaver.",
                   PhotoUrl = "https://openoregon.pressbooks.pub/app/uploads/sites/44/2018/10/Smith_Rock_in_the_Afternoon.jpg" },
        new Park { ParkId = 2, Name = "Ecola State Park", Location = "Seaside, OR",
                   Description= "Wrapping around Tillamook Head, between Seaside and Cannon Beach, Ecola State Park stretches along 9 miles of coastline and offers outstanding sightseeing and recreation opportunities combined with a storied past.  Though the scenic and hiking opportunities may be the main allure, the diversity of outdoor recreation including picnicking, tidepooling, surfing and wildlife observation make Ecola State park a destination year round.",
                   PhotoUrl = "https://images.squarespace-cdn.com/content/v1/50f189dde4b07e77c464e9f3/1514820900691-0DQ7Z1FW5TCWN4HY4N6M/Cannon+Beach+View.jpg?format=1000w" },
        new Park { ParkId = 3, Name = "Washington Park", Location = "Portland, OR",
                   Description = "Portland's signature park isn't just loaded with big trees and picnic tables. Located a mere two miles west of downtown and accessible by MAX light rail, 410-acre Washington Park offers up a zoo, two museums, a spectacular rose garden, one of the most authentic Japanese gardens in the world, all bordered by Forest Park — at 5,100 acres, one of the country's premier urban wildernesses.",
                   PhotoUrl = "https://images.squarespace-cdn.com/content/v1/5665d770df40f3d958f69fd2/1594098580329-26S5U9BRCO5EGE79Z0PA/International+Rose+Test+Garden6.jpg" },
        new Park { ParkId = 4, Name = "Silver Falls State Park", Location = "Salem, OR",
                   Description = "People call it the “crown jewel” of the Oregon State Parks system, and once you visit, you know why. Silver Falls State Park is the kind of standout scenic treasure that puts Oregon firmly onto the national—and international—stage. Its beauty, boundless recreational opportunities and historic presence keep it there.",
                   PhotoUrl = "https://oregonisforadventure.com/wp-content/uploads/2020/06/silver-falls-state-park-trail-of-ten-falls.jpg" },
        new Park { ParkId = 5, Name = "Mt. Hood Natl. Forest", Location = "Government Camp, OR",
                   Description = "Mt. Hood National Forest offers a huge variety of world-class recreational activities with opportunities for everyone. Mt Hood National Forest encompasses eight unique Wilderness areas as well as multiple barrier free accessible sites to explore. Whether it's skiing, hiking, boating, rafting, climbing, backpacking, horseback riding, or fishing that you are hoping to experience, you're sure to find great opportunities in your National Forest. Camping in one of our developed campgrounds is a wonderful way to enjoy the forest.", 
                   PhotoUrl = "https://media.istockphoto.com/photos/mount-hood-oregon-picture-id1268487061?k=20&m=1268487061&s=612x612&w=0&h=RJ1ZSwIVtEkQ8GRnOg7jD0iFH9msAjeIW9k7UmnjP1U=" }
      );
    }
  }
}