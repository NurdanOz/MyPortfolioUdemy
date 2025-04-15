using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
        public IActionResult DeletePortfolio(int id)
        {
            var values = context.Portfolios.Find(id);
            context.Portfolios.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = context.Portfolios.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio p)
        {
            context.Portfolios.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio p)
        {
            context.Portfolios.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
