using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTest15.Migrations
{
    /// <inheritdoc />
    public partial class sp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var proc2 = @"Create Proc spUpdateStudent
            @Student_Id int,
            @FirstName varchar(20),
            @LastName varchar(20),
            @EmailAddress varchar(30)
          
            as
            Begin
            Update Students SET FirstName=@FirstName,LastName=@LastName,
            EmailAddress=@EmailAddress Where Student_Id=@Student_Id
            End";

            migrationBuilder.Sql(proc2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROC spUpdateStudent");
        }
    }
}
