using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest15.Migrations
{
    /// <inheritdoc />
    public partial class sp3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var procDelete = @"Create Proc spDeleteStudent
            @Student_Id int        
            as
            Begin
            Delete from Students  Where Student_Id=@Student_Id
            End";

            migrationBuilder.Sql(procDelete);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROC spDeleteStudent");
        }
    }
}
