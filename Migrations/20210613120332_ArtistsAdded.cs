using Microsoft.EntityFrameworkCore.Migrations;

namespace RiyadhVoice.Migrations
{
    public partial class ArtistsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_Name = table.Column<string>(nullable: true),
                    A_ShortDescription = table.Column<string>(nullable: true),
                    A_LongDescription = table.Column<string>(nullable: true),
                    A_ImageURL = table.Column<string>(nullable: true),
                    A_ImageThumbnailURL = table.Column<string>(nullable: true),
                    A_IsEventOfTheWeek = table.Column<bool>(nullable: false),
                    A_CategoryID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistID);
                    table.ForeignKey(
                        name: "FK_Artists_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistID", "A_CategoryID", "A_ImageThumbnailURL", "A_ImageURL", "A_IsEventOfTheWeek", "A_LongDescription", "A_Name", "A_ShortDescription", "CategoryID" },
                values: new object[,]
                {
                    { 1, 2, "https://i.imgur.com/s9MZzSnm.jpg", "https://i.imgur.com/s9MZzSn.jpeg", false, "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best", "Band", "This field will be added later", null },
                    { 2, 2, "https://i.imgur.com/QRBIHpim.jpg", "https://i.imgur.com/QRBIHpi.jpeg", false, "We have bunch of talented DJ's outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best", "DJ", "This field will be added later", null },
                    { 3, 2, "https://i.imgur.com/uTx7mpOm.jpg", "https://i.imgur.com/vVSMrHL.jpeg", false, "We have bunch of talented solo singers outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best", "Solo Singer", "This field will be added later", null },
                    { 4, 2, "https://i.imgur.com/uTx7mpOm.jpg", "https://i.imgur.com/uTx7mpO.jpeg", false, "We have bunch of talented solo singers outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best", "duo", "This field will be added later", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_CategoryID",
                table: "Artists",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
