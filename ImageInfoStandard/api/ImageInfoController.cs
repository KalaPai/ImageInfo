using ImageInfoStandard.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImageInfoStandard
{
    public class ImageInfoController : ApiController
    {
        public ImageInfoController()
        {

        }

        public ImageInfo Get(string path)
        {
            var image = GetImageFromPath(path);

            var result = GetImageInfo(image);

            return result;
        }

        private static Image GetImageFromPath(string path)
        {
            var wc = new WebClient();

            var image = Image.FromStream(wc.OpenRead(path));

            return image;
        }

        private static ImageInfo GetImageInfo(Image image)
        {
            var result = new ImageInfo();

            result.Height = image.Height;
            result.Width = image.Width;
            result.HorizontalResolution = image.HorizontalResolution;
            result.VerticalResolution = image.VerticalResolution;
            result.Type = image.GetType().Name;

            return result;
        }
    }


}