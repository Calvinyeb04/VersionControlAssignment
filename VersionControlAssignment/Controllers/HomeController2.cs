using Microsoft.AspNetCore.Mvc;

namespace VersionControlAssignment.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            var data = new { Name = "Calvin Yeboah" };
            return Json(data);
        }
    }
}
