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
                return View(new MediaFile() { VideoId = "", SourceUrl = new Uri("https://www.youtube.com/") });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult LoadPlayer(string videoid, Uri sourceurl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return View("MediaPlayer", new MediaFile() { VideoId = videoid, SourceUrl = sourceurl });
                }
                return View("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
