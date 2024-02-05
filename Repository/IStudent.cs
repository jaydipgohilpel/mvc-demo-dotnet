using mvc_demo.Models;

namespace mvc_demo.Repository
{
    public interface IStudent
    {
        List<StudentModel2> GetAllStudents();
        StudentModel2 GetStudentById(int id);
    }
}
