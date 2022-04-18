using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_2.Migrations
{
    public partial class InverseProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    CurrentRoomId = table.Column<int>(type: "int", nullable: false),
                    PreviousRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Section = table.Column<int>(type: "int", nullable: false),
                    CurrentClientId = table.Column<int>(type: "int", nullable: false),
                    PreviousClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomNumber);
                    table.ForeignKey(
                        name: "FK_Room_Client_CurrentClientId",
                        column: x => x.CurrentClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Room_Client_PreviousClientId",
                        column: x => x.PreviousClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Room_CurrentClientId",
                table: "Room",
                column: "CurrentClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Room_PreviousClientId",
                table: "Room",
                column: "PreviousClientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
