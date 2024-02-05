using Microsoft.AspNetCore.Mvc;
using mvc_demo.Models;
using mvc_demo.Repository;
using System.Diagnostics;

namespace mvc_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel2> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public StudentModel2 GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public IActionResult Index()
        {

            /*           var students = new List<StudentModel>
                        {
                            new StudentModel{rollNo=50,name="asdfasdfasdf",gender="M",standard=12},
                            new StudentModel{rollNo=52,name="asdfasdfasdf",gender="M",standard=12},
                            new StudentModel{rollNo=53,name="asdfasdfasdf",gender="M",standard=12},
                            new StudentModel{rollNo=54,name="asdfasdfasdf",gender="M",standard=12},
                        };
                        ViewData["students"]=students;*/

            EmployeeModel emp = new EmployeeModel()
            {
                EmpId = 101,
                EmpName = "sbndsjsd",
                Designation = "developer",
                Salary = 200000000

            };

            ViewData["myemp1"] = emp;
            ViewBag.myemp2 = emp;

            var myEmployees = new List<EmployeeModel>
            {
                new EmployeeModel{EmpId=101,EmpName="asdfasdfasdf",Designation="developer",Salary=200000000},
                new EmployeeModel{EmpId=102,EmpName="asdfasdfasdf",Designation="developer",Salary=300000000},
                new EmployeeModel{EmpId=103,EmpName="asdfasdfasdf",Designation="developer",Salary=400000000},
                new EmployeeModel{EmpId=104,EmpName="asdfasdfasdf",Designation="developer",Salary=500000000},
                new EmployeeModel{EmpId=105,EmpName="asdfasdfasdf",Designation="developer",Salary=300000000},
                new EmployeeModel{EmpId=105,EmpName="asdfasdfasdf",Designation="developer",Salary=300000000},
                new EmployeeModel{EmpId=106,EmpName="asdfasdfasdf",Designation="developer",Salary=400000000},
                new EmployeeModel{EmpId=107,EmpName="asdfasdfasdf",Designation="developer",Salary=500000000},
            };

            ViewData["emp3array"] = myEmployees;
            ViewBag.emp3array2 = myEmployees;
            return View(emp);
        }

        public string GetDetails(int id,string name)
        {
            return "Id is:" + id + " ,Name: " + name;
        }

        [HttpPost]
        public string Index(EmployeeModel e)
        {
            return "Id is:" + e.EmpId + " ,Name: " + e.EmpName + " ,designation " + e.Designation + " ,salary: " + e.Salary;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
