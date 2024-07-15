using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest15.Migrations
{
    /// <inheritdoc />
    public partial class SpGetStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create Proc SpGetStudent
                    
             as
            Begin
            Select * from Students  
            End;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROC SpGetStudent");
        }
    }
}
