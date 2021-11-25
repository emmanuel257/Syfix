using Microsoft.AspNetCore.Mvc;
using SYFIX.Models;
using System;
using System.Linq;

namespace SYFIX.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        } 
        [HttpGet]
        public ViewResult CustomerForm()
        {

            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CustomerForm(CustomerResponse customerResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponses(customerResponse);
                return View("Thanks", customerResponse);
            }
            else {

                return View();
                
                    }
            
        }

        public ViewResult ListResponses()
        {
            
            return View(Repository.Responses);
        }


       
    }

}
