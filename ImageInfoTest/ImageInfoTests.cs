using FluentAssertions;
using ImageInfoStandard.Models;
using RestSharp;
using Xunit;

namespace ImageInfoTest
{
    public class ImageInfoTests
    {

        [Fact]
        public void CanGetMainPropertiesOfImage()
        {
            var path = @"https://imgc.allpostersimages.com/img/print/posters/axel-schmies-tower-bridge-across-the-thames-at-night-london-england-uk_a-G-14633706-14258384.jpg";


            var client = new RestClient("http://localhost:50509");

            var request = new RestRequest("api/ImageInfo/");

            request.AddParameter("path", path);

            var response = client.Execute<ImageInfo>(request);

            response.Data.Height.Should().Be(315);
            response.Data.Width.Should().Be(473);
            response.Data.Type.Should().Be("Bitmap");
            response.Data.VerticalResolution.Should().Be(96);
            response.Data.HorizontalResolution.Should().Be(96);
        }
    }
}