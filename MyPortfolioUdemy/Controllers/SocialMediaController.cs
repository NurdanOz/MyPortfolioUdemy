using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var SocialMedia = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(SocialMedia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var SocialMedia = context.SocialMedias.Find(id);
            return View(SocialMedia);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia p)
        {
            context.SocialMedias.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia p)
        {
            context.SocialMedias.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
