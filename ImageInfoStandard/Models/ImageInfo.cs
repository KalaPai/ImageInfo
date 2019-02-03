using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageInfoStandard.Models
{
    public class ImageInfo
    {
        public string Path{ get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public float VerticalResolution { get; set; }
        public float HorizontalResolution { get; set; }
        public string Type { get; set; }
        public string ErrorMessage { get; set; }
    }
}