using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            //Tạo danh sách sinh viên với 4 dữ liệu mẫu
            listStudents = new List<Student>()
{
new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT,
Gender = Gender.Male, IsRegular=true,
Address = "A1-2018", Email = "nam@g.com" },

new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
Gender = Gender.Female, IsRegular=true,
Address = "A1-2019", Email = "tu@g.com" },

new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
Gender = Gender.Male, IsRegular=false,
Address = "A1-2020", Email = "phong@g.com" },

new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
Gender = Gender.Female, IsRegular = false,
Address = "A1-2021", Email = "mai@g.com" }

};
        }
        public IActionResult Index()
        {
            //Trả về View Index.cshtml cùng Model là danh sách sv listStudents
            return View(listStudents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //lấy danh sách các giá trị Gender để hiển thị radio button trên form
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            //lấy danh sách các giá trị Branch để hiển thị select-option trên form
            //Để hiển thị select-option trên View cần dùng List<SelectListItem>
            ViewBag.AllBranches = new List<SelectListItem>()
{
new SelectListItem { Text = "IT", Value = "1" },
new SelectListItem { Text = "BE", Value = "2" },
new SelectListItem { Text = "CE", Value = "3" },
new SelectListItem { Text = "EE", Value = "4" }
};
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = listStudents.Last<Student>().Id + 1;
                listStudents.Add(s);
                return View("Index", listStudents);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
{
new SelectListItem { Text = "IT", Value = "1" },
new SelectListItem { Text = "BE", Value = "2" },
new SelectListItem { Text = "CE", Value = "3" },
new SelectListItem { Text = "EE", Value = "4" }
};
            return View();
        }
    }
}
