using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practica3.Models;

namespace Practica3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            villancicosContext context = new villancicosContext();
            var villancicos = context.Villancico.OrderByDescending(x => x.Anyo);

            return View(villancicos);
        }

        public IActionResult Villancico(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            villancicosContext context = new villancicosContext();
            var villancicos = context.Villancico.FirstOrDefault(x => x.Id == id);

            if (villancicos == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(villancicos);
            }


        }
    }
}
