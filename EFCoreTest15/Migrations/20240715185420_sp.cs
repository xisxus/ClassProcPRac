using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest15.Migrations
{
    /// <inheritdoc />
    public partial class sp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var proc1 = @"Create Proc spSaveStudent
            @FirstName varchar(20),
            @LastName varchar(20),
            @EmailAddress varchar(30)
       
            as
            Begin
            Insert into Students(FirstName,LastName,EmailAddress)
            values
            (@FirstName,@LastName,@EmailAddress)
            End ";

            migrationBuilder.Sql(proc1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DRPO PROC spSaveStudent");
        }
    }
}
