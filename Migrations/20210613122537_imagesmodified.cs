using Microsoft.EntityFrameworkCore.Migrations;

namespace RiyadhVoice.Migrations
{
    public partial class imagesmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 2,
                columns: new[] { "A_ImageThumbnailURL", "A_ImageURL" },
                values: new object[] { "https://i.imgur.com/8GqMC5Rm.jpg", "https://i.imgur.com/8GqMC5R.jpeg" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 3,
                column: "A_ImageThumbnailURL",
                value: "https://i.imgur.com/vVSMrHLm.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 4,
                columns: new[] { "A_ImageThumbnailURL", "A_ImageURL" },
                values: new object[] { "https://i.imgur.com/mUHmMqam.jpg", "https://i.imgur.com/mUHmMqa.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 2,
                columns: new[] { "A_ImageThumbnailURL", "A_ImageURL" },
                values: new object[] { "https://i.imgur.com/QRBIHpim.jpg", "https://i.imgur.com/QRBIHpi.jpeg" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 3,
                column: "A_ImageThumbnailURL",
                value: "https://i.imgur.com/uTx7mpOm.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ArtistID",
                keyValue: 4,
                columns: new[] { "A_ImageThumbnailURL", "A_ImageURL" },
                values: new object[] { "https://i.imgur.com/uTx7mpOm.jpg", "https://i.imgur.com/uTx7mpO.jpeg" });
        }
    }
}
