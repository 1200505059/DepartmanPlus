using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentid",
                table: "personels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_departmentid",
                table: "personels",
                column: "departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departmentid",
                table: "personels",
                column: "departmentid",
                principalTable: "departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departmentid",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_departmentid",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "departmentid",
                table: "personels");
        }
    }
}
