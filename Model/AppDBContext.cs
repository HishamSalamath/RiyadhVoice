using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RiyadhVoice.Model
{
    public class AppDBContext : DbContext

    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Events> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 1, CategoryName = "Events" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 2, CategoryName = "Artists Management" });

            //seed pies

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 1,
                Name = "Marriage",
                ShortDescription = "Life Changing moment for every Individual",
                LongDescription = "you somehow miss out on all the fun moments and celebration factor of your nuptial ceremonies as hosting a wedding is a tough task to do. If you are looking to embark your ceremonies wih glory , we can do this magic by our music",
                ImageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                //ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Wedding-min.jpg",
                IsEventOfTheWeek = true,
                ImageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                CategoryID = 1,


            }) ;

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 2,
                Name = "Restaurants/Coffee shops",
                ShortDescription = "Let your customers sip your coffee surrounded by music in air",
                LongDescription = "Coffee shops and Restaurants are meant generally for relxation , spending time with your loved ones! We make the feel even better by our gentle music",
                ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/coffee-shop-min.jpg",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                CategoryID = 1,


            });

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 3,
                Name = "Theaters",
                ShortDescription = "Our Professional music band will make sure no corners of your theatre is left empty",
                LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",
                ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/theatre-min.jpg",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                CategoryID = 1,


            });

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 4,
                Name = "Concerts",
                ShortDescription = "Our Professional music band will make sure audience get pumped up and chant loud enough to be heard miles apart",
                LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",
                ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Concerts-min.jpg",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                CategoryID = 1,


            });
            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 5,
                Name = "Sports Events",
                ShortDescription = "Let the Sport begin with a bang",
                LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/sports-event-min.jpg",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                CategoryID = 1,


            });
        }



    }

}
