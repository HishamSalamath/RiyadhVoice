// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RiyadhVoice.Model;

namespace RiyadhVoice.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210613120332_ArtistsAdded")]
    partial class ArtistsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RiyadhVoice.Model.ArtistManagement", b =>
                {
                    b.Property<int>("ArtistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("A_CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("A_ImageThumbnailURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("A_IsEventOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("A_LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.HasKey("ArtistID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ArtistID = 1,
                            A_CategoryID = 2,
                            A_ImageThumbnailURL = "https://i.imgur.com/s9MZzSnm.jpg",
                            A_ImageURL = "https://i.imgur.com/s9MZzSn.jpeg",
                            A_IsEventOfTheWeek = false,
                            A_LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                            A_Name = "Band",
                            A_ShortDescription = "This field will be added later"
                        },
                        new
                        {
                            ArtistID = 2,
                            A_CategoryID = 2,
                            A_ImageThumbnailURL = "https://i.imgur.com/QRBIHpim.jpg",
                            A_ImageURL = "https://i.imgur.com/QRBIHpi.jpeg",
                            A_IsEventOfTheWeek = false,
                            A_LongDescription = "We have bunch of talented DJ's outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                            A_Name = "DJ",
                            A_ShortDescription = "This field will be added later"
                        },
                        new
                        {
                            ArtistID = 3,
                            A_CategoryID = 2,
                            A_ImageThumbnailURL = "https://i.imgur.com/uTx7mpOm.jpg",
                            A_ImageURL = "https://i.imgur.com/vVSMrHL.jpeg",
                            A_IsEventOfTheWeek = false,
                            A_LongDescription = "We have bunch of talented solo singers outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                            A_Name = "Solo Singer",
                            A_ShortDescription = "This field will be added later"
                        },
                        new
                        {
                            ArtistID = 4,
                            A_CategoryID = 2,
                            A_ImageThumbnailURL = "https://i.imgur.com/uTx7mpOm.jpg",
                            A_ImageURL = "https://i.imgur.com/uTx7mpO.jpeg",
                            A_IsEventOfTheWeek = false,
                            A_LongDescription = "We have bunch of talented solo singers outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                            A_Name = "duo",
                            A_ShortDescription = "This field will be added later"
                        });
                });

            modelBuilder.Entity("RiyadhVoice.Model.AvailedEventItems", b =>
                {
                    b.Property<int>("EventItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("EventAvailedID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventsEventid")
                        .HasColumnType("int");

                    b.HasKey("EventItemID");

                    b.HasIndex("EventsEventid");

                    b.ToTable("AvailedEvents");
                });

            modelBuilder.Entity("RiyadhVoice.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Events"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Artists Management"
                        });
                });

            modelBuilder.Entity("RiyadhVoice.Model.Events", b =>
                {
                    b.Property<int>("Eventid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEventOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Eventid");

                    b.HasIndex("CategoryID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Eventid = 1,
                            CategoryID = 1,
                            ImageThumbnailURL = "https://i.imgur.com/zoQlZhMm.jpg",
                            ImageURL = "https://i.imgur.com/XXKoMbe.jpeg",
                            IsEventOfTheWeek = true,
                            LongDescription = "you somehow miss out on all the fun moments and celebration factor of your nuptial ceremonies as hosting a wedding is a tough task to do. If you are looking to embark your ceremonies wih glory , we can do this magic by our music",
                            Name = "Marriage",
                            ShortDescription = "Life Changing moment for every Individual"
                        },
                        new
                        {
                            Eventid = 2,
                            CategoryID = 1,
                            ImageThumbnailURL = "https://i.imgur.com/ec3O4Z9m.jpg",
                            ImageURL = "https://tinyurl.com/yjqn7oj6",
                            IsEventOfTheWeek = false,
                            LongDescription = "Coffee shops and Restaurants are meant generally for relxation , spending time with your loved ones! We make the feel even better by our gentle music",
                            Name = "Restaurants/Coffee shops",
                            ShortDescription = "Let your customers sip your coffee surrounded by music in air"
                        },
                        new
                        {
                            Eventid = 3,
                            CategoryID = 1,
                            ImageThumbnailURL = "https://i.imgur.com/Xb2yxJym.jpg",
                            ImageURL = "https://i.imgur.com/m2h1xi9.jpg",
                            IsEventOfTheWeek = false,
                            LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",
                            Name = "Theaters",
                            ShortDescription = "Our Professional music band will make sure no corners of your theatre is left empty"
                        },
                        new
                        {
                            Eventid = 4,
                            CategoryID = 1,
                            ImageThumbnailURL = "https://i.imgur.com/kXCdbCNm.jpg",
                            ImageURL = "https://i.imgur.com/W8RMBWD.jpeg",
                            IsEventOfTheWeek = false,
                            LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",
                            Name = "Concerts",
                            ShortDescription = "Our Professional music band will make sure audience get pumped up and chant loud enough to be heard miles apart"
                        },
                        new
                        {
                            Eventid = 5,
                            CategoryID = 1,
                            ImageThumbnailURL = "https://i.imgur.com/z4UQP7Lm.jpg",
                            ImageURL = "https://tinyurl.com/yzkgrz3m",
                            IsEventOfTheWeek = false,
                            LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",
                            Name = "Musical festivals",
                            ShortDescription = "Let the fest begin with a bang"
                        });
                });

            modelBuilder.Entity("RiyadhVoice.Model.ArtistManagement", b =>
                {
                    b.HasOne("RiyadhVoice.Model.Category", "Category")
                        .WithMany("Artists")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("RiyadhVoice.Model.AvailedEventItems", b =>
                {
                    b.HasOne("RiyadhVoice.Model.Events", "Events")
                        .WithMany()
                        .HasForeignKey("EventsEventid");
                });

            modelBuilder.Entity("RiyadhVoice.Model.Events", b =>
                {
                    b.HasOne("RiyadhVoice.Model.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
