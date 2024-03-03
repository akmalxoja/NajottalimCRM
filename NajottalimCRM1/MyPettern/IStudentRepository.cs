using NajottalimCRM1.Entities.DTOs;
using NajottalimCRM1.Models;

namespace NajottalimCRM1.MyPettern
{
    public interface IStudentRepository
    {
        public string CreateStudent(StudentDTO studentDTO);

        public IEnumerable<Student> GetAllStudents();

        public IEnumerable<Student> GetById(int id);
        public bool Delete(int id);
        public Student Update(int id, StudentDTO studentdto);


    }
}
