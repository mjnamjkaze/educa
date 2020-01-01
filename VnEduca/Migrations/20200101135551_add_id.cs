using Microsoft.EntityFrameworkCore.Migrations;

namespace VnEduca.Migrations
{
    public partial class add_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LessionCategoryId",
                table: "Lessions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "Password", "Phone", "UserName" },
                values: new object[] { 1, "mjnamjkaze@gmail.com", "12345", null, "namvh" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Email", "Password", "Phone", "UserName" },
                values: new object[] { 2, "vo.hai.nam@gosei.com.vn", "12345", null, "admin" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate" },
                values: new object[] { 1, "Lập trình C#", null, null, "Dạy bạn lập trình c#", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Lessions_LessionCategoryId",
                table: "Lessions",
                column: "LessionCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessions_LessionCategorys_LessionCategoryId",
                table: "Lessions",
                column: "LessionCategoryId",
                principalTable: "LessionCategorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessions_LessionCategorys_LessionCategoryId",
                table: "Lessions");

            migrationBuilder.DropIndex(
                name: "IX_Lessions_LessionCategoryId",
                table: "Lessions");

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "LessionCategoryId",
                table: "Lessions");
        }
    }
}
