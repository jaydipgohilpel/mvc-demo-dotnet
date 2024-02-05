using mvc_demo.Models;

namespace mvc_demo.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel2> GetAllStudents()
        {
            return Datasourese();
        }

        public StudentModel2 GetStudentById(int id)
        {
            return Datasourese().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel2> Datasourese()
        {
            return new List<StudentModel2>
            {
                new StudentModel2{rollNo=50,name="jkrrt",gender="M",standard=12},
                new StudentModel2{rollNo=52,name="fgnh",gender="M",standard=12},
                new StudentModel2{rollNo=53,name="44tt",gender="M",standard=12},
                new StudentModel2{rollNo=54,name="sjyrjrjrj",gender="M",standard=12},
                new StudentModel2{rollNo=50,name="jkrrt",gender="M",standard=12},
                new StudentModel2{rollNo=52,name="fgnh",gender="M",standard=12},
                new StudentModel2{rollNo=53,name="44tt",gender="M",standard=12},
                new StudentModel2{rollNo=54,name="sjyrjrjrj",gender="M",standard=12},
            };
        }
    }
}
