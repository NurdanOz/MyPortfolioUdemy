using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ContactIndex()
        {
            var values = context.Contacts.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult ContactIndex(Contact p)
        {
            context.Contacts.Update(p);
            context.SaveChanges();
            return RedirectToAction("ContactIndex");
        }
    }
}
