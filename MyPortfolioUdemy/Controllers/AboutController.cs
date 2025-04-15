using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();

        public IActionResult AboutIndex()
        {
            var values = context.Abouts.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutIndex(About p)
        {
            context.Abouts.Update(p);
            context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
    }
}
