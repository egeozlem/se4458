using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passangers_PassangerId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "PassangerId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Passangers_PassangerId",
                table: "Tickets",
                column: "PassangerId",
                principalTable: "Passangers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Passangers_PassangerId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "PassangerId",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Passangers_PassangerId",
                table: "Tickets",
                column: "PassangerId",
                principalTable: "Passangers",
                principalColumn: "Id");
        }
    }
}
