
using Microsoft.EntityFrameworkCore.Migrations;

namespace RiyadhVoice.Migrations
{
    public partial class dataAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 1, "Events", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[] { 2, "Artists Management", null });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Eventid", "CategoryID", "ImageThumbnailURL", "ImageURL", "IsEventOfTheWeek", "LongDescription", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Wedding-min.jpg", true, "you somehow miss out on all the fun moments and celebration factor of your nuptial ceremonies as hosting a wedding is a tough task to do. If you are looking to embark your ceremonies wih glory , we can do this magic by our music", "Marriage", "Life Changing moment for every Individual" },
                    { 2, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/coffee-shop-min.jpg", false, "Coffee shops and Restaurants are meant generally for relxation , spending time with your loved ones! We make the feel even better by our gentle music", "Restaurants/Coffee shops", "Let your customers sip your coffee surrounded by music in air" },
                    { 3, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/theatre-min.jpg", false, "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best", "Theaters", "Our Professional music band will make sure no corners of your theatre is left empty" },
                    { 4, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Concerts-min.jpg", false, "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best", "Concerts", "Our Professional music band will make sure audience get pumped up and chant loud enough to be heard miles apart" },
                    { 5, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/sports-event-min.jpg", false, "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best", "Sports Events", "Let the Sport begin with a bang" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);
        }
    }
}
