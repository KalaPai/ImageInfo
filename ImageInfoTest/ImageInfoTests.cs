using FluentAssertions;
using ImageInfoStandard;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using Xunit;
using RestSharp;
using ImageInfoStandard.Models;

namespace ImageInfoTest
{
    public class ImageInfoTests
    {
        public Dictionary<int, string> GetMap()
        {
            var map = new Dictionary<int, string>();
            map.Add(0, "PropertyTagGpsVer");
            map.Add(1, "PropertyTagGpsLatitudeRef");
            map.Add(2, "PropertyTagGpsLatitude");
            map.Add(3, "PropertyTagGpsLongitudeRef");
            map.Add(4, "PropertyTagGpsLongitude");
            map.Add(5, "PropertyTagGpsAltitudeRef");
            map.Add(6, "PropertyTagGpsAltitude");
            map.Add(7, "PropertyTagGpsGpsTime");
            map.Add(8, "PropertyTagGpsGpsSatellites");
            map.Add(9, "PropertyTagGpsGpsStatus");
            map.Add(10, "PropertyTagGpsGpsMeasureMode");
            map.Add(11, "PropertyTagGpsGpsDop");
            map.Add(12, "PropertyTagGpsSpeedRef");
            map.Add(13, "PropertyTagGpsSpeed");
            map.Add(14, "PropertyTagGpsTrackRef");
            map.Add(15, "PropertyTagGpsTrack");
            map.Add(16, "PropertyTagGpsImgDirRef");
            map.Add(17, "PropertyTagGpsImgDir");
            map.Add(18, "PropertyTagGpsMapDatum");
            map.Add(19, "PropertyTagGpsDestLatRef");
            map.Add(20, "PropertyTagGpsDestLat");
            map.Add(21, "PropertyTagGpsDestLongRef");
            map.Add(22, "PropertyTagGpsDestLong");
            map.Add(23, "PropertyTagGpsDestBearRef");
            map.Add(24, "PropertyTagGpsDestBear");
            map.Add(25, "PropertyTagGpsDestDistRef");
            map.Add(26, "PropertyTagGpsDestDist");
            map.Add(254, "PropertyTagNewSubfileType");
            map.Add(255, "PropertyTagSubfileType");
            map.Add(256, "PropertyTagImageWidth");
            map.Add(257, "PropertyTagImageHeight");
            map.Add(258, "PropertyTagBitsPerSample");
            map.Add(259, "PropertyTagCompression");
            map.Add(262, "PropertyTagPhotometricInterp");
            map.Add(263, "PropertyTagThreshHolding");
            map.Add(264, "PropertyTagCellWidth");
            map.Add(265, "PropertyTagCellHeight");
            map.Add(266, "PropertyTagFillOrder");
            map.Add(269, "PropertyTagDocumentName");
            map.Add(270, "PropertyTagImageDescription");
            map.Add(271, "PropertyTagEquipMake");
            map.Add(272, "PropertyTagEquipModel");
            map.Add(273, "PropertyTagStripOffsets");
            map.Add(274, "PropertyTagOrientation");
            map.Add(277, "PropertyTagSamplesPerPixel");
            map.Add(278, "PropertyTagRowsPerStrip");
            map.Add(279, "PropertyTagStripBytesCount");
            map.Add(280, "PropertyTagMinSampleValue");
            map.Add(281, "PropertyTagMaxSampleValue");
            map.Add(282, "PropertyTagXResolution");
            map.Add(283, "PropertyTagYResolution");
            map.Add(284, "PropertyTagPlanarConfig");
            map.Add(285, "PropertyTagPageName");
            map.Add(286, "PropertyTagXPosition");
            map.Add(287, "PropertyTagYPosition");
            map.Add(288, "PropertyTagFreeOffset");
            map.Add(289, "PropertyTagFreeByteCounts");
            map.Add(290, "PropertyTagGrayResponseUnit");
            map.Add(291, "PropertyTagGrayResponseCurve");
            map.Add(292, "PropertyTagT4Option");
            map.Add(293, "PropertyTagT6Option");
            map.Add(296, "PropertyTagResolutionUnit");
            map.Add(297, "PropertyTagPageNumber");
            map.Add(301, "PropertyTagTransferFunction");
            map.Add(305, "PropertyTagSoftwareUsed");
            map.Add(306, "PropertyTagDateTime");
            map.Add(315, "PropertyTagArtist");
            map.Add(316, "PropertyTagHostComputer");
            map.Add(317, "PropertyTagPredictor");
            map.Add(318, "PropertyTagWhitePoint");
            map.Add(319, "PropertyTagPrimaryChromaticities");
            map.Add(320, "PropertyTagColorMap");
            map.Add(321, "PropertyTagHalftoneHints");
            map.Add(322, "PropertyTagTileWidth");
            map.Add(323, "PropertyTagTileLength");
            map.Add(324, "PropertyTagTileOffset");
            map.Add(325, "PropertyTagTileByteCounts");
            map.Add(332, "PropertyTagInkSet");
            map.Add(333, "PropertyTagInkNames");
            map.Add(334, "PropertyTagNumberOfInks");
            map.Add(336, "PropertyTagDotRange");
            map.Add(337, "PropertyTagTargetPrinter");
            map.Add(338, "PropertyTagExtraSamples");
            map.Add(339, "PropertyTagSampleFormat");
            map.Add(340, "PropertyTagSMinSampleValue");
            map.Add(341, "PropertyTagSMaxSampleValue");
            map.Add(342, "PropertyTagTransferRange");
            map.Add(512, "PropertyTagJPEGProc");
            map.Add(513, "PropertyTagJPEGInterFormat");
            map.Add(514, "PropertyTagJPEGInterLength");
            map.Add(515, "PropertyTagJPEGRestartInterval");
            map.Add(517, "PropertyTagJPEGLosslessPredictors");
            map.Add(518, "PropertyTagJPEGPointTransforms");
            map.Add(519, "PropertyTagJPEGQTables");
            map.Add(520, "PropertyTagJPEGDCTables");
            map.Add(521, "PropertyTagJPEGACTables");
            map.Add(529, "PropertyTagYCbCrCoefficients");
            map.Add(530, "PropertyTagYCbCrSubsampling");
            map.Add(531, "PropertyTagYCbCrPositioning");
            map.Add(532, "PropertyTagREFBlackWhite");
            map.Add(769, "PropertyTagGamma");
            map.Add(770, "PropertyTagICCProfileDescriptor");
            map.Add(771, "PropertyTagSRGBRenderingIntent");
            map.Add(800, "PropertyTagImageTitle");
            map.Add(20481, "PropertyTagResolutionXUnit");
            map.Add(20482, "PropertyTagResolutionYUnit");
            map.Add(20483, "PropertyTagResolutionXLengthUnit");
            map.Add(20484, "PropertyTagResolutionYLengthUnit");
            map.Add(20485, "PropertyTagPrintFlags");
            map.Add(20486, "PropertyTagPrintFlagsVersion");
            map.Add(20487, "PropertyTagPrintFlagsCrop");
            map.Add(20488, "PropertyTagPrintFlagsBleedWidth");
            map.Add(20489, "PropertyTagPrintFlagsBleedWidthScale");
            map.Add(20490, "PropertyTagHalftoneLPI");
            map.Add(20491, "PropertyTagHalftoneLPIUnit");
            map.Add(20492, "PropertyTagHalftoneDegree");
            map.Add(20493, "PropertyTagHalftoneShape");
            map.Add(20494, "PropertyTagHalftoneMisc");
            map.Add(20495, "PropertyTagHalftoneScreen");
            map.Add(20496, "PropertyTagJPEGQuality");
            map.Add(20497, "PropertyTagGridSize");
            map.Add(20498, "PropertyTagThumbnailFormat");
            map.Add(20499, "PropertyTagThumbnailWidth");
            map.Add(20500, "PropertyTagThumbnailHeight");
            map.Add(20501, "PropertyTagThumbnailColorDepth");
            map.Add(20502, "PropertyTagThumbnailPlanes");
            map.Add(20503, "PropertyTagThumbnailRawBytes");
            map.Add(20504, "PropertyTagThumbnailSize");
            map.Add(20505, "PropertyTagThumbnailCompressedSize");
            map.Add(20506, "PropertyTagColorTransferFunction");
            map.Add(20507, "PropertyTagThumbnailData");
            map.Add(20512, "PropertyTagThumbnailImageWidth");
            map.Add(20513, "PropertyTagThumbnailImageHeight");
            map.Add(20514, "PropertyTagThumbnailBitsPerSample");
            map.Add(20515, "PropertyTagThumbnailCompression");
            map.Add(20516, "PropertyTagThumbnailPhotometricInterp");
            map.Add(20517, "PropertyTagThumbnailImageDescription");
            map.Add(20518, "PropertyTagThumbnailEquipMake");
            map.Add(20519, "PropertyTagThumbnailEquipModel");
            map.Add(20520, "PropertyTagThumbnailStripOffsets");
            map.Add(20521, "PropertyTagThumbnailOrientation");
            map.Add(20522, "PropertyTagThumbnailSamplesPerPixel");
            map.Add(20523, "PropertyTagThumbnailRowsPerStrip");
            map.Add(20524, "PropertyTagThumbnailStripBytesCount");
            map.Add(20525, "PropertyTagThumbnailResolutionX");
            map.Add(20526, "PropertyTagThumbnailResolutionY");
            map.Add(20527, "PropertyTagThumbnailPlanarConfig");
            map.Add(20528, "PropertyTagThumbnailResolutionUnit");
            map.Add(20529, "PropertyTagThumbnailTransferFunction");
            map.Add(20530, "PropertyTagThumbnailSoftwareUsed");
            map.Add(20531, "PropertyTagThumbnailDateTime");
            map.Add(20532, "PropertyTagThumbnailArtist");
            map.Add(20533, "PropertyTagThumbnailWhitePoint");
            map.Add(20534, "PropertyTagThumbnailPrimaryChromaticities");
            map.Add(20535, "PropertyTagThumbnailYCbCrCoefficients");
            map.Add(20536, "PropertyTagThumbnailYCbCrSubsampling");
            map.Add(20537, "PropertyTagThumbnailYCbCrPositioning");
            map.Add(20538, "PropertyTagThumbnailRefBlackWhite");
            map.Add(20539, "PropertyTagThumbnailCopyRight");
            map.Add(20624, "PropertyTagLuminanceTable");
            map.Add(20625, "PropertyTagChrominanceTable");
            map.Add(20736, "PropertyTagFrameDelay");
            map.Add(20737, "PropertyTagLoopCount");
            map.Add(20738, "PropertyTagGlobalPalette");
            map.Add(20739, "PropertyTagIndexBackground");
            map.Add(20740, "PropertyTagIndexTransparent");
            map.Add(20752, "PropertyTagPixelUnit");
            map.Add(20753, "PropertyTagPixelPerUnitX");
            map.Add(20754, "PropertyTagPixelPerUnitY");
            map.Add(20755, "PropertyTagPaletteHistogram");
            map.Add(33432, "PropertyTagCopyright");
            map.Add(33434, "PropertyTagExifExposureTime");
            map.Add(33437, "PropertyTagExifFNumber");
            map.Add(34665, "PropertyTagExifIFD");
            map.Add(34675, "PropertyTagICCProfile");
            map.Add(34850, "PropertyTagExifExposureProg");
            map.Add(34852, "PropertyTagExifSpectralSense");
            map.Add(34853, "PropertyTagGpsIFD");
            map.Add(34855, "PropertyTagExifISOSpeed");
            map.Add(34856, "PropertyTagExifOECF");
            map.Add(36864, "PropertyTagExifVer");
            map.Add(36867, "PropertyTagExifDTOrig");
            map.Add(36868, "PropertyTagExifDTDigitized");
            map.Add(37121, "PropertyTagExifCompConfig");
            map.Add(37122, "PropertyTagExifCompBPP");
            map.Add(37377, "PropertyTagExifShutterSpeed");
            map.Add(37378, "PropertyTagExifAperture");
            map.Add(37379, "PropertyTagExifBrightness");
            map.Add(37380, "PropertyTagExifExposureBias");
            map.Add(37381, "PropertyTagExifMaxAperture");
            map.Add(37382, "PropertyTagExifSubjectDist");
            map.Add(37383, "PropertyTagExifMeteringMode");
            map.Add(37384, "PropertyTagExifLightSource");
            map.Add(37385, "PropertyTagExifFlash");
            map.Add(37386, "PropertyTagExifFocalLength");
            map.Add(37500, "PropertyTagExifMakerNote");
            map.Add(37510, "PropertyTagExifUserComment");
            map.Add(37520, "PropertyTagExifDTSubsec");
            map.Add(37521, "PropertyTagExifDTOrigSS");
            map.Add(37522, "PropertyTagExifDTDigSS");
            map.Add(40960, "PropertyTagExifFPXVer");
            map.Add(40961, "PropertyTagExifColorSpace");
            map.Add(40962, "PropertyTagExifPixXDim");
            map.Add(40963, "PropertyTagExifPixYDim");
            map.Add(40964, "PropertyTagExifRelatedWav");
            map.Add(40965, "PropertyTagExifInterop");
            map.Add(41483, "PropertyTagExifFlashEnergy");
            map.Add(41484, "PropertyTagExifSpatialFR");
            map.Add(41486, "PropertyTagExifFocalXRes");
            map.Add(41487, "PropertyTagExifFocalYRes");
            map.Add(41488, "PropertyTagExifFocalResUnit");
            map.Add(41492, "PropertyTagExifSubjectLoc");
            map.Add(41493, "PropertyTagExifExposureIndex");
            map.Add(41495, "PropertyTagExifSensingMethod");
            map.Add(41728, "PropertyTagExifFileSource");
            map.Add(41729, "PropertyTagExifSceneType");
            map.Add(41730, "PropertyTagExifCfaPattern");

            return map;
        }
        [Fact]
        public void CanGetImageProperties()
        {
            var path1 = @"C:\Users\bimal\Desktop\LondonBridge.jpg";
            var path2 = @"C:\Users\bimal\Desktop\IMG1452.JPG";


            var map = GetMap();

            Image image = Image.FromFile(path1);
            Image image2 = Image.FromFile(path2);

            var propList = image.PropertyIdList;

            //var userCommentCode = 0x9286;
            //var documentNameCode = 0x010D;
            //int imageWidthCode = 0x0100;

            var resolutionXCode = 0x011A;
            var resolutionYCode = 0x011B;

            var propertyIdList = image2.PropertyIdList;
            var propertyIdListHex = new Dictionary<string, byte[]>();

            foreach (var property in propertyIdList)
            {
                var value = image2.GetPropertyItem(property).Value;

                if (map.ContainsKey(property))
                {
                    propertyIdListHex.Add(map[property], value);
                }

            }

            var propertyItemX = image.GetPropertyItem(20625).Value;
            var propertyItemY = image.GetPropertyItem(resolutionYCode).Value;
            //var documentName = image.GetPropertyItem(documentNameCode).Value;
            var imageWidth = image.GetPropertyItem(0x0002).Value;

            var resolutionXUTF8 = Encoding.UTF8.GetString(image.GetPropertyItem(resolutionXCode).Value);
            var resolutionXUnicode = Encoding.Unicode.GetString(image.GetPropertyItem(resolutionXCode).Value);
            var resolutionXAscii = Encoding.ASCII.GetString(image.GetPropertyItem(resolutionXCode).Value);
            var resolutionXUtf7 = Encoding.UTF7.GetString(image.GetPropertyItem(resolutionXCode).Value);
            var resolutionXUtf32 = Encoding.UTF32.GetString(image.GetPropertyItem(resolutionXCode).Value);
            //var resoltuionY = Encoding.UTF8.GetString(image.GetPropertyItem(resolutionYCode).Value);

            //Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            //Encoding utf8 = Encoding.UTF8;
            //string msg = iso.GetString(utf8.GetBytes(resolutionXUTF8));

            resolutionXUTF8.Should().NotBeNull();
        }

        //[Fact]
        //public void CanGetMainPropertiesOfImage()
        //{
        //    var path = @"C:\Users\bimal\Desktop\IMG1452.JPG";

        //    var imageInfoController = new ImageInfoController();

        //    var client = new RestClient("http://localhost:50509");

        //    var request = new RestRequest("api/ImageInfo/");

        //    request.AddParameter("path", path);

        //    var response = client.Execute<ImageInfo>(request);

        //    response.Data.Height.Should().BeGreaterThan(0);
        //    response.Data.Type.Should().Be("Bitmap");
        //    response.Data.VerticalResolution.Should().Be(350);
        //    response.Data.HorizontalResolution.Should().Be(350);
        //}

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