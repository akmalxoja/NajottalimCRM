using NajottalimCRM1.Entities.DTOs;
using NajottalimCRM1.Models;
using Npgsql;
using Dapper;

namespace NajottalimCRM1.MyPettern
{
    public class StudentRepository : IStudentRepository
    {
        public IConfiguration _configuration;
        public StudentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateStudent(StudentDTO studentDTO)
        {
            try
            {
                using (var connention = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection"))) 
                {
                    string query = "insert into students(full_name,age,course_id,perent_phone) values(@full_name, @age, @course_id, @perent_phone)";

                    StudentDTO paraments = new StudentDTO
                    {
                        full_name = studentDTO.full_name,
                        age = studentDTO.age,
                        course_id = studentDTO.course_id,
                        perent_phone = studentDTO.perent_phone
                        
                    };
                   connention.Execute(query, paraments);


                }
                return "Malumot yaratildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {

            using (var connention = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = "select *from students";

                var result = connention.Query<Student>(query);

                return result;

            }
        
        }    

        public IEnumerable<Student> GetById(int id)
        {
            using (var conenection = new NpgsqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string query = $"select *from students where id = {id}";
                var result = conenection.Query<Student>(query);
                return result;

            }

        }

        public Student Update(int id, StudentDTO studentdto)
        {
            throw new NotImplementedException();
        }
    }
}
