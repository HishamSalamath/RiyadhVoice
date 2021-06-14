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

        public DbSet<AvailedEventItems> AvailedEvents { get; set; }

        public DbSet<ArtistManagement> Artists { get; set; }

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
                ImageURL = "https://i.imgur.com/XXKoMbe.jpeg",
                IsEventOfTheWeek = true,
                ImageThumbnailURL = "https://i.imgur.com/zoQlZhMm.jpg",
                CategoryID = 1,


            }) ;

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 2,
                Name = "Restaurants/Coffee shops",
                ShortDescription = "Let your customers sip your coffee surrounded by music in air",
                LongDescription = "Coffee shops and Restaurants are meant generally for relxation , spending time with your loved ones! We make the feel even better by our gentle music",
                ImageURL = "https://tinyurl.com/yjqn7oj6",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://i.imgur.com/ec3O4Z9m.jpg",
                CategoryID = 1,


            });

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 3,
                Name = "Theaters",
                ShortDescription = "Our Professional music band will make sure no corners of your theatre is left empty",
                LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",
                ImageURL = "https://i.imgur.com/m2h1xi9.jpg",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://i.imgur.com/Xb2yxJym.jpg",
                CategoryID = 1,


            });

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 4,
                Name = "Concerts",
                ShortDescription = "Our Professional music band will make sure audience get pumped up and chant loud enough to be heard miles apart",
                LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",
                ImageURL = "https://i.imgur.com/W8RMBWD.jpeg",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://i.imgur.com/kXCdbCNm.jpg",
                CategoryID = 1,


            });
            modelBuilder.Entity<Events>().HasData(new Events
            {
                Eventid = 5,
                Name = "Musical festivals",
                ShortDescription = "Let the fest begin with a bang",
                LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                ImageURL = "https://tinyurl.com/yzkgrz3m",
                IsEventOfTheWeek = false,
                ImageThumbnailURL = "https://i.imgur.com/z4UQP7Lm.jpg",
                CategoryID = 1,


            });
            modelBuilder.Entity<ArtistManagement>().HasData(new ArtistManagement
            {
                ArtistID = 1,
                A_Name = "Band",
                A_ShortDescription = "This field will be added later",
                A_LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                A_ImageURL = "https://i.imgur.com/s9MZzSn.jpeg",
                A_ImageThumbnailURL = "https://i.imgur.com/s9MZzSnm.jpg",
                A_CategoryID = 2,
            });

            modelBuilder.Entity<ArtistManagement>().HasData(new ArtistManagement
            {
                ArtistID = 2,
                A_Name = "DJ",
                A_ShortDescription = "This field will be added later",
                A_LongDescription = "We have bunch of talented DJ's outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                A_ImageURL = "https://i.imgur.com/8GqMC5R.jpeg",
                A_ImageThumbnailURL = "https://i.imgur.com/8GqMC5Rm.jpg",
                A_CategoryID = 2,
            });

            modelBuilder.Entity<ArtistManagement>().HasData(new ArtistManagement
            {
                ArtistID = 3,
                A_Name = "Solo Singer",
                A_ShortDescription = "This field will be added later",
                A_LongDescription = "We have bunch of talented solo singers outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                A_ImageURL = "https://i.imgur.com/vVSMrHL.jpeg",
                A_ImageThumbnailURL = "https://i.imgur.com/vVSMrHLm.jpg",
                A_CategoryID = 2,
            });

            modelBuilder.Entity<ArtistManagement>().HasData(new ArtistManagement
            {
                ArtistID = 4,
                A_Name = "duo",
                A_ShortDescription = "This field will be added later",
                A_LongDescription = "We have bunch of talented solo singers outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                A_ImageURL = "https://i.imgur.com/mUHmMqa.jpeg",
                A_ImageThumbnailURL = "https://i.imgur.com/mUHmMqam.jpg",
                A_CategoryID = 2,
            });





        }



    }

}
