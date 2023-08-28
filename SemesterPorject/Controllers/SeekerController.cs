using Microsoft.AspNetCore.Mvc;
using SemesterPorject.Data;
using SemesterPorject.Models;

namespace SemesterPorject.Controllers
{
    public class SeekerController : Controller
    {
        public readonly ApplicationDbContext _db;

        public SeekerController(ApplicationDbContext db)
        {
                _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<RentalSpaceModel> RentalSpaceList = _db.RentalSpace;

            ViewBag.DisableFooter = true;
            return View(RentalSpaceList);
        }
        
    }
}
