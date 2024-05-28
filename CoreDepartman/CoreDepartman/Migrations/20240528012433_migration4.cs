using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departmentid",
                table: "personels");

            migrationBuilder.AlterColumn<int>(
                name: "departmentid",
                table: "personels",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(nullable: true),
                    AdminPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departmentid",
                table: "personels",
                column: "departmentid",
                principalTable: "departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departmentid",
                table: "personels");

            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.AlterColumn<int>(
                name: "departmentid",
                table: "personels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departmentid",
                table: "personels",
                column: "departmentid",
                principalTable: "departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
