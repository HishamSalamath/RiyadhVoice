using Microsoft.EntityFrameworkCore.Migrations;

namespace RiyadhVoice.Migrations
{
    public partial class eventcartAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailedEvents",
                columns: table => new
                {
                    EventItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventsEventid = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    EventAvailedID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailedEvents", x => x.EventItemID);
                    table.ForeignKey(
                        name: "FK_AvailedEvents_Events_EventsEventid",
                        column: x => x.EventsEventid,
                        principalTable: "Events",
                        principalColumn: "Eventid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailedEvents_EventsEventid",
                table: "AvailedEvents",
                column: "EventsEventid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailedEvents");
        }
    }
}
