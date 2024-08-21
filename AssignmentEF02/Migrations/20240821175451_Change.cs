using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentEF02.Migrations
{
    /// <inheritdoc />
    public partial class Change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Courses_Top_ID",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_Top_ID",
                table: "Topic");

            migrationBuilder.AlterColumn<int>(
                name: "Top_ID",
                table: "Topic",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentsId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_Top_ID",
                table: "Topic",
                column: "Top_ID",
                unique: true,
                filter: "[Top_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Courses_Top_ID",
                table: "Topic",
                column: "Top_ID",
                principalTable: "Courses",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Courses_Top_ID",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_Top_ID",
                table: "Topic");

            migrationBuilder.AlterColumn<int>(
                name: "Top_ID",
                table: "Topic",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentsId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topic_Top_ID",
                table: "Topic",
                column: "Top_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Courses_Top_ID",
                table: "Topic",
                column: "Top_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
