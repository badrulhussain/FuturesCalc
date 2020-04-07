using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FuturesCalc.Models;

namespace FuturesCalc.Controllers
{
    public class StandardAndPoorsController : Controller
    {
        private readonly ILogger<StandardAndPoorsController> _logger;

        public StandardAndPoorsController(ILogger<StandardAndPoorsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult MicroEMiniResult(Order order)
        {

            return View(order);
        }

        [HttpGet]
        public IActionResult MicroEMini()
        {

            return View();
        }


        [HttpPost]
        public IActionResult MicroEMini(Order order)
        {
            if(ModelState.IsValid)
            {
                var priceValue = order.ExitPrice - order.EntryPrice;
                order.Tick = priceValue / 0.25M;

                var contractValue = (1.25M * order.Contract);

                order.ProfitAndLose = order.Tick * contractValue;

                return RedirectToAction("MicroEMiniResult", order);
            }
            return View();
        }

        public IActionResult Index()
        {
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
