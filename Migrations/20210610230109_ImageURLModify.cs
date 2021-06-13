using Microsoft.EntityFrameworkCore.Migrations;

namespace RiyadhVoice.Migrations
{
    public partial class ImageURLModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 1,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://i.imgur.com/zoQlZhMm.jpg", "https://i.imgur.com/XXKoMbe.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 2,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://i.imgur.com/ec3O4Z9m.jpg", "https://tinyurl.com/yjqn7oj6" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 3,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://i.imgur.com/Xb2yxJym.jpg", "https://i.imgur.com/m2h1xi9.jpg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 4,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://i.imgur.com/kXCdbCNm.jpg", "https://i.imgur.com/W8RMBWD.jpeg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 5,
                columns: new[] { "ImageThumbnailURL", "ImageURL", "Name", "ShortDescription" },
                values: new object[] { "https://i.imgur.com/z4UQP7Lm.jpg", "https://tinyurl.com/yzkgrz3m", "Musical festivals", "Let the fest begin with a bang" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 1,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 2,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/coffee-shop-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 3,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/theatre-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 4,
                columns: new[] { "ImageThumbnailURL", "ImageURL" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Concerts-min.jpg" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 5,
                columns: new[] { "ImageThumbnailURL", "ImageURL", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/sports-event-min.jpg", "Sports Events", "Let the Sport begin with a bang" });
        }
    }
}
