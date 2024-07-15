using EFCoreTest15.Contracts;
using EFCoreTest15.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreTest15.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly AppDbContext _db;

        public StudentRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<int> AddStudent(Student student)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@FirstName", student.FirstName));
            parameter.Add(new SqlParameter("@LastName", student.LastName));
            parameter.Add(new SqlParameter("@EmailAddress", student.EmailAddress));
          

            var result = await Task.Run(() => _db.Database.ExecuteSqlRawAsync(@"Exec spSaveStudent @FirstName,@LastName,@EmailAddress", parameter.ToArray()));
            return result;
        }

        public async Task<int> DeleteStudent(int id)
        {
            var parameter = new SqlParameter("@Student_Id", id);

            var result = await Task.Run(() => _db.Database.ExecuteSqlRawAsync(@"Exec spDeleteStudent @Student_Id", parameter));
            return result;
        }



        public async Task<List<Student>> GetStudentsAsync()
        {
            var students = await _db.Students.FromSqlRaw("EXEC SpGetStudent").ToListAsync();
            return students;
        }


        public async Task<int> GetStudentByID(int id)
        {

            var paran = new List<SqlParameter>()
            {
                new SqlParameter("@stuID", id)
            };
            var rest = await Task.Run(() => _db.Database.ExecuteSqlRawAsync(@"Exec SpGetStudentById @stuID", paran.ToArray()));
            return rest;
        }

        public async Task<int> UpdateStudent(int id, Student updatedStudent)
        {



            var parameter = new List<SqlParameter>
            {
                new SqlParameter("@Student_Id", id),
                new SqlParameter("@FirstName", updatedStudent.FirstName),
                new SqlParameter("@LastName", updatedStudent.LastName),
                new SqlParameter("@EmailAddress", updatedStudent.EmailAddress)
            };

            var result = await Task.Run(() => _db.Database.ExecuteSqlRawAsync(@"Exec spUpdateStudent @Student_Id, @FirstName, @LastName, @EmailAddress", parameter.ToArray()));
            return result;
        }
    }
}
