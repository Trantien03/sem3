using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using t2210m.Models;

namespace t2210m.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<UserRegisterModel> ls = new List<UserRegisterModel>();
            ls.Add(new UserRegisterModel 
            {
                Id = 1,
                Email = "tien@gmail.com",
                FullName = "Tran van tien",
               Telephone= "0123456778"
            });
            ls.Add(new UserRegisterModel
            {
                Id = 2,
                Email = "trann@gmail.com",
                FullName = "Tran van trann",
                Telephone = "01234566543"
            });
            //ViewData["users"] = ls; // cach1
            //ViewBag.user = ls;        // cach2

            return View(ls);
        }
        public IActionResult Product()
        {
            List<ProductModel> ls = new List<ProductModel>();
            ls.Add(new ProductModel
            {
                Id = 1,
                NameProduct = "ip 7 plus",
                Describe = "trang ti tan",
                Price = "10000",
                Quantity = "10"
            });
            ls.Add(new ProductModel
            {
                Id = 2,
                NameProduct = "ip 7 plus",
                Describe = "trang ti tan",
                Price = "10000",
                Quantity = "10"
            }); 
            ls.Add(new ProductModel
            {
                Id = 3,
                NameProduct = "ip 8 plus",
                Describe = "trang ti tan",
                Price = "10000",
                Quantity = "10"
            });
            ls.Add(new ProductModel
            {
                Id = 4,
                NameProduct = "ip 8 plus",
                Describe = "trang ti tan",
                Price = "10000",
                Quantity = "10"
            });

            //ViewData["users"] = ls; // cach1
            //ViewBag.user = ls;        // cach2

            return View(ls);
        }
    }
}
