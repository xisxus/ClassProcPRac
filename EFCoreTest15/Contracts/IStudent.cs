using EFCoreTest15.Models;

namespace EFCoreTest15.Contracts
{
    public interface IStudent
    {
        public Task<List<Student>> GetStudentsAsync();
        public Task<int> GetStudentByID(int id);
        public Task<int> AddStudent(Student student);
        public Task<int> UpdateStudent(int id, Student updatedStudent);
       public Task<int> DeleteStudent(int id);


    }
}
