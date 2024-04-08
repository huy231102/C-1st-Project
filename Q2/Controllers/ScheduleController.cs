using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        private PePrnFall2023B1Context _context = new PePrnFall2023B1Context();

        public ScheduleController()
        {

        }

        public IActionResult List(String dateTime)
        {
            DateTime date = DateTime.Now;

            if (dateTime!=null)
            {
                date = DateTime.Parse(dateTime);
            }

            List<Schedule> schedules = _context.Schedules
                .Include(x => x.Room).Include(x => x.TimeSlot).Include(x => x.Movie)
                .Where(x => x.StartDate <= date && x.EndDate >= date).ToList();

            ViewBag.Schedules = schedules;
            ViewBag.Date = date;

            return View();
        }
    }
}
