using AspNetMvc4ScopedDependencyResolver.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc4ScopedDependencyResolver.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IProductService service, IOrderService orderService)
        {
            this.productService = service;
            this.orderService = orderService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        private readonly IProductService productService;
        private readonly IOrderService orderService;
    }
}
