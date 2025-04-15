using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        [HttpGet]
        public IActionResult FeatureIndex()
        {
            var values = context.Features.FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult FeatureIndex(Feature p)
        {
            context.Features.Update(p);
            context.SaveChanges();
            return RedirectToAction("FeatureIndex");
        }
    }
}
