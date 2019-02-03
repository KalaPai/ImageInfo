using ImageInfoStandard.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageInfoStandard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpPost]
        public ActionResult Index(ImageInfo Model)
        {
            ViewBag.Title = "Home Page";

            var client = new RestClient("http://localhost:50509");

            var request = new RestRequest("api/ImageInfo/");

            request.AddParameter("path", Model.Path);

            var response = client.Execute<ImageInfo>(request);          

            return View(response.Data);
        }
    }
}
