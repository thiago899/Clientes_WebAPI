using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Client.Models;

namespace WebApplication_Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClientModelCon objClient = new ClientModelCon();
            ViewBag.ListClients = objClient.ListAllClients();


            return View();
        }

        [HttpGet]
        public IActionResult Register(int? id)
        {
            if (id != null)
            {
                ViewBag.Register = new ClientModelCon().ToCharge(id);
            }
  
            return View();
        }

        public IActionResult Delete(int id)
        {
            ViewData["ClienteID"] = id.ToString();
            return View();
        }

        public IActionResult DelCustomer(int id)
        {
            new ClientModelCon().Delete(id);
            return View();
        }

        [HttpPost]
        public IActionResult Register(ClientModelCon dados)
        {
            dados.Insert();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
