using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpawnAreaWebCore.Models;

namespace SpawnAreaWebCore.Controllers
{
    public class MediaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception e)
            {
                return View("Error",e);
            }
        }

        [HttpPost]
        public IActionResult LoadPlayer()
        {
            try
            {               
                return View("MediaPlayer");
                
            }
            catch (Exception e)
            {
                return View("Error", e);
            }
        }
    }
}
