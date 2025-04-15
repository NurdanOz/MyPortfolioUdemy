using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var Testimonial = context.Testimonials.Find(id);
            context.Testimonials.Remove(Testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var Testimonial = context.Testimonials.Find(id);
            return View(Testimonial);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial p)
        {
            context.Testimonials.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial p)
        {
            context.Testimonials.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
