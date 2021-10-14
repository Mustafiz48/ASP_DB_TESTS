using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// This controller to take an PDF input and return base64 encoded version of the pdf and vice versa
namespace ASP_DB_TESTS.Controllers
{
    public class PDFUploadController: ControllerBase
    {

        //pdf to base64
        [HttpPost]
        public String Upload(IFormFile files)
        {
            var ms = new MemoryStream();
            files.CopyTo(ms);
            var fileBytes = ms.ToArray();
            string s = Convert.ToBase64String(fileBytes);
            return s;

        }

        //base64 to pdf

        [HttpPost]
        public IActionResult Download([FromBody] string encodedstring)
        {
            byte[] bytes = Convert.FromBase64String(encodedstring);
            MemoryStream stream = new MemoryStream(bytes);

            return File(stream, "application/pdf", "returned_pdf");

            // to use File, extend from ControllerBase class

        }
    }
}


//2.1.12