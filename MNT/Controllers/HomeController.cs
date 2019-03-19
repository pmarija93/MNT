using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MNT.Models;


namespace MNT.Controllers
{
    public class HomeController : Controller
    {

      


        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult About(MNT.Models.ArticleViewModel artkli)
        {
            using (var ctx = new CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext())
            {
                var lista = ctx.Article.Select(a => new ArticleViewModel()
                {
                    ArticleCode = a.ArticleCode,
                    ID = a.Id,
                    ArticleName = a.ArticleName
                    
                   
                }).ToList();



                ViewData["Message"] = "Your application description page.";
                return View(lista);

            }

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MNT.Models.User u)
        {
            using (var ctx = new CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext())
            {

           
                u.UserGroupId = 1;
                ctx.User.Add(u);
                ctx.SaveChanges();
                return View();
            }
        }
        [HttpPost]
        public IActionResult autorizacija(MNT.Models.User k )
        {
            using (CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext db = new CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext())
            {
                var logirani = db.User.Where(x => x.Username == k.Username && x.Password == k.Password).FirstOrDefault();
                if (logirani == null)
                {
                    return View("Contact", k);
                    
                }
                else {
                    

                    return RedirectToAction("about", "Home");
                }
            }
        }
       public IActionResult Azuriraj(int id)
        {
            using (CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext db = new CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext())
            {
                var Artikal = db.Article.Where(a => a.Id == id).FirstOrDefault();
                return View(Artikal);

            }
        }


        [HttpPost]
        public IActionResult Azuriraj(Article article)
        {
            using (CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext db = new CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext())
            {
                try
                {
                    db.Update(article);
                    db.SaveChanges();
                    return RedirectToAction("About", "Home");
                }
                catch (Exception)
                {
                    return View(article);
                    //ovde uhvatit gresku
                }
          
            }
        }



        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
