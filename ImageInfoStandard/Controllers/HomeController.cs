using ImageInfoStandard.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
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

            if (IsImageUrl(Model.Path))
            {
                var client = new RestClient("http://localhost:50509");

                var request = new RestRequest("api/ImageInfo/");

                request.AddParameter("path", Model.Path);

                var response = client.Execute<ImageInfo>(request);

                return View(response.Data);
            }
            else
            {
                return View(new ImageInfo { ErrorMessage = "Not Valid Image" });
            }
            
        }

        bool IsImageUrl(string URL)
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(URL);
            req.Method = "HEAD";
            using (var resp = req.GetResponse())
            {
                return resp.ContentType.ToLower(CultureInfo.InvariantCulture)
                           .StartsWith("image/");
            }
        }
    }
}
