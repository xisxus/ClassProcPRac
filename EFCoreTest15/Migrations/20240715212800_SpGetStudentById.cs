using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest15.Migrations
{
    /// <inheritdoc />
    public partial class SpGetStudentById : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create proc SpGetStudentById @stuID int as begin select * from student where Student_Id = @stuID end ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROC SpGetStudentById");
        }
    }
}
