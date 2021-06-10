using Microsoft.EntityFrameworkCore.Migrations;

namespace RiyadhVoice.Migrations
{
    public partial class imageadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 1,
                column: "ImageURL",
                value: "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Eventid",
                keyValue: 1,
                column: "ImageURL",
                value: "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Wedding-min.jpg");
        }
    }
}
