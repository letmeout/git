using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp.Models;
using Aspose.BarCode.Generation;
using Aspose.BarCode;
using System.Drawing;
using System.Text.Encodings.Web;

namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            GenerateBarCode();

            ViewBag.Output = HtmlEncoder.Default.Encode("This is a sample, Yes!"); //<script>alert('Test@test.com')</script>

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

        public void GenerateBarCode(int number = 1234567)
        {
            //  // The path to the documents directory.
            // string dataDir = ".\\";
            // // Instantiate barcode object and set differnt barcode properties
            // BarcodeGenerator  generator = new BarcodeGenerator (EncodeTypes.Code128, number.ToString());
            // generator.Parameters.Barcode.XDimension.Millimeters = 1f;

            // // Save the image to your system and set its image format to Jpeg
            // generator.Save(dataDir + "output.jpg", BarCodeImageFormat.Jpeg);

            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.CODE128, "038000356216", Color.Black, Color.White, 290, 120);
            img.Save( "newoutput.jpg");
        }
    }
}
