using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.ViewComponents
{
    public class MajorViewComponents : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;
        public MajorViewComponents(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", majors);
        }
    }
}
